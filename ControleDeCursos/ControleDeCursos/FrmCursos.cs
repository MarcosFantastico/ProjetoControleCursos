using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class FrmCursos : Form
    {
        Conexao obj_conexao = new Conexao();
        Curso obj_curso = new Curso();
        public FrmCursos()
        {
            InitializeComponent();
            dtgCursos.DataSource = obj_curso.ListarCursos();
        }

        public void limpaCampos()
        {
            txtNomeCurso.Clear();
            txtConteudo.Clear();
            txtValorMensalidade.Clear();
            txtValorMensalidade.Clear();
            txtCargaHoraria.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        { 
            obj_conexao.Conectar();
            obj_curso.nomeCurso = txtNomeCurso.Text;
            obj_curso.conteudoProgramatico = txtConteudo.Text;
            obj_curso.valorMensalidade = double.Parse(txtValorMensalidade.Text);
            obj_curso.cargaHoraria = int.Parse(txtCargaHoraria.Text);
            obj_curso.CadastrarCurso();
            MessageBox.Show("Registro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
            dtgCursos.DataSource = obj_curso.ListarCursos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            obj_conexao.Conectar();
            obj_curso.codigoCurso = int.Parse(txtCodigo.Text);
            obj_curso.nomeCurso = txtNomeCurso.Text;
            obj_curso.conteudoProgramatico = txtConteudo.Text;
            obj_curso.valorMensalidade = double.Parse(txtValorMensalidade.Text);
            obj_curso.cargaHoraria = int.Parse(txtCargaHoraria.Text);
            obj_curso.AlterarCurso();
            MessageBox.Show("Registro alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgCursos.DataSource = obj_curso.ListarCursos();
        }

        private void dgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // carregar nos txt o valor selecionado no grid
            txtCodigo.Text = dtgCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeCurso.Text = dtgCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtConteudo.Text = dtgCursos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValorMensalidade.Text = dtgCursos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCargaHoraria.Text = dtgCursos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            obj_conexao.Conectar();
            obj_curso.codigoCurso = int.Parse(txtCodigo.Text);
            obj_curso.nomeCurso = txtNomeCurso.Text;
            obj_curso.conteudoProgramatico = txtConteudo.Text;
            obj_curso.valorMensalidade = double.Parse(txtValorMensalidade.Text);
            obj_curso.cargaHoraria = int.Parse(txtCargaHoraria.Text);
            obj_curso.ExcluirCurso();
            MessageBox.Show("Registro removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
            dtgCursos.DataSource = obj_curso.ListarCursos();
        }
    }
}
