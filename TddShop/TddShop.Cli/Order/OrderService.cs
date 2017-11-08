﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddShop.Cli.Order.Models;
using TddShop.Cli.Order.Repositories;

namespace TddShop.Cli.Order
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IStockRepository _stockRepository;

        public OrderService(IOrderRepository orderRepository, IStockRepository stockRepository)
        {
            _orderRepository = orderRepository;
            _stockRepository = stockRepository;
        }

        /// <summary>
        /// Should update stock and save order via repository
        /// </summary>
        /// <param name="order"></param>
        public void PlaceOrder(OrderModel order)
        {



            throw new NotImplementedException();
        }
    }
}
