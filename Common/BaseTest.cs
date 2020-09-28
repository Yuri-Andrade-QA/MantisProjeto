using NUnit.Framework;
using Coypu;
using Coypu.Drivers.Selenium;
using System;
namespace MantisPlus.Common
{
    public class BaseTest
    {
        protected BrowserSession Browser;

        [SetUp]
        public void Setup()
        {
            var configs = new SessionConfiguration
            {
                AppHost = "https://mantis-prova.base2.com.br/login_page.php?return=%2Fmy_view_page.php",
                SSL = false,
                Driver = typeof(SeleniumWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome,
                Timeout = TimeSpan.FromSeconds(5)
            };
            Browser = new BrowserSession(configs);
            Browser.MaximiseWindow();

        }


        [TearDown]

        public void Finish()
        {
            Browser.Dispose();
        }
    }
}