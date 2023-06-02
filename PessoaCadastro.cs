using cadastro.modelo.Enums;
using CadastroGeral.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////// Empresa MaxAlteirTesla
////// cargos: Gerente [2], Atendente [2] , rh[2], suporte[2].
//////média salarial por setor
//////Registro de tempo por setor
////// cadastro e listagem por setor
///// criar um código para cada cargo
///// gerente cod 1 , Atendente cod 2, RH cod 3 e suporte cod 4


namespace EmpresaMaxAlteirTesla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------CADASTRO DE FUNCIONÁRIOS----------------");

            var Cad1 = new Cadastro();
            Cad1.CadastroId = 1;
            Cad1.Nome = "José";
            Cad1.Escolaridade = (NivelEscolar)2;
            Cad1.Salario = 5036.32f;
            Cad1.TempoDeServico = 8f;
            Cad1.Setor = (TipoFuncao)1;

            var Cad2 = new Cadastro();
            Cad2.CadastroId = 2;
            Cad2.Nome = "Joana";
            Cad2.Escolaridade = (NivelEscolar)1;
            Cad2.Salario = 2500.32f;
            Cad2.TempoDeServico = 9.5f;
            Cad2.Setor = (TipoFuncao)2;

            var Cad3 = new Cadastro();
            Cad3.CadastroId = 3;
            Cad3.Nome = "João";
            Cad3.Escolaridade = (NivelEscolar)3;
            Cad3.Salario = 3500.65f;
            Cad3.TempoDeServico = 7f;
            Cad3.Setor = (TipoFuncao)3;

            var Cad4 = new Cadastro();
            Cad4.CadastroId = 4;
            Cad4.Nome = "Ana";
            Cad4.Escolaridade = (NivelEscolar)3;
            Cad4.Salario = 3200.65f;
            Cad4.TempoDeServico = 6.5f;
            Cad4.Setor = (TipoFuncao)4;

            var Cad5 = new Cadastro();
            Cad5.CadastroId = 5;
            Cad5.Nome = "Lua";
            Cad5.Escolaridade = (NivelEscolar)2;
            Cad5.Salario = 7352.65f;
            Cad5.TempoDeServico = 5f;
            Cad5.Setor = (TipoFuncao)1;

            var Cad6 = new Cadastro();
            Cad6.CadastroId = 6;
            Cad6.Nome = "Jonas";
            Cad6.Escolaridade = (NivelEscolar)1;
            Cad6.Salario = 3659.65f;
            Cad6.TempoDeServico = 3.5f;
            Cad6.Setor = (TipoFuncao)2;

            var Cad7 = new Cadastro();
            Cad7.CadastroId = 7;
            Cad7.Nome = "Júlia";
            Cad7.Escolaridade = (NivelEscolar)3;
            Cad7.Salario = 5659.65f;
            Cad7.TempoDeServico = 9.5f;
            Cad7.Setor = (TipoFuncao)3;

            var Cad8 = new Cadastro();
            Cad8.CadastroId = 8;
            Cad8.Nome = "Lana";
            Cad8.Escolaridade = (NivelEscolar)5;
            Cad8.Salario = 13659.65f;
            Cad8.TempoDeServico = 2.5f;
            Cad8.Setor = (TipoFuncao)4;

            var lista = new List<Cadastro>();
            lista.Add(Cad1);
            lista.Add(Cad2);
            lista.Add(Cad3);
            lista.Add(Cad4);
            lista.Add(Cad5);
            lista.Add(Cad6);
            lista.Add(Cad7);
            lista.Add(Cad8);

            Console.WriteLine($"Total de pessoas: {lista.Count}");

            // Quantidade de pessoas por escolaridade
            var quantidadePorEscolaridade = new Dictionary<NivelEscolar, int>();
            foreach (var cadastro in lista)
            {
                if (quantidadePorEscolaridade.ContainsKey(cadastro.Escolaridade))
                    quantidadePorEscolaridade[cadastro.Escolaridade]++;
                else
                    quantidadePorEscolaridade[cadastro.Escolaridade] = 1;
            }

            Console.WriteLine("Quantidade de pessoas por escolaridade:");
            foreach (var item in quantidadePorEscolaridade)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            // Quantidade de pessoas por setor
            var quantidadePorSetor = new Dictionary<TipoFuncao, int>();
            foreach (var cadastro in lista)
            {
                if (quantidadePorSetor.ContainsKey(cadastro.Setor))
                    quantidadePorSetor[cadastro.Setor]++;
                else
                    quantidadePorSetor[cadastro.Setor] = 1;
            }

            Console.WriteLine("Quantidade de pessoas por setor:");
            foreach (var item in quantidadePorSetor)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            // Média de salário por setor
            var mediaSalarioPorSetor = new Dictionary<TipoFuncao, float>();
            var quantidadePessoasPorSetor = new Dictionary<TipoFuncao, int>();
            foreach (var cadastro in lista)
            {
                if (mediaSalarioPorSetor.ContainsKey(cadastro.Setor))
                {
                    mediaSalarioPorSetor[cadastro.Setor] += cadastro.Salario;
                    quantidadePessoasPorSetor[cadastro.Setor]++;
                }
                else
                {
                    mediaSalarioPorSetor[cadastro.Setor] = cadastro.Salario;
                    quantidadePessoasPorSetor[cadastro.Setor] = 1;
                }
            }

            Console.WriteLine("Média de salário por setor:");
            foreach (var item in mediaSalarioPorSetor)
            {
                var setor = item.Key;
                var mediaSalario = item.Value / quantidadePessoasPorSetor[setor];
                Console.WriteLine($"{setor}: {mediaSalario:C}");
            }

            // Registro de tempo por setor
            var tempoPorSetor = new Dictionary<TipoFuncao, float>();
            foreach (var cadastro in lista)
            {
                if (tempoPorSetor.ContainsKey(cadastro.Setor))
                    tempoPorSetor[cadastro.Setor] += cadastro.TempoDeServico;
                else
                    tempoPorSetor[cadastro.Setor] = cadastro.TempoDeServico;
            }

            Console.WriteLine("Registro de tempo por setor:");
            foreach (var item in tempoPorSetor)
            {
                Console.WriteLine($"{item.Key}: {item.Value} horas");
            }
            Console.WriteLine("-------------------------------------------------");

            // Cadastro de funcionários por setor
            var cadastroPorSetor = new Dictionary<TipoFuncao, List<Cadastro>>();
            foreach (var cadastro in lista)
            {
                if (cadastroPorSetor.ContainsKey(cadastro.Setor))
                    cadastroPorSetor[cadastro.Setor].Add(cadastro);
                else
                    cadastroPorSetor[cadastro.Setor] = new List<Cadastro> { cadastro };
            }

            Console.WriteLine("Cadastro de funcionários por setor:");
            foreach (var item in cadastroPorSetor)
            {
                var setor = item.Key;
                var funcionarios = item.Value;
                Console.WriteLine($"Setor: {setor}");
                foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine($"ID: {funcionario.CadastroId}, Nome: {funcionario.Nome}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------");

            // Listagem de funcionários por setor
            Console.WriteLine("Listagem de funcionários por setor:");
            foreach (var item in cadastroPorSetor)
            {
                var setor = item.Key;
                var funcionarios = item.Value;
                Console.WriteLine($"Setor: {setor}");
                foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine($"ID: {funcionario.CadastroId}, Nome: {funcionario.Nome}, Salário: {funcionario.Salario:C}, Tempo de Serviço: {funcionario.TempoDeServico} horas");
                }
                Console.WriteLine();
            }
        }
    }
}


