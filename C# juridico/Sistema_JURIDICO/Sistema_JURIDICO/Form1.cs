using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_JURIDICO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Server=.\SENAI2022; Database=BDJURIDICO; User Id =sa; Password=senai.123;");

            conexao.Open();

            var sql = "SELECT * FROM ESTADO";
            var dados = conexao.Query<ESTADO>(sql).ToList();

            foreach (var item in dados)
            {
                listView1.Items.Add(intem.ESTID + " | " + intem.ESTDESCRICAO + " | " + intem.ESTSIGLA);
            }
        }
    }
}
