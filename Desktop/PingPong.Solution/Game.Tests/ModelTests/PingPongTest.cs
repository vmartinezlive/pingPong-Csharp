using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Game;

namespace Game.Tests
{
  [TestClass]
  public class PingPongTest
  {
    // Test methods go here
    [TestMethod]
    public void PingPong_NumberDisvibleByThree_True()
    {
      PingPongGame testPingPongGame = new PingPongGame();
      Assert.AreEqual(true, testPingPongGame.PingPong(3));
    }
    [TestMethod]
    public void PingPongFive_NumberDisvibleByFive_True()
    {
      PingPongGame testPingPongGame = new PingPongGame();
      Assert.AreEqual(true, testPingPongGame.PingPongFive(5));
    }
    [TestMethod]
    public void PingPongFiveThree_NumberDisvibleByFiveThree_True()
    {
      PingPongGame testPingPongGame = new PingPongGame();
      Assert.AreEqual(true, testPingPongGame.PingPongFiveThree(15));
    }
    [TestMethod]
    public void NumberList_CompareList_True()
    {
      PingPongGame testPingPongGame = new PingPongGame();
      CollectionAssert.AreEqual(new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12, 13, 14, 15}, testPingPongGame.NumberList(15));
    }
  }
}
