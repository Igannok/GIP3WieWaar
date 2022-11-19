using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP3WieWaar.logic
{
    internal class UI


    {
        public string? Value { get; set; }
        public string Welcome()
        {

  
            Value = "Welkom op de GIP3 verdeling van Team JS\nWe gaan ieder lid van een team een random waarde toekennen (1d20). \nHierna zullen Jan en ik een nummer toebedeeld krijgen. De groep met het hoogste nummer zal de persoon met de hoogste waarde toegevoegd krijgen";
            return Value;



        }
        public string Menu() {

            
            Value = "1. Genereer nummer voor huidig groepslid\n2. Toon resultaten\n3. STOP";
            return Value;
        
        
        }
        public string Shutdown() {

            Value = "Bedankt voor gebruik te maken van de random dice generator voor GIP3.\nHopelijk is iedereen tevreden met de verdeling!";
            return Value;
        

        }

        public string Member()
        {
            Value = "Geef naam groepslid op";
            return Value;

        }

        public string Results(int jt, int aw, int j, int s)
        {
            Value = $"Resultaat Team Toby/Johan: {jt}\nResultaat Team Arthur/Wouter: {aw}\nResultaat Jan: {j}\nResultaat Steven: {s}   ";
            return Value;
        }
    }
}
