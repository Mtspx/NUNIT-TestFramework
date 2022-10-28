using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidadorCPF.models
{
    public class Usuario
    {
        public Usuario(string nome, string cPF)
        {
            Nome = nome;
            CPF = cPF;
        }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Boolean ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".","");
            cpf = cpf.Replace("-","");
            if(cpf.Length == 11)
            {
               return true; 
            }
            else
            {
                return false;
            }
            
        }
    }
}