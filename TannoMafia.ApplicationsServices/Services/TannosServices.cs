using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tannomafia.Controllers;
using TannoMafia.Data;

namespace TannoMafia.ApplicationsServices.Services
{
    public class TannosServices : ITannosServices
    {
        private readonly TannoMafiaContext _context;


        public TannosServices(TannoMafiaContext context,/* IFileServices fileServices*/)
        {
            _context = context;
            //_fileServices = fileServices
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <returns>resulting Tanno</returns>

        public async Task<Tanno> DetailsAsync(Guid id)
        {
            var result = await _context.Tannos
                .FirstOrDefaultAsync(x => x.Id == id); 
            return result;
        }
    }
    

}
