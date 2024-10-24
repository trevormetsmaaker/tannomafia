using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TannoMafia.Core.Domain.Dto
{
    public enum TannoType
    {
        Happy, Sad, Angry, High, Hungry, Drunk
    }

    public enum TannoStatus
    {
        Dead, Alive, High, Drinking, Eating, Smoking
    }
    public class TannoDto
    {
        public Guid ID { get; set; }
        public string TannoName { get; set; }
        public int TannoHealth { get; set; }
        public int TannoXP { get; set; }
        public int TannoXPNextLevel { get; set; }
        public int TannoLevel { get; set; }
        public TannoType TannoType { get; set; }
        public TannoStatus TannoStatus { get; set; }
        public int PrimaryAttackPower { get; set; }
        public string PrimaryAttackName { get; set; }
        public int SecondaryAttackPower { get; set; }
        public string SecondaryAttackName { get; set; }
        public int SpecialAttackPower { get; set; }
        public string SpecialAttackName { get; set; }
        public DateTime TannoWasBorn { get; set; }
        public DateTime TannoDied { get; set; }

        
        //image
        /*
        public List<iFormFiile> Files { get; set; }
        public IEnumerable<FileToDatabaseDto> image { get; set; } = new List<FileToDatabaseDto>();
        */
        


        //db only
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}      




    

