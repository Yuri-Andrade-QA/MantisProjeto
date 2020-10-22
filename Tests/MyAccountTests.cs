using MantisHome.Pages;
using MantisLogin.Pages;
using MantisPlus.Common;
using NUnit.Framework;


using System.Threading;
using MantisAccount.Pages;

namespace MantisView.Tests
{
    public class MyAccountTests : BaseTest
    {
        private LoginPage _loginPage;

        private HomePage _homePage;
        private MyAccountPage _accountPage;



        [SetUp]
        public void Before()
        {
            _homePage = new HomePage(Browser);
            _loginPage = new LoginPage(Browser);
            _accountPage = new MyAccountPage(Browser);
            _loginPage.AcessarPagina();
            _loginPage.PreencheUsuario("********");
            _loginPage.PreencheSenha("**********");
            _loginPage.BotaoLogin();
        }

        [Test]
        [Category("Edit")]

        public void EditContaSucesso ()
        {
            _homePage.ClickAccount();
            _accountPage.PreencheEmail("yuritest3@yahoo.com.br");
            _accountPage.ConfirmaEdit();
            Assert.AreEqual("Operation successful.\r\n[ Proceed ]", _accountPage.ValidaEdit());
        }
        [Test]
        public void EmailInvalido() 
        {
            _homePage.ClickAccount();
            _accountPage.PreencheEmail("yuritest3@yahoo.com.");
            _accountPage.ConfirmaEdit();
            Assert.AreEqual("Invalid e-mail address.",_accountPage.InvalidaEmail());
            
        }

        [Test]

        public void AddPerfilSucess () 
        {
          _homePage.ClickAccount();
          _accountPage.ClickPerfil();
          _accountPage.PreencheForm("Microsoft","Windows D","x64");
          _accountPage.ClickAddPerfil();
          _accountPage.AbrirDropDown();
          bool hasPerfil= Browser.FindCss("td > select",text: "Microsoft Windows D x64").Exists();
          Assert.That(hasPerfil);
        }
    }
}
