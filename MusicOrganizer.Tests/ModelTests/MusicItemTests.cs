using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class MusicItemTests : IDisposable
  {
    public void Dispose()
    {
      MusicItem.ClearAll();
    }

    [TestMethod]
    public void MusicItemConstructor_CreatesInstanceofMusicItem_MusicItem()
    {
      MusicItem newMusicItem = new MusicItem("test", "test");
      Assert.AreEqual(newMusicItem.GetType(), typeof(MusicItem));
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Octavarium";
      MusicItem newMusicItem = new MusicItem(title, "test");

      string result = newMusicItem.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetFormat_ReturnsMusicFormat_String()
    {
      string format = "Vinyl";
      MusicItem newMusicItem = new MusicItem("test", format);

      string result = newMusicItem.Format;

      Assert.AreEqual(format, result);
    }

    [TestMethod]
    public void GetAllItems_ReturnsAllMusicItems_ListMusicItem()
    {
      MusicItem newMusicItem = new MusicItem("test", "test");
      MusicItem newMusicItem2 = new MusicItem("test2", "test2");
      List<MusicItem> newMusicList = new List<MusicItem> { newMusicItem, newMusicItem2 };

      List<MusicItem> result = MusicItem.GetAllItems();

      CollectionAssert.AreEqual(newMusicList, result);
    }
  }
}