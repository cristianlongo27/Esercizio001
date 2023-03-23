namespace MyFirstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definizione variabili
            // [tipo] [nome]
            int pippo;
            double numeroDecimale;
            string pluto;
            bool variabileBooleana = true;

            //qui sotto noi andremo ad impostare un valore alla variabile chiamata intero
            pippo = 10;



            Console.WriteLine("La variabile di nome 'intero' vale:" + pippo);
            //La variabile di nome 'intero' vale:10

            pippo = pippo * 2;

            Console.WriteLine($"La variabile di nome 'intero' vale:{pippo}");

            //ToDo: poi lo vedrai
            //Console.WriteLine(string.Format("La variabile di nome 'intero' vale:{0}", intero));


            Console.WriteLine("Ciao, come ti chiami? Inserisci il tuo nome e poi premi invio");

            pluto = Console.ReadLine();


            Console.WriteLine($"Hai scritto '{pluto}'");


            if (variabileBooleana == true)
            {
                //se vero
                Console.WriteLine("Ramo vero");
            }
            else
            {
                //se falso
                Console.WriteLine("Ramo falso");
            }

            Console.WriteLine("Fine");
        }
    }
}