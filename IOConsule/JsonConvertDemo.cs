using Newtonsoft.Json;
using System.Dynamic;

namespace IOConsule
{
    public static class JsonConvertDemo
    {
        public static JsonSerializerSettings serializerSettings { set; get; } = new JsonSerializerSettings()
        {

            DateFormatString = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            Formatting = Formatting.Indented,
            //PreserveReferencesHandling = PreserveReferencesHandling.Objects

        };
        public static void SerializeFromObject(Object obj, string file)

        {
            //var obj = JsonConvert.SerializeObject(rahim, Formatting.None);
            //Console.WriteLine(obj);

            dynamic dd = new ExpandoObject();



            using (var streamWriter = new StreamWriter(file))
            {
                var objString = JsonConvert.SerializeObject(obj, serializerSettings);
                Console.WriteLine(objString.ToString());
                streamWriter.WriteLine(objString);
                Console.WriteLine($"{obj.GetType().Name} serialized and saved into {file}");
            }


        }

        public static void DeserializeFromObject(Object obj, string file)
        {
            using (var streamReader = new StreamReader(file))
            {
                var player = JsonConvert.DeserializeObject<Player>(streamReader.ReadToEnd());
                Console.WriteLine(player);
            }

            using (var streamReader = new StreamReader(file))
            {
                var myObj = JsonConvert.DeserializeObject(streamReader.ReadToEnd(), serializerSettings);
                Console.WriteLine($"{obj.GetType().Name} Deserialized from {file}");
                Console.WriteLine(myObj);
            }


        }

    }
}
