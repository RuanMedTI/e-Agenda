using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace eAgenda
{
    public partial class Form2 : Form
    {
        private readonly ControladorCompromisso controlador;
        private readonly ControladorContato controladorContato;

        private List<Contato> contatos;

        public Form2()
        {
            InitializeComponent();

            controlador = new ControladorCompromisso();
            controladorContato = new ControladorContato();

            contatos = controladorContato.SelecionarTodos();

            CarregarCompromissos();
        }

        private void InserirNovoCompromisso()
        {
            string assunto = txtAssunto.Text;

            string local = txtLocal.Text;

            string link = txtLocal.Text;

            DateTime data = dtDataCompromisso.Value;

            TimeSpan horaInicio = TimeSpan.Parse(txtHoraInicio.Text);

            TimeSpan horaTermino = TimeSpan.Parse(txtHoraTermino.Text);

            Contato contato = contatos.Find(c => c.Nome == (string)cmbContatos.SelectedItem);

            controlador.InserirNovo(new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato));

            CarregarCompromissos();

            LimparCamposInserts();
        }

        private void CarregarCompromissos()
        {
            dtCompromissos.Clear();

            List<Compromisso> compromissos = controlador.SelecionarTodos();

            foreach (Compromisso compromisso in compromissos)
            {
                var camposBanco = dtCompromissos.NewRow();

                camposBanco["Id"] = compromisso.Id;
                camposBanco["Assunto"] = compromisso.Assunto;
                camposBanco["Local"] = compromisso.Local;
                camposBanco["Data"] = compromisso.Data.ToShortDateString();
                camposBanco["Inicio"] = compromisso.HoraInicio;
                camposBanco["Termino"] = compromisso.HoraTermino;
                camposBanco["Contato"] = (compromisso.Contato != null) ? compromisso.Contato.Nome : null;

                dtCompromissos.Rows.Add(camposBanco);

                PopulandoComboBoxContatos();
            }
        }

        private void LimparCamposInserts()
        {
            txtIdCompromisso.Clear();
            txtAssunto.Clear();
            txtLocal.Clear();
            txtHoraInicio.Clear();
            txtHoraTermino.Clear();
            cmbContatos.ResetText();
        }

        private void PopulandoComboBoxContatos()
        {
            foreach (Contato contato in contatos)
            {
                cmbContatos.Items.Add(contato.Nome);
            }
        }

        private void EditarCompromisso()
        {
            int id = Convert.ToInt32(txtIdCompromisso.Text);

            string assunto = txtAssunto.Text;

            string local = txtLocal.Text;

            string link = txtLocal.Text;

            DateTime data = dtDataCompromisso.Value;

            TimeSpan horaInicio = TimeSpan.Parse(txtHoraInicio.Text);

            TimeSpan horaTermino = TimeSpan.Parse(txtHoraTermino.Text);

            Contato contato = contatos.Find(contatoSelect => contatoSelect.Nome == (string)cmbContatos.SelectedItem);

            Compromisso compromissoEdit = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);

            controlador.Editar(id, compromissoEdit);

            CarregarCompromissos();

            LimparCamposInserts();
        }

        private void ExcluirCompromisso()
        {

            int id = Convert.ToInt32(txtIdCompromisso.Text);

            controlador.Excluir(id);

            CarregarCompromissos();
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            txtIdCompromisso.ReadOnly = true;

            txtAssunto.ReadOnly = false;
            txtLocal.ReadOnly = false;
            dtDataCompromisso.Enabled = true;
            txtHoraInicio.ReadOnly = false;
            txtHoraTermino.ReadOnly = false;
            cmbContatos.Enabled = true;
        }

        private void btnLiberarEditar_Click(object sender, EventArgs e)
        {
            txtIdCompromisso.ReadOnly = false;

            txtAssunto.ReadOnly = false;
            txtLocal.ReadOnly = false;
            dtDataCompromisso.Enabled = true;
            txtHoraInicio.ReadOnly = false;
            txtHoraTermino.ReadOnly = false;
            cmbContatos.Enabled = true;
        }

        private void btnLiberarExcluir_Click(object sender, EventArgs e)
        {
            txtIdCompromisso.ReadOnly = false;

            txtAssunto.ReadOnly = true;
            txtLocal.ReadOnly = true;
            dtDataCompromisso.Enabled = false;
            txtHoraInicio.ReadOnly = true;
            txtHoraTermino.ReadOnly = true;
            cmbContatos.Enabled = false;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInserirCompromisso_Click(object sender, EventArgs e)
        {
            InserirNovoCompromisso();

            LimparCamposInserts();
        }

        private void btnExcluirCompromisso_Click(object sender, EventArgs e)
        {
            ExcluirCompromisso();

            LimparCamposInserts();
        }

        private void btnEditarCompromisso_Click(object sender, EventArgs e)
        {
            EditarCompromisso();

            LimparCamposInserts();
        }
    }
}
