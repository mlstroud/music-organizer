using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public static List<Artist> _instances = new List<Artist>();
    public string Name { get; set; }
    public int Id { get; }
    public List<MusicItem> MusicItems { get; set; }

    public Artist(string name)
    {
      Name = name;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}