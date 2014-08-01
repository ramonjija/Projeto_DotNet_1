using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamonSilva.Aula3.Model
{
    public class Logradouro
    {
        //TODO: definir enum de logradouro
        public int ID { get; set; }
        public int IDBairro { get; set; }
        public TipoLogradouro Tipo { get; set; }
        public String Descricao { get; set; }
        public int Numero { get; set; }
        public String Complemento { get; set; }
    }
}
