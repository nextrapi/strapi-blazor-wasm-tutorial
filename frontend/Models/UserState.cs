public class UserState
{
    public string jwt { get; set; }
    public UserData user { get; set; }
    public UserState(string jwt, UserData user) => (this.jwt, this.user) = (jwt, user);
}