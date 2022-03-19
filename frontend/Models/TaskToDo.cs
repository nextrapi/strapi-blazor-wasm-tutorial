public class TaskToDo
{

    public int id { get; set; }
    public TaskAttributes attributes { get; set; }

    public TaskToDo(int id, TaskAttributes attributes) => (this.id, this.attributes) = (id, attributes);
}