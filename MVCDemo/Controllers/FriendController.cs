using Microsoft.AspNetCore.Mvc;
using MVCDemo.FriendService;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public List<Friend> Friends { get; set; }
        public IActionResult Index()
        {
            List<Friend> Friends = FriendService.FriendServices.GetAll();

            return View(Friends);
        }
        public IActionResult List()
        {
            List<Friend> friends = FriendService.FriendServices.GetAll();
            return View(friends);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Friend p)
        {
            FriendService.FriendServices.Add(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Friend p = FriendService.FriendServices.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(Friend p)
        {
            FriendService.FriendServices.Delete(p.FriendID);
            return RedirectToAction("List");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Friend f)
        {
            FriendService.FriendServices.Update(f);
            return RedirectToAction("List");
        }
        public IActionResult Details(int ID)
        {
             Friend f = FriendService.FriendServices.Get(ID);
            return View(f);
        }
    }
}
