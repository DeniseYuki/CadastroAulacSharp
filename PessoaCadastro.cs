using CadastroGeral.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// Empresa MaxAlteirTesla
//// cargos: Gerente [2], Atendente [2] , rh[2], suporte[2].
////média salarial por setor
////Registro de tempo por setor
//// cadastro e listagem por setor
/// criar um código para cada cargo
/// gerente cod 1 , Atendente cod 2, RH cod 3 e suporte cod 4


namespace EmpresaMaxAlteirTesla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------CADASTRO DE FUNCIONARIOS----------------");

            var Cad1 = new Cadastro();
            Cad1.CadastroId = 1;
            Cad1.Nome = "José";
            Cad1.Esolaridade = (cadastro.modelo.Enums.NivelEscolar)2;
            Cad1.Salario = 5036.32f;
            Cad1.TempoDeServico = 8f;
            Cad1.Setor = (cadastro.modelo.Enums.TipoFuncao)1;

            var Cad2 = new Cadastro();
            Cad2.CadastroId = 2;
            Cad2.Nome = "Joana";
            Cad2.Esolaridade = (cadastro.modelo.Enums.NivelEscolar)1;
            Cad2.Salario = 2500.32f;
            Cad2.TempoDeServico = 9.5f;
            Cad2.Setor = (cadastro.modelo.Enums.TipoFuncao)2;

            var Cad3 = new Cadastro();
            Cad3.CadastroId = 3;
            Cad3.Nome = "Joao";
            Cad3.Esolaridade = (cadastro.modelo.Enums.NivelEscolar)3;
            Cad3.Salario = 3500.65f;
            Cad3.TempoDeServico = 7f;
            Cad3.Setor = (cadastro.modelo.Enums.TipoFuncao)3;

            var Cad4 = new Cadastro();
            Cad4.CadastroId = 4;
            Cad4.Nome = "Ana";
            Cad4.Esolaridade = (cadastro.modelo.Enums.NivelEscolar)3;
            Cad4.Salario = 3200.65f;
            Cad4.TempoDeServico = 6.5f;
            Cad4.Setor = (cadastro.modelo.Enums.TipoFuncao)4;

            var Cad5 = new Cadastro();
            Cad5.CadastroId = 5;
            Cad5.Nome = "Lua";
            Cad5.Esolaridade = (cadastro.modelo.Enums.NivelEscolar)2;
            Cad5.Salario = 7352.65f;
            Cad5.TempoDeServico = 5f;
            Cad5.Setor = (cadastro.modelo.Enums.TipoFuncao)1;

            var Cad6 = new Cadastro();
            Cad6.CadastroId = 6;
            Cad6.Nome = "Jonas";
            Cad6.Esolaridade = (cadastro.modelo.Enums.NivelEscolar)1;
            Cad6.Salario = 3659.65f;
            Cad6.TempoDeServico = 3.5f;
            Cad6.Setor = (cadastro.modelo.Enums.TipoFuncao)2;

            var Cad7 = new Cadastro();
            Cad7.CadastroId = 7;
            Cad7.Nome = "Julia";
            Cad7.Esolaridade = (cadastro.modelo.Enums.NivelEscolar)3;
            Cad7.Salario = 5659.65f;
            Cad7.TempoDeServico = 9.5f;
            Cad7.Setor = (cadastro.modelo.Enums.TipoFuncao)3;

            var Cad8 = new Cadastro();
            Cad8.CadastroId = 8;
            Cad8.Nome = "Lana";
            Cad8.Esolaridade = (cadastro.modelo.Enums.NivelEscolar)5;
            Cad8.Salario = 13659.65f;
            Cad8.TempoDeServico = 2.5f;
            Cad8.Setor = (cadastro.modelo.Enums.TipoFuncao)4;

            var lista = new List<Cadastro>();
            lista.Add(Cad1);
            lista.Add(Cad2);
            lista.Add(Cad3);
            lista.Add(Cad4);
            lista.Add(Cad5);
            lista.Add(Cad6);
            lista.Add(Cad7);
            lista.Add(Cad8);

            foreach(var Registro in lista)
            {

                Console.WriteLine($"ID :{Cad1.CadastroId}");
                Console.WriteLine($" NOME : {Cad1.Nome}");
                Console.WriteLine($" Escolaridade : {Cad1.Esolaridade}");
                Console.WriteLine($"SALARIO: {Cad1.Salario}");
                Console.WriteLine($"HORAS TRABALHADAS {Cad1.TempoDeServico}");
                Console.WriteLine($" SETOR {Cad1.Setor}");

                Console.WriteLine("---------------------------------");

                Console.WriteLine($"ID :{Cad2.CadastroId}");
                Console.WriteLine($" NOME : {Cad2.Nome}");
                Console.WriteLine($" Escolaridade : {Cad2.Esolaridade}");
                Console.WriteLine($"SALARIO: {Cad2.Salario}");
                Console.WriteLine($"HORAS TRABALHADAS {Cad2.TempoDeServico}");
                Console.WriteLine($" SETOR {Cad2.Setor}");

                Console.WriteLine("---------------------------------");

                Console.WriteLine($"ID :{Cad3.CadastroId}");
                Console.WriteLine($" NOME : {Cad3.Nome}");
                Console.WriteLine($" Escolaridade : {Cad3.Esolaridade}");
                Console.WriteLine($"SALARIO: {Cad3.Salario}");
                Console.WriteLine($"HORAS TRABALHADAS {Cad3.TempoDeServico}");
                Console.WriteLine($" SETOR {Cad3.Setor}");

                Console.WriteLine("---------------------------------");

                Console.WriteLine($"ID :{Cad4.CadastroId}");
                Console.WriteLine($" NOME : {Cad4.Nome}");
                Console.WriteLine($" Escolaridade : {Cad4.Esolaridade}");
                Console.WriteLine($"SALARIO: {Cad4.Salario}");
                Console.WriteLine($"HORAS TRABALHADAS {Cad4.TempoDeServico}");
                Console.WriteLine($" SETOR {Cad4.Setor}");

                Console.WriteLine("---------------------------------");

                Console.WriteLine($"ID :{Cad5.CadastroId}");
                Console.WriteLine($" NOME : {Cad5.Nome}");
                Console.WriteLine($" Escolaridade : {Cad5.Esolaridade}");
                Console.WriteLine($"SALARIO: {Cad5.Salario}");
                Console.WriteLine($"HORAS TRABALHADAS {Cad5.TempoDeServico}");
                Console.WriteLine($" SETOR {Cad5.Setor}");

                Console.WriteLine("---------------------------------");

                Console.WriteLine($"ID :{Cad6.CadastroId}");
                Console.WriteLine($" NOME : {Cad6.Nome}");
                Console.WriteLine($" Escolaridade : {Cad6.Esolaridade}");
                Console.WriteLine($"SALARIO: {Cad6.Salario}");
                Console.WriteLine($"HORAS TRABALHADAS {Cad6.TempoDeServico}");
                Console.WriteLine($" SETOR {Cad6.Setor}");

                Console.WriteLine("---------------------------------");

                Console.WriteLine($"ID :{Cad7.CadastroId}");
                Console.WriteLine($" NOME : {Cad7.Nome}");
                Console.WriteLine($" Escolaridade : {Cad7.Esolaridade}");
                Console.WriteLine($"SALARIO: {Cad7.Salario}");
                Console.WriteLine($"HORAS TRABALHADAS {Cad7.TempoDeServico}");
                Console.WriteLine($" SETOR {Cad7.Setor}");

                Console.WriteLine("---------------------------------");

                Console.WriteLine($"ID :{Cad8.CadastroId}");
                Console.WriteLine($" NOME : {Cad8.Nome}");
                Console.WriteLine($" Escolaridade : {Cad8.Esolaridade}");
                Console.WriteLine($"SALARIO: {Cad8.Salario}");
                Console.WriteLine($"HORAS TRABALHADAS {Cad8.TempoDeServico}");
                Console.WriteLine($" SETOR {Cad8.Setor}");


                Console.WriteLine("--------------FIM-----------------");


            }
        


        }
    }
}























