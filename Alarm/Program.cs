using System;

namespace Alarm
{
    class Program
    {
        static void Main(string[] args)
        {

            Clock clock = new Clock(new Bell(), DateTime.Now, new Display());

            Console.WriteLine("Quando vuoi che la sveglia suoni?");


            Console.WriteLine("Ore");
            int.TryParse(Console.ReadLine(), out int ora);

            Console.WriteLine("Minuti");
            int.TryParse(Console.ReadLine(), out int minuto);

            Console.WriteLine("Secondi");
            int.TryParse(Console.ReadLine(), out int secondi);


            if (ora != 0 && minuto != 0 && secondi != 0)
            {
                clock.SetAlarm(ora, minuto, secondi);
                clock.TurnOn();

                Console.WriteLine("Premere un tasto per terminare il programma, altrimenti attendere che suoni la sveglia\n\n");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("C'è stato un errore, ripetere l'azione!");
                Main(new string[] { "" });
            }

            clock.TurnOff();

            Console.WriteLine("L'oroloio si è spento");
        }
    }
}
