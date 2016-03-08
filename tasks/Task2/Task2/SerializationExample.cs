using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task2
{
    class SerializationExample
    {
        public static void Run(IItem[] items)
        {

            // serialize all items
            // ... include type, so we can deserialize sub-classes to interface type
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            //DEBUG:
            Console.WriteLine(JsonConvert.SerializeObject(items, settings));

            // store json string to file "items.json" on your Desktop
            var text = JsonConvert.SerializeObject(items, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "items.json");
            File.WriteAllText(filename, text);

            // deserialize items from "items.json"
            // ... and print Description and Price of deserialized items
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<IItem[]>(textFromFile, settings);

            foreach (var x in itemsFromFile)
            {
                Console.WriteLine("Deserialized: Price of {0} is {1} {2}", x.Description, x.Price.Unit, x.Price.Amount);
            }
        }
    }
}