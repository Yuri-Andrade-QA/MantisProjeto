using System;
using Coypu;
namespace MantisHome.Pages
{
    public class HomePage
    {
        private readonly BrowserSession _browser;
        public HomePage(BrowserSession browser)
        {
            _browser = browser;
        }
        public string UsuarioLogado()
        {
            return _browser.FindCss(".login-info-left > .italic").Text;
        }
        public void ClickReport()
        {
            _browser.ClickLink("Report Issue");
        }
        public void ClickView()
        {
            _browser.ClickLink("View Issues");
        }
        public void ClickAccount()
        {
            _browser.ClickLink("My Account");
        }
        public void Logout () 
        {
            _browser.ClickLink("Logout");
        }
    }
}