using PROJETOMVCB35.BLL;
using PROJETOMVCB35.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJETOMVCB35.UI
{
    public partial class Frmindex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                tblClienteDTO client = new tblClienteDTO(txtCpfB35.Text, txtNomeB35.Text, "sobrenome", "email@email", "senha", txtNomeMaeB35.Text);
                tblClienteBLL clientBll = new tblClienteBLL();
                if (clientBll.auth(client.Cpf))
                {
                    lblError.Visible = true;
                    lblError.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";

                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                }
            }
            catch (Exception erro)
            {
                lblError.Visible = true;
                lblError.Text = erro.Message;
            }

        }
    }
}