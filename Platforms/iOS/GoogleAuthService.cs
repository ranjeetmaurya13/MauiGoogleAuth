using System;
using MAUIGoogleAuth.GoogleAuth;

namespace MAUIGoogleAuth.Platforms.iOS
{
    public partial class GoogleAuthService : IGoogleAuthService
    {
        public Task<GoogleUserModel> AuthenticateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GoogleUserModel> GetCurrentUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}

