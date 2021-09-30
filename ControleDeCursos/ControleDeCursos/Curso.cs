using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControleDeCursos
{
    class Curso
    {
        public int codigoCurso, cargaHoraria;
        public string nomeCurso, conteudoProgramatico;
        public double valorMensalidade;
        public string tabela = "curso";

        Conexao obj = new Conexao();
        public void CadastrarCurso()
        {
            string insert = $"insert into {tabela} values (null,'{nomeCurso}','{conteudoProgramatico}',{valorMensalidade},{cargaHoraria})";
            obj.ExecutarComando(insert);
        }

        public void AlterarCurso()
        {
            string update = $@"update {tabela} set nome = '{nomeCurso}', conteudo_programatico = '{conteudoProgramatico}', valor_mensalidade = {valorMensalidade}, 
            carga_horaria = {cargaHoraria} where id = '{codigoCurso}'";
            obj.ExecutarComando(update);

        }

        public void ExcluirCurso()
        {
            string delete = $"delete from {tabela} where id = {codigoCurso}";
            obj.ExecutarComando(delete);
        }

        public DataTable ListarCursos()     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela}";
            return obj.ExecutarConsulta(sql);
        }
    }
}
