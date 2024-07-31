﻿using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using GCrm.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCrm.Persistence.Repositories.WriteRepository
{
    public class EmployeeWriteRepository : WriteRepository<BaseProjectDbContext, Employee>, IEmployeeWriteRepository
    {
        public EmployeeWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
