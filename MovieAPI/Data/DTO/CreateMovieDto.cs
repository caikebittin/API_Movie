using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Data.DTO;

public class CreateMovieDto
{
    [Required(ErrorMessage = "Movie title is required.")]
    [StringLength(50, ErrorMessage = "Movie title cannot exceed 50 characters.")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Movie genre is required.")]
    [StringLength(50, ErrorMessage = "Movie genre cannot exceed 50 characters.")]
    public string Gender { get; set; }
    [Required(ErrorMessage = "Movie length is required.")]
    [Range(40, 360, ErrorMessage = "The duration of the film must be a minimum of 40 minutes and maximum of 360 minutes.")]
    public int Duration { get; set; }
    [StringLength(30, ErrorMessage = "Director name cannot exceed 30 characters.")]
    public string Director { get; set; }
}
