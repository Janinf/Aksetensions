using Aksetensions;
using NUnit.Framework;
using Shouldly;

namespace Test.Aksetensions
{
    [TestFixture]
    public class ParameterPredicateExtensions
    {
        [Test]
        public void IsNullTest_True()
        {
            object variable = null;
            variable.IsNull().ShouldBeTrue();
        }

        [Test]
        public void IsNullTest_False()
        {
            object variable = new object();
            variable.IsNull().ShouldBeFalse();
        }

        [Test]
        public void IsNotNullTest_True()
        {
            object variable = new object();
            variable.IsNotNull().ShouldBeTrue();
        }

        [Test]
        public void IsNotNullTest_False()
        {
            object variable = null;
            variable.IsNotNull().ShouldBeFalse();
        }
    }
}
