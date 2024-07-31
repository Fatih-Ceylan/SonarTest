﻿using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.SocialMediaUrl.GetAll
{
    public class GetAllSocialMediaUrlRequest : Pagination, IRequest<GetAllSocialMediaUrlResponse>
    {
        public string CompanyId { get; set; } 
        public string BranchId { get; set; } 
    }
}
