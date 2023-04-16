using Practice;

public  class Program
{
    static  void Main(string[] args)
    {
        Promotion promotion = new Promotion("Tesla", 15000);
        BriefCase newCase = new BriefCase();
        User user1 = new User("nurik", 20000,newCase);
        user1.AddToBriefCase(promotion);
        Console.WriteLine(newCase.Promotions[0].Name);






    }
}