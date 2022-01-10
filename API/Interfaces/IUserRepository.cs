using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.DTO;

namespace API.Interfaces
{
    public interface IUserRepository
    {
         void UpdateProfile(AppUser user);

         Task<bool> SaveAllAsync();
         Task <IEnumerable<AppUser>> GetUserAsync();
         Task<AppUser> GetUserByIdAsync(long id);
         Task<AppUser> GetUserByUsernameAsync(string username);
         Task<IEnumerable<MemberDto>> GetMembersAsync();
         Task<MemberDto> GetMemberAsync(string username);
    }
}