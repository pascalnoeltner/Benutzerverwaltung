public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public bool IsLocked { get; set; }

    public User(int id, string username, string password, string email,
                string role, bool isLocked)
    {
        Id = id;
        Username = username;
        Password = password;
        Email = email;
        Role = role;
        IsLocked = isLocked;
    }

    public override string ToString()
    {
        return $"Benutzer: {Username}" +
            $"\nPasswort: {Password}" +
            $"\nEmail: {Email}" +
            $"\nRole: {Role}" +
            $"\nIsLocked: {IsLocked}";

    }
}