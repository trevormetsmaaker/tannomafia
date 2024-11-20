using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TannoMafia.Core.Domain.Dto.AccountsDto
{
    public class ApplicationUserDto
    {
        public string city {  get; set; }
        public string password { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public Guid? AssociatedPlayerProfile {  get; set; }
    }
}
