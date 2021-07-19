using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace eAgenda
{
    public partial class Form3 : Form
    {
        private readonly ControladorContato controlador;

        public Form3()
        {
            InitializeComponent();

            controlador = new ControladorContato();

            CarregarContatos();
        }

        private void InserirNovoContato()
        {
            string nome = txtNome.Text;

            string email = txtEmail.Text;

            string telefone = txtTelefone.Text;

            string empresa = txtEmpresa.Text;

            string cargo = txtCargo.Text;

            controlador.InserirNovo(new Contato(nome, email, telefone, empresa, cargo));

            CarregarContatos();

            LimparCamposInserts();
        }

        private void CarregarContatos()
        {
            dtContatos.Clear();

            List<Contato> contatos = controlador.SelecionarTodos();

            foreach (Contato contato in contatos)
            {
                var camposBanco = dtContatos.NewRow();

                camposBanco["Id"] = contato.Id;
                camposBanco["Nome"] = contato.Nome;
                camposBanco["Email"] = contato.Email;
                camposBanco["Telefone"] = contato.Telefone;
                camposBanco["Empresa"] = contato.Empresa;
                camposBanco["Cargo"] = contato.Cargo;

                dtContatos.Rows.Add(camposBanco);
            }

        }

        private void LimparCamposInserts()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtEmpresa.Clear();
            txtCargo.Clear();
        }

        private void EditarContato()
        {
            int id = Convert.ToInt32(txtId.Text);

            Contato contato = new Contato(txtNome.Text, txtEmail.Text, txtTelefone.Text,
                txtEmpresa.Text, txtCargo.Text);

            controlador.Editar(id, contato);

            CarregarContatos();

            LimparCamposInserts();
        }

        private void ExcluirContato()
        {

            int id = Convert.ToInt32(txtId.Text);

            controlador.Excluir(id);

            CarregarContatos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            InserirNovoContato();

            LimparCamposInserts();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirContato();

            LimparCamposInserts();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarContato();

            LimparCamposInserts();
        }

        private void btnLiberarInsert_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;

            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtEmpresa.ReadOnly = false;
            txtCargo.ReadOnly = false;
            txtTelefone.ReadOnly = false;
        }

        private void btnLiberarExcluir_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtEmpresa.ReadOnly = true;
            txtCargo.ReadOnly = true;
            txtTelefone.ReadOnly = true;

            txtId.ReadOnly = false;
        }

        private void btnLiberarEdit_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;

            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtEmpresa.ReadOnly = false;
            txtCargo.ReadOnly = false;
            txtTelefone.ReadOnly = false;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '+' || e.KeyChar == '-') return;
            if (e.KeyChar == 8) return;
            e.Handled = true;
        }
    }
}
