using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace RisoOdonto.UI.utilitarios
{
    public class Limpar
    {
        public static void ClearControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c is Label)
                {
                    ((Label)c).Text = string.Empty;
                }
                else if (c is DropDownList)
                {
                    ((DropDownList)c).ClearSelection();
                }
                else if (c is RadioButtonList)
                {
                    ((RadioButtonList)c).ClearSelection();
                }
                ClearControl(c);

            }
        }
    }
}