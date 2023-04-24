using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RP_EF_Maria.Models;

public class Game
{
    public uint GameId { get; set; }
    public string Title { get; set; } = "";

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)] //this restricts the input to a date not a time

    public DateTime Release { get; set; }

    public string Genre { get; set; } = "";

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }

    public virtual List<Rating> Rating { get; set; } = default!;
}