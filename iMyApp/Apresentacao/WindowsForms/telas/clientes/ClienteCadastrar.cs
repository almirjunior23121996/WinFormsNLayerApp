﻿using Negocio.Comum;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.telas.clientes
{
    public partial class ClienteCadastrar : Form
    {
        public ClienteCadastrar()
        {
            InitializeComponent();

            var cliente = new Cliente();
           
            var colaborador = new Colaborador();


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Cpf = txtCpf.Text;
            cliente.Nome = txtNomeCompleto.Text;
          

        }
    }
}
