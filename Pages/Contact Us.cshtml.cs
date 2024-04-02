using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewWeb.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public string firstName = "";
        public string lastname = "";
        public string message = "";
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            hasData = true;
            firstName = Request.Form["firstname"];
            lastname = Request.Form["lastname"];
            message = Request.Form["message"];
        }
    }
}
