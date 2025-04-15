using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; } = String.Empty;

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(100)]
        public string Email { get; set; } = String.Empty;

        [Display(Name = "Phone Number")]
        [Phone]
        [StringLength(15)]
        public string PhoneNumber { get; set; } = String.Empty;

        [Required(ErrorMessage = "Hire Date is required")]
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [StringLength(50)]
        public string Department { get; set; } = String.Empty;

        [Display(Name = "Salary")]
        [DataType(DataType.Currency)]
        [Range(0, 1000000, ErrorMessage = "Salary must be between 0 and 1,000,000")]
        public decimal Salary { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;
    }
}