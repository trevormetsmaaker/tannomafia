using Microsoft.AspNetCore.Mvc;
using tannomafia.Models.Tannos;
using TannoMafia.Core.ServicesInterFace;
using TannoMafia.Data;

namespace tannomafia.Controllers
{
    public class TannoController : Controller
    {
        private readonly TannoMafiaContext _context;
        private readonly ITannosServices _TannoServices;

        public TannoController(TannoMafiaContext context, ITannosServices tannosServices)
        {
            _context = context;
            _TannoServices = tannosServices;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var resultingInvetory = _context.Tannos
                .OrderByDescending(y => y.TannoLevel)
                .Select(x => new TannoIndexViewModel
                 {
                    ID = x.ID,
                    TannoName = x.TannoName,
                    TannoType = (TannoType)x.TannoType,
                    TannoLevel = x.TannoLevel
                 });
            return View(resultingInvetory);

        }
    }
}


