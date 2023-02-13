using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class PCancelleria : Prodotto
    {
        public PCancelleria(string id, string nome, string prod, string descr, decimal prezzo) : base(id, nome, prod, descr, prezzo)
        {
        }
        public override void Applica()
        {
            if (DateTime.Today.Day % 2 == 0)
                Sconto(3);
        }
    }
}