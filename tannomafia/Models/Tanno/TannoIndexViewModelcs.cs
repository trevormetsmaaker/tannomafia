namespace tannomafia.Models.Tannos
{

    public enum TitanType
    {
        Happy, Sad, Angry, High, Hungry, Drunk
    }
public enum TitanStatus
    {
        Dead, Alive,High, Drinking, Eating, Smoking
    }





    public class TannoIndexViewModelcs
    {
        public Guid ID { get; set; }
        public string TitanName { get; set; }
        public int TitanHealth { get; set; }
        public int TitanXP { get; set; }
        public int TitanXPNextLevel { get; set; }
        public int TitanLevel { get; set; }
        public TitanType TitanType { get; set; }
        public TitanStatus TitanStatus { get; set; }
        public int PrimaryAttackPower { get; set; }
        public string PrimaryAttackName { get; set; }
        public int SecondaryAttackPower { get; set; }
        public string SecondaryAttackName { get; set; }
        public int SpecialAttackPower { get; set; }
        public string SpecialAttackName { get; set; }
        public DateTime TitanWasBorn { get; set; }
        public DateTime TitanDied { get; set; }

        //db only
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
