using GerenciadorDeAniversarios.Domain.Entities;
using GerenciadorDeAniversarios.Domain.Interfaces;
using GerenciadorDeAniversarios.Domain.Repositories;
using System.Linq;
using System.Web.Mvc;

namespace GerenciadorDeAniversarios.Web.Controllers
{
    public class FriendsController : Controller
    {
        private readonly IRepository<Friend> db;

        public FriendsController()
        {
            db = FriendsRepository.Instance;
        }

        public ActionResult Index()
        {
            var friends = db.GetAll().ToList();

            return View(friends);
        }

        public ActionResult Details(int id)
        {
            var friend = db.GetById(id);

            return View(friend);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Friend friend)
        {
            if (ModelState.IsValid)
            {
                db.Insert(friend);
                return RedirectToAction("Index");
            }

            return View(friend);
        }

        public ActionResult Edit(int id)
        {
            var friend = db.GetById(id);

            return View(friend);
        }

        [HttpPost]
        public ActionResult Edit(Friend friend)
        {
            db.Update(friend);
            return RedirectToAction("Details", new { id = friend.Id });
        }

        public ActionResult Delete(int id)
        {
            db.Remove(id);
            return RedirectToAction("Index");
        }
    }
}