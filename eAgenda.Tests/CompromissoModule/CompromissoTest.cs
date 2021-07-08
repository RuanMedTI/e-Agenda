using Microsoft.VisualStudio.TestTools.UnitTesting;
using eAgenda.Dominio.CompromissoModule;
using FluentAssertions;
using System;

namespace eAgenda.Tests.CompromissoModule
{
    
    [TestClass]
    public class CompromissoTest
    {
        [TestMethod]
        public void DeveCriar_Compromisso()
        {
            //action
            Compromisso compromisso = new Compromisso("Reunião novo Produto", "Sala Dois", "Não existe Link", DateTime.Today, new TimeSpan (6,15,10), new TimeSpan (7,15,10), null);

            //assert
            compromisso.Data.Should().Be(DateTime.Today.Date);
        }

        [TestMethod]
        public void DeveValidar_Assunto()
        {
            //arrange
            var compromisso = new Compromisso("", "Sala Dois", "Não existe Link", DateTime.Today, new TimeSpan(6, 15, 10), new TimeSpan(7, 15, 10), null);

            //action
            var resultado = compromisso.Validar();

            //assert
            resultado.Should().Be("O campo Assunto é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Local()
        {
            //arrange
            var compromisso = new Compromisso("Reuniao", "", "Não existe Link", DateTime.Today, new TimeSpan(6, 15, 10), new TimeSpan(7, 15, 10), null);

            //action
            var resultado = compromisso.Validar();

            //assert
            resultado.Should().Be("O campo Local é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Data()
        {
            //arrange
            var compromisso = new Compromisso("Reuniao", "Cafe", "Não existe Link", DateTime.MinValue, new TimeSpan(6, 15, 10), new TimeSpan(7, 15, 10), null);

            //action
            var resultado = compromisso.Validar();

            //assert
            resultado.Should().Be("O campo Data é obrigatório");
        }


    }
}
