using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaSite.DTO;

namespace PizzaSite.Domain
{
    public class PizzaPriceManager
    {
        public static decimal CalculateCost(DTO.OrderDTO order)
        {
            decimal cost = 0.0M;
            var prices = getPizzaPrices();

            cost += calculateSizeCost(order, prices);
            cost += calculateCrustCost(order, prices);
            cost += calculeteToppings(order, prices);

            return cost;
        }

        private static decimal calculeteToppings(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            cost += (order.Sausage) ? prices.SausageCost : 0M;
            cost += (order.Pepperoni) ? prices.PepperoniCost : 0M;
            cost += (order.Onion) ? prices.OnionsCost : 0M;
            cost += (order.GreenPeppers) ? prices.GreenPeppersCost : 0M;
            return cost;

        }

        private static decimal calculateCrustCost(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            switch (order.Crust)
            {
                case PizzaSite.DTO.Enums.CrustType.Thin:
                    cost = prices.ThinCrustCost;
                    break;
                case PizzaSite.DTO.Enums.CrustType.Regular:
                    cost = prices.RegularCrustCost;
                    break;
                case PizzaSite.DTO.Enums.CrustType.Thick:
                    cost = prices.ThickCrustCost;
                    break;
                default:
                    break;
            }
            return cost;
        }

        private static decimal calculateSizeCost(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            switch (order.Size)
            {
                case PizzaSite.DTO.Enums.SizeType.Small:
                    cost = prices.SmallSizeCost;
                    break;
                case PizzaSite.DTO.Enums.SizeType.Medium:
                    cost = prices.MediumSizeCost;
                    break;
                case PizzaSite.DTO.Enums.SizeType.Large:
                    cost = prices.LargeSizeCost;
                    break;
                default:
                    break;
            }
            return cost;
        }

        private static DTO.PizzaPriceDTO getPizzaPrices()
        {
            var prices = Persistance.PizzaPriceRepository.GetPizzaPrices();
            return prices;


        }
    
    }
}
