public class Game
{
    private string id { get; set; }
    private string Player1 { get; set; }
    private string Player2 { get; set; }
    private string board { get; set; }
    private bool isOver { get; set; }
    private int turn = 1;
    private int numberPlayer = 1;
    private int boardSize = 15;
    private int winner = 3;

    private int rows = 0;

    private int columns = 0;

    public Game()
    {
        this.id = "";
        this.Player1 = "";
        this.Player2 = "";
        this.board = "";
        this.isOver = false;
    }

    public void BeginGame()
    {
        bool finishGame = false;
        ValidateCallPlayer();
        PrintBeginGame();
        Board init = new Board();
        // init.InitBoard();
        while (finishGame == false)
        {
            TurnPlayer();
            init.FillCell(rows,columns);
            finishGame = CallBoard();
        }
        WinnerPlayer();
    }

    public int TurnPlayer()
    {
        if (boardSize < 1)
        {
            turn = 0;
            return 0;
        }
        else
        {
            if (turn == 1)
            {
                Console.WriteLine("\n=========================================");
                Console.WriteLine("=====  Es el turno del jugador : " + Player1);
                Console.WriteLine("=========================================");
                turn--;
                return turn;
            }
            else
            {
                Console.WriteLine("\n=========================================");
                Console.WriteLine("=====  Es el turno del jugador : " + Player2);
                Console.WriteLine("=========================================");
                turn++;
                return turn;
            }
        }

    }

    public void PrintBeginGame()
    {
        Console.WriteLine("\n==============================================");
        Console.WriteLine("===  Triqui Avanzado esta siendo ejecutado   ===");
        Console.WriteLine("================================================\n");
    }
    public void WinnerPlayer()
    {
        Board board = new Board();
        board.ValidateBoardWinner(winner);
    }

    public string NamePlayersTurns()
    {
        if (TurnPlayer() == 1)
        {
            return this.Player1;
        }
        else
        {
            return this.Player1;
        }
    }

    public void ValidateCallPlayer()
    {
        do
        {
            CallPlayer();
            numberPlayer++;
        } while (numberPlayer == 2);
    }
    public string CallPlayer()
    {
        Player player = new Player();
        if (numberPlayer == 1)
        {
            Player1 = player.NamePlayer(numberPlayer);
            return Player1;
        }
        else
        {
            Player2 = player.NamePlayer(numberPlayer);
            return Player2;
        }
    }
    public bool CallBoard()
    {
        if (boardSize < 1)
        {
            Console.WriteLine("\n=========================================");
            Console.Write("============  Fin del juego  ============");
            Console.WriteLine("\n=========================================");
            isOver = true;
            return isOver;
        }
        Board board = new Board();
        isOver = board.BoardFull(boardSize);
        boardSize--;
        return isOver;
    }
}