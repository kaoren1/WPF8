using Newtonsoft.Json;

namespace FunctionalLib
{
    public class Class1
    {
        public static void Serialize<T>(T list, string filename)
        {
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(filename, json);
        }

        public static T Deserialize<T>(string filename)
        {
            string json = File.ReadAllText(filename);
            T json1 = JsonConvert.DeserializeObject<T>(json);
            return json1;
        }
    }
}