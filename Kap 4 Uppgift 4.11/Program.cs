using System;
namespace Uppgift4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in något slumpmässigt:");
            string userInput = Console.ReadLine();

            bool again = false;

            for (int i = 0; i < userInput.Length; i++) 
            { 
                //Aktuellt tecken == userInput[i]

                //Finns tecknet igen?
                for (int j = 0; j < userInput.Length; j++)
                {
                    if (j != i && userInput[j] == userInput[i]) //Om j INTE == indextecken som i men samma tecken
                    {
                            Console.WriteLine($"'{userInput[j]}' förekommer mer än en gång.");
                            again = true; //Ja, det finns minst ett dubbeltecken
                            break;
                    }
                }
            }

            if (again == false)
            {
                Console.WriteLine("Inget tecken förekommer fler än en gång.");
            }
            /*Jag hittade inget sätt att spara vilken karaktär som redan har funnits av programmet, 
            så den skriver att samma karaktär har hittats flera gånger.*/
        }
    }
}