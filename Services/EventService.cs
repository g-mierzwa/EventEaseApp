using System.Collections.Generic;

public class EventService
{
    private readonly List<Event> events = new List<Event>()
    {
        new Event {Name = "Event 1", Date = new System.DateTime(2025, 2, 3), Location = "Location 1"},
        new Event {Name = "Event 2", Date = new System.DateTime(2025, 3, 4), Location = "Location 2"}
    };

    public List<Event> GetEvents()
    {
        return events;
    }

    public void AddEvent(Event newEvent)
    {
        events.Add(newEvent);
    }

    public void AddAttendee(string eventName, Attendee attendee)
    {
        var eventItem = events.FirstOrDefault(e => e.Name == eventName);
        if (eventItem != null)
        {
            eventItem.Attendees.Add(attendee);
        }
    }
}