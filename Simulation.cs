using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Probabilistyka_projekt
{
    public partial class Simulation : Form
    {
        private static int ilosc_pol;
        private static int ilosc_symulacji;
        public static string[] wyniki;
        public static ProgressBar pb = new ProgressBar();
        public static Label label3 = new Label();
        private static double indeks = 0, max = 0, procent = 0;

        public Simulation()
        {
            InitializeComponent();
        }
        private void zerowanie()
        {
            textBox1.Text = "";
            textBox_field_count.Text = "";
            Main_Code.zeruj_na_koniec_sym();
            pb.Value = 0;
            label3.Text = "0%";
            procent = 0;
            indeks = 0;
        }
        private void Start_Simulation_button_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out ilosc_symulacji);
            int.TryParse(textBox_field_count.Text, out ilosc_pol);
            
            max = ile_sym;
            pb.Maximum = ile_sym;
            pb.Value = 1;
            wyniki = new string[ilosc_symulacji + 1];
            Main_Code.start_simulation();
            zapisz();         
            zerowanie();
        }
            
        public static void progresbar()
        {
            pb.PerformStep();
            indeks++;
            procent = ((indeks / max) * 100);
            label3.Text = Math.Round(procent, 2).ToString() + "%";
            label3.Refresh();
        }
        
        private static void zapisz()
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać wynik symulacji?", "Wybor", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveFileDialog sfd = new SaveFileDialog(); //okno dialogowe (plik do zapisu)
                sfd.Filter = "Plik tekstowy|*.txt"; //pokażą się tylko pliki tekstowe
                sfd.Title = "Do jakiego pliku chcesz zapisać ilość rzutów?"; //tytuł okna dialogowego
                sfd.ShowDialog();

                if (sfd.FileName != "")
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(sfd.FileName);
                    wyniki[0] = "Wart";
                    File.WriteAllLines(dirInfo.ToString(), wyniki);
                }
                sfd.FileName = "";
                sfd.Title = "Do jakiego pliku chcesz zapisać ilość wygranych?";
                sfd.ShowDialog();
                if (sfd.FileName != "")
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(sfd.FileName);
                    File.WriteAllText(dirInfo.ToString(), Main_Code.ileWygranych[0].ToString() + ", " + Main_Code.ileWygranych[1].ToString() + ", " + Main_Code.ileWygranych[2].ToString() + ", " + Main_Code.ileWygranych[3].ToString());
                }
            }  
        }
        private static int pola()
        {
            return ilosc_pol;
        }

        public static int get_pola
        {
            get
            {
                return pola();
            }
        }
        private static int il_sym()
        {
            return ilosc_symulacji;
        }

        public static int ile_sym
        {
            get
            {
                return il_sym();
            }
        }

        private void textBox_field_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void Back_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Simulation_Load(object sender, EventArgs e)
        {
            Simulation s = new Simulation();
            pb.Name = "pb";
            pb.Size = new Size(184, 23);
            pb.Location = new Point(65, 165);
            pb.Minimum = 0;
            pb.Step = 1;
            pb.Visible = true;
            pb.Show();
            this.Controls.Add(pb);

            label3.Name = "label3";
            label3.Text = "0%";
            label3.Location = new Point(252, 170);
            label3.Size = new Size(55, 16);
            label3.Visible = true;
            label3.Show();
            this.Controls.Add(label3);
        }
    }
}
