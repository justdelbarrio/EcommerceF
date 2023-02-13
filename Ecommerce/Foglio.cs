using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Foglio : PCancelleria
    {
        private int _grammatura;
        public Foglio(string id, string nome, string prod, string descr, decimal prezzo, int grammatura) : base(id, nome, prod, descr, prezzo)
        {
            Grammatura = grammatura;
        }
        public int Grammatura
        {
            get
            {
                return _grammatura;
            }
            set
            {
                if (value > 0)
                    _grammatura = value;
                else
                    throw new Exception("Grammatura errata");
            }
        }
        public override string[] ToString()
        {
            string[] p = { Id, Nome, Produttore, Convert.ToString(Prezzo), Convert.ToString(Scontato), Convert.ToString(Grammatura), Descrizione };
            return p;
        }
    }
}
