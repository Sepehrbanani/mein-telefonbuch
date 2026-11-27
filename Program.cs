using System;
using System.IO;

Console.Write("Name suchen: ");
string suchname = Console.ReadLine() ?? "";

string[] kontakte = File.ReadAllLines("kontakte.txt");

bool gefunden = false;

foreach (string kontakt in kontakte)
{
    if (kontakt.Contains(suchname, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine(kontakt);
        gefunden = true;
    }
}

if (!gefunden)
{
    Console.WriteLine("Kein Kontakt gefunden.");
}
