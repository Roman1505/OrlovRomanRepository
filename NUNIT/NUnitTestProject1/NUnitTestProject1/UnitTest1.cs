using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {

        [Test, TestCaseSource("AddCases")]

        public void AddTest(int op1, int op2, int res)
        {
            Assert.AreEqual(res, Calc.Add(op1, op2));
        }


        [Test, TestCaseSource("SubtractionCases")]

        public void SubtractionTest(int op1, int op2, int res)
        {
            Assert.AreEqual(res, Calc.Subtraction(op1, op2));
        }


        [Test, TestCaseSource("MultiplyCases")]

        public void MultiplyTest(int op1, int op2, int res)
        {
            Assert.AreEqual(res, Calc.Multiply(op1, op2));
        }

        [Test, TestCaseSource("PartitionCases")]

        public void PartitionTest(int op1, int op2, int res)
        {
            Assert.AreEqual(res, Calc.Partition(op1, op2));
        }

        static object[] AddCases =
        {
            new object[] {1,2,3},
            new object[] {2,2,4},
            new object[] {3,4,7}
        };

        static object[] SubtractionCases =
               {
            new object[] {3,2,1},
            new object[] {4,2,2},
            new object[] {7,4,3}
        };

        static object[] MultiplyCases =
       {
            new object[] {1,2,2},
            new object[] {2,2,4},
            new object[] {3,3,9}
        };

        static object[] PartitionCases =
       {
            new object[] {4,2,2},
            new object[] {6,2,3},
            new object[] {8,4,2}
        };
    }
}
