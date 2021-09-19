using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feedz.PageObjects
{
    public class MeuPerfilPO
    {
        private IWebDriver driver;
        private By byBotaoMenu;
        private By byLinkMeuPerfil;

        public MeuPerfilPO(IWebDriver driver)
        {
            this.driver = driver;
            byBotaoMenu = By.Id("dropdownMenuMobile");
            byLinkMeuPerfil = By.ClassName("fa-user");
        }

        public void IrMeuPerfil()
        {
            driver.FindElement(byBotaoMenu).Click();
            //var link = driver.FindElement(byLinkMeuPerfil);
            //IAction acaoMeuPerfil = new Actions(driver).MoveToElement(link).Click().Build();
            //acaoMeuPerfil.Perform();
            driver.FindElement(byLinkMeuPerfil).Click();
        }
    }
}
