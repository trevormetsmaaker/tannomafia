using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TannoMafia.Core.Domain;
using TannoMafia.Core.ServiceInterface;
using TannoMafia.Data;

namespace TannoMafia.ApplicationsServices.Services
{
    public class TannosServices : ITannoServices
    {
        private readonly TannoMafiaContext _context;



        public TannosServices(TannoMafiaContext context)
        {
            _context = context;
        }




        public async Task<Tanno> DetailsAsync(Guid id)
        {
            var result = await _context.Tannos
            .FirstOrDefaultAsync(x => x.ID == id);  
            return result;
        }
    }

}
