using IMQ1.BaseSerialization.Library.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Xml.Serialization;

namespace IMQ1.BaseSerialization.Executor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPP");
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAA");
            Console.WriteLine("KKKKKKKSERGEYKKKKKKK");
            Console.WriteLine("EEEEEEEEEEEEEEEEEEEE");
            Console.WriteLine("TTTTTTTTTTTTTTTTTTTT");
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAA");
            Console.Write("Please enter valid file path: ");
            var filePath = Console.ReadLine();
            if (File.Exists(filePath))
            {
                var catalog = Deserialize(filePath);
                Console.WriteLine(ParseJson(catalog));
                catalog.Date = DateTime.Now;
                Serialize(filePath, catalog);
                Console.WriteLine($"File was resaved to {filePath} with updated Date.");
            }
           
            Console.ReadLine();
        }

        private static Catalog Deserialize(string filePath)
        {
            var serializer = new XmlSerializer(typeof(Catalog));
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                return serializer.Deserialize(fileStream) as Catalog;
            }
        }

        private static void Serialize(string filePath, Catalog catalog)
        {
            var serializer = new XmlSerializer(typeof(Catalog));
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(stream, catalog);
            }
        }

        public static string ParseJson(dynamic content)
        {
            try
            {
                return JObject.FromObject(content).ToString(Newtonsoft.Json.Formatting.Indented);
            }
            catch
            {
                try
                {
                    return JArray.FromObject(content).ToString(Newtonsoft.Json.Formatting.Indented);
                }
                catch
                {
                    return string.Empty;
                }
            }
        }
    }
}
