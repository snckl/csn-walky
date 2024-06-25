using Microsoft.AspNetCore.Identity;

namespace Walky.API.Repositories.IRepository
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user,List<string> roles);
    }
}
