// See https://aka.ms/new-console-template for more information

string[] people = { "Tina", "Bart", "Sander", "Jan" }; //[] staat voor Array 

Console.WriteLine(people[0]); //eerste element zeg je 0 dus Tina 2e element zeg je 1 dus Bart
Console.WriteLine(people[people.Length - 1]); //LENGTH GEEFT LENGTE AAN PEUPLE.LENGTH MOET OP -1 OM DE LAATSTE TE PAKKEN.

for (int i = 0; i < people.Length; i++) //i wordt net zo groot als de Array dus 4 personen 
{
    Console.WriteLine(people[i]); 
}


