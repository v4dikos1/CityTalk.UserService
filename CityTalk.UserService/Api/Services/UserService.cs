using CommonLibrary.Protos;
using Grpc.Core;

namespace Api.Services
{
    public class UserService : User.UserBase
    {
        public override Task<UserProfile> GetUserProfile(GetUserProfileRequest request, ServerCallContext serverCallContext)
        {
            return Task.FromResult(new UserProfile { Username = "Test" });
        }
    }
}
