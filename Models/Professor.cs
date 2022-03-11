namespace ExemploPOO.Models
{
    public   class Professor : Pessoa
    {
        public double Salario { get; set; } 

        public  override void Apresentar()
        {
            System.Console.WriteLine($"O salário do professor é: {Salario} e o numero de documento = {Documento}");
            System.Console.WriteLine($"Ola meu nome é: {Nome}");
        }
    
    }
    
}