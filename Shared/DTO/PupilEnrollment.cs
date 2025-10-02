using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public class PupilEnrollment
    {
        [Key]
        public int Id { get; set; } // Auto-generated PK

        [DisplayName("First Name")]
        [Required, MaxLength(100)]
        public string FirstName { get; set; }


        [DisplayName("Last Name")]
        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Gender")]
        [Required, MaxLength(10)]
        public string Gender { get; set; }


        [DisplayName("Class Applying for")]
        [Required, MaxLength(50)]
        public string ClassApplyingFor { get; set; }

        [DisplayName("Former School")]
        [MaxLength(150)]
        public string FormerSchool { get; set; }

        [DisplayName("Parent/Guardian")]
        [Required, MaxLength(150)]
        public string ParentGuardian { get; set; }

        [DisplayName("Parent/Guardian Email Addess")]
        [EmailAddress, MaxLength(100)]
        public string ParentEmail { get; set; }

        [DisplayName("Parent/Guardian Phone Number")]
        [Required, MaxLength(20)]
        public string ParentPhone { get; set; }

        [DisplayName("Address")]
        [MaxLength(200)]
        public string Address { get; set; }

        [DisplayName("Address Line 1")]
        [MaxLength(150)]
        public string AddressLine1 { get; set; }

        [DisplayName("Address Line 2")]
        [MaxLength(150)]
        public string AddressLine2 { get; set; }

        [DisplayName("Country")]
        [MaxLength(100)]
        public string Country { get; set; }

        public bool HasOtherChildren { get; set; }

        public string OtherChildrenDetails { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
