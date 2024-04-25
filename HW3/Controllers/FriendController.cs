using HW2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW2.Controllers
{
    public class FriendController : Controller
    {
       
        static List<Friend> friendList = new List<Friend>()
        {
            new Friend{ FriendId = 1,  FriendName = "Ivan",  Place = "Minsk" },
            new Friend{ FriendId = 2,  FriendName = "Sergey", Place = "Grodno" },
            new Friend{ FriendId = 3,  FriendName = "Maria",  Place = "Gomel" }
        };


        public ActionResult Index()
        {

            return View(friendList);

        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Friend friend)
        {
            if (ModelState.IsValid)
            {

                friend.FriendId = friendList.Count+1;
                friendList.Add(friend);

                return RedirectToAction(nameof(Index));
            }
            return View(friend);
        }

        public ActionResult Edit(int? id)
        {
            var friend = friendList[id.Value-1];
            return View(friend);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Friend friend)
        {
            if (ModelState.IsValid)
            {
                
                friendList[friend.FriendId - 1].FriendName = friend.FriendName;
                friendList[friend.FriendId - 1].Place = friend.Place;

                return RedirectToAction("Index");
            }
            return View(friend);
        }

        public ActionResult Delete(int? id)
        {
            var friend = friendList[id.Value - 1];
            return View(friend);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Friend friend)
        {
            if (ModelState.IsValid)
            {
                friendList.RemoveAt(friend.FriendId - 1);
                return RedirectToAction("Index");
            }
            return View(friend);

        }
    }
}
