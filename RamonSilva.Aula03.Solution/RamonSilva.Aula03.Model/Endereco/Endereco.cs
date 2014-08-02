using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamonSilva.Aula03.Model
{
    public class Endereco
    {
        public int ID { get; set; }
        public int IDLogradouro { get; set; }
        public TipoEndereco Tipo { get; set; }
        public int Numero { get; set; }
        public String Complemento { get; set; }
        public String CEP { get; set; }
    }
}
