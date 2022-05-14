using NUnit.Framework;
using ServerApp;

namespace ServerAppTests
{
    public class LocalizationFactoryTests
    {
        private ILocalizationFactory? _factory;

        [SetUp]
        public void Setup()
        {
            _factory = new LocalizationFactory();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}