using Aksetensions;
using NUnit.Framework;
using Shouldly;
using System;

namespace Test.Aksetensions
{
    [TestFixture]
    public class ParameterCheckExtensionsTests
    {

        [Test]
        public void CheckNotNullTest_Success()
        {
            var variable = new object();
            variable.CheckNotNull().ShouldBe(variable);
        }

        [Test]
        public void CheckNotNullTest_FailNameGiven()
        {
            object variable = null;
            Should.Throw<ArgumentNullException>(() => variable.CheckNotNull(nameof(variable)))
                .ParamName.ShouldBe(nameof(variable));
        }

        [Test]
        public void CheckNotNullTest_FailNameNotGiven()
        {
            object variable = null;
            Should.Throw<ArgumentNullException>(() => variable.CheckNotNull())
                .ParamName.ShouldBe("source");
        }
    }
}
