namespace LocalQuest.Core;

public class Experience
{
    public Guid Id { get; }
    public string Title { get; }
    public string Organizer { get; }

    public Experience(string title, string organizer)
    {
        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(organizer))
        {
            throw new ArgumentException("Title or Organizer name is required");
        }

        Id = Guid.NewGuid();
        Title = title;
        Organizer = organizer;
    }
}
