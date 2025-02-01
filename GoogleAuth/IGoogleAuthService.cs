using System;
namespace MAUIGoogleAuth.GoogleAuth
{
    public interface IGoogleAuthService
    {
        public Task<GoogleUserModel> AuthenticateAsync();
        public Task<GoogleUserModel> GetCurrentUserAsync();
        public Task LogoutAsync();
    }
}

