
using SampleProjectAzure.Services;
using Xunit;

namespace SampleProjectAzure.Tests.Services
{
    public class StockServicesTests
    {

        [Fact]
        public void GivenStockId_WhenStockInformationCalled_ThenReturnInformationForThatStockId()
        {
            var stockService = new StockService();

            var actual = stockService.StockInformation("Apple");

            Assert.Equal("Some dummy information for stock Apple", actual) ;
        }

    }
}
