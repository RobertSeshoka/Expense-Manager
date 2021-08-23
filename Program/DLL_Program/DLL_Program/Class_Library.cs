using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Program
{
    public class Class_Library
    {




        //This will handle the calculating of monthly expenese
        public int addMonthlyExpenses(int income, int tax, 
            int groceries, int water_Electricity, 
            int travel_Costs, int phoneBill, 
            int others, int rent)
        {

            return income - tax - groceries - water_Electricity - travel_Costs - phoneBill - others - rent;
        }


        //This will handle the calculating of property expenese

        public int property_Expenses(int price, int deposit, int rate, int months_Pay)
        {

            int answer, answer1;//Varibales yo hold the ansers

            deposit = rate / 100 * price;//Calculates the percentage of the price
            price = price - deposit; //Holds the calculated price
            rate = rate / 100;//Calculates the given rate
            months_Pay = months_Pay / 12;//Devides by 12 months

            answer1 = price * (1 + rate * months_Pay);

            answer = answer1 / 12;

            return answer;

        }
        //This will handle the calculating of vehicle expenese

        public int vehicle_Expenses(int model, int price, int deposit,
            int rate , int insurance, int loan, int years)
        {

            int answer, sum;


            deposit = rate / 100 * price;
            insurance = insurance + loan + model;
            price = price - deposit + insurance;
            rate = rate / 100;
            years = years / 12;// 5 will be the number of years

            sum = price * (1 + rate * years);
            answer = sum / years;

            return answer;
        }
    }



  
}
