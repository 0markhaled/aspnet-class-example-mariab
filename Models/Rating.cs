using System.ComponentModel.DataAnnotations;

namespace RP_EF_Maria.Models;

public class Rating
{

    public uint RatingId { get; set; }

    [Range(0, 5, ErrorMessage = "Please enter a number between 0 and 5")]
    public uint StarRating { get; set; } = 0;

    [MaxLength(1000, ErrorMessage = "Your Comment is too long, please use 100 characters or less")]
    [MinLength(4, ErrorMessage = "Your Comment is too short, please use 4 characters or more")]
    public string Comment { get; set; } = "";

    [Required]
    public virtual Game Game { get; set; } = default!;
}