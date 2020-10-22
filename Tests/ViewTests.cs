using MantisHome.Pages;
using MantisLogin.Pages;
using MantisPlus.Common;
using NUnit.Framework;

using MantisView.Pages;
using System.Threading;

namespace MantisView.Tests
{
    public class ViewTests : BaseTest
    {
        private LoginPage _loginPage;

        private HomePage _homePage;
        private ViewPage _viewPage;



        [SetUp]
        public void Before()
        {
            _homePage = new HomePage(Browser);
            _loginPage = new LoginPage(Browser);
            _viewPage = new ViewPage(Browser);
            _loginPage.AcessarPagina();
            _loginPage.PreencheUsuario("********");
            _loginPage.PreencheSenha("**********");
            _loginPage.BotaoLogin();
        }

        [Test]

        public void FiltrarIssue ()
        {
            _homePage.ClickView();
            _viewPage.PreencheFiltro("0004631");
            _viewPage.ClickFiltro();
            Assert.AreEqual("ID", _viewPage.FiltroSucess());
            
    
            
        }
        [Test]
        public void VisualizarIssue()
        {
            _homePage.ClickView();
            _viewPage.PreencheFiltro("0004631");
            _viewPage.ClickFiltro();
            _viewPage.AbrirIssue();
            Assert.AreEqual("0004631", _viewPage.ValidaIssue());
           
        }
    }
}
