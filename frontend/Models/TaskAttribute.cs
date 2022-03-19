public class TaskAttributes
{
    public string title { get; set; }

    public string description { get; set; }
    public TaskAttributes(string title, string description) =>
    (this.title, this.description) = (title, description);

}