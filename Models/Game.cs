using System.ComponentModel.DataAnnotations;

namespace RP_EF_Maria.Pages;

public class Game
{
    public uint GameId { get; set; }
    public string Title { get; set; } = "";

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)] //this restricts the input to a date not a time


    public DateTime Release { get; set; }

    public string Genre { get; set; } = "";
    public decimal Price { get; set; }
}