using UnitTesting;

namespace StudentGradesnUnitTest
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; } = null!;
        
        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        //[Test]
        [TestCase(91)]
        [TestCase(95)]
        [TestCase(100)]
        [TestCase(99)]
        [TestCase(90)]
        public void GetGradeByPercentage_EqualTest(int percentage)
        {
            //var percentage = 99;

            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            
            Assert.AreEqual("O",grade);
        }

        [TestCase(9)]
        [TestCase(59)]
        [TestCase(80)]
        [TestCase(64)]
        [TestCase(83)]
        public void GetGradeByPercentage_NotEqualTest(int percentage)
        {
            //var percentage = 99;
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            Assert.AreNotEqual("O", grade);
        }
    }
}