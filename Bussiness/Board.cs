public class Board
{
    private bool isFull { get; set; }
    public int size = 4;
    public Board()
    {
        this.isFull = false;
    }

    public bool BoardFull(int boardSize)
    {
        Console.WriteLine("Quedan " + boardSize + " jugadas en esta partida");
        Console.WriteLine("Coloque una forma en el tablero");
        if (boardSize == 0)
        {
            isFull = true;
            return isFull;
        }
        else
        {
            return isFull;
        }
    }

    public void ValidateBoardWinner(int winner)
    {
        if (winner > 2)
        {
            Console.WriteLine("\nEmpate");
        }
        else if (winner == 1)
        {
            Console.WriteLine("\nJugador 1 Gana");
        }
        else if (winner == 2)
        {
            Console.WriteLine("\nJugador 2 Gana");
        }
    }

    public void InitBoard(int rows, int columns)
    {
        string[,] boardGame = new string[size, size];
        Console.WriteLine("=============================================");
        Console.WriteLine("=============  Triqui Avanzado  =============");
        Console.WriteLine("=============================================\n");
        for (int rowsFill = 0; rowsFill < boardGame.GetLength(0); rowsFill++)
        {
            for (int columnFill = 0; columnFill < boardGame.GetLength(1); columnFill++)
            {
                Cell cell = new Cell();
                boardGame[rowsFill, columnFill] = cell.piece;
                Console.Write("\t[" + (boardGame[rowsFill, columnFill] = cell.piece) + "]" + " ");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("\n=============================================");
        Console.WriteLine("=============================================\n");
    }

    public void FillCell(int rows, int columns)
    {
        string[,] boardGame = new string[size, size];
        Console.WriteLine("Seleccione en que posición desea colocar la figura");
        do
        {
            try
            {
                Console.WriteLine("Indique la fila que este entre 1 y 4");
                rows = Int32.Parse(Console.ReadLine())-1;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Ingrese valores númericos");
            }
        } while (rows < 0 || rows > 4);
        do
        {
            try
            {
                Console.WriteLine("Indique la columna que este entre 1 y 4");
                columns = Int32.Parse(Console.ReadLine())-1;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Ingrese valores númericos");
            }
        } while (columns < 0 || columns > 4);

        FillBoard(rows, columns);
    }

    public string SelectFigure(int rows, int columns)
    {
        string figure = $"{ShapeFigure(rows, columns)},{SizeFigure(rows, columns)},{ColorFigure(rows, columns)},{EquisFigure(rows, columns)}";
        Console.WriteLine("La figura que selecciono es : " + figure);
        return figure;
    }

    public string ShapeFigure(int rows, int columns)
    {
        string[,] boardGame = new string[size, size];
        int shapeOption = 0;
        string shape = "";
        Cell cell = new Cell();
        do
        {
            try
            {
                Console.WriteLine("Seleccione la forma de la figura que va colocar en el tablero");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Circulo");
                Console.WriteLine("3. Triangulo");
                shapeOption = Int32.Parse(Console.ReadLine());
                if ((shapeOption < 1) || (shapeOption > 3))
                {
                    Console.WriteLine("Error selección fuera de rango");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Ingrese valores númericos");
            }
        } while ((shapeOption < 1) || (shapeOption > 3));
        switch (shapeOption)
        {
            case 1:
                shape = "Q";
                break;
            case 2:
                shape = "C";
                break;
            case 3:
                shape = "T";
                break;
            default:
                shape = "Error en la selección de la figura";
                break;
        }
        return shape;
    }

    public string SizeFigure(int rows, int columns)
    {
        string[,] boardGame = new string[size, size];
        int shapeOption = 0;
        string shape = "";
        do
        {
            try
            {
                Console.WriteLine("Seleccione el tamaño de la figura que va colocar en el tablero");
                Console.WriteLine("1. Grande");
                Console.WriteLine("2. Mediano");
                Console.WriteLine("3. Pequeño");
                shapeOption = Int32.Parse(Console.ReadLine());
                if ((shapeOption < 1) || (shapeOption > 3))
                {
                    Console.WriteLine("Error selección fuera de rango");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Ingrese valores númericos");
            }
        } while ((shapeOption < 1) || (shapeOption > 3));
        switch (shapeOption)
        {
            case 1:
                shape = "B";
                break;
            case 2:
                shape = "M";
                break;
            case 3:
                shape = "S";
                break;
            default:
                shape = "Error en la selección de la figura";
                break;
        }
        return shape;
    }

    public string ColorFigure(int rows, int columns)
    {
        string[,] boardGame = new string[size, size];
        Cell cell = new Cell();
        int shapeOption = 0;
        string shape = "";
        do
        {
            try
            {
                Console.WriteLine("Seleccione el color de la figura que va colocar en el tablero");
                Console.WriteLine("1. Amarillo");
                Console.WriteLine("2. Verde");
                Console.WriteLine("3. Rojo");
                shapeOption = Int32.Parse(Console.ReadLine());
                if ((shapeOption < 1) || (shapeOption > 3))
                {
                    Console.WriteLine("Error selección fuera de rango");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Ingrese valores númericos");
            }
        } while ((shapeOption < 1) || (shapeOption > 3));
        switch (shapeOption)
        {
            case 1:
                shape = "Y";
                break;
            case 2:
                shape = "G";
                break;
            case 3:
                shape = "R";
                break;
            default:
                shape = "Error en la selección de la figura";
                break;
        }
        return shape;
    }

    public string EquisFigure(int rows, int columns)
    {
        string[,] boardGame = new string[size, size];
        Cell cell = new Cell();
        int shapeOption = 0;
        string shape = "";
        do
        {
            try
            {
                Console.WriteLine("Seleccione si la figura tiene o no tiene X que va colocar en el tablero");
                Console.WriteLine("1. Equis");
                Console.WriteLine("2. No Equis");
                shapeOption = Int32.Parse(Console.ReadLine());
                if ((shapeOption < 1) || (shapeOption > 2))
                {
                    Console.WriteLine("Error selección fuera de rango");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Ingrese valores númericos");
            }
        } while ((shapeOption < 1) || (shapeOption > 2));
        switch (shapeOption)
        {
            case 1:
                shape = "H";
                break;
            case 2:
                shape = "N";
                break;
            default:
                shape = "Error en la selección de la figura";
                break;
        }
        return shape;
    }

    public void FillBoard(int rows, int columns)
    {
        string[,] boardGame = new string[size, size];
        string nameFigure = "";
        nameFigure = SelectFigure(rows,columns);
        Console.WriteLine("=======================================================================");
        Console.WriteLine("=====================         Triqui Avanzado      ====================");
        Console.WriteLine("=======================================================================\n");
        for (int rowsFill = 0; rowsFill < boardGame.GetLength(0); rowsFill++)
        {
            for (int columnFill = 0; columnFill < boardGame.GetLength(1); columnFill++)
            {
                if(rows == rowsFill && columns == columnFill){
                    Console.Write("\t[" + (boardGame[rowsFill, columnFill] = nameFigure) + "]" + " ");
                }else{
                Cell cell = new Cell();
                Console.Write("\t[" + (boardGame[rowsFill, columnFill] = cell.piece) + "]" + " ");
                }
            }
            Console.WriteLine("");
        }
        Console.WriteLine("=======================================================================");
        Console.WriteLine("=======================================================================\n");
    }

}
