using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string Name { get; set; }
    public int Id { get; }
    public List<MusicItem> MusicItems { get; set; }

    public Artist(string name)
    {

    }
  }
}