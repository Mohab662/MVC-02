using Microsoft.AspNetCore.Mvc;

namespace MVC_02.Controllers
{
    public class MovieController : Controller
    {
        public /*ContentResult*/ IActionResult GetMovie(int id) 
        {
            //ContentResult result= new ContentResult();
            //result.Content=$"The Id is : {id}";
            //result.ContentType= "text/html";
            //result.StatusCode=200;
            //return result;

            return Content($"The Id is : {id}", "text/html");
            
        }
        [ActionName("Belkan")]
        //[HttpPost]
       //[AcceptVerbs("Post","Get")]
        public /*RedirectResult*/ IActionResult Index()
        {
            //RedirectResult redirect = new RedirectResult("https://localhost:44373/Movie/GetMovie/10");
            //return Redirect("https://localhost:44373/Movie/GetMovie/10");
            //return RedirectToAction(nameof(GetMovie), new { id = 10 });
            return RedirectToRoute("default");
        }

        public /*ViewResult*/ IActionResult Mohab()
        {
            //ViewResult view = new ViewResult();
            //return view;

            return View();
        }
    }
}
