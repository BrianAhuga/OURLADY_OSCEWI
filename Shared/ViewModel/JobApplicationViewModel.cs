using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ViewModel
{
    public class JobApplicationViewModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Position { get; set; }

        public string About { get; set; }

        public IFormFile CoverLetter { get; set; }
        public IFormFile CV { get; set; }
        public IFormFile IDPassport { get; set; }
        public IFormFile AcademicDocs { get; set; }
    }

}
