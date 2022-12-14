using WebAppDETAug2022.Models;
using WebAppDETAug2022.Service;

namespace MyFirstUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetAllPizzas()
        {
            int expected = 2;
            int actual = PizzaService.GetAll().Count;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test_AddPizzas()
        {

            Pizza p = new Pizza { Name = "xxx", Size = PizzaSize.Small, IsGlutenFree = true };

            PizzaService.Add(p);
            Pizza verify = PizzaService.Get(2);

            Assert.Equal(3, PizzaService.GetAll().Count);
            Assert.NotNull(verify.Id);

        }
    }
}