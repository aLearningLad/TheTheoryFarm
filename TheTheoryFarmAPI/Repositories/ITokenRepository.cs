using Microsoft.AspNetCore.Identity;

namespace TheTheoryFarmAPI.Repositories
{
    public interface ITokenRepository
    {
       string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
