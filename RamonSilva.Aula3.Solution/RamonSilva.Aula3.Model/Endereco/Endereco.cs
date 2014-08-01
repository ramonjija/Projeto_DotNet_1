using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamonSilva.Aula3.Model
{
    public class Endereco
    {
        public int ID { get; set; }
        public int IDLogradouro { get; set; }
        public TipoEndereco Tipo { get; set; }
    }
}
