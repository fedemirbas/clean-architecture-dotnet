using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Dtos.User;
using CleanArchitecture.Application.Wrappers;

namespace CleanArchitecture.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request);
    }
}
