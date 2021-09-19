using Feedz.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feedz.Fixture
{
    public class TesteFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        //SETUP
        public TesteFixture()
        {
            Driver = new ChromeDriver(TesteHelper.PastaDoExecutavel);
        }

        //TEARDOWN
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
