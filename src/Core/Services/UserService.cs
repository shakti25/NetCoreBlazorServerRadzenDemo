using System.ComponentModel.DataAnnotations;

namespace NetCoreBlazorServerRadzenDemo.Core.Services;

public class UserService : IUserService
{
    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return new List<User> { 
            new User{ Id = 1, FirstName = "Pepe", LastName = "Perez", DateOfBirth = new DateOnly(1950, 05, 15), Email = "abc@test.co", Phone = "1408453998"  },
            new User{ Id = 2, FirstName = "Ramona", LastName = "Peluche", DateOfBirth = new DateOnly(1951, 06, 25), Email = "def@tst.coe", Phone = "1408453365"  },
            new User{ Id = 3, FirstName = "Goku", LastName = "Son", DateOfBirth = new DateOnly(1952, 07, 11), Email = "ghi@ffg.cof", Phone = "1408453556"  },
            new User{ Id = 4, FirstName = "James", LastName = "Bond", DateOfBirth = new DateOnly(1953, 08, 04), Email = "jkl@fdgd.coy", Phone = "1408453039"  },
            new User{ Id = 5, FirstName = "Ash", LastName = "Ketchup", DateOfBirth = new DateOnly(1954, 09, 18), Email = "mno@fhh.cor", Phone = "140845379"  }
        };
    }
}

public class User
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}