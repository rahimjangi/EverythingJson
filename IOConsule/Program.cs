using IOConsule;

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

JsonConvertDemo.SerializeFromObject(rahim, file.FullName);
JsonConvertDemo.DeserializeFromObject(rahim, file.FullName);