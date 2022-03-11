using System;
namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string? Nome {get; set;}

        public int Idade {get; set;}

        public int Peso {get;set;}

        public string? Cabelo {get; set;}

        public  string? Documento {get; set;}

        public virtual void Apresentar ()
        {
        Console.WriteLine($"O nome da pessoa é: {Nome} e a idade da pessoa é: {Idade}");
        Console.WriteLine($"O peso atual é: {Peso}");
        Console.WriteLine($"A cor do cabelo é: {Cabelo}");
        Console.WriteLine($"O Documento da pessoa é: {Documento}");
        }
    }
}