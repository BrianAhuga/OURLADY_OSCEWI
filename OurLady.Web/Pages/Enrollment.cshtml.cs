using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shared.Interface;

namespace OurLadyPS.Web.Pages
{
    public class EnrollmentModel : PageModel
    {
        private readonly IPupilEnrollmentService _enrollmentService;

        public EnrollmentModel(IPupilEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [BindProperty]
        public PupilEnrollment Enrollment { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var (success, message) = await _enrollmentService.SavePupilEnrollmentAsync(Enrollment);

            TempData["Success"] = success;
            TempData["Message"] = message;

            return RedirectToPage();
        }
    }
}
