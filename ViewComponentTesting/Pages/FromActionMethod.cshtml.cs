using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ViewComponentTesting.Pages
{
    public class FromActionMethodModel : PageModel
    {
        public IActionResult OnGet()
        {
            return ViewComponent("Users");
        }
    }
}
