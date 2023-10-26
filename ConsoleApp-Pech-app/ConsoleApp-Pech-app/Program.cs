// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;


Console.BackgroundColor = ConsoleColor.Black; // Set the background color to blue

Console.OutputEncoding = System.Text.Encoding.UTF8; //Deze code zorgt ervoor dat de console Emoji's kan laten zien.
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Welkom bij de Auto Pechapp!\U0001F527");
Thread.Sleep(3500); // Wait for 3.5 seconds (adjust the duration as needed)
Console.Clear(); // Clear the screen

Console.WriteLine("Gebruik de Pijltjes toetsen \u2191 en \u2193 om te navigeren en gebruikt de toets Enter om te slecteren"); //\u2191 staat voor de emoji pijl omlaag.
Console.WriteLine("Maak nu een keuze uit 1 van onderstaande opties");
Console.ResetColor();
Console.WriteLine();



ConsoleKeyInfo Key;
int option = 1;
bool isgekozen = false;
(int left, int top) = Console.GetCursorPosition();
string kleur = "\u001b[32m"; // deze code laat de kleur groen zien "\u001b[32m";

while (!isgekozen)
{ 
Console.SetCursorPosition(left, top);

Console.WriteLine($"{(option == 1 ? kleur : "" )}Lekke band\u001b[0m");  // Hier staat optie 1 krijgt kleur \u001b[32m groen wanneer geselecteerd hierna krijgt optie 1 de standaard kleur terug \u001b[0m wanneer deze niet meer geselecteerd is.
Console.WriteLine($"{(option == 2 ? kleur : "")}Auto start niet\u001b[0m"); 
Console.WriteLine($"{(option == 3 ? kleur : "")}Optie 3\u001b[0m");
Console.WriteLine($"{(option == 4 ? kleur : "")}Optie 4\u001b[0m");
Console.WriteLine($"{(option == 5 ? kleur : "")}Optie 5\u001b[0m");
Console.WriteLine($"{(option == 6 ? kleur : "")}Optie 6\u001b[0m");
Console.WriteLine($"{(option == 7 ? kleur : "")}Optie 7\u001b[0m");
Console.WriteLine($"{(option == 8 ? kleur : "")}Optie 8\u001b[0m");
Console.ResetColor();

     var key = Console.ReadKey(true);

	switch (key.Key)
	{
		case ConsoleKey.DownArrow:
			option = (option == 8 ? 1 : option + 1); // Hier staat wanneer er met pijltje omlaag de optie op de laatse optie staat dus 8 en als er dan nog door geklikt wordt gaat hij automatisch terug naar  8 ? 1 defineert  max aantal keuzes
            break;

			case ConsoleKey.UpArrow:
			option = (option == 1 ? 8 : option - 1); // Hier staat wanneer er met pijltje omhoog de optie op de laatse optie staat dus 1 en als er dan nog door geklikt wordt gaat hij automatisch terug naar  1 ? 8 defineert  max aantal keuzes
            break;

		case ConsoleKey.Enter:
			isgekozen = true;
			break;
	}

}

Console.WriteLine($"Je hebt de Optie gekozen {option}"); // hier wordt de option int weergegevn van de keuze die wordt gemaakt.


Console.Clear();
Console.WriteLine("Tweede commit git");

