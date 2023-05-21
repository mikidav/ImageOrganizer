using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DuplicateFilesOrginaizer
{
    /// <summary>
    ///     XmlSerializes the <c>object</c> to a compressed <see langword="byte" /> array
    /// </summary>
    public static class XmlSerializationHelper
    {
        // Public Methods (11) 
        /// <summary>
        ///     load objects from file
        /// </summary>
        /// <typeparam name="T">type of <c>object</c></typeparam>
        /// <param name="filename">path file</param>
        /// <returns>
        /// </returns>
        public static T Load<T>(string filename)
        {
            var t = default(T);
            try
            {
                if (File.Exists(filename))
                {
                    var xs = XmlSerializer.FromTypes(new[] { typeof(T) })[0];
                    using (var rd = new StreamReader(filename))
                    {
                        return (T)xs.Deserialize(rd);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }


            return t;
        }

        /// <summary>
        ///     XML Deserialize the <c>object</c>
        /// </summary>
        /// <returns>
        ///     serialized <c>object</c>
        /// </returns>
        [DebuggerStepThrough]
        public static T Load<T>(this object objectToCompress, string filename)
        {
            var xs = XmlSerializer.FromTypes(new[] { typeof(T) })[0];
            using (var rd = new StreamReader(filename))
            {
                return (T)xs.Deserialize(rd);
            }
        }

        /// <summary>
        ///     XmlSerializes the <c>object</c> to a compressed <see langword="byte" />
        ///     array
        /// </summary>
        /// <param name="objectToCompress">The object to Save.</param>
        /// <param name="filePath"></param>
        /// <returns>
        ///     <see langword="void" />
        /// </returns>
        public static void Save<T>(this object objectToCompress, string filePath)
        {
            var folderPath = Path.GetDirectoryName(filePath);
            if (folderPath != null && !Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            var xs = XmlSerializer.FromTypes(new[] { typeof(T) })[0];

            using (var wr = new StreamWriter(filePath))
            {
                xs.Serialize(wr, objectToCompress);
            }
        }

        /// <summary>
        ///     Save to file
        /// </summary>
        /// <typeparam name="T"><c>object</c> type</typeparam>
        /// <param name="filename">file path</param>
        /// <param name="obj"><c>object</c> to save</param>
        public static void Save<T>(string filename, T obj)
        {
            var xs = XmlSerializer.FromTypes(new[] { typeof(T) })[0];

            using (var wr = new StreamWriter(filename))
            {
                xs.Serialize(wr, obj);
            }
        }

        /// <summary>
        ///     Serialize an <c>object</c> to string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="toSerialize"></param>
        /// <returns>
        /// </returns>
        public static string SerializeObject<T>(this T toSerialize)
        {
            var xmlSerializer = new XmlSerializer(toSerialize.GetType());
            var textWriter = new StringWriter();

            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString();
        }

        /// <summary>
        ///     Serialize <c>object</c> as XML string
        /// </summary>
        /// <param name="objectToSerialize"></param>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        public static void ToXml<T>(this T objectToSerialize, Stream stream)
        {
            new XmlSerializer(typeof(T)).Serialize(stream, objectToSerialize);
        }

        /// <summary>
        ///     Serialize <c>object</c> as XML string
        /// </summary>
        /// <param name="objectToSerialize"></param>
        /// <param name="writer"></param>
        /// <typeparam name="T">XML string</typeparam>
        public static void ToXml<T>(this T objectToSerialize, StringWriter writer)
        {
            new XmlSerializer(typeof(T)).Serialize(writer, objectToSerialize);
        }


        // Private Methods (2) 

        /// <summary>
        ///     Helper function To get Xpath from XElement
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private static int GetIndex(XElement element)
        {
            var i = 1;

            if (element.Parent == null) return 1;

            foreach (var e in element.Parent.Elements(element.Name.LocalName))
            {
                if (e == element) break;

                i++;
            }

            return i;
        }

        /// <summary>
        ///     /// Helper function To get X path from XElement
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private static string GetPath(XElement element)
        {
            return string.Join(".", element.AncestorsAndSelf().Reverse()
                .Select(e =>
                {
                    var index = GetIndex(e);

                    if (index == 1) return e.Name.LocalName;

                    return $"{e.Name.LocalName}[{GetIndex(e)}]";
                }));
        }
    }
}