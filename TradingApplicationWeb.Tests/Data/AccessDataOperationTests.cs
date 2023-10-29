using Microsoft.EntityFrameworkCore;
using TradingApplicationWeb.Data;
using TradingApplicationWeb.Interfaces;

namespace TradingApplicationWeb.Tests.Data
{
    public class AccessDataOperationTests
    {
        private readonly IFixture _fixture;
        private readonly Mock<ApplicationDbContext> _dbContext;
        private readonly Mock<DbContextOptions<ApplicationDbContext>> _dbOption;
        private readonly ApplicationDbContext _applicationDBContext;
        private readonly AccessDataOperation _accessDataOperation;
        public AccessDataOperationTests()
        {
            _fixture = new Fixture();
            _dbOption = _fixture.Freeze<Mock<DbContextOptions<ApplicationDbContext>>>();
            _dbContext = _fixture.Freeze<Mock<ApplicationDbContext>>();

            _applicationDBContext = new ApplicationDbContext(_dbOption.Object);
            _accessDataOperation = new AccessDataOperation(_applicationDBContext);
        }

        [Fact]
        public void GetAllFinancialProducts_GetList_whenDataExist()
        {
            //Arrange
            var financialProducts = _accessDataOperation.GetAllFinancialProducts();

            //Act

            //Assert

        }
    }
}
