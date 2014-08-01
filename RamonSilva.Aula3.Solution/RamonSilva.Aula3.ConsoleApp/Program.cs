using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamonSilva.Aula3.Model;

namespace RamonSilva.Aula3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Fisica PFisica = new Fisica();
            PFisica.CPF = "111.111.111-11";
            PFisica.Nome = "Ramon";
            PFisica.Sobrenome = "Silva";
            PFisica.RG = "11111111-1";
            PFisica.ID = 1;
            PFisica.Sexo = TipoSexo.Masculino;
            PFisica.DataNascimento = new DateTime(1988, 3, 19);

            //Calculo da idade

            idade = DateTime.Now.Year - PFisica.DataNascimento.Year;

            Telefone telefone = new Telefone();
            telefone.ID = 1;
            telefone.Tipo = TipoTelefone.Celular;
            telefone.Numero = "99999999999";

            Juridica PJuridica = new Juridica();
            PJuridica.ID = 1;
            PJuridica.CNPJ = "84.139.074/0001-01";
            PJuridica.IE = "84715212";
            PJuridica.RazaoSocial = "Jija Business";

            UF uf = new UF();
            uf.ID = 25;
            uf.Sigla = "RJ";

            Cidade cidade = new Cidade();
            cidade.ID = 24;
            cidade.IDUF = 25;
            cidade.Descricao = "Rio de Janeiro";

            Bairro bairro = new Bairro();
            bairro.ID = 23;
            bairro.IDCidade = 24;
            bairro.Descricao = "Centro";

            Logradouro logradouro = new Logradouro();
            logradouro.ID = 22;
            logradouro.IDBairro = 23;
            logradouro.Tipo = TipoLogradouro.Rua;
            logradouro.Descricao = "Senador Dantas";
            logradouro.Numero = 29;
            logradouro.Complemento = "41";

            Endereco endereco = new Endereco();
            endereco.ID = 1;
            endereco.Tipo = TipoEndereco.Residencial;
            endereco.IDLogradouro = 22;

            PFisica.IDEndereco = 1;
            PFisica.IDTelefone = 1;

            Console.WriteLine(
                "ID: " + PFisica.ID + "\n" +
                "CPF: " + PFisica.CPF + "\n" +
                "RG: " + PFisica.RG + "\n" +
                "Nome e Sobrenome: " + PFisica.Nome + " " + PFisica.Sobrenome + "\n" +
                "Sexo: " + PFisica.Sexo + "\n" +
                "Idade: " + idade + "\n" +
                telefone.Tipo + " : " + telefone.Numero + "\n" +
                "Endereço: " + endereco.Tipo + " " + logradouro.Tipo + " " + logradouro.Descricao + " nº " + logradouro.Numero + " Complemento: " + logradouro.Complemento + "\n" +
                "Bairro: " + bairro.Descricao + "\n" +
                "Cidade: " + cidade.Descricao + "\n" +
                "UF: " + uf.Sigla
                );
            Console.ReadKey();

        }
    }
}
