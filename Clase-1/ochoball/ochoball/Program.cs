
using ochoball;

bool flag= true;

while (flag)
{
    var game = new Game();
    Console.WriteLine("ingresa una pregunta");
    String pregunta = Console.ReadLine();
    try
    {
        string juego = game.Play(pregunta);
        Console.WriteLine(juego);
    }
    catch (QuestionInvalidExeption)
    {
        Console.WriteLine("pregunta invalida");
    }
    Console.WriteLine("¿desea salir? escriba salir si desea seguir jugando ingrese cualquier cosa");
    String rta = Console.ReadLine();
    if (rta.Contains("salir"))
    {
        flag = false;
    }
}