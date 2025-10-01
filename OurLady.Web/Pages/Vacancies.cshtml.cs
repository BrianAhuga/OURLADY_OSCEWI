using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shared.Interface;
using Shared.ViewModel;

namespace OurLadyPS.Web.Pages
{
    public class VacanciesModel : PageModel
    {
        private readonly IJobApplicationService _jobApplicationService;

        public VacanciesModel(IJobApplicationService jobApplicationService)
        {
            _jobApplicationService = jobApplicationService;
        }

        [BindProperty]
        public JobApplicationViewModel Application { get; set; }

        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            byte[] ConvertToBytes(IFormFile file)
            {
                if (file == null || file.Length == 0) return null;
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                return ms.ToArray();
            }

            var jobApp = new JobApplication
            {
                FullName = Application.FullName,
                Email = Application.Email,
                PhoneNumber = Application.PhoneNumber,
                Position = Application.Position,
                About = Application.About,
                CoverLetter = ConvertToBytes(Application.CoverLetter),
                CV = ConvertToBytes(Application.CV),
                IDPassport = ConvertToBytes(Application.IDPassport),
                AcademicDocs = ConvertToBytes(Application.AcademicDocs),
                CoverLetterFileName = Application.CoverLetter?.FileName,
                CVFileName = Application.CV?.FileName,
                IDPassportFileName = Application.IDPassport?.FileName,
                AcademicDocsFileName = Application.AcademicDocs?.FileName
            };

            var result = await _jobApplicationService.SaveJobApplicationAsync(jobApp);

            if (result)
            {
                TempData["Success"] = "Your application has been submitted successfully!";
                return RedirectToPage("Success");
            }

            TempData["Error"] = "There was an error submitting your application. Please try again.";
            return Page();
        }
    }
}
