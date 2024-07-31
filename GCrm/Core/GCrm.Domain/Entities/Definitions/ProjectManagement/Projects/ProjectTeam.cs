﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.Definitions.ProjectManagement.Projects
{
    public class ProjectTeam : BaseEntity
    {
        public string ProjectTeamName { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
