﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.Infrastructure
{
    public interface IUnitOfWorkFactory
    {
        Task WithAsync(Func<IUnitOfWork, Task> action);
    }
}