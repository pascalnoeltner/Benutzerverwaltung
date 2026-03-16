public class User
{
    private int Id;
    private string Username;
    private string Passwort;
    private string Email;
    private string Role;
    private bool isLocked;

    public User(int Id, string Username, string Passwort, string Email,
                string Role, bool isLocked)
    {
        this.Id = Id;
        this.Username = Username;
        this.Passwort = Passwort;
        this.Email = Email;
        this.Role = Role;
        this.isLocked = isLocked;
    }

    
}