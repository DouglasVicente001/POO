namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
        Console.WriteLine($"O nome da pessoa é: {Nome} e a idade da pessoa é: {Idade}");
        Console.WriteLine($"O peso atual é: {Peso}");
        Console.WriteLine($"A cor do cabelo é: {Cabelo}");
        Console.WriteLine($"O documento do aluno é {Documento}");
        }


    }
}