using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eAgenda.Forms
{
    public partial class Form4 : Form
    {
        Tarefa tarefa;
        private readonly ControladorTarefa controlador;

        public Form4()
        {
            InitializeComponent();
            controlador = new ControladorTarefa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sair
            MessageBox.Show("Programa Finalizado!");
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            tarefa = new Tarefa(textBox1.Text, DateTime.Now,(PrioridadeEnum)comboBox1.SelectedIndex);

            string resultadoValidacao = controlador.InserirNovo(tarefa);
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                MessageBox.Show("Tarefa inserida com sucesso");
                Dispose();
            }
            else
                MessageBox.Show(resultadoValidacao);
        }
    }
}
