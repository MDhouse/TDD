﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddShop.Cli.Order.Models;
using TddShop.Cli.Order.Repositories;

namespace TddShop.Cli.Order
{
    public class DiscountCalculator
    {
        private readonly IStockRepository _stockRepository;
        private const string BeerCategory = "Beer";

        public DiscountCalculator(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        /// <summary>
        /// Possible rules:
        ///     * Total order value > $500 : 10%
        ///     * Items from 'Beer' category are discounted: EUR 2 (don't allow negative price)
        ///     * Items which are leftovers (only one item in stock left): 
        ///         50% to items worth more than EUR 100, 75% to items worth more than EUR 200
        ///     * Discounts placed in December: 30%
        /// 
        /// Only one discount can be applied - it should be the one which is the best for customer
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public decimal GetDiscount(OrderModel order, DateTime orderPlacedOn)
        {
            throw new NotImplementedException();
        }
    }
}
