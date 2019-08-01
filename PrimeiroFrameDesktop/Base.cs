using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Winium;

namespace PrimeiroFrameDesktop
{
    public abstract class Base
    {

        public static WiniumDriver Driver;

        [TestInitialize]
        public void Inicialize()
        {
            DesktopOptions Option = new DesktopOptions();
            Option.ApplicationPath = @"C:\Windows\System32\calc.exe";
            Driver = new WiniumDriver("Drivers", Option);
        }
    }
}