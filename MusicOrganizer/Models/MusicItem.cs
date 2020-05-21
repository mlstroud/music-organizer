using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class MusicItem
  {
    public string Title { get; set; }
    public string Format { get; set; }
    public static List<MusicItem> _instances = new List<MusicItem>();
    public int Id { get; }

    public MusicItem(string title, string format)
    {
      Title = title;
      Format = format;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<MusicItem> GetAllItems()
    {
      return _instances;
    }
  }
}