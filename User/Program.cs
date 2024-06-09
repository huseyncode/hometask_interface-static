public enum RegistrationMonth
{
    Yanvar,
    Fevral,
    Mart,
    Aprel,
    May,
    İyun,
    İyul,
    Avqust,
    Sentyabr,
    Oktyabr,
    Noyabr,
    Dekabr
}

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public RegistrationMonth RegistrationMonth { get; set; }
    private string _pin;

    public string PIN
    {
        get { return _pin; }
        set
        {
            if (value.IsValidPIN())
            {
                _pin = value;
            }
            else
            {
                Console.WriteLine("Invalid PIN. PIN must be 7 characters long and all characters must be uppercase.");
                _pin = "INVALID";
            }
        }
    }

    public User(string name, string surname, RegistrationMonth registrationMonth, string pin)
    {
        Name = name;
        Surname = surname;
        RegistrationMonth = registrationMonth;
        PIN = pin;
    }

    public string GetDetails()
    {
        return $"Name: {Name}, Surname: {Surname}, Registration Month: {RegistrationMonth}, PIN: {PIN}";
    }
}

public static class StringExtensions
{
    public static bool IsValidPIN(this string str)
    {
        return str.Length == 7 && str.All(char.IsUpper);
    }
}

class Program
{
    static void Main(string[] args)
    {
        User[] users = new User[5];
        users[0] = new User("Ali", "Aliyev", RegistrationMonth.Yanvar, "3D83JX6");
        users[1] = new User("Veli", "Veliyev", RegistrationMonth.Fevral, "4E94KY7");
        users[2] = new User("Hasan", "Hasanov", RegistrationMonth.Mart, "5F05LZ8");
        users[3] = new User("Huseyn", "Huseynov", RegistrationMonth.Aprel, "6G16MA9");
        users[4] = new User("Ismayil", "Ismayilov", RegistrationMonth.May, "7H27NB0");

        foreach (User user in users)
        {
            Console.WriteLine(user.GetDetails());
        }
    }
}
