﻿

using System;
using System.Collections.Generic;

namespace BlazingPizza
{
    /// <summary>
    /// Represents a customized pizza as part of an order
    /// </summary>
    public class Pizza
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public PizzaSpecial Special { get; set; }

        public int SpecialId { get; set; }

        public PizzaSize Size { get; set; }

        public List<PizzaTopping> Toppings { get; set; }

        public decimal GetPriceForSize(PizzaSize size)
        {
            switch (size)
            {
                case PizzaSize.Small:
                    return Special.BasePrice * .75m;

                case PizzaSize.Medium:
                    return Special.BasePrice * 1.00m;

                case PizzaSize.Large:
                    return Special.BasePrice * 1.25m;

                default:
                    throw new InvalidOperationException();
            }
        }

        public static int GetSizeInInches(PizzaSize size)
        {
            switch (size)
            {
                case PizzaSize.Small:
                    return 9;

                case PizzaSize.Medium:
                    return 12;

                case PizzaSize.Large:
                    return 17;

                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
