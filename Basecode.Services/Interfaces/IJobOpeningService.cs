﻿using Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Services.Interfaces
{
    public interface IJobOpeningService
    {
        List<JobOpening> GetJobs();
        void Create(JobOpening jobOpening, string createdBy);
    }
}
