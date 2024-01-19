using NUnit.Framework;
using NUnit.Framework.Legacy;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConAppPizzaNunit.PizzaManagementTests;

namespace ConAppPizzaNunit
{
    [TestFixture]
    public class PizzaManagementTests
    {
        [Test]
        public void AddPizza_ShouldAddPizzaToList()
        {
            // Arrange
            PizzaManagement pizzaManagement = new PizzaManagement();
            PizzaNu pizza = new PizzaNu("Margherita", 12, 10.99m);

            // Act
            pizzaManagement.AddPizza(pizza);
            var result = pizzaManagement.GetPizzas();

            // Assert
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Has.Exactly(1).EqualTo(pizza).Using(PizzaEqualityComparer.Instance));
        }



        public class PizzaEqualityComparer : IEqualityComparer<PizzaNu>
        {
            public static readonly PizzaEqualityComparer Instance = new PizzaEqualityComparer();

            public bool Equals(PizzaNu x, PizzaNu y)
            {
                return x != null && y != null &&
                       x.Name == y.Name &&
                       x.Size == y.Size &&
                       x.Price == y.Price;
            }

            public int GetHashCode(PizzaNu obj)
            {
                throw new NotImplementedException();
            }
        }
    }
}





