using Feedz.Fixture;
using OpenQA.Selenium;
using System;
using Xunit;
using Feedz.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Feedz
{
    [Collection("Chrome Driver")]
    public class LoginFeedz
    {
        private IWebDriver driver;
        public LoginFeedz(TesteFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void Login()
        {
            var LoginPO = new LoginPO(driver);
            LoginPO.Visitar();
            LoginPO.PreencherLogin("rafael.paula@netviewinformatica.com.br", "Netview123");
            LoginPO.SubmeterLogin();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            bool iguais = wait.Until(drv => LoginPO.NomeUsuario == "Rafael de Paula");
            Assert.True(iguais);

            //Assert.Contains("Rafael de Paula", driver.PageSource);
            MeuProfile();
        }
        [Fact]
        public void MeuProfile()
        {
            new LoginPO(driver).EfetuarLoginComCredenciais("ra*********.br", "********");
            new ResponderHumor(driver).ClicarFeliz();
            //new AlterarWppPO(driver).SalvarMeuPerfil("31993865846");

        }
    }
}
