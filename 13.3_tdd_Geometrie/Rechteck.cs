using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3_tdd_Geometrie
{
    // Klasse muss public sein, sonst kann sie das 
    // externe Testprojekt nicht nutzen.
    public class Rechteck 
    {
        private int breite;
        private int hoehe;

        public int Breite { 
            get { return breite; } 
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                breite = value; 
            }
            
        }
        public int Hoehe { 
            get { return hoehe; } 
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                hoehe = value; 
            }
        }

        public Rechteck()
        {
            breite = 0;
            hoehe = 0;
        }

        public Rechteck(int breite, int hoehe)
        {
            this.breite = breite;
            this.hoehe = hoehe; 
        }

        public void Skalieren(double faktor)
        {
            if (faktor <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            breite = Convert.ToInt32(breite * faktor);
            hoehe = Convert.ToInt32(hoehe * faktor);
        }

        public int Umfang()
        {
            return (breite + hoehe) * 2;
        }

        public int Flaeche()
        {
            return breite * hoehe;
        }

        public bool GroeserAls(int breite, int hoehe)
        {
            int r1 = (this.breite + this.hoehe) * 2;
            int r2 = (breite + hoehe) * 2;

            if (r1 > r2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
