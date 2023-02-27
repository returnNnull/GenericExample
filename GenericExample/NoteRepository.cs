namespace GenericExample;

public class NoteRepository
{
    private List<Note> _notes = new();

    public Note GetById(int id) => _notes.First(u => u.Id == id);

    public List<Note> GetAll() => _notes;

    public List<Note> Filter(Func<Note, bool> filter) => _notes.Where(filter).ToList();

}