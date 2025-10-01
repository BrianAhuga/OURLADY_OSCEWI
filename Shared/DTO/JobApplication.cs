using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public class JobApplication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-generated
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Position { get; set; }

        public string About { get; set; }

        public byte[] CoverLetter { get; set; }
        public string CoverLetterFileName { get; set; }

        public byte[] CV { get; set; }
        public string CVFileName { get; set; }

        public byte[] IDPassport { get; set; }
        public string IDPassportFileName { get; set; }

        public byte[] AcademicDocs { get; set; }
        public string AcademicDocsFileName { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.Now;
    }
}
