using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;
using TradingApplicationWeb.Data;
using TradingApplicationWeb.Interfaces;

namespace TestProject
{
    public class UnitTest1 : DbContext
    {
        [Fact]
        public void Test1()
        {
            AccessDataOperation accessDataOperation = new AccessDataOperation(
                new ApplicationDbContext(
                    new DbContextOptions<ApplicationDbContext>()));
            var fp = accessDataOperation.GetAllFinancialProducts();

            string a = "a";
            a.Should().Be("a");
        }
    }
}