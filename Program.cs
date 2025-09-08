using System;
using System.Diagnostics.Tracing;

namespace Trabalho3POO
{
    public class Pessoa
    {
        private string nome;
        public string Getnome()
        {
            return this.nome;
        }

        public void Setnome(string nome)
        {
            if (!string.IsNullOrWhiteSpace(nome))
                this.nome = nome;
            else
                throw new ArgumentException("O nome não pode ser vazio.");
        }
        private int idade;
        public int Getidade()
        {
            return this.idade;
        }
        public void Setidade(int idade)
        {
            if (idade >= 0 && idade <= 130)
                this.idade = idade;
            else
                throw new ArgumentException("Idade invalida");
        }

        private string? cpf;
        public string Getcpf()
        {
            if (!string.IsNullOrWhiteSpace(cpf))
                return this.cpf;
            else
                throw new ArgumentException("CPF invalido");
        }
        public void Setcpf(string cpf)
        {
            if (!string.IsNullOrWhiteSpace(cpf))
            {
                if (Int64.TryParse(cpf, out Int64 result) == true)
                    this.cpf = cpf;
                else
                    throw new ArgumentException("CPF invalido (deve contar apenas números)");
            }
            else
                throw new ArgumentException("CPF invalido (deve contar apenas números)");
        }
        private char sexo;
        public char Getsexo()
        {
            return this.sexo;
        }
        public void Setsexo(char sexo)
        {
            sexo = char.ToUpper(sexo);
            if (sexo != '\0' && (sexo == 'M' || sexo == 'F'))
            {
                this.sexo = sexo;
            }
            else
                throw new ArgumentException("Sexo invalido");
        }
        private char estadocivil;
        public char Getestadocivil()
        {
            return this.estadocivil;
        }
        public void Setestadocivil(char estadocivil)
        {
            estadocivil = char.ToUpper(estadocivil);
            if (estadocivil != '\0' && (estadocivil == 'S' || estadocivil == 'C'))
            {
                this.estadocivil = estadocivil;
            }
            else
                throw new ArgumentException("Estado civil invalido");
        }
        public Pessoa(string nome, char sexo, int idade, string cpf, char estadocivil)
        {
            if (!string.IsNullOrWhiteSpace(nome))
                this.nome = nome;
            else
                throw new ArgumentException("O nome não pode ser vazio.");

            sexo = char.ToUpper(sexo);
            if (sexo != '\0' && (sexo == 'M' || sexo == 'F'))
            {
                this.sexo = sexo;
            }
            else
                throw new ArgumentException("Sexo invalido");

            if (idade >= 0 && idade <= 130)
                this.idade = idade;
            else
                throw new ArgumentException("Idade invalida");

            if (!string.IsNullOrWhiteSpace(cpf))
            {
                if (Int64.TryParse(cpf, out Int64 result) == true)
                    this.cpf = cpf;
                else
                    throw new ArgumentException("CPF invalido (deve contar apenas números)");
            }
            else
                throw new ArgumentException("CPF invalido (deve contar apenas números)");

            estadocivil = char.ToUpper(estadocivil);
            if (estadocivil != '\0' && (estadocivil == 'S' || estadocivil == 'C'))
            {
                this.estadocivil = estadocivil;
            }
            else
                throw new ArgumentException("Estado civil invalido");
        }
        public Pessoa(string nome, char sexo) : this(nome, sexo, 0, "00000000000", 's')
        {
        }
        public Pessoa(string nome, char sexo, int idade) : this(nome, sexo, idade, "00000000000", 's')
        {
        }
    }

    class Trabalho3POO
    {
        private static void Main()
        {
            //criação do objeto com todos os atributos e impressão para mostrar que esta funcionando.
            Pessoa p = new("Alan Hilario Pedro Pedro Bruno", 'M');
            p.Setcpf("12345678910");
            p.Setidade(25);
            p.Setestadocivil('s');

            Console.WriteLine($"Nome = {p.Getnome()}");
            Console.WriteLine($"Sexo = {p.Getsexo()}");
            Console.WriteLine($"Idade = {p.Getidade()}");
            Console.WriteLine($"CPF = {p.Getcpf()}");
            Console.WriteLine($"Estado Civil = {p.Getestadocivil()}");

            Console.WriteLine("");
            Console.WriteLine("");

            //criação de um segundo objeto com todos os atributos e impressão para mostrar que esta funcionando.
            Pessoa pp = new("Maiara", 'F');
            pp.Setcpf("01987654321");
            pp.Setidade(28);
            pp.Setestadocivil('c');

            Console.WriteLine($"Nome = {pp.Getnome()}");
            Console.WriteLine($"Sexo = {pp.Getsexo()}");
            Console.WriteLine($"Idade = {pp.Getidade()}");
            Console.WriteLine($"CPF = {pp.Getcpf()}");
            Console.WriteLine($"Estado Civil = {pp.Getestadocivil()}");

            /*

            //criação de uma classe para gerar os lançamentos das exceções
            Pessoa pessoa1 = new("Exemplo 1", 'M');

            //geração do erro ao tentar colocar um cpf invalido
            //aqui deveria constar um CPF válido, não podendo conter letras nem um espaço em branco.
            p.Setcpf("Teste erro cpf");
            
            */

            /*

            //criação de outra classe para gerar os lançamentos das exceções
            Pessoa pessoa2 = new("Exemplo 1", 'M');

            //geração do erro ao tentar colocar uma idade negativa
            p.Setidade(-5);
            
            */
        }
    }
}