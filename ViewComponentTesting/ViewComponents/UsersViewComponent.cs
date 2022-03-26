using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ViewComponentTesting.Services;

namespace RazorPages.ViewComponents
{
    public class UsersViewComponent : ViewComponent
    {
        private IUserService _userService;
        public UsersViewComponent(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await _userService.GetUsersAsync();
            return View(users);
        }
    }
}