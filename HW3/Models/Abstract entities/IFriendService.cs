using HW3.Models.Entities;

namespace HW3.Models.Abstract_entities
{
    public interface IFriendService
    {
        public List<Friend> GetFriends();
        public void CreateFriendsFile();
    }
}
