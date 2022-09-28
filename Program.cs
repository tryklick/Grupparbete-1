using System;

namespace Miniräknare
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Välkommen till miniräknaren!");

            Console.Write("\n __*____/____+______-_____\n");

            Console.Write("\nHallå där!\n");

            // Välkomnande meddelande




            List<string> ResultatHistoria = new List<string>();

            // En lista för att spara historik för räkningar


            while (true)
            {
                string Operator = "";
                string total = "";
                string input1 = "";
                string input2 = "";
                double Resultat = 0;
                double tal1 = 0;
                double tal2 = 0;

                

                Console.WriteLine("Uppge ditt första heltal");
                input1 = Console.ReadLine();
                while (!double.TryParse(input1, out tal1))
                {
                    if (input1 == " ")
                    {
                        Console.WriteLine("Skriv in ett tal:");
                        input1 = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Inaktuell,vad vänligt skriv in ett heltal!");
                        input1 = Console.ReadLine();
                    }
                }
                // Användaren matar in tal och matematiska operation
                //OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!



                Console.WriteLine("Välje en operator ( -, +, *, / )");
                Operator = Console.ReadLine();

                while (true)
                {

                    if (Operator == "*" || Operator == "+" || Operator == "-" || Operator == "/")
                    {
                        break;
                    }
                    else if (Operator == "EXIT")
                    {

                        Console.WriteLine("Hej");
                        Environment.Exit(10);

                    }
                    else
                    {
                        Console.WriteLine("operator");
                        Operator = Console.ReadLine();
                    }

                } // Användaren matar in tal och matematiska operation




                Console.WriteLine("Uppge andra talet");
                input2 = Console.ReadLine();
                while (!double.TryParse(input2, out tal2))
                {
                    if (input2 == " ")
                    {
                        Console.WriteLine("Skriv in ett tal::");
                        input2 = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Inaktuell,välj ett heltal ");
                        input2 = Console.ReadLine();
                    }
                }

                
                switch (Operator)
                {
                    case "/":
                        Resultat = tal1 / tal2;
                        break;
                    case "*":
                        Resultat = tal1 * tal2;
                        break;
                    case "-":
                        Resultat = tal1 - tal2;
                        break;
                    case "+":
                        Resultat = tal1 + tal2;
                        break;

                }

                
                if (Operator == "-")
                {
                    total = tal1 + " - " + tal2 + " = " + Resultat.ToString();
                    Console.WriteLine(total);
                }
                else if (Operator == "+")
                {
                    total = tal1 + " + " + tal2 + " = " + Resultat.ToString();
                    Console.WriteLine(total);
                }
                else if (Operator == "*")
                {
                    total = tal1 + " * " + tal2 + " = " + Resultat.ToString();
                    Console.WriteLine(total);
                }
                else if (Operator == "/")
                {
                    
                    if (tal2 == 0)
                    {
                        Console.WriteLine("\n Inaktuell, vad vänligt välj en av operator.");
                    }

                    else
                    {
                        total = tal1 + " / " + tal2 + " = " + Resultat.ToString();
                        Console.WriteLine(total);
                    }


                    // Användaren matar in tal och matematiska operation
                    //OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
                    // Ifall användaren skulle dela 0 med 0 visa Ogiltig inmatning!




                }
                //resusltat till listan 
                ResultatHistoria.Add(total);

                
                Console.Write("\n __*____/____+______-_____\n" +
                    "Om du vill se tidigare resultat klicka på ( h ) eller på ( ENTER ) för att fortsätta: ");
                if (Console.ReadLine() == "h")
                {
                    foreach (string h in ResultatHistoria)
                    {
                        Console.WriteLine("\n" + h);
                    }
                }

                
                Console.Write("Om du vill avsluta pårgramet tryck ( a ) eller på ( ENTER ) för en ny beräkning: ");
                if (Console.ReadLine() == "a")
                {
                    break;
                }
                Console.Write("\n __*____/____+______-_____\n");
            }
            //Fråga användaren om den vill avsluta eller fortsätta.

        }
    }
}