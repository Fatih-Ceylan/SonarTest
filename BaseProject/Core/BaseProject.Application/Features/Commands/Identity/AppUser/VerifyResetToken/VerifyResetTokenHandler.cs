﻿using BaseProject.Application.Abstractions.Services.Identity;
using MediatR;

namespace BaseProject.Application.Features.Commands.Identity.AppUser.VerifyResetToken
{
    public class VerifyResetTokenHandler : IRequestHandler<VerifyResetTokenRequest, VerifyResetTokenResponse>
    {
        readonly IAuthService _authService;

        public VerifyResetTokenHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<VerifyResetTokenResponse> Handle(VerifyResetTokenRequest request, CancellationToken cancellationToken)
        {
            bool state = await _authService.VerifyResetTokenAsync(request.ResetToken, request.UserId);

            return new()
            {
                State = state,
            };
        }
    }
}
