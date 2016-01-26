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

        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }
        private bool fancyDecorations;

        public decimal CostOfBeveragesPerPersom;
        public decimal CostOfDecorations = 0;
        public decimal DagensKurs = 8;


        public MiddagsSelskap(int numberOfPeople, bool healtyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyPotion(healtyOption);
            CalculateCostOfDecorations(fancyDecorations);
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

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 150.00M * DagensKurs) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 70.50M * DagensKurs) + 30M;
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
