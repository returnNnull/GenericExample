namespace GenericExample;

public class Repository<TModel> where TModel : Model
{
    private readonly List<TModel> _items = new();

    public TModel GetById(int id) => _items.First(u => u.Id == id);

    public List<TModel> GetAll() => _items;

    public List<TModel> Filter(Func<TModel, bool> filter) => _items.Where(filter).ToList();

    public void Add(TModel model) => _items.Add(model);

    public void Delete(TModel model) => _items.Remove(model);
}