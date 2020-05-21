using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class MusicItemTests
  {
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
  }
}