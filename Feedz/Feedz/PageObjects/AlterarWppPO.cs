using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feedz.PageObjects
{
    public class AlterarWppPO
    {
        private IWebDriver driver;
        private By byBotaoSalvar;
        private By byInputWpp;

        public AlterarWppPO(IWebDriver driver)
        {
            this.driver = driver;
            byInputWpp = By.ClassName("form-control.infoInput");
            byBotaoSalvar = By.Id("idButtonSaveProfile");
        }

        public void SalvarMeuPerfil(string wpp)
        {
            driver.FindElement(byInputWpp).SendKeys(wpp);
            driver.FindElement(byBotaoSalvar).Click();
        }
    }
}
