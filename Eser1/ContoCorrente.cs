namespace Eser1
{
    internal class ContoCorrente
    {
        public int NumeroConto { get; set; }
        public string Intestatario { get; set; }
        public int Saldo { get; set; }
        public bool contoAperto = false;

        //CREA IL CONTO
        public void ApriConto(int numeroConto, string intestario, int saldo)
        {
            NumeroConto = numeroConto;
            Intestatario = intestario;
            Saldo = saldo;
            contoAperto = false;

            if (contoAperto)
            {
                Console.WriteLine("Il conto e' stato gia aperto.");
            }
            else
            {
                if (Saldo < 1000)
                {
                    Console.WriteLine("Il deposito iniziale non puo essere minore di 1000 eur");
                    return;
                }
                else
                {
                    Console.WriteLine($"Ciao {Intestatario}, il saldo del tuo conto {NumeroConto}: {Saldo} eur");
                    contoAperto = true;
                }
            }
        }

        //VERSARE IL DENARO
        public void Versa(int importo)
        {
            if (contoAperto)
            {
                Saldo += importo;
                Console.WriteLine($"Versamento effettuato. Saldo attuale: {Saldo} eur");
            }
            else
            {
                return;
            }
        }

        //PRELIEVO
        public void Preleva(int importo)
        {
            if (contoAperto)
            {
                if (importo > Saldo)
                {
                    Console.WriteLine("Fondi insufficienti");
                    return;
                }
                else
                {
                    Saldo -= importo;
                    Console.WriteLine($"Hai prelevato {importo} eur. Saldo attuale: {Saldo} eur");
                }
            }
            else
            {
                return;
            }
        }
    }
}