using Eser1;

public class Program
{
    public static void Main()
    {
        ContoCorrente conto1 = new ContoCorrente();
        conto1.ApriConto(1845, "Carlo", 1000);
        conto1.Versa(400);
        conto1.Preleva(200);
        Console.WriteLine("");

        ContoCorrente conto2 = new ContoCorrente();
        conto2.ApriConto(4367, "Mario", 2000);
    }
}