// See https://aka.ms/new-console-template for more information

using Benutzerverwaltung;


List<User> UserListe = new List<User>();

void anzeigeUser()
{
    foreach(User user in UserListe)
    {
        Console.WriteLine(user.ToString());

        if (UserListe.Count > 1)
        {
            Console.WriteLine(new string('*', 42));
        }
    }
}

void erstelleUser()
{
    Console.WriteLine("Wie viele Benutzer wollen Sie erfassen?");
    int anzahl = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < anzahl; i++)
    {
        int Id = UserListe.Length;

        Console.WriteLine("Bitte geben Sie den Benutzername ein: ");
        string Username = Console.ReadLine();

        Console.WriteLine("Bitte geben Sie das Passwort ein: ");
        string Password = Console.ReadLine();

        Console.WriteLine("Bitte geben Sie die Email ein: ");
        string Email = Console.ReadLine();

        UserListe.Add(new User(1, Username, Password, Email, "User", false));
 
    }
}

bool on = true;

while (on)
{
    Console.WriteLine("Herzlich Willkommen in der Benutzerverwaltung" +
        "\n Folgende Programmfunktionen stehen Ihnen zur Verfügung:" +
        "\n (1) Accounts anzeigen" +
        "\n (2) Account erstellen" +
        "\n (3) Account bearbeiten (Account sperren / entsperren)" +
        "\n (4) Account löschen" +
        "\n (5) Accounts exportieren" +
        "\n (6) Programm beenden");

        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                anzeigeUser();
            break;
            case 2:
                erstelleUser();
            break;
            case 3:
            break;
            case 4:
            break;
            case 5:
            break;
            case 6:
                on = false;
            break;
            default:
                Console.WriteLine("Ungültige Auswahl, Bitte Auswahl überprüfen");
            break;
        }
}
