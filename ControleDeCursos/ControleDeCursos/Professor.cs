using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControleDeCursos
{
    class Professor
    {
        public int id;
        public string nome, telefone, valorAula, tabela = "professor";


        Conexao obj_conexao = new Conexao();

        public void CadastrarProfessor()
        {
            string insert = $"insert into {tabela} values (null,'{nome}',{valorAula},'{telefone}')";
            obj_conexao.ExecutarComando(insert);
        }

        public void AlterarProfessor()
        {
            string update = $@"update {tabela} set nome = '{nome}', valor_aula = {valorAula}, telefone = '{telefone}' where id = {id}";
            obj_conexao.ExecutarComando(update);

        }

        public void ExcluirProfessor()
        {
            string delete = $"delete from {tabela} where id = {id}";
            obj_conexao.ExecutarComando(delete);
        }

        public DataTable ListarProfessores()     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela}";
            return obj_conexao.ExecutarConsulta(sql);
        }
    }
}
