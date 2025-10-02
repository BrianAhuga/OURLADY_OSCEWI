using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interface
{
    public interface IPupilEnrollmentService
    {
        Task<(bool Success, string Message)> SavePupilEnrollmentAsync(PupilEnrollment enrollment);
    }
}
