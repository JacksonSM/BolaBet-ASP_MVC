using BolaBet.Domain.Entities;
using BolaBet.Domain.Validation;
using FluentAssertions;
using System;
using Xunit;

namespace BolaBet.Domain.Tests
{
    public class ApostadorUnitTest1
    {
        [Fact]
        public void CriarApostador_ComParametrosValidos_ResultaObjetoValido()
        {
            Action action = () => new Apostador("Jackson","jackson243","123456");
            action.Should()
                 .NotThrow<DomainExceptionValidation>();
        }

        //-------------Nome
        [Fact]
        public void CriarApostador_ComNomeVazio_DomainExceptionNomeInvalido()
        {
            Action action = () => new Apostador("", "poul32", "78749");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Nome inválido. Nome é obrigatório");
        } 

        [Fact]
        public void CriarApostador_ComNomeNulo_DomainExceptionNomeInvalido()
        {
            Action action = () => new Apostador(null, "poul32", "78749");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Nome inválido. Nome é obrigatório");
        }

        [Fact]
        public void CriarApostador_ComNomeLongo_DomainExceptionNomeInvalido()
        {
            Action action = () => new Apostador("ggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg", "bigshow32", "Big230@");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Nome muito longo. É permitido no máximo 50 caracteres");
        }

        //-----------Usuário
        [Fact]
        public void CriarApostador_ComUsuarioVazio_DomainExceptionUsuarioInvalido()
        {
            Action action = () => new Apostador("john baby", "", "34545");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Usuário inválido. Usuario é obrigatório");
        }

        [Fact]
        public void CriarApostador_ComUsuarioNulo_DomainExceptionUsuarioInvalido()
        {
            Action action = () => new Apostador("joao paulo", null, "345756");
            action.Should().Throw<DomainExceptionValidation>()
                   .WithMessage("Usuário inválido. Usuario é obrigatório");
        }

        [Fact]
        public void CriarApostador_ComUsuarioLongo_DomainExceptionUsuarioInvalido()
        {
            Action action = () => new Apostador("Jacob", "gggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg", "jag268@");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Usuário muito longo. É permitido no máximo 30 caracteres");
        }

        //-----------Senha
        [Fact]
        public void CriarApostador_ComSenhaVazio_DomainExceptionSenhaInvalido()
        {
            Action action = () => new Apostador("john baby", "johnb12", "");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Senha inválido. Senha é obrigatório");
        }

        [Fact]
        public void CriarApostador_ComSenhaNulo_DomainExceptionSenhaInvalido()
        {
            Action action = () => new Apostador("joao paulo", "joao34", null);
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Senha inválido. Senha é obrigatório");
        }

        [Fact]
        public void CriarApostador_ComSenhaLongo_DomainExceptionSenhaInvalido()
        {
            Action action = () => new Apostador("Jacob", "jacob23", "ggggggggggggggggggggggggg@");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Senha muito longo. É permitido no máximo 8 caracteres");
        }


    }
}
