using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.VideoJuegos.Formularios
{
    public partial class CR_FR_ProductoC : Form
    {
        public CR_FR_ProductoC()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CR_PC _Rpt = new CR_PC();

            var reporte = new ReporteProductosPorConsola();


            _Rpt.SetDataSource(reporte.ObtenerDatosParaReporte());

            crystalReportViewer1.ReportSource = _Rpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
