using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.DirectoryServices;
namespace WebApplicationHH.ru.Pages
{ 
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        bool check = false;
        public string Message { get; private set; } = "";
        public void FindUser(string login)
        {
            DirectoryEntry catalog = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            try
            {
                DirectoryEntry user = catalog.Children.Find(login);
                check = true;


            }
            catch
            {
                check = false;
            }

        }
        public void OnGet()
        {
            Message = "Поле ввода имени пользователя";

        }
        public void OnPost(string username)
        {
            FindUser(username);
            if (check == true)
            {
                Response.Redirect("ResultTrue");
            }
            else if (check == false)
            {
                Response.Redirect("ResultFalse");
            }
        }
    }
}