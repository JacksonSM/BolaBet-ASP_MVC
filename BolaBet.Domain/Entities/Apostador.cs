using BolaBet.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolaBet.Domain.Entities
{
    public class Apostador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public double Saldo { get; private set; }

        public Apostador(string nome, string usuario, string senha)
        {

            DomainExceptionValidation.When(string.IsNullOrEmpty(nome),
               "Nome inválido. Nome é obrigatório");
            DomainExceptionValidation.When(nome.Length > 50,
                "Nome muito longo. É permitido no máximo 50 caracteres");

            DomainExceptionValidation.When(string.IsNullOrEmpty(usuario),
               "Usuário inválido. Usuario é obrigatório");
            DomainExceptionValidation.When(usuario.Length > 30,
                "Usuário muito longo. É permitido no máximo 30 caracteres"); 
            
            DomainExceptionValidation.When(string.IsNullOrEmpty(senha),
               "Senha inválido. Senha é obrigatório");
            DomainExceptionValidation.When(senha.Length > 8,
                "Senha muito longo. É permitido no máximo 8 caracteres");

            Nome = nome;
            Usuario = usuario;
            Senha = senha;
        }
        public void AcresentarSaldo(double valor)
        {
            Saldo += valor;
        }
        public void RetirarSaldo(double valor)
        {
            Saldo -= valor;
        }
    }
}
