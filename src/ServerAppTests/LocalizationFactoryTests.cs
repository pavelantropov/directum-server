using System.Globalization;
using Moq;
using NUnit.Framework;
using ServerApp;
using ServerApp.Data;

namespace ServerAppTests
{
    public class LocalizationFactoryTests
    {
        private ILocalizationFactory _factory = null!;
        private Mock<IDataSource> _sourceMock = null!;

        [SetUp]
        public void Setup()
        {
            _factory = new LocalizationFactory();
            _sourceMock = new Mock<IDataSource>();
        }

        [Test]
        public void GetString_CallsGetStringOfDataSource()
        {
            const string code = "test";
            var culture = CultureInfo.InvariantCulture;

            _factory.RegisterSource(_sourceMock.Object);

            _factory.GetString(code, culture);

            _sourceMock.Verify(
                m => m.GetString(code, culture), 
                Times.Once());
        }

        [Test]
        public void GetString_ReturnsExpectedResult()
        {
            const string expected = "TEST";
            const string code = "test";
            var culture = CultureInfo.InvariantCulture;

            _sourceMock.Setup(m => m.GetString(code, culture))
                .Returns(expected);
            _factory.RegisterSource(_sourceMock.Object);

            var result = _factory.GetString(code, culture);

            Assert.AreEqual(expected, result);
        }
    }
}