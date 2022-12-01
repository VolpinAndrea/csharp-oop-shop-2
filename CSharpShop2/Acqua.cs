using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    internal class Acqua : Prodotto //<<Attore>
    {
        private double capienza;
        
        public Acqua(string nome, string descrizione, double prezzo, double iva, double capienza) : base(nome, descrizione, prezzo, iva)
        {
            SetCapienza(capienza);
        }

        public double GetCapienza()
        {
            return this.capienza;
        }
        public void SetCapienza(double newCapienza)
        {
            if (newCapienza >= 0 && newCapienza <= 1.5)
            {
                this.capienza = newCapienza;
            }
            else if (newCapienza > 1.5)
            {
                Console.WriteLine("troppa acqua insrita, settato a 1,5 Litri");
                this.capienza = 1.5;
            }
            else
            {
                Console.WriteLine("numero acqua non valido inserito 0 Litri");
                this.capienza = 0;

            }
        }

        public override void StampaTutto()
        {
            base.StampaTutto();
            Console.WriteLine("Capienza:" + capienza + " Litri");
        }



    }
}
