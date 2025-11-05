public class Program
{
    static void Main(string[] args)
    {
        string[] arrayNames = { "francesco", "mario", "ugo", "roberto", "ravioli", "mario" };
        string name;
        int numRes = 0;

        Console.WriteLine("Inserisci il nome da cercare:");
        name = Console.ReadLine();

        foreach (string e in arrayNames)
        {
            if (e == name)
            {
                numRes++;
            }
        }
        if (numRes == 0)
        {
            Console.WriteLine("Nessun resultato");
        }
        else
        {
            Console.WriteLine($"Nomi trovati: {numRes}");
        }
    }
}
