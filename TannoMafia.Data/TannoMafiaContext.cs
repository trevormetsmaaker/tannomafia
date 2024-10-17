using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TannoMafia.Data
{
    public class TannoMafiaContext
    {
        public DbSet<Tanno> Tannos { get; set; }
    }
}
