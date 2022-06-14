using ProyectoLoboSostenido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewReportesControlEscolar
{
    public partial class FrmAdministrarParametrosRCE : Form
    {
        Clase_Reportes parametros;
        Keys LastKeyPressed;

        int posicioncuandoescribe = 0;
        private int rowIndex = 0;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Console.WriteLine("ProcessCmdKey <- Enter");

            
            if (CellIsBeingEdited)
            {
                Console.WriteLine(posicioncuandoescribe);
                posicioncuandoescribe = DGV_parametros.CurrentCell.RowIndex;
                if (keyData == Keys.Enter ||
                    keyData == Keys.Right ||
                    keyData == Keys.Left ||
                    keyData == Keys.Up ||
                    keyData == Keys.Down ||
                    keyData == Keys.Tab)
                {
                    string nombre = DGV_parametros.CurrentCell.EditedFormattedValue.ToString();   
                    if (modoinser)
                    { 
                        if (MessageBox.Show("Esta seguro de ingresar este nuevo Registro?","Confirmacion",MessageBoxButtons.YesNo)==DialogResult.Yes)
                        {
                            Clase_Reportes clase_Reportes = new Clase_Reportes();
                           // clase_Reportes.ParametrosReportes("1", "", "", "");
                        }
                        else
                        {
                            DGV_parametros.Rows.RemoveAt(posicioncuandoescribe);
                            modoinser = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Cell Edit mode Keypress > " + keyData);
                    // do any checking here for invalid keys pressed
                    // example if you wanted to allow only numeric keys to be pressed in a column of int cells
                    // simply check if the key is numeric and if not ignore it...
                    //if (!char.IsDigit(((char)keyData))) {
                    //  return true;
                    //}
                }
                LastKeyPressed = keyData;
            }
            //Console.WriteLine("ProcessCmdKey -> Leave");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public FrmAdministrarParametrosRCE()
        {
            InitializeComponent();
            parametros = new Clase_Reportes();
            llenadoListaParametros();

            DGV_parametros.Columns[0].ReadOnly = true;
            DGV_parametros.Columns[2].ReadOnly = true;

            DGV_parametros.CellEndEdit += new DataGridViewCellEventHandler(DGV_parametros_CellEndEdit);
            DGV_parametros.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DGV_parametros_EditingControlShowing);

            label1.Text = DGV_parametros.Rows.Count.ToString();
            modoinser = false;
        }

        public void llenadoListaParametros()
        {
            parametros.MostrarParametros();
            DGV_parametros.DataSource = parametros.Lector.Tables[0];
        }

        private void DGV_parametros_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }

        private void button1_Click(object sender2, EventArgs ee)
        {
            DGV_parametros.RowsAdded += (sender, e) =>
            {
                

                    if (MessageBox.Show("Estas Seguro de Agregar este Parametro", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Console.WriteLine(e.RowIndex);
                    }
                    else try
                        {
                            DGV_parametros.Rows.RemoveAt(e.RowIndex);
                        }
                        catch (System.InvalidOperationException x)
                        { MessageBox.Show(""); }
                 
                //   this.DGV_parametros.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_parametros_RowsAdded);
            };
        }

        private void DGV_parametros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (DGV_parametros.CurrentCell.IsInEditMode == true)
            //{
            //    int i = DGV_parametros.CurrentRow.Index;
            //    button1.Text = i.ToString();
            //    // MessageBox.Show(i.ToString());
            //}
        }

        private void DGV_parametros_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyData == Keys.Enter && DGV_parametros.BeginEdit(false) ==true)
            //{
            //    e.SuppressKeyPress = true;
            //    int row = DGV_parametros.CurrentRow.Index;
            //    int col = DGV_parametros.CurrentCell.ColumnIndex;
            //    MessageBox.Show("presiono enter");
            //}
        }

        private void DGV_parametros_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //e.KeyCode == Keys.Enter &&
            if ( DGV_parametros.CurrentCell.IsInEditMode == true)
            {
                int i = DGV_parametros.CurrentRow.Index;
                button1.Text = i.ToString();
               // MessageBox.Show(i.ToString());
            }
        }

        bool CellIsBeingEdited = false;
        private void DGV_parametros_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CellIsBeingEdited = true;
        }

        private void DGV_parametros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Pressed Key to finish editing was -> " + LastKeyPressed);
            // if you wanted to "move" the next active cell to some non-default cell
            // then in this event… you should be able to set the grids CurrentCell to whatever cell you want.
            //   Example, move the active cell to the right as opposed to down when the “Enter” key is pressed 
            CellIsBeingEdited = false;
            Console.WriteLine("No cell is being edited! -----------");
            //Console.WriteLine("DGV_CellEndEdit -> Leave");
        }
        bool modoinser = false;

        private void DGV_parametros_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            modoinser = true;
            //renglonadd = DGV_parametros.CurrentRow.ToString();
            label1.Text = DGV_parametros.Rows.Count.ToString();
        }
        string renglonadd="";

        private void DGV_parametros_SelectionChanged(object sender, EventArgs e)
        {
            

            if (modoinser)
            {

                if(MessageBox.Show("DGV_parametros_SelectionChanged - Quieres Insertar el Nuevo Registro de la posi?" + posicioncuandoescribe, "Confirmacion",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {

                    modoinser = false;

                }
                else
                {
                    modoinser = false;
                    DGV_parametros.Rows.RemoveAt(posicioncuandoescribe);
                }
            }
            //if (modoinser == true)
            //{
            //    if (MessageBox.Show("desea modificar esrte archivo priomer", "espera", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        MessageBox.Show("se registra");
            //        modoinser = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Se borra");
            //        modoinser = false;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("modoinser false");
            //    modoinser = false;
            //}
        }
    
        private void DGV_parametros_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DGV_parametros.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DGV_parametros.CurrentCell = this.DGV_parametros.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.DGV_parametros, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clase_Reportes elimina = new Clase_Reportes();

            if (!this.DGV_parametros.Rows[this.rowIndex].IsNewRow){
                this.DGV_parametros.Rows.RemoveAt(this.rowIndex);
                if (elimina.EliminarParametros(txtID_Parametro.Text))
                {
                    MessageBox.Show("El registro ha sido eliminado");
                }
                else
                {
                    MessageBox.Show("Error en el procedimiento");
                }
            }
        
        }

        private void DGV_parametros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_Parametro.Text = DGV_parametros.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
