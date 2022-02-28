public class Piece
{
    private string shape { get; set; }
    private string size { get; set; }
    private string color { get; set; }
    private string equis { get; set; }
    private string properties { get; set; }

    public Piece()
    {
        this.shape = "";
        this.size = "";
        this.color = "";
        this.equis = "";
        this.properties = $"{this.shape},{this.size},{this.color},{this.equis}";
    }
}