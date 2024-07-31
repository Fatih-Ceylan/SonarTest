﻿using GCard.Application.VMs;
using MediatR;

namespace GCard.Application.Features.Commands.Definitions.StaffField.UpdateWithList
{
    public class UpdateWithListStaffFieldRequest:IRequest<UpdateWithListStaffFieldResponse>
    {
        public List<StaffFieldVM> StaffFields { get; set; }
    }
}
