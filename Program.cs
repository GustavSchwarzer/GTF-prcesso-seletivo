using AulasDio;


Arus Arus = new Arus("Arus", 42, "Knight", 469, 72);
Wedge Wedge = new Wedge("Wedge",42,"Ninja",292, 89 );
Jennica Jennica = new Jennica("Jennica", 42, "White Wizard", 325, 474);
Topapa Topapa = new Topapa("Topapa", 42, "Black Wizard", 106, 611);


Console.WriteLine( "Estes são os guerreiros! PREPARE-SE!");

Console.WriteLine(Arus);
Console.WriteLine(Wedge);
Console.WriteLine(Jennica);
Console.WriteLine(Topapa);
Console.WriteLine("Esta preparado? y ou n");

string read = Console.ReadLine();
if (read == "y")
{
    Console.WriteLine("STARTING GAME NOW! (to continue click 'ENTER')");
    Console.ReadLine();
    Console.WriteLine(Arus.Atack());
    Console.ReadLine();
    Console.WriteLine(Jennica.Atack());
    Console.ReadLine();
    Console.WriteLine(Topapa.Atack());
    Console.ReadLine();
    Console.WriteLine(Wedge.Atack());
    Console.ReadLine();
    Console.WriteLine("Fim da Batalha!");
}
else { Console.WriteLine("Try again"); }


