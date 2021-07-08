using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using eAgenda.Controladores.ContatoModule;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {
        ControladorCompromisso controladorCompromisso = null;
        ControladorContato controladorContato = null;

        public ControladorCompromissoTest()
        {
            controladorCompromisso = new ControladorCompromisso();
            controladorContato = new ControladorContato();
            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");
        }

        [TestMethod]
        public void DeveInserir_Compromisso()
        {
            Contato contato = new Contato("Ruan", "ruan@academia.com", "32213434", "Ruan S/A", "CEO");
            controladorContato.InserirNovo(contato);

            Compromisso compromisso = new Compromisso("Reuniao Emergencia", "Sala Quatorze", "Não existe Link", DateTime.Today,
                new TimeSpan(2, 12, 15), new TimeSpan(3, 12, 15), contato);

            //action
            controladorCompromisso.InserirNovo(compromisso);

            //assert
            var compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrado.Should().Be(compromisso);
        }

        [TestMethod]
        public void DeveSelecionar_Compromisso_PorId()
        {
            //arrange
            var compromisso = new Compromisso("Reuniao Top", "Dallas Park", "Não existe Link", DateTime.Today, new TimeSpan(4, 14, 18), new TimeSpan(5, 14, 18), null);
            controladorCompromisso.InserirNovo(compromisso);

            //action
            Compromisso compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);

            //assert
            compromissoEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveExcluir_Compromisso()
        {
            //arrange            
            var compromisso = new Compromisso("Reuniao Emergencia", "Sala Quatorze", "Não existe Link", DateTime.Today, new TimeSpan(4, 14, 18), new TimeSpan(5, 14, 18), null);
            controladorCompromisso.InserirNovo(compromisso);

            //action            
            controladorCompromisso.Excluir(compromisso.Id);

            //assert
            Compromisso compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosCompromissos()
        {
            //arrange
            var c1 = new Compromisso("Reuniao Emergencia", "Sala Quatorze", "Não existe Link", DateTime.Today, new TimeSpan(4, 14, 18), new TimeSpan(5, 14, 18), null);
            controladorCompromisso.InserirNovo(c1);

            var c2 = new Compromisso("Reuniao Normal", "Sala Dez", "Não existe Link", DateTime.Today, new TimeSpan(4, 10, 10), new TimeSpan(5, 10, 15), null);
            controladorCompromisso.InserirNovo(c2);

            var c3 = new Compromisso("Reuniao Baixa", "Sala Oito", "Não existe Link", DateTime.Today, new TimeSpan(7, 15, 10), new TimeSpan(8, 16, 15), null);
            controladorCompromisso.InserirNovo(c3);

            //action
            var compromissos = controladorCompromisso.SelecionarTodos();

            //assert
            compromissos.Should().HaveCount(3);
            compromissos[0].Assunto.Should().Be("Reuniao Emergencia");
            compromissos[1].Assunto.Should().Be("Reuniao Normal");
            compromissos[2].Assunto.Should().Be("Reuniao Baixa");
        }

        [TestMethod]
        public void DeveSelecionar_Compromissos_Passado()
        {
            //arrange
            var c1 = new Compromisso("Reuniao Emergencial", "Sala Quatorze", "Não existe Link", new DateTime(2020, 10, 10), new TimeSpan(4, 14, 18), new TimeSpan(5, 14, 18), null);
            controladorCompromisso.InserirNovo(c1);

            var c2 = new Compromisso("Reuniao Normal", "Sala Dez", "Não existe Link", new DateTime(2020, 10, 11), new TimeSpan(4, 10, 10), new TimeSpan(5, 10, 15), null);
            controladorCompromisso.InserirNovo(c2);

            var c3 = new Compromisso("Reuniao Sistema", "Sala Oito", "Não existe Link", new DateTime(2020, 10, 12), new TimeSpan(7, 15, 10), new TimeSpan(8, 16, 15), null);
            controladorCompromisso.InserirNovo(c3);

            //action
            var compromissos = controladorCompromisso.SelecionarTodos();

            //assert
            compromissos.Should().HaveCount(3);
            compromissos[0].Data.Should().Be(new DateTime(2020, 10, 10));
            compromissos[1].Data.Should().Be(new DateTime(2020, 10, 11));
            compromissos[2].Data.Should().Be(new DateTime(2020, 10, 12));
        }

        [TestMethod]
        public void DeveSelecionar_Compromissos_Futuros()
        {
            //arrange
            var c1 = new Compromisso("Reuniao Emergencial", "Sala Quatorze", "Não existe Link", new DateTime(2021, 10, 10), new TimeSpan(4, 14, 18), new TimeSpan(5, 14, 18), null);
            controladorCompromisso.InserirNovo(c1);

            var c2 = new Compromisso("Reuniao Normal", "Sala Dez", "Não existe Link", new DateTime(2021, 10, 11), new TimeSpan(4, 10, 10), new TimeSpan(5, 10, 15), null);
            controladorCompromisso.InserirNovo(c2);

            var c3 = new Compromisso("Reuniao Sistema", "Sala Oito", "Não existe Link", new DateTime(2021, 10, 12), new TimeSpan(7, 15, 10), new TimeSpan(8, 16, 15), null);
            controladorCompromisso.InserirNovo(c3);

            //action
            var compromissos = controladorCompromisso.SelecionarTodos();

            //assert
            compromissos.Should().HaveCount(3);
            compromissos[0].Data.Should().Be(new DateTime(2021, 10, 10));
            compromissos[1].Data.Should().Be(new DateTime(2021, 10, 11));
            compromissos[2].Data.Should().Be(new DateTime(2021, 10, 12));
        }

        [TestMethod]
        public void DeveVerificar_Mesma_HoraTermino()
        {
            Compromisso compromisso = new Compromisso("Validar teste", "Academia", "", DateTime.Today,
                new TimeSpan(17, 00, 00), new TimeSpan(18, 00, 00), null);

            controladorCompromisso.InserirNovo(compromisso);

            Compromisso novoCompromisso = new Compromisso("Validar teste dois", "Academia ndd", "", DateTime.Today,
                new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);

            controladorCompromisso.InserirNovo(novoCompromisso);

            var compromissos = controladorCompromisso.SelecionarTodos();
            compromissos.Should().HaveCount(2);
        }
    }
}
