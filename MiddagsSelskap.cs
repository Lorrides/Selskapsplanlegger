﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selskapsplanlegger
{
    class MiddagsSelskap
    {
        const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPersom;
        public decimal CostOfDecorations = 0;


        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public void SetHealthyPotion(bool helse)
        {
            if (helse)
            {
                CostOfBeveragesPerPersom = 5.0M;
            }
            else
            {
                CostOfBeveragesPerPersom = 20.0M;
            }
        }

        public decimal CalculateCost(bool kostnader)
        {
            decimal totalKost = CostOfDecorations + ((CostOfBeveragesPerPersom + CostOfFoodPerPerson) * NumberOfPeople);

            if (kostnader)
            {
                return totalKost * .95M;
            }
            else
            {
                return totalKost;
            }
        }
    }
}