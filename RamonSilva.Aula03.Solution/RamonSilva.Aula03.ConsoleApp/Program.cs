using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamonSilva.Aula03.Model;

namespace RamonSilva.Aula03.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Fisica pFisica = new Fisica();
            pFisica.CPF = "111.111.111-11";
            pFisica.Nome = "Ramon";
            pFisica.Sobrenome = "Silva";
            pFisica.RG = "11111111-1";
            pFisica.ID = 1;
            pFisica.Sexo = TipoSexo.Masculino;
            pFisica.DataNascimento = new DateTime(1988, 3, 19);

            //Calculo da idade

            idade = DateTime.Now.Year - pFisica.DataNascimento.Year;

            Telefone telefone = new Telefone();
            telefone.ID = 1;
            telefone.Tipo = TipoTelefone.Celular;
            telefone.Numero = "99999999999";

            Juridica pJuridica = new Juridica();
            pJuridica.ID = 1;
            pJuridica.CNPJ = "84.139.074/0001-01";
            pJuridica.IE = "84715212";
            pJuridica.RazaoSocial = "Jija Business";

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

            Endereco endereco = new Endereco();
            endereco.ID = 1;
            endereco.Tipo = TipoEndereco.Residencial;
            endereco.IDLogradouro = 22;
            endereco.Numero = 29;
            endereco.Complemento = "41";
            endereco.CEP = "20031-202";

            pFisica.IDEndereco = 1;
            pFisica.IDTelefone = 1;

            Console.WriteLine(
                "ID: " + pFisica.ID + "\n" +
                "CPF: " + pFisica.CPF + "\n" +
                "RG: " + pFisica.RG + "\n" +
                "Nome e Sobrenome: " + pFisica.Nome + " " + pFisica.Sobrenome + "\n" +
                "Sexo: " + pFisica.Sexo + "\n" +
                "Idade: " + idade + "\n" +
                telefone.Tipo + " : " + telefone.Numero + "\n" +
                "Tipo de Endereço: " + endereco.Tipo + "\n" +
                "CEP: " + endereco.CEP + "\n" +
                "Endereço: "+ logradouro.Tipo + " " + logradouro.Descricao + " nº " + endereco.Numero + " Complemento: " + endereco.Complemento + "\n" +
                "Bairro: " + bairro.Descricao + "\n" +
                "Cidade: " + cidade.Descricao + "\n" +
                "UF: " + uf.Sigla 
                );
            Console.ReadKey();

        }
    }
}
