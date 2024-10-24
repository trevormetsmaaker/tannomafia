using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TannoMafia.Core.Domain;

namespace TannoMafia.Core.ServicesInterFace
{
    public interface ITannosServices
    {
        Task<Tanno> DetailsAsync(Guid id);
    }
}
