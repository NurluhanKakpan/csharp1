namespace Practice;

public class User
{
    private string login;
    private int balance;

    public User(string login, int balance)
    {
        this.balance = balance;
        this.login = login;
    }

    public void addToBalance(int sum)
    {
        balance += sum;
    }

    public void spendFromBalance( int sum )
    {
        if (sum > balance)
        {
            Console.WriteLine("You enter sum bigger than your balance");
            Console.WriteLine("Enter another sum");
            int summa = Convert.ToInt32(Console.ReadLine());
            spendFromBalance( summa);
        }
        else
        {
            balance = balance - sum;
            Console.WriteLine($"You get from balance {sum} and in your balance have {balance}");
            
        }
        
    }

    public int Balance
    {
        get
        {
            return balance;
        }
        set
        {
            balance = value;
        }
    }

    public string Login
    {
        get
        {
            return login;
        }
        set
        {
            login = value;
        }
    }

    
}