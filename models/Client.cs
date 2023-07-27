// Models/Client.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Client
{
    [Key]
    [Column("id")] // Map the property to the "id" column in the database
    public int ID { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [Column("name")] // Map the property to the "name" column in the database
    public string? Name { get; set; } // Make the property nullable with '?'

    [Required(ErrorMessage = "IP Address is required")]
    [Column("ip")] // Map the property to the "ip" column in the database
    public string? Ip { get; set; } // Make the property nullable with '?'

    [Required(ErrorMessage = "Phone Number is required")]
    [Column("phone")] // Map the property to the "phone" column in the database
    public string? Phone { get; set; } // Make the property nullable with '?'
}
