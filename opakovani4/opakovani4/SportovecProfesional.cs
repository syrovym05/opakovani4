using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opakovani4
{
    internal class SportovecProfesional : SportovecAmater
    {
        DateTime datumVznikuClenstvi;
        double bazalniMetabolismus;
        int stupenVykonosti;

        public int StupenVykonosti
        {
            get
            {
                if (stupenVykonosti == 0) MessageBox.Show("Neproběhla klasifikace stupně výkonosti!!");             
                return stupenVykonosti;
            }
            set
            {
                if (value % 10 == value && value >= 1 && value <= 7)
                {
                    stupenVykonosti = value;
                }
                else stupenVykonosti = 0;
            }
        }

        public SportovecProfesional(string jmeno, double obvodPasu, double vyska, DateTime datumVznikuClenstvi, double bazalniMetabolismus) : base(jmeno, obvodPasu, vyska)
        {
            this.datumVznikuClenstvi = datumVznikuClenstvi;
            this.bazalniMetabolismus = bazalniMetabolismus;
        }

        bool MaNarokNaSlevu()
        {
            double delka = (DateTime.Now - datumVznikuClenstvi).TotalDays / 365;
            if (delka > 5) return true;
            return false;
        }

        public override void Trenuj(int x)
        {
            if(pocetHodinTreninku + x > 100) Math.Round(bazalniMetabolismus *= 1.1, 2);    
            base.Trenuj(x);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Vznik členství: {0}\nBazální metabolismus: {1}\nNárko na slevu: {2}\nStupen výkonosti: {3}", datumVznikuClenstvi, bazalniMetabolismus, MaNarokNaSlevu() ? "Ano" : "Ne", StupenVykonosti);
        }
    }
}
