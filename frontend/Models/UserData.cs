public class UserData
{
    public int id { get; set; }
    public string email { get; set; }
    public string username { get; set; }
    public string provider { get; set; }
    public bool confirmed { get; set; }
    public bool blocked { get; set; }
    public string createdAt { get; set; }
    public string updatedAt { get; set; }
    public UserData(int id, string email, string username, string provider, bool confirmed, bool blocked,
    string createdAt, string updatedAt) => (this.id, this.email, this.username, this.provider,
    this.confirmed,
    this.blocked, this.createdAt, this.updatedAt) =
    (id, email, username, provider, confirmed, blocked, createdAt, updatedAt);


}