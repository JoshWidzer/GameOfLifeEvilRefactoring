using System.Reflection.Emit;
using ApprovalTests;
using ApprovalTests.Reporters;
using GameOfLifeEvilRefactoring;
using NUnit.Framework;

namespace NUnitTestProject1
{
    [UseReporter(typeof(DiffReporter))]

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMobTest()
        {

            var got = Program.run(new string[]{});
            Approvals.Verify(got);
        }
    }
}