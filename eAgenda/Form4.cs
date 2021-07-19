using System;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda
{
    public partial class Form4 : Form
    {
        private readonly ControladorTarefa controlador;

        public Form4()
        {
            InitializeComponent();

            controlador = new ControladorTarefa();

            CarregarTarefasConcluidas();
            CarregarTarefasPendentes();
        }

        private void InserirNovaTarefa()
        {
            string titulo = textBox1.Text;

            int prioridade = DefinirPrioridade(comboBox1.SelectedItem);

            controlador.InserirNovo(new Tarefa(titulo, DateTime.Now, (PrioridadeEnum)prioridade));

            CarregarTarefasPendentes();

            LimparCamposInserts();
        }

        private void CarregarTarefasPendentes()
        {
            dtTarefasPendentes.Clear();

            List<Tarefa> tarefas = controlador.SelecionarTodasTarefasPendentes();

            foreach (Tarefa tarefa in tarefas)
            {
                var camposBanco = dtTarefasPendentes.NewRow();

                camposBanco["Id"] = tarefa.Id;
                camposBanco["Titulo"] = tarefa.Titulo;
                camposBanco["Data de Criação"] = tarefa.DataCriacao.ToShortDateString();
                camposBanco["Prioridade"] = tarefa.Prioridade;
                camposBanco["Percentual"] = tarefa.Percentual;

                dtTarefasPendentes.Rows.Add(camposBanco);
            }

        }

        private void CarregarTarefasConcluidas()
        {
            dtTarefasConcluidas.Clear();

            List<Tarefa> tarefas = controlador.SelecionarTodasTarefasConcluidas();

            foreach (Tarefa tarefa in tarefas)
            {
                var camposBanco = dtTarefasConcluidas.NewRow();

                camposBanco["Id"] = tarefa.Id;
                camposBanco["Titulo"] = tarefa.Titulo;
                camposBanco["Prioridade"] = tarefa.Prioridade;
                camposBanco["Percentual"] = tarefa.Percentual;
                camposBanco["Data de Conclusão"] = ((DateTime)tarefa.DataConclusao).ToShortDateString();

                dtTarefasConcluidas.Rows.Add(camposBanco);
            }
        }
        private int DefinirPrioridade(object selectedItem)
        {
            switch (selectedItem.ToString())
            {
                case "Prioridade Alta": return 2;
                case "Prioridade Normal": return 1;
                case "Prioridade Baixa": return 0;
            }
            return 0;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            InserirNovaTarefa();
        }

        private void LimparCamposInserts()
        {
            textBox1.Clear();
            textBox2.Enabled = false;
            textBox3.Clear();
            comboBox1.ResetText();
        }

        private void EditarTarefa()
        {
            int id = Convert.ToInt32(textBox3.Text);

            Tarefa tarefaSelecionada = controlador.SelecionarPorId(id);

            int prioridadeEdicao = DefinirPrioridade(comboBox1.SelectedItem);

            Tarefa tarefa = new Tarefa(textBox1.Text, tarefaSelecionada.DataCriacao, (PrioridadeEnum)prioridadeEdicao);

            tarefa.AtualizarPercentual(Convert.ToInt32(textBox2.Text), DateTime.Now);

            controlador.Editar(id, tarefa);

            CarregarTarefasPendentes();
            CarregarTarefasConcluidas();

            LimparCamposInserts();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarTarefa();

            LimparCamposInserts();
        }

        private void ExcluirTarefa()
        {
            ControlarExclusao();

            int id = Convert.ToInt32(textBox3.Text);

            controlador.Excluir(id);

            CarregarTarefasPendentes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirTarefa();
        }

        private void ControlarExclusao()
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = true;
            comboBox1.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLiberarEditar_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;

            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void btnLiberarExcluir_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void btnLiberarInserir_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;

            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
        }
    }
}
