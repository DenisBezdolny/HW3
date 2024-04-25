using HW3.Models.Abstract_entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HW3.Models.Entities
{
    public class StubFriendService : IFriendService
    {
        public List<Friend> GetFriends()
        {
            return new List<Friend>();
        }

        public void CreateFriendsFile()
        {
            return ;
        }
    }
}
