using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opakovani4
{
    internal class SportovecAmater
    {
        protected string jmeno;
        protected int pocetHodinTreninku;
        protected double obvodPasu;
        protected double vyska;

        double ObvodPasu 
        {
            get => (int)obvodPasu;
            set
            {
                if(value < 2) obvodPasu = value * 100;
                else obvodPasu = value;
            }       
        }

        double Vyska
        {
            get => (int)vyska;
            set
            {
                if (value < 2) vyska = value * 100;               
                else vyska = value;
            }
        }
        
        public SportovecAmater(string jmeno, double obvodPasu, double vyska)
        {
            this.jmeno = jmeno;
            this.pocetHodinTreninku = 0;
            ObvodPasu = obvodPasu;
            Vyska = vyska;

        }

        double WHtR()
        {
            return Math.Round(obvodPasu / vyska, 4);
        }

        public virtual void Trenuj(int x)
        {
            pocetHodinTreninku += x;
        }

        bool JeObezni()
        {
            return WHtR() > 0.5778;
        }

        public override string ToString()
        {
            return String.Format("Jmeno: {0}\nPočet hodin tréninku: {1}h\nObvod pasu: {2}cm\nVýška: {3}cm\nWHtR: {4}\n", jmeno, pocetHodinTreninku, ObvodPasu, Vyska, JeObezni() ? "Je obézní" : "Není obézní");
        }
    }
}
