using System;
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
    public partial class CR_FR_Clientes : Form
    {
        public CR_FR_Clientes()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            VideoJuegosBL db = new VideoJuegosBL();
            BindingSource bs = new BindingSource();
            bs.DataSource = db.ObtenerClientesLista();

            CR_Clientes rpt = new CR_Clientes();
            rpt.SetDataSource(bs);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
