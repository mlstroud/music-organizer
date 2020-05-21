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
      MusicItem newMusicItem = new MusicItem();
      Assert.AreEqual(newMusicItem.GetType(), typeof(MusicItem));
    }
  }
}