using Microsoft.AspNetCore.Mvc;
using tannomafia.Models.Tannos;
using TannoMafia.Data;

namespace tannomafia.Controllers
{
    public class TannoController : Controller
    {
        private readonly TannoMafiaContext _context;
        private readonly ITannoServices _TannoServices;

        public TannoController(TannoMafiaContext context, ITannoServices tannosServices)
        {
            _context = context;
            _TannoServices = tannosServices;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var resultingInvetory = _context.Tanno
                .OrderByDescending(y => y.TannoLevel)
                .Select(x => new TannoIndexViewModel
                 {
                    ID = x.ID,
                    TannoName = x.TannoName,
                    TannoType = x.TannoType,
                    TannoLevel = x.TannoLevel;
                 });
            return View(resultingInvetory);

        }
    }
}


