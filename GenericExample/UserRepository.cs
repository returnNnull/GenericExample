namespace GenericExample;

public class UserRepository
{
    private List<User> _users = new();

    public User GetById(int id) => _users.First(u => u.Id == id);

    public List<User> GetAll() => _users;

    public List<User> Filter(Func<User, bool> filter) => _users.Where(filter).ToList();

}