using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
  public class ArtistsController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> artists = Artist.GetAllArtists();
      return View(artists);
    }

    [HttpPost("/artists")]
    public ActionResult Create(string name)
    {
      Artist artist = new Artist(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/artists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/artists/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist artist = Artist.Find(id);
      List<MusicItem> albums = artist.MusicItems;
      model.Add("artist", artist);
      model.Add("albums", albums);
      return View(model);
    }

    [HttpPost("/artists/{artistId}/albums")]
    public ActionResult Create(int artistId, string title)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist artist = Artist.Find(artistId);
      MusicItem album = new MusicItem(title, "CD");
      artist.AddAlbum(album);
      List<MusicItem> albums = artist.MusicItems;
      model.Add("albums", albums);
      model.Add("artist", artist);
      return View("Show", model);
    }
  }
}