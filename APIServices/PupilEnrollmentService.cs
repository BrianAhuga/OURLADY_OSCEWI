using Microsoft.EntityFrameworkCore;
using Shared.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServices
{
    public class PupilEnrollmentService : IPupilEnrollmentService
    {
        private readonly ApplicationDbContext _context;

        public PupilEnrollmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<(bool Success, string Message)> SavePupilEnrollmentAsync(PupilEnrollment enrollment)
        {
            try
            {
                // Prevent duplicate by ParentEmail + ChildName + DOB
                var existingEnrollment = await _context.PupilEnrollments
                    .FirstOrDefaultAsync(e => e.ParentEmail == enrollment.ParentEmail
                                           && e.FirstName == enrollment.FirstName
                                           && e.LastName == enrollment.LastName);

                if (existingEnrollment != null)
                {
                    return (false, "We already received an enrollment for this pupil. Please wait for a response.");
                }

                if (enrollment.HasOtherChildren == false)
                    enrollment.OtherChildrenDetails = "None";

                _context.PupilEnrollments.Add(enrollment);
                await _context.SaveChangesAsync();

                return (true, "Enrollment submitted successfully!");
            }
            catch (Exception ex)
            {
                return (false, $"An error occurred: {ex.Message}");
            }
        }
    }
}
