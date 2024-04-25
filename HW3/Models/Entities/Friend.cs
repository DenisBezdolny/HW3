using HW3.Models.Abstract_entities;

namespace HW3.Models.Entities
{
    public class Friend:IFriendService
    {
        public int FriendId { get; set; }
        public string FriendName { get; set; }
        public string Place { get; set; }

        public List<Friend> GetFriends()
        {
            throw new NotImplementedException();
        }
    }
}
