﻿using BaseProject.Domain.Entities.GCard.Definitions;
using Utilities.Core.UtilityApplication.Interfaces;

namespace GCard.Application.Repositories.WriteRepository
{
    public interface IIbanWriteRepository : IWriteRepository<Iban>
    {
    }
}
