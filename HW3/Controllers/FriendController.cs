using HW3.Models.Abstract_entities;
using HW3.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HW3.Controllers
{
    public class FriendController : Controller
    {

        IFriendService friendService;
                public FriendController(IFriendService friendService)
        {
            this.friendService = friendService;
        }

        public ActionResult Index()
        {

            if (System.IO.File.Exists("friends.json"))
            {
            }
            else
            {
                friendService.CreateFriendsFile();
            }

            List<Friend> friends = friendService.GetFriends();
            return View(friends);
        }
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Friend friend)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        friend.FriendId = friendList.Count+1;
        //        friendList.Add(friend);

        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(friend);
        //}

        //public ActionResult Edit(int? id)
        //{
        //    var friend = friendList[id.Value-1];
        //    return View(friend);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(Friend friend)
        //{
        //    if (ModelState.IsValid)
        //    {
                
        //        friendList[friend.FriendId - 1].FriendName = friend.FriendName;
        //        friendList[friend.FriendId - 1].Place = friend.Place;

        //        return RedirectToAction("Index");
        //    }
        //    return View(friend);
        //}

        //public ActionResult Delete(int? id)
        //{
        //    var friend = friendList[id.Value - 1];
        //    return View(friend);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(Friend friend)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        friendList.RemoveAt(friend.FriendId - 1);
        //        return RedirectToAction("Index");
        //    }
        //    return View(friend);

        //}
    }
}
