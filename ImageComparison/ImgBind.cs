using System;
using System.IO;
using ExifLib;

namespace ImageComparison;

/// <summary>
///     Class used for binders in ListView
/// </summary>
public class ImgBind
{
    //Double[] latitude, longitude;
    //modifiedDate
    //cameraModel

    public ImgBind(string fullName, string group, string hash)
    {
        FullName = fullName;
        Name = fullName;
        Group = group;
        Hash = hash;
        //Latitude = latitude;
        //Longitude = longitude;
        //CreatedDate = createdDate;
        //ModifiedDate = modifiedDate;
        //PictureDateTaken = pictureDateTaken;
        //Resolution = resolution;
        //CameraModel = cameraModel;
        SizeInBytes = Utils.GetFileSize(FullName);
        Size = Utils.GetFileSize(SizeInBytes);

        //FileInfo fi=new FileInfo(FullName);
        //CreatedDate = fi.CreationTime;
        //ModifiedDate = fi.LastWriteTime;
        //Length=fi.Length;
        try
        {
            using var reader = new ExifReader(fullName);
            // Extract the tag data using the ExifTags enumeration
            DateTime datePictureTaken;
            if (reader.GetTagValue(ExifTags.DateTimeDigitized, out datePictureTaken))
                DatePictureTaken = datePictureTaken;

            string cameraModel;
            if (reader.GetTagValue(ExifTags.CameraOwnerName, out cameraModel)) CameraModel = cameraModel;

            if (reader.GetTagValue(ExifTags.DateTimeOriginal, out datePictureTaken)) CreatedDate = datePictureTaken;

            //  if (reader.GetTagValue(ExifTags.ImageLength, out uint length)) Length = length;
            if (reader.GetTagValue(ExifTags.ImageUniqueID, out string imageUniqueID)) ImageUniqueID = imageUniqueID;


            if (reader.GetTagValue(ExifTags.GPSLongitude, out double[] longitude)) Longitude = longitude[0];

            if (reader.GetTagValue(ExifTags.GPSLatitude, out double[] latitude)) Latitude = latitude[0];
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            //  throw;
        }
    }


    public string ImageUniqueID { get; set; }
    public long Length { get; set; }
    public string FullName { get; set; }
    public string Name { get; set; }
    public string Group { get; set; }
    public string Hash { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime DatePictureTaken { get; }
    public string Resolution { get; }
    public string CameraModel { get; }

    public string Size { get; set; }

    public double SizeInBytes { get; set; }
}

public static class Utils
{
    /// <summary>
    ///     Return size of file in humar readable format
    /// </summary>
    /// <param name="path">Path to file</param>
    /// <returns>Human readable filesize</returns>
    public static string GetFileSize(double sizeInBytes)
    {
        string[] sizes = { "B", "KB", "MB", "GB" };

        var index = 0;

        while (sizeInBytes >= 1024 && index < sizes.Length - 1)
        {
            index++;
            sizeInBytes /= 1024;
        }

        return string.Format("{0:0.##} {1}", sizeInBytes, sizes[index]);
    }

    public static double GetFileSize(string path)
    {
        var t = new FileInfo(path);
        var len = t.Length;
        return len;
    }
}