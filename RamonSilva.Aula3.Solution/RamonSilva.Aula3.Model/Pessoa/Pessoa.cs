using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamonSilva.Aula3.Model
{
    public abstract class Pessoa
    {
        public int ID { get; set; }
        public int IDTelefone { get; set; }
        public int IDEndereco { get; set; }
    }
}
