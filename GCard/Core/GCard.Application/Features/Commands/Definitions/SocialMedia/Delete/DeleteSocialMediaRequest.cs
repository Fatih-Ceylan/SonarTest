﻿using MediatR;

namespace GCard.Application.Features.Commands.Definitions.SocialMedia.Delete
{
    public class DeleteSocialMediaRequest : IRequest<DeleteSocialMediaResponse>
    {
        public string Id { get; set; }
    }
}
