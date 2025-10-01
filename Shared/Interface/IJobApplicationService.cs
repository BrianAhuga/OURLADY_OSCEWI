using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interface
{
    public interface IJobApplicationService
    {
        Task<bool> SaveJobApplicationAsync(JobApplication jobApplication);
    }
}
