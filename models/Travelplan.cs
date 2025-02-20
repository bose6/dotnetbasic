namespace lotus.models;

public class Travelplan
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int Noofdays { get; set; }
    public bool Status { get; set; }
    public ICollection<Destination> Destinations { get; set; } = new List<Destination>();

}