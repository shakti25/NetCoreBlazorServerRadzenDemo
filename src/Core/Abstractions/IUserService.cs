namespace NetCoreBlazorServerRadzenDemo.Core.Abstractions;

public interface IUserService
{
    Task<IEnumerable<User>> GetUsersAsync();
}
