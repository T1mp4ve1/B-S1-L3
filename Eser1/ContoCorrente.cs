public class ContoCorrente
{
    private string _cognomeCorrentista;
    public string CognomeCorrentista
    {
        get { return _cognomeCorrentista; }
        set { _cognomeCorrentista = value; }
    }

    private string _nomeCorrentista;
    public string NomeCorrentista
    {
        get { return _nomeCorrentista; }
        set { _nomeCorrentista = value; }
    }

    private decimal _saldo;
    public decimal Saldo
    {
        get { return _saldo; }
        set { _saldo = value; }
    }

    private bool _contoAperto = false;
    public bool ContoAperto
    {
        get { return _contoAperto; }
        set { _contoAperto = value; }
    }

    public void MenuIniziale()
    {
        bool continua = true;

        while (continua)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("I N T E S A   S A N   M A R C O   B A N K");
            Console.WriteLine("==========================================");

            Console.WriteLine("\nScegli l'operazione da effettuare:");
            Console.WriteLine("1. APRI NUOVO CONTO CORRENTE");
            Console.WriteLine("2. EFFETTUA UN VERSAMENTO");
            Console.WriteLine("3. EFFETTUA UN PRELEVAMENTO");
            Console.WriteLine("4. ESCI");

            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1":
                    ApriNuovoConto();
                    break;

                case "2":
                    Versamento();
                    break;

                case "3":
                    Prelevare();
                    break;

                case "4":
                    continua = false;
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }

    }

    //APRI CC
    public void ApriNuovoConto()
    {
        if (ContoAperto)
        {
            Console.WriteLine("Non puoi creare un'altro conto corrente.");
        }
        else
        {
            Console.WriteLine("Cognome Correntista: ");
            string Cognome = Console.ReadLine();

            Console.WriteLine("Nome Correntista: ");
            string Nome = Console.ReadLine();

            ContoCorrente cc = new ContoCorrente();
            _cognomeCorrentista = Cognome;
            _nomeCorrentista = Nome;
            _saldo = 0;
            _contoAperto = true;
            Console.WriteLine($"Il conto corrente nr. 3485 intestato a: {Nome} {Cognome} aperto con sucesso.");
            MenuIniziale();
        }

    }

    //VERSARE
    public void Versamento()
    {
        if (!ContoAperto)
        {
            Console.WriteLine("E' necessario prima aprire il conto\n");
        }
        else
        {
            Console.WriteLine("Quanto vuoi versare?");
            decimal importo = Decimal.Parse(Console.ReadLine());
            Saldo += importo;
            Console.WriteLine($"Versamento effettuato. Il saldo attuale del tuo conto: {Saldo}");
        }
        MenuIniziale();

    }

    //PRELEVARE
    public void Prelevare()
    {
        if (!ContoAperto)
        {
            Console.WriteLine("E' necessario prima aprire il conto\n");
        }
        else
        {
            Console.WriteLine("Quanto voi prelevare?");
            decimal importo = Decimal.Parse(Console.ReadLine());
            if (importo > Saldo)
            {
                Console.WriteLine("Fondi insuficenti");
            }
            else
            {
                Saldo -= importo;
                Console.WriteLine($"Prelevamento effettuato. Il saldo attuale del tuo conto: {Saldo}");
            }

        }
        MenuIniziale();
    }

}