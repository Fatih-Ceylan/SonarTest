﻿using MediatR;

namespace GCard.Application.Features.Queries.Definitions.Iban.GetById
{
    public class GetByIdIbanRequest : IRequest<GetByIdIbanResponse>
    {
        public string Id { get; set; }
    }
}
