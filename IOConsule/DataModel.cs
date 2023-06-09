namespace IOConsule;


//[Newtonsoft.Json.JsonObject("Csv")]
public class DataModel
{
    //id,first_name,last_name,email,gender,ip_address,birth_date
    public int id { get; set; }
    public string first_name { get; set; } = string.Empty;
    public string last_name { get; set; } = string.Empty;
    public string email { get; set; } = string.Empty;
    public Gender gender { get; set; }
    public string Ip_address { get; set; } = string.Empty;
    public DateTime birth_date { get; set; }
}

public enum Gender
{
    Female,
    Male,
    Genderqueer
}