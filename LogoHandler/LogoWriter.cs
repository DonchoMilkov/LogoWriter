namespace LogoHandler
{
    using System.IO;
    public class LogoWriter : ILogoWriter
    {
        private char textSymbol;
        private char backgroundSymbol;
        public LogoWriter(char textSymbol, char backgroundSymbol)
        {
            this.textSymbol = textSymbol;
            this.backgroundSymbol = backgroundSymbol;
        }
        public void WriteLogo(TextWriter writer, ILogo logo)
        {
            var arr = logo.LogoMatrix;
            var height = arr.GetUpperBound(0);
            var len = arr.GetUpperBound(1);
            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j <= len; j++)
                {
                    if (arr[i, j])
                    {
                        writer.Write(textSymbol);
                    }
                    else
                    {
                        writer.Write(backgroundSymbol);
                    }
                }
                writer.WriteLine();
            }
        }
    }
}
