using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PROJETOMVCB35.DAL
{
    public class DALMVC
    {
        private const string conString = "Persist Security info=false ; server=localhost; database=ProjetoMVCB35 ;user=root ;pwd=;";
        public static string tableName = "tbl_clienteB35";
        MySqlConnection con;

        //start singleton
        private DALMVC() { }

        private static DALMVC _instance;

        public static DALMVC getInstance()
        {
            return _instance == null ? _instance = new DALMVC() : _instance;
        }
        //end singleton

        //start connection to database
        public void connect()
        {
            try
            {
                con = new MySqlConnection(conString);
                con.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception(string.Format($@"Erro ao conectar ao banco de dados \n error: {e.Message}"));
            }
        }
        //end connection to database

        //start search for a data
        public DataTable search(string query)
        {
            try
            {
                connect();
                DataTable table = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(query, con);
                dados.Fill(table);
                return table;
            }
            catch (MySqlException e)
            {
                throw new Exception(string.Format($@"Erro ao executar comando no banco de dados \n error: {e.Message}"));
            }
            finally
            {
                con.Close();
            }
        }
        //end search for a data



    }
}