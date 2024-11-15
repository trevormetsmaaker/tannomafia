using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TannoMafia.Core.Domain;
using TannoMafia.Core.Domain.Dto;

namespace TannoMafia.Core.ServicesInterFace
{
    public interface IFileServices
    {
        void UploadFilesToDatabase(TannoDto dto, Tanno domain);
        Task<FileToDatabase> RemoveImageFromDatabase(FileToDatabaseDto dto);
    }
}
