using tannomafia.Models.Tannos;

namespace tannomafia.Models.Tanno
{
    public class TannoDetailsViewModelcs
    {
        public Guid? ID { get; set; }
        public string TannoName { get; set; }
        public int TannoHealth { get; set; }
        public int TannoXP { get; set; }
        public int TannoXPNextLevel { get; set; }
        public int TannoLevel { get; set; }
        public TannoType TitanType { get; set; }
        public TannoStatus TitanStatus { get; set; }
        public int PrimaryAttackPower { get; set; }
        public string PrimaryAttackName { get; set; }
        public int SecondaryAttackPower { get; set; }
        public string SecondaryAttackName { get; set; }
        public int SpecialAttackPower { get; set; }
        public string SpecialAttackName { get; set; }
       // public List<IFormFile> Files { get; set; }
        public List<TannoImageViewModelcs> Image { get; set; } = new List<TannoImageViewModelcs>();
    }
}
