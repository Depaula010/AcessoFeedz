using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feedz.PageObjects
{
    public class LoginPO
    {
        private IWebDriver driver;
        private By byInputEmail;
        private By byInputSenha;
        private By byBotaoLogin;
        private By byConfereLogin;

        public string NomeUsuario
        {
            get
            {
                var valorTexto = driver.FindElement(byConfereLogin).Text;
                return valorTexto;
            }
        }

        public LoginPO(IWebDriver driver)
        {
            this.driver = driver;
            byInputEmail = By.Id("login_email");
            byInputSenha = By.Name("login_password");
            byBotaoLogin = By.TagName("button");
            byConfereLogin = By.ClassName("profile-label");
        }

        public void Visitar()
        {
            driver.Navigate().GoToUrl("https://app.feedz.com.br/");
        }

        public void SubmeterLogin()
        {
            driver.FindElement(byBotaoLogin).Click();
        }

        public void PreencherLogin(string email, string senha)
        {
            driver.FindElement(byInputEmail).SendKeys(email);
            driver.FindElement(byInputSenha).SendKeys(senha);
        }

        public void EfetuarLoginComCredenciais(string email, string senha)
        {
            Visitar();
            PreencherLogin(email, senha);
            SubmeterLogin();
        }
    }
}
