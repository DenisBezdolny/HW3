using HW3.Models.Abstract_entities;
using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace HW3.Models.Entities
{
    public class Friend:IFriendService
    {

        public int FriendId { get; set; }
        public string FriendName { get; set; }
        public string Place { get; set; }

        public List<Friend> GetFriends()
        {
            string filePath = "friends.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                Friend[] friends = JsonSerializer.Deserialize<Friend[]>(jsonString);
                return friends.ToList();
            }
            else
            {
                return new List<Friend>();
            }
        }

        public void CreateFriendsFile()
        {
            string filePath = "friends.json";
            if (!File.Exists(filePath))
            {
                List<Friend> friendList = new List<Friend>()
                {
                    new Friend{ FriendId = 1,  FriendName = "Ivan",  Place = "Minsk" },
                    new Friend{ FriendId = 2,  FriendName = "Sergey", Place = "Grodno" },
                    new Friend{ FriendId = 3,  FriendName = "Maria",  Place = "Gomel" }
                };

                string jsonString = JsonConvert.SerializeObject(friendList);
                File.WriteAllText(filePath, jsonString);
            }
        }
    }
}
