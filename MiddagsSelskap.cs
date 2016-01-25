using System;
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
        public decimal DagensKurs = 8;


        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M * DagensKurs) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M * DagensKurs) + 30M;
            }
        }

        public void SetHealthyPotion(bool helse)
        {
            if (helse)
            {
                CostOfBeveragesPerPersom = 5.0M * DagensKurs;
            }
            else
            {
                CostOfBeveragesPerPersom = 20.0M * DagensKurs;
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
