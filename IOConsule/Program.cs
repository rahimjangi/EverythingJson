using IOConsule;
using Newtonsoft.Json;

var currentDirectory = Directory.GetCurrentDirectory();
var file = new FileInfo(Path.Combine(currentDirectory, "player.json"));
Player rahim = new Player()
{

    id = 1,
    first_name = "Rahim",
    last_name = "Jangi",
    email = "rahimjangi@gmail.com",
    gender = Gender.Male,
    birth_date = DateTime.Now.AddYears(-41),
    ip_address = "127.0.0.1"
};

//var obj = JsonConvert.SerializeObject(rahim, Formatting.None);
//Console.WriteLine(obj);

using (var streamWriter = new StreamWriter(file.FullName))
{
    var obj = JsonConvert.SerializeObject(rahim, Formatting.Indented);
    Console.WriteLine(obj.ToString());
    streamWriter.WriteLine(obj);
}

using (var streamReader = new StreamReader(file.FullName))
{
    var player = JsonConvert.DeserializeObject<Player>(streamReader.ReadToEnd());
    Console.WriteLine(player);
}