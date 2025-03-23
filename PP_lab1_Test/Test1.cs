using PP_lab1;
namespace PP_lab1_Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AtLeastOneItemSelected()
        {
            Problem problem = new Problem(5, 1);
            int capacity = 10;

            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.SelectedItems.Length > 0);
        }

        [TestMethod]
        public void NoItemSelected()
        {
            Problem problem = new Problem(10, 1);
            int capacity = 0;

            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.SelectedItems.Length == 0);
        }

        [TestMethod]
        public void CorrectSolutionForInstance()
        {
            Problem problem = new Problem(10, 1);
            int capacity = 10;

            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.SelectedItems.Length == 3);
            Assert.IsTrue(result.SelectedItems[0] == 1);
            Assert.IsTrue(result.SelectedItems[1] == 3);
            Assert.IsTrue(result.SelectedItems[2] == 6);
            Assert.IsTrue(result.TotalValue == 11);
            Assert.IsTrue(result.TotalWeight == 10);
        }

        [TestMethod]
        public void AllItemsFit()
        {
            Problem problem = new Problem(3, 1);
            int capacity = 100;

            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.SelectedItems.Length == 3);
            Assert.IsTrue(result.TotalValue == 15);
            Assert.IsTrue(result.TotalWeight == 15);
            Assert.AreEqual(15, result.TotalWeight);
        }

        [TestMethod]
        public void OnlyOneHighestRatioItemSelected()
        {
            Problem problem = new Problem(3, 1);
            int capacity = 2;

            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.SelectedItems.Length == 1);
            Assert.IsTrue(result.TotalValue == 3);
            Assert.IsTrue(result.TotalWeight == 2);
        }
    }
}
