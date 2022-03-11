using System;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
      class program
      {
            public static void Main (string[]args)
                  {   


                       //---------------------------------------------------------------

                        var caminho = "C:\\TrabalhandoComArquivos";
                        var caminhoPathCombine = Path.Combine(caminho,"Paste Teste 1");
                       var caminhoArquivo = Path.Combine(caminho,"Arquivo-Teste.txt");
                        FileHelper helper = new FileHelper();
                         //helper.ListarDiretorios(caminho);
                         //helper.ListarArquivosDiretorios(caminho);
                        // helper.CriarDiretorio(caminhoPathCombine);
                        //helper.ApagarDiretorio(caminhoPathCombine, true);
                        helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de Arquivo");
                        
                        
                   //------------------------------------------------------------------
                  // ICalculadora calc = new Calculadora();
                  // Console.WriteLine(calc.Somar(10,20));
                  // Console.WriteLine(calc.Subtrair(20,10));
                  // Console.WriteLine(calc.Multiplicar(10,20));
                  // Console.WriteLine(calc.Dividir(20,10));

                  //----------------------------------------------------------------
                  // Computador comp = new Computador ();
                  // System.Console.WriteLine(comp.ToString());


                  //-------------------------------------------------------------
                  // Pessoa r = new Pessoa ();
                  // r.Nome = "Douglas";
                  // r.Idade = 26;
                  // r.Cabelo = "Castanho";
                  // r.Peso = 83;
                  // r.Documento = "3243244/4";

                  // r.Apresentar();

                 //--------------------------------------------------------------
                  // Corrente C = new Corrente();
                  // C.Creditar(100);
                  
                  
                  // C.ExibirSaldo();
                  //--------------------------------------------------------------
                 
                  // Diretor d1 = new Diretor ();
                  // d1.Apresentar();


                  //----------------------------------------------------------------------------
                  // Calculadora c1 = new Calculadora ();
                  // System.Console.WriteLine("Resultado da primeira soma " + c1.Somar(10,10));
                  // System.Console.WriteLine("Resultado da primeira soma " + c1.Somar(10,10,10));
                  
                  
                      //-----------------------------------------------------------------------
                  //  Aluno p1 = new Aluno ();
                  //  p1.Nome = "Douglas";
                  //  p1.Idade = 27;
                  //  p1.Peso = 87;
                  //  p1.Cabelo = "Castanho"; 
                  //  p1.Nota = 8.5;  
                  //  p1.Documento = "1444567/54";

                  //  p1.Apresentar();
                  //  p1.NotaAluno();

                  //  System.Console.WriteLine();

                  //  Professor prof1 =  new Professor();
                  //  prof1.Nome = "Judácio";
                  //  prof1.Idade = 57;
                  //  prof1.Peso = 68;
                  //  prof1.Cabelo = "Ruivo";
                  //  prof1.Salario = 2890;
                  //  prof1.Documento = "1523654/20";
                  //  prof1.Apresentar();
                  //  prof1.ProfSalario();
                   //---------------------------------------------------------------------------------
                   
                  // Console.WriteLine();

                  // Pessoa p2 = new Pessoa ();
                  // p2.Nome = "Nicole";
                  // p2.Idade = 25;
                  // p2.Peso = 60;
                  // p2.Cabelo = "Preto";

                  // p2.Apresentar();

                  //----------------------------------------------------------------------
                  //       //valores válidos
                  // Retangulo r = new Retangulo();
                  // r.DefinirMedidas(30,30);
                  // System.Console.WriteLine($"Area:  {r.ObterArea()}");
                  
                  // Retangulo r2 = new Retangulo();
                  // r2.DefinirMedidas (-5,-25);
                  // System.Console.WriteLine($"Area: {r.ObterArea()}");
                  //-----------------------------------------------------------------------


            }
      }
}