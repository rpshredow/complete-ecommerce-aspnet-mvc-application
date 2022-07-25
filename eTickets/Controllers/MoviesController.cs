using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.Cinema);

            return View(data);
        }

        //GET: Movies/Detail/1
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        public IActionResult Create()
        {
            ViewData["Welcome"] = "Welcome to our store";
            ViewBag.Description = "This is the store description";

            return View();
        }
    }
}
