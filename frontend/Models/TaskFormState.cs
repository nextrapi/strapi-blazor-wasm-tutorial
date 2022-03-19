using System.ComponentModel.DataAnnotations;
public class TaskFormState : IEquatable<TaskFormState>, ICloneable
{
    [Required]
    public string? title { get; set; }
    [Required]
    public string? description { get; set; }
    public bool Equals(TaskFormState? other)
    {
        if (this.title != other?.title) return false;
        if (this.description != other?.description) return false;
        return true;
    }
    public object Clone()
    {

        var data = new TaskFormState();
        data.title = this.title;
        data.description = this.description;
        return data;
    }
}