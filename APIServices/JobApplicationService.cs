using Microsoft.EntityFrameworkCore;
using Shared.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServices
{
    public class JobApplicationService : IJobApplicationService
    {
        private readonly ApplicationDbContext _context;

        public JobApplicationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<(bool Success, string Message)> SaveJobApplicationAsync(JobApplication jobApplication)
        {
            try
            {
                // Check if an application with the same Email & Phone already exists
                var existingApp = await _context.JobApplications
                    .FirstOrDefaultAsync(a => a.Email == jobApplication.Email
                                           && a.PhoneNumber == jobApplication.PhoneNumber
                                           && a.Position == jobApplication.Position
                                           && a.FullName == jobApplication.FullName);

                if (existingApp != null)
                {
                    return (false, "We already received your application for this position. Please wait for a response.");
                }

                // Save new application
                _context.JobApplications.Add(jobApplication);
                await _context.SaveChangesAsync();

                return (true, "Your application has been submitted successfully!");
            }
            catch (Exception ex)
            {
                return (false, $"An error occurred: {ex.Message}");
            }
        }

    }

}
