public class Cell
{
    public string row = "";
    public string column = "";
    public string position = "";
    private bool isEmpty { get; set; }
    public string piece = "-,-,-,-";

    public Cell()
    {
        this.row = "";
        this.column = "";
        this.position = $"{row},{column}";
        this.isEmpty = false;
        this.piece = piece;
    }
}