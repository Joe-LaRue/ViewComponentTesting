using static ViewComponentTesting.Domain;

namespace ViewComponentTesting.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
    }
}
