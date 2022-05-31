using System;
using System.Windows.Forms;

using FastReport;
//using HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago;
using FastReport.Utils;

namespace ProyectoLoboSostenido
{
    public partial class FrmFRVisor : Form
    {
        public FastReport.Report frReporte;
        public FrmFRVisor(//parametro
                          )
        {
            InitializeComponent();
        }

        private void FrmFRVisor_Load(object sender, EventArgs e)
        {
            //try
            //{
            //frReporte = new FastReport.Report();
            //frReporte.Preview = FRpvwControl;
            //frReporte = new FastReport.Report();
            //    // frReporte.Preview = FRpvwControl;

            if (Clase_Sesion.Rol == "15" || Clase_Sesion.Rol == "14")
            {
                FastReport.EnvironmentSettings fsetting = new FastReport.EnvironmentSettings();
                fsetting.PreviewSettings.Buttons = PreviewButtons.All;

            }

            else if (Clase_Sesion.Rol == "7" || Clase_Sesion.Rol == "8" || Clase_Sesion.IDEmpleado == "016047001")
            { 
                    FastReport.EnvironmentSettings fsetting = new FastReport.EnvironmentSettings();
                    fsetting.PreviewSettings.Buttons = PreviewButtons.Print | PreviewButtons.Close | PreviewButtons.Find | PreviewButtons.Zoom | PreviewButtons.Navigator | PreviewButtons.Save;
            }
            else
            {
                FastReport.EnvironmentSettings fsetting = new FastReport.EnvironmentSettings();
                fsetting.PreviewSettings.Buttons = PreviewButtons.Print | PreviewButtons.Save;//| PreviewButtons.Close | PreviewButtons.Find | PreviewButtons.Zoom | PreviewButtons.Navigator |

                //if (Clase_Sesion.Rol == "7" || Clase_Sesion.Rol == "8")
                //{
                //    fsetting.PreviewSettings.Buttons = PreviewButtons.Print | PreviewButtons.Close | PreviewButtons.Find | PreviewButtons.Zoom | PreviewButtons.Navigator | PreviewButtons.Save;
                //}
                //else
                //{
                //    fsetting.PreviewSettings.Buttons = PreviewButtons.Print | PreviewButtons.Close | PreviewButtons.Find | PreviewButtons.Zoom | PreviewButtons.Navigator;
                //}

            }








            frReporte.Show();

        }
    }
}
