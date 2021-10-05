using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ControleDeCursos
{
    class Turma
    {
        public int id, cursoid, professorid;
        public string data_inicio, data_termino, hora_inicio, hora_termino, tabela = "turma";

        Conexao obj_conexao = new Conexao();

        public void CadastrarTurma()
        {
            string insert = $"insert into {tabela} values (null,'{data_inicio}','{data_termino}','{hora_inicio}','{hora_termino}', {cursoid}, {professorid})";
            obj_conexao.ExecutarComando(insert);
        }

        public void AlterarTurma()
        {
            string update = $@"update {tabela} set data_inicio = '{data_inicio}', data_termino = '{data_termino}', hora_inicio = '{hora_inicio}', hora_termino = '{hora_termino}',
            cursoid = {cursoid}, professorid = {professorid} where id = {id}";
            obj_conexao.ExecutarComando(update);

        }

        public void ExcluirTurma()
        {
            string delete = $"delete from {tabela} where id = {id}";
            obj_conexao.ExecutarComando(delete);
        }

        public DataTable ListarTurma()     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela}";
            return obj_conexao.ExecutarConsulta(sql);
        }
    }
}
