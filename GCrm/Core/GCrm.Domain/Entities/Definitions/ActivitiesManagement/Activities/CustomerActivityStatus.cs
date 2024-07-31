﻿using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.Definitions.ActivitiesManagement.Activities
{
    public class CustomerActivityStatus : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<CustomerActivity> CustomerActivities { get; set; }
    }
}
