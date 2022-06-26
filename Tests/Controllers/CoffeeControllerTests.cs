
using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;
using FluentAssertions;
namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        [Test]
        public void Test_Get_Coffee_lover() {
            string expectedCoffee = "I like coffee!";
            var coffeeController = new CoffeeController();
            var actualResult = coffeeController.GetCoffeeLover();
            Assert.AreEqual(expectedCoffee, actualResult);
        }
        [Test]
        public void Test_Get_Coffee_No_Param() {
            Coffee expectedCoffee = new Coffee
            {
                Name = "latte",
                Id = -1
            };
            var coffeeController = new CoffeeController();
            var result = coffeeController.Get(null);
       
            expectedCoffee.Name.Should().Be(result.Name);
            expectedCoffee.Id.Should().Be(result.Id);
        }
        [Test]
        public void Test_Get_Coffee_By_Name() {
            Coffee expectedCoffee = new Coffee
            {
                Name = "cappacino",
                Id = 7
            };
            var coffeeController = new CoffeeController();
            var result = coffeeController.Get("cappacino");
            expectedCoffee.Name.Should().Be(result.Name);
            expectedCoffee.Id.Should().Be(result.Id);
        }

    }
}
