using System.ComponentModel.DataAnnotations;

namespace PeopleOverview.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Surnames { get; set; }
        [Required]
        [Range(0, 120)]
        public int? Age { get; set; }
        public string? CountryOfBirth { get; set; }
        [Required]
        public string? CountryOfResidence { get; set; }
        [Required]
        public string? Job { get; set; }
        public bool IsSatisfiedWithWork { get; set; }
        [Required]
        [Range(0.01, 1000000.00)]
        public decimal? GrossAnnualSalary { get; set; }
        [Required]
        public string? Currency { get; set; } 
        public bool IsSatisfiedWithSalary { get; set; }
    }

    public enum Satisfied { Yes, No }
}