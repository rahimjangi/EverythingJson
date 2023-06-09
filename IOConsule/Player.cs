using System.ComponentModel.DataAnnotations.Schema;

namespace IOConsule;

public class Player
{
    public int id { get; set; }
    public string first_name { get; set; } = string.Empty;
    public string last_name { get; set; } = string.Empty;
    public string email { get; set; } = string.Empty;
    public Gender? gender { get; set; }
    public string ip_address { get; set; } = string.Empty;
    [Column(TypeName = "date")]
    public DateTime birth_date { get; set; }

    public override string ToString()
    {
        return
    $@"Player (OBJ)
        Id:{id},
        first_name: {first_name},
        last_name: {last_name},
        email: {email},
        gender: {gender},
        ip_address: {ip_address},
        birth_date: {birth_date}
    ";
    }

}


