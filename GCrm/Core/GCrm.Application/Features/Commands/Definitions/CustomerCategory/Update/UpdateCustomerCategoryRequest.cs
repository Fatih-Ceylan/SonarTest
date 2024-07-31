﻿using MediatR;

namespace GCrm.Application.Features.Commands.Definitions.CustomerCategory.Update
{
    public class UpdateCustomerCategoryRequest : IRequest<UpdateCustomerCategoryResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
}
