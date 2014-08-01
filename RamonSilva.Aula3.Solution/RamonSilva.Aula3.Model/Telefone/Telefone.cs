using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamonSilva.Aula3.Model
{
    public class Telefone
    {
        //TODO: É necessario definir o enum dos telefones
        public int ID { get; set; }
        public TipoTelefone Tipo { get; set; }
        public String Numero { get; set; }

    }
}
