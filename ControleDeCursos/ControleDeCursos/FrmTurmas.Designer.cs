
namespace ControleDeCursos
{
    partial class FrmTurmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurmas));
            this.txt_codigo_turma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_data_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_data_termino = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.txt_hora_inicio = new System.Windows.Forms.TextBox();
            this.txt_hora_termino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_curso = new System.Windows.Forms.ComboBox();
            this.cbx_professor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codigo_turma
            // 
            this.txt_codigo_turma.BackColor = System.Drawing.Color.Khaki;
            this.txt_codigo_turma.Location = new System.Drawing.Point(116, 6);
            this.txt_codigo_turma.Name = "txt_codigo_turma";
            this.txt_codigo_turma.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_turma.TabIndex = 14;
            this.txt_codigo_turma.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código da Turma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data de Término:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de Início:";
            // 
            // dtp_data_inicio
            // 
            this.dtp_data_inicio.CalendarMonthBackground = System.Drawing.Color.Khaki;
            this.dtp_data_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_inicio.Location = new System.Drawing.Point(116, 40);
            this.dtp_data_inicio.Name = "dtp_data_inicio";
            this.dtp_data_inicio.Size = new System.Drawing.Size(100, 20);
            this.dtp_data_inicio.TabIndex = 15;
            // 
            // dtp_data_termino
            // 
            this.dtp_data_termino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_termino.Location = new System.Drawing.Point(347, 40);
            this.dtp_data_termino.Name = "dtp_data_termino";
            this.dtp_data_termino.Size = new System.Drawing.Size(100, 20);
            this.dtp_data_termino.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hora de Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hora de Término:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_cadastrar);
            this.panel1.Controls.Add(this.btn_alterar);
            this.panel1.Controls.Add(this.btn_listar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Location = new System.Drawing.Point(15, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 57);
            this.panel1.TabIndex = 21;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Khaki;
            this.btn_cadastrar.Location = new System.Drawing.Point(27, 13);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(90, 30);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "CADASTRAR ";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Khaki;
            this.btn_alterar.Location = new System.Drawing.Point(123, 13);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(90, 30);
            this.btn_alterar.TabIndex = 7;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.BackColor = System.Drawing.Color.Khaki;
            this.btn_listar.Location = new System.Drawing.Point(318, 13);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(90, 30);
            this.btn_listar.TabIndex = 9;
            this.btn_listar.Text = "LISTAR";
            this.btn_listar.UseVisualStyleBackColor = false;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Khaki;
            this.btn_excluir.Location = new System.Drawing.Point(222, 13);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(90, 30);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.GridColor = System.Drawing.Color.Khaki;
            this.dgv_turmas.Location = new System.Drawing.Point(15, 228);
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.Size = new System.Drawing.Size(432, 150);
            this.dgv_turmas.TabIndex = 22;
            this.dgv_turmas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick_Turmas);
            // 
            // txt_hora_inicio
            // 
            this.txt_hora_inicio.BackColor = System.Drawing.Color.Khaki;
            this.txt_hora_inicio.Location = new System.Drawing.Point(116, 78);
            this.txt_hora_inicio.Name = "txt_hora_inicio";
            this.txt_hora_inicio.Size = new System.Drawing.Size(100, 20);
            this.txt_hora_inicio.TabIndex = 23;
            // 
            // txt_hora_termino
            // 
            this.txt_hora_termino.BackColor = System.Drawing.Color.Khaki;
            this.txt_hora_termino.Location = new System.Drawing.Point(347, 78);
            this.txt_hora_termino.Name = "txt_hora_termino";
            this.txt_hora_termino.Size = new System.Drawing.Size(100, 20);
            this.txt_hora_termino.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Curso:";
            // 
            // cbx_curso
            // 
            this.cbx_curso.BackColor = System.Drawing.Color.Khaki;
            this.cbx_curso.FormattingEnabled = true;
            this.cbx_curso.Location = new System.Drawing.Point(347, 5);
            this.cbx_curso.Name = "cbx_curso";
            this.cbx_curso.Size = new System.Drawing.Size(100, 21);
            this.cbx_curso.TabIndex = 26;
            // 
            // cbx_professor
            // 
            this.cbx_professor.BackColor = System.Drawing.Color.Khaki;
            this.cbx_professor.FormattingEnabled = true;
            this.cbx_professor.Location = new System.Drawing.Point(116, 114);
            this.cbx_professor.Name = "cbx_professor";
            this.cbx_professor.Size = new System.Drawing.Size(100, 21);
            this.cbx_professor.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Professor(a):";
            // 
            // FrmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(460, 394);
            this.Controls.Add(this.cbx_professor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_curso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_hora_termino);
            this.Controls.Add(this.txt_hora_inicio);
            this.Controls.Add(this.dgv_turmas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_data_termino);
            this.Controls.Add(this.dtp_data_inicio);
            this.Controls.Add(this.txt_codigo_turma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TURMAS";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codigo_turma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_data_inicio;
        private System.Windows.Forms.DateTimePicker dtp_data_termino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.TextBox txt_hora_inicio;
        private System.Windows.Forms.TextBox txt_hora_termino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_curso;
        private System.Windows.Forms.ComboBox cbx_professor;
        private System.Windows.Forms.Label label7;
    }
}