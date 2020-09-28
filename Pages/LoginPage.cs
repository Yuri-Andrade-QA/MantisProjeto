using System;
using Coypu;

namespace MantisLogin.Pages
{
    public class LoginPage
    {
        private readonly BrowserSession _browser;

        public LoginPage(BrowserSession browser)
        {
            _browser = browser;
        }

        public void AcessarPagina()
        {
            _browser.Visit("/login_page.php?return=%2Fmy_view_page.php");
        }

        public void PreencheUsuario(string username)
        {
            _browser.FillIn("username").With(username);
        }
        public void PreencheSenha(string password)
        {
              _browser.FillIn("password").With(password);
        }
        public void BotaoLogin()
       {
           _browser.ClickButton("Login");
       }
       public string FalhaLogin() 
       {
           return _browser.FindCss("font").Text;
       }
            public string ValidLogout()
            {
             return _browser.FindCss(".form-title").Text;
            }
        
    }
    

}