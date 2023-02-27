namespace GenericExample;

public class Note : Model
{
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime CreateDate { get; } = DateTime.Now;
}