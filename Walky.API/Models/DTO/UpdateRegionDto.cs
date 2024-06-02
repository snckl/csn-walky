using System.ComponentModel.DataAnnotations;

namespace Walky.API.Models.DTO
{
    public class UpdateRegionDto
    {
        [Required]
        [StringLength(3, ErrorMessage = "Code length must be between 1 to 3")]
        public string Code { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name cannot be longer than 100 character")]
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
