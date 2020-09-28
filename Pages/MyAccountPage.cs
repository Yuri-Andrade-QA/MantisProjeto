using Coypu;
namespace MantisAccount.Pages
{
   public class MyAccountPage {
       private readonly BrowserSession _browser;

        public MyAccountPage(BrowserSession browser)
        {
            _browser=browser;
        }

        public void  PreencheEmail (string email)
        {
            _browser.FillIn("email").With(email);
           
        }
           
           public void ConfirmaEdit ()
           {
               _browser.ClickButton("Update User");
           }




        public string  ValidaEdit()
        {
            return _browser.FindCss("div:nth-child(5)").Text;
        }
        public string  InvalidaEmail()
        {
            return _browser.FindCss("tr:nth-child(2) .center").Text;
        }
        public void ClickPerfil()
        {
            _browser.ClickLink("Profiles");
        }
        public void PreencheForm (string plataforma , string  os , string build)
        {
            _browser.FillIn("platform").With(plataforma);
            _browser.FillIn("os").With(os);
            _browser.FillIn("os_build").With(build);
        }
        public void ClickAddPerfil ()
        {
            _browser.ClickButton("Add Profile");
            
        }
        public void AbrirDropDown() 
        {
            _browser.FindCss("td > select").Click();
            
        }
       
        
            
        
   }

}
