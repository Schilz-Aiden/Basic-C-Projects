using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Range(1900, 2100, ErrorMessage = "Please enter a valid car year.")]
        public int CarYear { get; set; }

        [Required]
        [StringLength(50)]
        public string CarMake { get; set; }

        [Required]
        [StringLength(50)]
        public string CarModel { get; set; }

        public bool DUI { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Tickets cannot be negative.")]
        public int SpeedingTickets { get; set; }

        // True = Full coverage, False = Liability only
        public bool CoverageType { get; set; }

        // Calculated by controller, hidden from Create/Edit form
        [DataType(DataType.Currency)]
        public decimal Quote { get; set; }
    }
}