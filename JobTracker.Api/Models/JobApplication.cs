using System.ComponentModel.DataAnnotations;

namespace JobTracker.Api.Models
{
    public class JobApplication
    {
        public int Id { get; set; }

        [Required]
        public string Company { get; set; } = string.Empty;

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Status { get; set; } = "Applied"; // e.g. Applied, Interviewing, Offer, Rejected

        public DateTime DateApplied { get; set; } = DateTime.UtcNow;
    }
}