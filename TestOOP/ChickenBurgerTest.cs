using OOP2024;

namespace TestOOP
{
    [TestClass]
    public class ChickenBurgerTest
    {
        ChickenBurger cb = new ChickenBurger();
        [TestMethod]
        public void TestChicken()
        {
            String expected = "Chicken";
            Assert.AreNotEqual(expected, cb.getPatty());

        }
    }
}