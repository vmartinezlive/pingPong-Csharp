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
      Assert.AreEqual(true, testPingPongGame.PingPong(4));
    }

  }
}
