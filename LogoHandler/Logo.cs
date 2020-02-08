namespace LogoHandler
{
    public class Logo : ILogo
    {
        public Logo(ILogoDesigner logoDesigner)
        {
            this.LogoMatrix = logoDesigner.CreateLogo();
        }
        public bool[,] LogoMatrix { get; private set; }
    }
}
