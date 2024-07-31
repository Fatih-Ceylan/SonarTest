﻿using MediatR;

namespace NLLogistics.Application.Features.Commands.Definitions.Voyage.Update
{
    public class UpdateVoyageRequest: IRequest<UpdateVoyageResponse>
    {
        public string Id { get; set; }

        public string VesselId { get; set; }

        public string Name { get; set; }

    }
}
