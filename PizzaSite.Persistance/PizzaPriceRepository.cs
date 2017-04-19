﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSite.Persistance
{
    public class PizzaPriceRepository
    {
        public static DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var db = new PizzaSiteDbEntities();
            var prices = db.PizzaPrices.First();
            var dto = convertToDTO(prices);
            return dto; 
        }

        private static DTO.PizzaPriceDTO convertToDTO(PizzaPrice pizzaPrice)
        {
            var dto = new DTO.PizzaPriceDTO();

            dto.SmallSizeCost = pizzaPrice.SmallSizeCost;
            dto.MediumSizeCost = pizzaPrice.MediumSizeCost;
            dto.LargeSizeCost = pizzaPrice.LargeSizeCost;
            dto.ThinCrustCost = pizzaPrice.ThinCrustCost;
            dto.RegularCrustCost = pizzaPrice.RegularCrustCost;
            dto.ThickCrustCost = pizzaPrice.ThickCrustCost;
            dto.SausageCost = pizzaPrice.SausageCost;
            dto.PepperoniCost = pizzaPrice.PepperoniCost;
            dto.OnionsCost = pizzaPrice.OnionsCost;
            dto.GreenPeppersCost = pizzaPrice.GreenPeppersCost;


            return dto;

        }
    }
}
