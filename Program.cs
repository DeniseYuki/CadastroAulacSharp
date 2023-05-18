using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cadastro.modelo.Enums;

namespace CadastroGeral.modelo
{
    public class Cadastro
    {
    
        public int CadastroId { get; set; }
        public string Nome { get; set; }
        public NivelEscolar Esolaridade {get; set;}
        public float Salario { get; set; }
        public float TempoDeServico { get; set;}
        public TipoFuncao Setor { get; set; }

    }


   
    // public class TotalFuncionarios
    // {
    //List<string> lista = new List<string>();

    //public class Setor
    //{
    //    List<string> ListaSetor = new List<string>();

    //    Setor2.Add(Cadastro3.Nome);
    //    Setor2.Add(Convert.ToString(Cadastro3.CodidoFuncao));
    //    Setor2.Add(Convert.ToString(Cadastro3.Id));
    //    Setor2.Add(Convert.ToString(Cadastro3.Salario));
    //    Setor2.Add(Convert.ToString(Cadastro3.TempoDeServico));
    //    Setor2.Add(Cadastro.Nome);
    //    Setor2.Add(Convert.ToString(Cadastro.CodidoFuncao));
    //    Setor2.Add(Convert.ToString(Cadastro.Id));
    //    Setor2.Add(Convert.ToString(Cadastro.Salario));
    //    Setor2.Add(Convert.ToString(Cadastro.TempoDeServico));
    //}




}
    
