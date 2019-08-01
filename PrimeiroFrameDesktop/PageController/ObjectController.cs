using PrimeiroFrameDesktop.PageObjects;

namespace PrimeiroFrameDesktop.PageController
{
    public class ObjectController : ObjectPage
    {
        public static void ClickNumUm()
        {
            Driver.FindElement(NumeroUm()).Click();
        }
    }
}