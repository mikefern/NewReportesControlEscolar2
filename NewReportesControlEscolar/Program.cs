using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLoboSostenido;
using System.Drawing;
namespace NewReportesControlEscolar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmRPT_Principal_RCE());
        }
    }
    /*
    class Nebular
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Spaceship { get; set; }
    }

    static partial class Program
    {
        private static ListView mylistView;
        private static TextBox searchTxt;
        private static Form myForm;
        private static Nebular[] nebulae;
        private static bool selected;

        private static void populateData()
        {
            nebulae = new[]
            {
                new Nebular{Name = "Horse Head",Type = "HII REGION",Spaceship = "James Web"},
                new Nebular{Name = "Black Widow",Type = "DARK NEBULAR",Spaceship = "Casini"},
                new Nebular{Name = "Ghost",Type = "REFLECTION NEBULAR",Spaceship = "New horizon"},
                new Nebular{Name = "Witch Head",Type = "PLANETRAY NEBULAR",Spaceship = "start Dust"},
                new Nebular{Name = "Cats eyes",Type = "SUPERNOVA REMNANT",Spaceship = "Juno"},
                new Nebular{Name = "elephat Trunk",Type = "REFLECTION NEBULAR",Spaceship = "Opportunity"},
                new Nebular{Name = "Snake",Type = "DARK NEBULAR",Spaceship = "Hubble"},
                new Nebular{Name = "butterFly",Type = "HII REGION",Spaceship = "endeavor"},
                new Nebular{Name = "Ant",Type = "HII REGION",Spaceship = "Apollo 15"},
                new Nebular{Name = "Rossete",Type = "REFLECTION NEBULAR",Spaceship = "Atlantis"},
                new Nebular{Name = "Bernand 68",Type = "SUPERNOVA NEBULAR",Spaceship = "Columbia"},
                new Nebular{Name = "Helix",Type = "DARK NEBULA",Spaceship = "Challenger"},
                new Nebular{Name = "Pelican",Type = "HII REGION",Spaceship = "Enterprise"},
                new Nebular{Name = "Orion",Type = "PLANETRAY NEBULAR",Spaceship = "Galileo"},
                new Nebular{Name = "Eagle",Type = "REFLECTION NEBULAR",Spaceship = "WMAP"},
                new Nebular{Name = "Own",Type = "PLANETAR NEBULAR",Spaceship = "Swift"},
                new Nebular{Name = "Ring",Type = "REFLECTION NEBULAR",Spaceship = "Vogayer B"},
                new Nebular{Name = "Flame",Type = "PLANETRAY NEBULAR",Spaceship = "Spitzer"},
                new Nebular{Name = "Cone",Type = "DARK NEBULAR",Spaceship = "Pionner"},
                new Nebular{Name = "Bumerang",Type = "SUPERNOVA REMNANT",Spaceship = "Voyager A"},
            };

            foreach (Nebular s in nebulae)
            {
                mylistView.Items.Add(new ListViewItem(new[] { s.Name, s.Type, s.Spaceship }));
            }

        }

        private static void SearchData(string searchTerm)
        {
            mylistView.Items.Clear();
            foreach (Nebular s in nebulae)
            {
                if(s.Name.ToLower().Contains(searchTerm.ToLower()) || s.Type.ToLower().Contains(searchTerm.ToLower()) || s.Spaceship.ToLower().Contains(searchTerm.ToLower()) )
                {
                    mylistView.Items.Add(new ListViewItem(new[] { s.Name, s.Type, s.Spaceship }));
                }
            }
        }

        private static void setUpEventHandlers()
        {
            mylistView.ItemSelectionChanged += myListView_ItemSelectionChanged;
            searchTxt.TextChanged += searchTxt_TextChanged;
            searchTxt.Click += searchTxt_Click;
        }

        static void searchTxt_TextChanged(object sender,EventArgs e)
        {
            SearchData(searchTxt.Text);
        }

        static void searchTxt_Click(object sender, EventArgs e)
        {
            PruebaListViewcs a = new PruebaListViewcs();
            a.Show();
        }

        static void myListView_ItemSelectionChanged(object sender , ListViewItemSelectionChangedEventArgs e)
        {
            if(e.IsSelected)
            {
                MessageBox.Show("NEBULAR : " + mylistView.SelectedItems[0].SubItems[0].Text + "\n" +
                    "TYPE : " + mylistView.SelectedItems[0].SubItems[1].Text + "\n" +
                    "SPACHESHIP : " + mylistView.SelectedItems[0].SubItems[2].Text);
                selected = true;
            }
            else
            {
                selected = false;
            }
        }

        private static void createForm()
        {
            myForm = new Form
            {
                AutoScaleDimensions = new SizeF(6F,13F),
                AutoScaleMode = AutoScaleMode.Font,
                Text = "C# ListView : MultiColumn Search/Filter",
                ClientSize = new Size(520,585),
                BackColor  = Color.Salmon
            };
            createComponents();
            populateData();
            setUpEventHandlers();
            Application.EnableVisualStyles();
            Application.Run(myForm);
        }

        public static void Main()
        {
            createForm();
        }

    }

    static partial class Program
    {
        public static void createComponents()
        {
            Label searchLabel = new Label
            {
                Location = new Point(57, 106),
                Size = new Size(38, 19),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel),
                Text = "Filter"
            };

            searchTxt = new TextBox
            {
                Location = new Point(146, 106),
                Size = new Size(173, 23),
                TabIndex = 0
            };

            mylistView = new ListView { Location = new Point(57, 165), Size = new Size(400, 400), View = View.Details, FullRowSelect = true, Alignment = ListViewAlignment.SnapToGrid };
            mylistView.Columns.Add("NEBULAR", 100);
            mylistView.Columns.Add("CATEGORY", 150);
            mylistView.Columns.Add("SPACESHIP", 150);

            myForm.Controls.Add(searchLabel);
            myForm.Controls.Add(searchTxt);
            myForm.Controls.Add(mylistView);

        }

    }
            
 */   
}
         
 