namespace LogoHandler
{
    using System.IO;
    interface ILogoWriter
    {
        void WriteLogo(TextWriter writer, ILogo logo);
    }
}
