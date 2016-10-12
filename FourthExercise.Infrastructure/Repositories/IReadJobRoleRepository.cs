﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FourthExercise.Models;

namespace FourthExercise.Infrastructure.Repositories
{
    public interface IReadJobRoleRepository : IEnlistableRepository
    {
        Task<IEnumerable<JobRole>> GetAllAsync();
    }
}