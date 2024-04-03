// See https://aka.ms/new-console-template for more information

/*creeningen skal anbefales for mænd over 50. Kvinder skal have at vide, at de ikke er i risikogruppen,
og mænd under 50 skal have at vide, at de bør blive screenet når de er over 50.*/

Console.WriteLine("Hvad er dit køn (mand/kvinde)");
var koen = Console.ReadLine();

Console.WriteLine("Hvor gammel er du?");
int alder = Convert.ToInt32(Console.ReadLine());

Console.Clear();
if (koen == "kvinde")
{
    Console.WriteLine("Du er ikke i risikogruppen.");
} else
{
    if (alder > 50)
    {
        Console.WriteLine("Du bør tage en screeningen.");
    } else
    {
        Console.WriteLine("Du bør tage en sceenet, når du er 50 år gammel.");
    }
    
}
