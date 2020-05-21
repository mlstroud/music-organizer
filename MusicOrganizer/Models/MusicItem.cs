namespace MusicOrganizer.Models
{
  public class MusicItem
  {
    public string Title { get; set; }

    public MusicItem(string title)
    {
      Title = title;
    }
  }
}