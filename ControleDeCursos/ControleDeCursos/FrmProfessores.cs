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
    public partial class frm_professores : Form
    {
        Conexao obj_conexao = new Conexao();
        Professor obj_professor = new Professor();
        public frm_professores()
        {
            
            InitializeComponent();
            dgv_professores.DataSource = obj_professor.ListarProfessores();
            txt_codigo.Enabled = false;
            txt_codigo.Text = "0";
        }

        public void preencheCampos()
        {
            obj_conexao.Conectar();
            obj_professor.id = int.Parse(txt_codigo.Text);
            obj_professor.nome = txt_nome.Text;
            obj_professor.valorAula = txt_valor_aula.Text.Replace(',', '.');
            obj_professor.telefone = txt_telefone.Text;
        }
        private void limpaCampos()
        {
            txt_codigo.Text = "0";
            txt_nome.Clear();
            txt_valor_aula.Clear();
            txt_telefone.Clear();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            preencheCampos();
            obj_professor.CadastrarProfessor();
            MessageBox.Show("Registro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
            dgv_professores.DataSource = obj_professor.ListarProfessores();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            preencheCampos();
            obj_professor.AlterarProfessor();
            MessageBox.Show("Registro Alterardo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
            dgv_professores.DataSource = obj_professor.ListarProfessores();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString() == "Yes")
            {
                preencheCampos();
                obj_professor.ExcluirProfessor();
                MessageBox.Show("Registro Removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampos();
                dgv_professores.DataSource = obj_professor.ListarProfessores();
            }
        }

        private void dgv_professores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_professores.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
            {
                txt_codigo.Text = "0";
            }
            else
            {
                txt_codigo.Text = dgv_professores.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            txt_codigo.Text = dgv_professores.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_professores.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_valor_aula.Text = dgv_professores.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_telefone.Text = dgv_professores.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dgv_professores.DataSource = obj_professor.ListarProfessores();
        }
    }
}
