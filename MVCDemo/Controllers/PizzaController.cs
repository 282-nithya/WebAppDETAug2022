using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.PizzaService;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        private int id;

        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.PizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Details(int id)
        {
            Pizza p = PizzaService.PizzaService.Get(id);
            return View(p);
        }

      
        public IActionResult list()
        {
            List<Pizza> pizzas = PizzaService.PizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        //public IActionResult Create(int id,string name , int size, decimal price, bool Isglutenfree)

        //{
        //    Pizza p = new Pizza { Id = id, Name = name, Size = (PizzaSize)size, Price=price,IsGlutenFree=Isglutenfree};
        //    PizzaService.Add(p);
        //    return RedirectToAction("List");
        //}
        public IActionResult Create(Pizza p)
        {
            PizzaService.PizzaService.Add();
            return RedirectToAction("List");
        }


        public IActionResult Delete(int Id)
        {
            Pizza p = PizzaService.PizzaService.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Pizza p)
        {
            PizzaService.PizzaService.Update(p.id);
            return RedirectToAction("List");
        }
    }
}
