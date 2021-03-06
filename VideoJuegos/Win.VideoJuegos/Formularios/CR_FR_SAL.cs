﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.VideoJuegos;
namespace Win.VideoJuegos.Formularios
{
    public partial class CR_FR_SAL : Form
    {
        public CR_FR_SAL()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            VideoJuegosBL db = new VideoJuegosBL();
            BindingSource bs = new BindingSource();
            bs.DataSource = db.ObtenerListadoRenta();

            CR_Salida rpt = new CR_Salida();
            rpt.SetDataSource(bs);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
