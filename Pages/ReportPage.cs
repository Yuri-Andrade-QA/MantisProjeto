using Coypu;
namespace MantisReport.Pages
{
    public class ReportPage
    {
        private readonly BrowserSession _browser;

        public ReportPage(BrowserSession browser)
        {
            _browser=browser;
        }
         
         
    public void PreencheReport(string summary,string description)
    {
        _browser.FindCss(".row-1:nth-child(2) select").Click();
        _browser.Select("[All Projects] General").From("category_id");
        _browser.FillIn("summary").With(summary);
        _browser.FillIn("description").With(description);
          
    }
    public void EnviarRelatorio()
    {
        _browser.ClickButton("Submit Report");
    }
    public string AddSucess()
    {
       return _browser.FindCss("tr:nth-child(4) a").Text;
    }
    public string AddFail()
    {
       return _browser.FindCss(".form-title").Text;
}

    }
}