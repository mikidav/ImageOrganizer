using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ImageComparison;

namespace FileOrganizer
{

    public enum HashEnum
    {
        Difference,
        Mean,
        Perceptual
    }
    public class FilesIterator
    {
        private static InterpolationMode m_currentInterpolationMode = InterpolationMode.Bicubic;
        private static readonly string[] imageExtensions = { ".png", ".jpg", ".jpeg", ".bmp" };


        private static double[,] GetResizedGrayImageMatrix(string filename,
         int height, int width, out double grayMean)
        {
            grayMean = 0;

            // Load original image
            Bitmap originalBmp;
            try
            {
                originalBmp = new Bitmap(filename);
            }
            catch (ArgumentException)
            {
                return null;
            }

            // Resize image
            var imageMatrix = new double[width, height];
            double graySum = 0;
            using (var bmp = new Bitmap(width, height))
            {
                using (var g = Graphics.FromImage(bmp))
                {
                    g.CompositingQuality = CompositingQuality.HighSpeed;
                    g.InterpolationMode = m_currentInterpolationMode;
                    g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                    g.DrawImage(originalBmp, 0, 0, bmp.Width, bmp.Height);
                }

                originalBmp.Dispose();

                // Get gray image matrix
                var bd = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                var ptr = bd.Scan0;
                var length = Math.Abs(bd.Stride) * bmp.Height;
                var pixels = new byte[length];
                Marshal.Copy(ptr, pixels, 0, length);
                for (var i = 0; i < pixels.Length; i += 4) // BGRA
                {
                    var gray = pixels[i + 2] * 0.30 +
                               pixels[i + 1] * 0.59 +
                               pixels[i + 0] * 0.11;
                    var x = Math.DivRem(i / 4, height, out var y);
                    imageMatrix[x, y] = gray;
                    graySum += gray;
                }

                bmp.UnlockBits(bd);
            }

            // Get mean gray
            grayMean = graySum / height / width;

            return imageMatrix;
        }

        private static string GetDifferenceHash(string filename, int currentPrecision)
        {
            // Get gray image matrix
            double[,] imageMatrix = GetResizedGrayImageMatrix(filename,
                currentPrecision, currentPrecision + 1, out double _);
            if (imageMatrix == null) { return null; }

            // Get hash
            StringBuilder sbHash = new StringBuilder();
            for (int w = 0; w < currentPrecision; w++)
            {
                for (int h = 0; h < currentPrecision; h++)
                {
                    sbHash.Append(imageMatrix[w, h] > imageMatrix[w + 1, h] ? "1" : "0");
                }
            }
            return sbHash.ToString();
        }


        private static string GetPerceptualHash(string filename, int currentPrecision)
        {
            // Get gray image matrix
            double[,] imageMatrix = GetResizedGrayImageMatrix(filename,
                currentPrecision, currentPrecision, out double _);
            if (imageMatrix == null) { return null; }

            // Generate transformation matrix
            double[,] transMatrix = MatrixHelper.GetTransMatrix(currentPrecision);

            // Get DCT coefficient
            double[,] frequencyMatrix = MatrixHelper.MultiplyMatrixes(
                MatrixHelper.MultiplyMatrixes(transMatrix, imageMatrix),
                MatrixHelper.GetTansposedMatrix(transMatrix));

            // Take low frequency part and get mean frequency
            double frequencySum = 0;
            int height = currentPrecision / 2;
            int width = currentPrecision / 2;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    frequencySum += frequencyMatrix[i, j];
                }
            }
            double frequencyMean = frequencySum / height / width;

            // Get hash
            StringBuilder sbHash = new StringBuilder();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sbHash.Append(frequencyMatrix[i, j] > frequencyMean ? "1" : "0");
                }
            }
            return sbHash.ToString();
        }
        private static string GetMeanHash(string filename, int currentPrecision)
        {
            // Get gray image matrix
            var imageMatrix = GetResizedGrayImageMatrix(filename,
                currentPrecision, currentPrecision, out var grayMean);
            if (imageMatrix == null) return null;

            // Get hash
            var sbHash = new StringBuilder();
            for (var w = 0; w < currentPrecision; w++)
                for (var h = 0; h < currentPrecision; h++)
                    sbHash.Append(imageMatrix[w, h] > grayMean ? "1" : "0");
            return sbHash.ToString();
        }

        public List<ImgBind> Foo(string folderPath, int currentPrecision, HashEnum hashEnum)
        {
            var di = new DirectoryInfo(folderPath);
            var imageNames = from imageName
                    in Directory.EnumerateFiles(folderPath, "*.*", SearchOption.AllDirectories)
                             where imageExtensions.Any(imageName.ToLower().EndsWith)
                             select imageName;

            // Get hash algorithm
            Func<string, string>? hashMethod = null;
            switch (hashEnum)
            {
                case HashEnum.Difference:
                    hashMethod = (imageName) => GetDifferenceHash(imageName, currentPrecision);
                    break;
                case HashEnum.Mean:
                    hashMethod = (imageName) => GetMeanHash(imageName, currentPrecision);
                    break;
                case HashEnum.Perceptual:
                    hashMethod = (imageName) => GetPerceptualHash(imageName, currentPrecision);
                    break;
                default: break;
            }
            List<ImgBind> collection = new List<ImgBind>();

            // Get hashes
            var imageHashPairs = new ConcurrentDictionary<string, List<string>>();
            Parallel.ForEach(imageNames,
            // TODO: Add performance limitation option 
            //new ParallelOptions { MaxDegreeOfParallelism = Convert.ToInt32(Math.Ceiling((Environment.ProcessorCount * 0.5) * 1.0)) },
            imageName =>
            {
                string hash = hashMethod(imageName);
                if (!string.IsNullOrEmpty(hash))
                {
                    if (imageHashPairs.ContainsKey(hash))
                    {
                        imageHashPairs[hash].Add(imageName);
                    }
                    else
                    {
                        imageHashPairs.TryAdd(hash, new List<string> { imageName });
                    }


                  //  collection.Add(new ImgBind(imageName, hash, hash));
                    //  imageHashPairs.AddOrUpdate(imageName, hash, (k, v) => v = hash);
                }
            });
            int i = 0;
            foreach (var pair in imageHashPairs)
            {
                foreach (var item in pair.Value)
                {
                    collection.Add(new ImgBind(item, "Group " + (i), pair.Key));
                }
                i++;
            }
            return collection;
        }
    }
}
