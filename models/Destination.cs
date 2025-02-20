namespace lotus.models;

public class Destination
{
    public int Id { get; set; }
    public int TravelId { get; set; }
    public Travelplan Travel { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Place { get; set; }
    public int TransportationId { get; set; }
    public Transportation Transportation { get; set; }
}