using PROJETOMVCB35.DAL;
using PROJETOMVCB35.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PROJETOMVCB35.BLL
{
    public class tblClienteBLL
    {
        private DALMVC bd = DALMVC.getInstance();

        public bool auth(string cpf)
        {
            string query = string.Format($@"select {tblClientesFieldsDTO.cpf} from {DALMVC.tableName} where {tblClientesFieldsDTO.cpf} = {cpf}");

            DataTable table = bd.search(query);

            return table.Rows.Count == 1;
        }
    }
}