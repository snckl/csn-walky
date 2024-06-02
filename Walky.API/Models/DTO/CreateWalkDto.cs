using System.ComponentModel.DataAnnotations;
using Walky.API.Models.Domain;

namespace Walky.API.Models.DTO
{
    public class CreateWalkDto
    {
        [Required]
        [MaxLength(128)]
        [MinLength(4)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        [MinLength(8)]
        public string Description { get; set; }
        [Required]
        [Range(0,100)]
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }
        [Required]
        public Guid DifficultyId { get; set; }
        [Required]
        public Guid RegionId { get; set; }
    }
}
