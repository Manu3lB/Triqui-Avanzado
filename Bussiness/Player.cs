public class Player
{
    public string name { get; set; }
    private string namePlayer = "";

    public Player()
    {
        this.name = "";
    }

    public string NamePlayer(int numberPlayer)
    {
            Console.WriteLine("Ingrese el nombre del jugador : " + numberPlayer);
            string namePlayer = Console.ReadLine();
            return namePlayer;
    }
    
}