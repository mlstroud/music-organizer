using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("test");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsArtistName_String()
    {
      string name = "Dream Theater";
      Artist newArtist = new Artist(name);

      string result = newArtist.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsArtistId_Int()
    {
      Artist newArtist = new Artist("test");
      int id = 1;

      int result = newArtist.Id;

      Assert.AreEqual(id, result);
    }

    [TestMethod]
    public void GetAllArtists_ReturnsAllArtists_ArtistList()
    {
      Artist newArtist = new Artist("test");
      Artist newArtist2 = new Artist("test2");
      List<Artist> newList = new List<Artist> { newArtist, newArtist2 };

      List<Artist> result = Artist.GetAllArtists();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}