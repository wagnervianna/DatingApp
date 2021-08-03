using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
         void UpdateProfile(AppUser user);

         Task<bool> SaveAllAsync();
         Task <IEnumerable<AppUser>> GetUserAsync();
         Task<AppUser> GetUserByIdAsync(long id);
         Task<AppUser> GetUserByUsernameAsync(string username);
    }
}