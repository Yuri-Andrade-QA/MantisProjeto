using MantisHome.Pages;
using MantisLogin.Pages;
using MantisPlus.Common;
using NUnit.Framework;
using MantisReport.Pages;


namespace MantisReport.tests
{
    public class ReportTest: BaseTest
    {
       private LoginPage _loginPage;
       private ReportPage _reportPage;
       private HomePage _homePage;



        [SetUp]
        public void Before()
        {
            _homePage=new HomePage(Browser);
            _reportPage= new ReportPage(Browser);
            var loginPage = new LoginPage(Browser);
            loginPage.AcessarPagina();
            loginPage.PreencheUsuario("yuri.andrade");
            loginPage.PreencheSenha("33335385yuri");
            loginPage.BotaoLogin();

        }

        [Test]
        public void ReportIssueComSucess()
        {    
            _homePage.ClickReport();
            _reportPage.PreencheReport("Problema","Problema Encontrado em Produção");
            _reportPage.EnviarRelatorio();
             
             Assert.AreEqual("0004704", _reportPage.AddSucess());
           
        }
        [Test]
        public void ReportIssueFalha()
        {
            _homePage.ClickReport();
            _reportPage.PreencheReport("problema","");
            _reportPage.EnviarRelatorio();
            Assert.AreEqual("APPLICATION ERROR #11", _reportPage.AddFail());
        }
    }
}