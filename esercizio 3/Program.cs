public class Program
{
    static void Main()
    {
        int somm = 0;
        int arrayLen;
        Console.WriteLine("Di quanti elementi voi creare l'array?");
        arrayLen = int.Parse(Console.ReadLine());

        for (int i = 0; i < arrayLen; i++)
        {
            Console.WriteLine($"Devi inserire {arrayLen - i} numeri");
            Console.WriteLine("Inserisci il numero: ");
            somm += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"La somma: {somm}");
        Console.WriteLine($"La media: {somm / arrayLen} ");
    }
}