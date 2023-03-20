using Microsoft.AspNetCore.Mvc;
using Trains.Models;
using Trains.Repository;

namespace Trains.Controllers
{
    public class StationDataController : Controller
    {
        private readonly ITrainRepository _trainRepository;
        public StationDataController(ITrainRepository trainRepository)
        {
            _trainRepository = trainRepository;
        }

        public IActionResult Index()
        {
            return View(_trainRepository.GetAllTrains());
        }
        [HttpGet]
        public IActionResult FindTrains()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AvailableTrains(Input input)
        {
            var trains = _trainRepository.FindAllTrains(input);
            return View(trains);
        }
    }
}
