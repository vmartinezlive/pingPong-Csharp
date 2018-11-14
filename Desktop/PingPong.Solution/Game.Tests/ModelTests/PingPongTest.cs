using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public void PingPongFive_NumberDisvibleByFive_true()
    {
      PingPongGame testPingPongGame = new PingPongGame();
      Assert.AreEqual(true, testPingPongGame.PingPongFive(5));
    }
    [TestMethod]
    public void PingPongFiveThree_NumberDisvibleByFiveThree_true()
    {
      PingPongGame testPingPongGame = new PingPongGame();
      Assert.AreEqual(true, testPingPongGame.PingPongFiveThree(15));
    }

  }
}
