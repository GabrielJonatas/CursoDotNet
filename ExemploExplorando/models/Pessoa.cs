using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Pessoa
    {
        public Pessoa() {
            
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome; // body expressions, simplificação quando há somente uma linha de código
        private int _idade;
        public string Nome 
        { 
            get =>_nome.ToUpper();
            
            set
            {
                if(value == "") 
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        { 
            get => _idade; // body expressions, simplificação quando há somente uma linha de código
            
            set
            {
                if(value < 0) 
                {
                    throw new ArgumentException("A idade não pode ser menor do que zero");
                }

                _idade = value;
            } 
            
        }

        public void Apresentar() 
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}