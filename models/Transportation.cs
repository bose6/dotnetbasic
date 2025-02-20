namespace lotus.models;

public class Transportation
{
    public int Id { get; set; }
    public string Methode { get; set; }
    
    public ICollection<Destination> Destinations { get; set; } = (ICollection<Destination>)new List<Destination>();

}