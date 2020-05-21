namespace MusicOrganizer.Models
{
  public class MusicItem
  {
    public string Title { get; set; }
    public string Format { get; set; }

    public MusicItem(string title, string format)
    {
      Title = title;
      Format = format;
    }
  }
}