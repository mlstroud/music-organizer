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
      MusicItems = new List<MusicItem>();
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Artist> GetAllArtists()
    {
      return _instances;
    }

    public static Artist Find(int id)
    {
      return _instances[id - 1];
    }

    public static Artist Find(string name)
    {
      foreach (Artist artist in _instances)
      {
        if (artist.Name == name)
        {
          return artist;
        }
      }

      return null;
    }

    public void AddAlbum(MusicItem album)
    {
      MusicItems.Add(album);
    }
  }
}