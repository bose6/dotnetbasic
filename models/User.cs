﻿namespace lotus.models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Code { get; set; }
    public string PhoneNumber { get; set; }
    public string Role { get; set; }
    
    public ICollection<Travelplan> Travels { get; set; } = (ICollection<Travelplan>)new List<Travelplan>();

}