
using SampleProjectAzure.Services;
using Xunit;

namespace SampleProjectAzure.Tests.Services
{
    public class StockServicesTests
    {

        [Fact]
        public void GivenStockId_WhenStockInformationCalled_ThenReturnInformationForThatStockId()
        {
            var expected = "Apple";
            var stockService = new StockService();

            var actual = stockService.StockInformation(expected);

            Assert.Equal(expected, actual);
        }

    }
}
