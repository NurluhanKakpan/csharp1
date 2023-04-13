using Practice;

public  class Program
{
    static  void Main(string[] args)
    {
        User user1 = new User("nkakpan",200000);
        user1.addToBalance(10000);
        Console.WriteLine(user1.Balance);
        user1.spendFromBalance(3000000);
        Console.WriteLine(user1.Balance);
        
    }
}