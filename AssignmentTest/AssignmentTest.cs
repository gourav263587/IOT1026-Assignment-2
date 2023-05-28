using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void OpenLockedChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            chest.Manipulate(TreasureChest.Action.Open);
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());
        }

        [TestMethod]
        public void OpenClosedChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Manipulate(TreasureChest.Action.Open);
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());
        }

        [TestMethod]
        public void OpenOpenChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Manipulate(TreasureChest.Action.Open);
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());
        }

        [TestMethod]
        public void CloseOpenChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Manipulate(TreasureChest.Action.Close);
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }

        [TestMethod]
        public void CloseClosedChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Manipulate(TreasureChest.Action.Close);
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }

        [TestMethod]
        public void CloseLockedChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            chest.Manipulate(TreasureChest.Action.Close);
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());
        }

        [TestMethod]
        public void LockClosedChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Manipulate(TreasureChest.Action.Lock);
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());
        }

        [TestMethod]
        public void LockLockedChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            chest.Manipulate(TreasureChest.Action.Lock);
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());
        }

        [TestMethod]
        public void LockOpenChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Manipulate(TreasureChest.Action.Lock);
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());
        }

        [TestMethod]
        public void UnlockClosedChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Manipulate(TreasureChest.Action.Unlock);
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }

        [TestMethod]
        public void UnlockLockedChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            chest.Manipulate(TreasureChest.Action.Unlock);
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }

        [TestMethod]
        public void UnlockOpenChestTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Manipulate(TreasureChest.Action.Unlock);
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());
        }
    }
}
