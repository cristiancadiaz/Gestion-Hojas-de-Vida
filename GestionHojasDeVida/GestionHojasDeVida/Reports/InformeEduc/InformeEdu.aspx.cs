﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionHojasDeVida.Reports
{
    public partial class InformeEdu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            SqlDataSource1.DataBind();
            ReportViewer1.LocalReport.Refresh();
        }
    }
}