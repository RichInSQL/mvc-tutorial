using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApplication.Models;

namespace MyFirstMVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            //Clean view model as we are also creating a new dog in this view
            var dogvM = new DogViewModel();
            return View(dogvM);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");

            //This is going to redirect to an action in this controller.
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

    }
}
