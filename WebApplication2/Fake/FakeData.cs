using Bogus;
using WebApplication2.Models;

namespace WebApplication2.Fake
{
    public class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers()
        {
            if (_users == null)
            {
                _users = new Faker<User>()
                    .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                    .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                    .RuleFor(u => u.LastName, f => f.Name.LastName())
                    .RuleFor(u => u.Address, f => f.Address.City())
                    .Generate(20);
            }
            return _users;
        }
    }
}
