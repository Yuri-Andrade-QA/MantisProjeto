using NUnit.Framework;
using MantisLogin.Pages;
using MantisHome.Pages;
using MantisPlus.Common;

namespace MantisLogin.tests
{
    public class LoginTests : BaseTest
    {
    private LoginPage _loginPage;
    private HomePage _homePage;

    





        [Test]
        [Category("Login")]
        public void LoginComSucesso()
        {
             _loginPage = new LoginPage(Browser);
             _homePage = new HomePage(Browser);
            _loginPage.AcessarPagina();
            _loginPage.PreencheUsuario("*******");
            _loginPage.PreencheSenha("*********");
            _loginPage.BotaoLogin();

            Assert.AreEqual("yuri.andrade", _homePage.UsuarioLogado());
        }



        [Test]
        [Category("Login")]
        public void LoginInvalido()
        {
            _loginPage = new LoginPage(Browser);
            _loginPage.AcessarPagina();
            _loginPage.PreencheUsuario("mantis");
            _loginPage.PreencheSenha("123");
            _loginPage.BotaoLogin();

             Assert.AreEqual("Your account may be disabled or blocked or the username/password you entered is incorrect.", _loginPage.FalhaLogin());
        }
          [Test]
        public void LogoutSucess ()
        {
             _loginPage = new LoginPage(Browser);
             _homePage = new HomePage(Browser);
            _loginPage.AcessarPagina();
            _loginPage.PreencheUsuario("*******");
            _loginPage.PreencheSenha("**********");
            _loginPage.BotaoLogin();
            _homePage.Logout();
            Assert.AreEqual("Login",_loginPage.ValidLogout());
        }


    }
}
