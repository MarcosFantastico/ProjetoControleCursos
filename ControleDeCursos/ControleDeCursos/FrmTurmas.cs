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
    public partial class FrmTurmas : Form
    {
        Turma obj_turma = new Turma();
        Curso obj_curso = new Curso();
        Professor obj_professor = new Professor();
        Conexao obj_conexao = new Conexao();
        public FrmTurmas()
        {
            InitializeComponent();
            txt_codigo_turma.Enabled = false;
            dgv_turmas.DataSource = obj_turma.ListarTurma();

            cbx_curso.DataSource = obj_curso.ListarCursos();
            cbx_curso.ValueMember = "id";
            cbx_curso.DisplayMember = "nome";

            cbx_professor.DataSource = obj_professor.ListarProfessores();
            cbx_professor.ValueMember = "id";
            cbx_professor.DisplayMember = "nome";
        }

        public void preencheCampos()
        {
            obj_conexao.Conectar();
            obj_turma.id = int.Parse(txt_codigo_turma.Text);
            obj_turma.data_inicio = dtp_data_inicio.Text;
            obj_turma.data_termino = dtp_data_termino.Text;
            obj_turma.hora_inicio = txt_hora_inicio.Text;
            obj_turma.hora_termino = txt_hora_termino.Text;
            obj_turma.cursoid = cbx_curso.SelectedIndex+1;
            obj_turma.professorid = cbx_professor.SelectedIndex+1;
        }
        private void limpaCampos()
        {
            txt_codigo_turma.Text = "0";
            //dtp_data_inicio.Text = " ";
            //dtp_data_termino.Text = " ";
            txt_hora_inicio.Clear();
            txt_hora_termino.Clear();
            cbx_curso.Text = " ";
            cbx_professor.Text = " ";
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            preencheCampos();
            obj_turma.CadastrarTurma();
            MessageBox.Show("Registro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
            dgv_turmas.DataSource = obj_turma.ListarTurma();
        }

        private void CellClick_Turmas(object sender, DataGridViewCellEventArgs e)
        {
          
            if(dgv_turmas.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
            {
                txt_codigo_turma.Text = "0";
            }
            else
            {
                txt_codigo_turma.Text = dgv_turmas.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            
            dtp_data_inicio.Text = dgv_turmas.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtp_data_termino.Text = dgv_turmas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_hora_inicio.Text = dgv_turmas.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_hora_termino.Text = dgv_turmas.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbx_curso.Text = dgv_turmas.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbx_professor.Text = dgv_turmas.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            preencheCampos();
            obj_turma.AlterarTurma();
            MessageBox.Show("Registro alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
            dgv_turmas.DataSource = obj_turma.ListarTurma();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            

            if(MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString() == "Yes")
            {
                
                preencheCampos();
                obj_turma.ExcluirTurma();
                MessageBox.Show("Registro excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals("Yes");
                limpaCampos();
                dgv_turmas.DataSource = obj_turma.ListarTurma();
            }
            

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dgv_turmas.DataSource = obj_turma.ListarTurma();
        }
    }
}
