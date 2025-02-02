using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Event
{
    [Required(ErrorMessage = "Event name is required")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Event date is required")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Event location is required")]
    public string? Location { get; set; }

    public List<Attendee> Attendees { get; set; } = new List<Attendee>();
}

public class Attendee
{
    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string? Email { get; set; }
}