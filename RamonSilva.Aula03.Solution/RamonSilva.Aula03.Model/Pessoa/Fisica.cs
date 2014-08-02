using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamonSilva.Aula03.Model
{
    public class Fisica : Pessoa
    {
        public String CPF { get; set; }
        public String RG { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; } 
        public TipoSexo Sexo { get; set; }
    }
}
