using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP3WieWaar.logic
{
    enum Leden
    {
        Arthur,
        Jan,
        Johan,
        Steven,
        Toby,
        Wouter

    }
    internal class Logic
    {
        public IDictionary<Leden, int> InputMap;

        public Logic()
        {
            InputMap = new Dictionary<Leden, int>();
        }

        public int Random1d20Roll()
        {
            Random random = new Random();
            int numb = random.Next(21);
            return numb;
        }


        public int RandomLogic(string name, int i)
        {


            int given;
            bool validName = Enum.TryParse(name, out Leden enumName);
            if (validName)
            {
                //pas te doen als valid enum naam opgegeven
                given = Random1d20Roll();
                if (!InputMap.ContainsKey(enumName))
                {
                    Console.WriteLine($"Toekende waarden: {enumName} > {given}");
                    InputMap.Add(enumName, given);

                }
                else
                {
                    Console.WriteLine($"Opgegeven naam {enumName} bestaat reeds\nProbeer opnieuw");
                    i--;

                }
            }
            else
            {
                Console.WriteLine("Gelieve hoofdlettergevoelig te typen aub.");
                i--;
            }

            return i;
        }

        public string ResultsOrdered(int jt, int aw, int j, int s)
        {
            string value = "";

            if (jt > aw)
            {
                value += "Team Toby/Johan heeft de meeste punten\n";

            }
            if (aw > jt)
            {
                value += "Team Arthur/Wouter heeft de meeste punten\n";
            }
            if (j > s)
            {
                value += "Jan zal hen vervoegen";
            }
            if (s > j)
            {
                value += "Steven zal hen vervoegen";
            }



            return value;
        }



    }
}
