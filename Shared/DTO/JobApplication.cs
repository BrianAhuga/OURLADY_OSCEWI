using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public class JobApplication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Position { get; set; }

        public string About { get; set; }

        // Files stored in DB as binary
        public byte[] CoverLetter { get; set; }
        public byte[] CV { get; set; }
        public byte[] IDPassport { get; set; }
        public byte[] AcademicDocs { get; set; }

        // Store original file names for later download
        public string CoverLetterFileName { get; set; }
        public string CVFileName { get; set; }
        public string IDPassportFileName { get; set; }
        public string AcademicDocsFileName { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}
