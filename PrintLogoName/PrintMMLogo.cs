namespace PrintLogoName
{
    using System;
    using LogoHandler;

    class PrintMMLogo
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            if(n % 2 == 0 || n < 2 || n > 10000)
            {
                throw new ArgumentException("Thickness (N) should be odd number between 2 and 10000!");
            }
            var designer = new MMLogoDesigner(n);
            var mmLogo = new Logo(designer);
            var writer = new LogoWriter('*', '-');
            writer.WriteLogo(Console.Out, mmLogo);
        }
    }
}
