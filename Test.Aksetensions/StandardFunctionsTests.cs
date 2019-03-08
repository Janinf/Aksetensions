using Aksetensions;
using NUnit.Framework;
using Shouldly;
using System;

namespace Test.Aksetensions
{
    [TestFixture]
    public class StandardFunctionsTests
    {
        private object _parameter;

        [Test]
        public void MapTest_SourceNull()
        {
            _parameter = null;
            Should.Throw<ArgumentNullException>(() => _parameter.Map(p => p.ToString()))
                .ParamName.ShouldBe("source");
        }

        [Test]
        public void MapTest_FunctionNull()
        {
            _parameter = new object();
            Should.Throw<ArgumentNullException>(() => _parameter.Map<object, string>(null))
                .ParamName.ShouldBe("function");
        }
    }
}
