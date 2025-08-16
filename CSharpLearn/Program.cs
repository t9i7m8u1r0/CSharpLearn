class MainClass
{
    public static void Main(string[] args)
    {
        
    }
}

class User
{
    string login;
    string email;

    public string Login
    {
        get
        {
            return login;
        }

        set
        {
            if (value.Length >= 3)
            {
                login = value;
            }
            else
            {
                Console.WriteLine("Login must be 3 or more characters");
            }
        }
    }

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            if (value.Contains("@"))
            {
                email = value;
            }
            else
            {
                Console.WriteLine("Email must contain @");
            }
        }
    }
}