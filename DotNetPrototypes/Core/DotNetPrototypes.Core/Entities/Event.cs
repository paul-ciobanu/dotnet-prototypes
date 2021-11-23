namespace DotNetPrototypes.Core.Entities;

internal class Event
{
    public static readonly Event RandomEvent
        = new Event { Id = Guid.NewGuid(), Name = " random event" };

    public Guid Id { get; set; }
    public string Name { get; set; }
}
