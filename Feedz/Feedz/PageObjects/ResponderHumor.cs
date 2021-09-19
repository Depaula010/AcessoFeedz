using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feedz.PageObjects
{
    public class ResponderHumor
    {
        private IWebDriver driver;
        private By byBtnFeliz;
        private By byLinkMeuPerfil;

        public ResponderHumor(IWebDriver driver)
        {
            this.driver = driver;
            byBtnFeliz = By.LinkText("/assets/images/mood-4.png");
            //byLinkMeuPerfil = By.ClassName("fa-user");
        }

        public void ClicarFeliz()
        {
            var body = By.TagName("body");
            var inputs = body.FindElements((ISearchContext)By.TagName("input"));
            foreach (var input in inputs)
            {
                //input.Equals()
            }
            driver.FindElement(byBtnFeliz).Click();
        }
    }
}
