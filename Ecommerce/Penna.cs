using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    internal class Penna : PCancelleria
    {
        private string _funzionamento;
        public Penna(string id, string nome, string prod, string descr, decimal prezzo, string funzionamento) : base(id, nome, prod, descr, prezzo)
        {
            Funzionamento = funzionamento;
        }
        public string Funzionamento
        {
            get
            {
                return _funzionamento;
            }
            private set
            {
                if (value != null)
                    _funzionamento = value;
                else
                    throw new Exception("Inserire un funzionamento valido");
            }
        }
        public override string[] ToString()
        {
            string[] p = { Id, Nome, Produttore, Convert.ToString(Prezzo), Convert.ToString(Scontato), Convert.ToString(Funzionamento), Descrizione };
            return p;
        }
    }
}
