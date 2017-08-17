using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dana";
            //Console.WriteLine(name);

            name = "Dave";
            //Console.WriteLine(name);

            string birthMonth = "September";
            //Console.WriteLine(birthMonth);
            //integers
            int birthMonthNumber = 28;
            int age = 65;
            int population = 100000;

            //floating type variables
            float number = 2.164403304897294383961032f;
            double someNumber = 2.164403304897294383961032d;
            decimal partialNumber = 2.164403304897294383961032m;

            //Console.WriteLine(number);
            //Console.WriteLine(someNumber);
            //Console.WriteLine(partialNumber);

            //Boolean
            bool isPresent = true;
            bool seatTaken = false;

            //Character
            char lastLetter = 'd';

            //int jessicaAge = 23;
            //int samAge = 47;
            //Console.WriteLine(jessicaAge < samAge);

            //Mike and his three friends decided to divide the bill evenly. If each person paid $13 then what was the total bill?
            //Lisa's recipe called for 7 cups of sugar.  She put in 2 cups.  How many more cups does she need

            //int mike = 13;
            //int friendA = 13;
            //int friendB = 13;
            //int friendC = 13;
            ////The following line is the answer to question 1
            //Console.WriteLine(mike + friendA + friendB + friendC);

            //int cupsNeeded = 7;
            //int cupsIn = 2;
            ////The following line is the answer to question 2
            //Console.WriteLine(cupsNeeded - cupsIn);

            ////how many diapers can you buy with 40 if each pack is 8
            //int diaperCost = 8;
            //int totalMoney = 40;
            ////The following line is the anser to question 3
            //Console.WriteLine(totalMoney / diaperCost); 

            //int trevonMoney = 41;
            //int trevonPrevious = 29;
            ////The following line is the answer to question 4
            //Console.WriteLine(trevonMoney - trevonPrevious);

            //int juliaMiles = 47;
            //int pranavMiles = -30;
            ////The following line is the answer to question 5
            //Console.WriteLine(juliaMiles + pranavMiles);

            //int boxEnvelopes = 3;
            //int totalCash = 12;
            ////The following line is the answer to question 6
            //Console.WriteLine(totalCash / boxEnvelopes);

            //float total = 27.10f;
            //float saladCost = 5.12f;
            ////The following line is the answer to question 7;
            //Console.WriteLine(total + saladCost);

            int studentTotal = 331;
            int totalBuses = 6;
            int carStudents = 7;
            int studentsInBuses = studentTotal - carStudents;
            int averageBusLoad = studentsInBuses / totalBuses;
            Console.WriteLine(averageBusLoad);

            float aliyahStartMoney = 24.00f;
            float aliyahLeftoverMoney = 10.00f;
            float aliyahMoneySpent = aliyahStartMoney - aliyahLeftoverMoney;
            int numberPencils = 7;
            float pencilCost = aliyahMoneySpent / numberPencils;
            Console.WriteLine(pencilCost);

            int finalNumber = 72;
            int averageNumber = 72 / 3;
            int firstConsecutive = averageNumber - 1;
            int secondConsecutive = averageNumber;
            int thirdConsecutive = averageNumber + 1;
            Console.WriteLine(firstConsecutive);

            int specialNumber = 48;
            int averageSpecialNumber = 48 / 3;
            int firstSpecialConsecutive = averageSpecialNumber - 2;
            int thirdSpecialConsecutive = averageSpecialNumber + 2;
            Console.WriteLine(firstSpecialConsecutive);
            //comment
            int totalBoxesLeft = 22;
            int maxBoxes = totalBoxesLeft * 2;
            int boxesbought = 7;
            int startBoxTotal = maxBoxes - boxesbought;
            Console.WriteLine(startBoxTotal);





            








           








        }
    }
}
