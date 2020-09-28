using Coypu;
namespace MantisView.Pages
{
   public class ViewPage {
       private readonly BrowserSession _browser;

        public ViewPage(BrowserSession browser)
        {
            _browser=browser;
        }

         public void PreencheFiltro(string ID)
         {
              _browser.FillIn("search").With(ID);
         }
         public void ClickFiltro()
         {
             _browser.ClickButton("filter");
         }
    public string FiltroSucess()
    {
       return _browser.FindLink("ID").Text;
   

    }
    public void AbrirIssue()
    {
        _browser.FindCss("tr:nth-child(4) > td:nth-child(4) > a").Click();
        _browser.ClickLink("Print");
    }
    public string ValidaIssue()
    {
        return _browser.FindCss(".print:nth-child(5) > .print:nth-child(1)").Text;
    }
   }  
}