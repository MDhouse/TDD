using NUnit.Framework;
using Moq;
using TddShop.Cli.Order;
using TddShop.Cli.Order.Models;
using TddShop.Cli.Order.Repositories;

namespace TddShop.Cli.Tests.Order
{
    [TestFixture]
    public class OrderServiceTests
    {
        private OrderService _target;
        private Mock<IStockRepository> _stockRepository;
        private Mock<IOrderRepository> _orderRepository;
        

        [SetUp]
        public void Initilize()
        {
            _stockRepository = new Mock<IStockRepository>();
            _orderRepository = new Mock<IOrderRepository>();
            _target = new OrderService(_orderRepository.Object, _stockRepository.Object);
        }

        [Test]
        public void OrderService_IncrementItemInStock_IsWork()
        {
            //Arrange
            var item = "Milk";
            var quantity = 5;
            var order = new OrderModel {
                Items = new ItemModel[]
                {
                    new ItemModel
                    {
                        Name = item,
                        Quantity = quantity
                    }
                }
            };

            _stockRepository.Setup(x => x.GetAvailableItemsByName(item)).Returns(quantity);

            //Act
             _target.PlaceOrder(order);

            // Assert
            _stockRepository.Verify(x => x.DecreaseItemsInStock(item, quantity), Times.AtLeastOnce());
            
        }

    }
}
