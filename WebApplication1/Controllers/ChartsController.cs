using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class ChartsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ChartsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChartsData()
        {
            return View();
        }
        [HttpPost]
        public List<object> GetChartsData()
        {
            List<object> Tabledata = new List<object>();

            List<int> labels = _db.NetEnergies.Select(p => p.Id).ToList();
            Tabledata.Add(labels);

            List<string> value = _db.NetEnergies.Select(p =>p.ESd1).ToList();
            Tabledata.Add(value);


            return Tabledata;
        }
    }
}
