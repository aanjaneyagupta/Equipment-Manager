using System.ComponentModel.DataAnnotations;

namespace EquipmentManager_Assignment1.Models
{
    public enum EquipmentType { Laptop, Phone, Tablet, Other}
    public enum RoleType { Student, Professor}
    public class Request
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required"), EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone is required"), Phone]
        [RegularExpression(@"\d{3}-\d{3}-\d{4}",ErrorMessage =("Please enter the phone number in correct format: XXX-XXX-XXXX"))]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public RoleType? Role {  get; set; }

        [Required(ErrorMessage = "Equipment Type is required")]
        public EquipmentType? Type { get; set; }

        [Required(ErrorMessage = "Request Details are required")]
        public string? RequestDetails {  get; set; }

        [Required(ErrorMessage = "Duration is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Enter a positive number")]
        public int? Duration { get; set; }
    }
}
