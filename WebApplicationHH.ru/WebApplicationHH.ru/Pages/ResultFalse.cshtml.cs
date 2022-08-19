using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationHH.ru.Pages
{
    [IgnoreAntiforgeryToken]
    public class ResultFalseModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Response.Redirect("index");
        }
    }
}
