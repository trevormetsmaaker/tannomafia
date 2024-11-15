namespace tannomafia.Models.Tanno
{
    public class TannoImageViewModelcs
    {
        public Guid ImageID { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
        public string Image { get; set; }
        public Guid? TannoID { get; set; }
    }
}
