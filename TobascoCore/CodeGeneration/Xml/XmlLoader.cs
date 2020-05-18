using System;
using System.IO;
using System.Xml.Serialization;

namespace Tobasco.CodeGeneration.Xml
{
    internal static class XmlLoader
    {
        internal static T Load<T>(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            try
            {
                using (var reader = new StreamReader(Path.Combine(path)))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error with reading tobasco xml: {ex}");
            }
        }
    }
}
