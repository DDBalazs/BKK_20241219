using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKK_20241219
{
    public partial class frmvasarlas : Form
    {
        int vondb = 0;
        int vonosszeg = 0;
        int tdb = 0;
        int tosszeg = 0;
        int ddb = 0;
        int dosszeg = 0;
        int fizentendo = 0;

        void szamolas()
        {
            lbvonossz.Visible = true;
            lbdiakossz.Visible = true;
            lbteljossz.Visible = true;
            lbfizetendo.Visible = true;

            if (txvondb.TextLength > 0)
            {
                vondb = Convert.ToInt32(txvondb.Text);
                vonosszeg = vondb*450;
            }
            else
            {
                vondb = 0;
                vonosszeg= 0;
            }
            if(txvonteljdb.TextLength > 0)
            {
                tdb = Convert.ToInt32(txvonteljdb.Text);
                tosszeg = tdb * 9500;
            }
            else
            {
                tdb = 0;
                tosszeg = 0;
            }
            if(txdiakdb.TextLength > 0)
            {
                ddb = Convert.ToInt32(txdiakdb.Text);
                dosszeg = ddb * 3450;
            }
            else
            {
                ddb = 0;
                dosszeg = 0;
            }
            fizentendo= vonosszeg + tosszeg + dosszeg;
            lbvonossz.Text = "Vonaljegy összege: " + vonosszeg.ToString() + " Ft";
            lbdiakossz.Text = "A diákbérletek összege: "+ dosszeg.ToString()+ " Ft";
            lbteljossz.Text = "A teljesárú felnőtbérlet"+tosszeg.ToString()+" Ft";
            lbfizetendo.Text = "Össz fizetetendő: " + fizentendo.ToString()+ "Ft";
        }

        public frmvasarlas()
        {
            InitializeComponent();
        }

        private void frmvasarlas_Load(object sender, EventArgs e)
        {

        }

        private void btelvet_Click(object sender, EventArgs e)
        {
            DialogResult uzenet = new DialogResult();
            uzenet = MessageBox.Show("Biztos elveti?","Üzenet",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (uzenet == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txvondb_TextChanged(object sender, EventArgs e)
        {
            if (txvondb.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txvondb.Text);
                    szamolas();
                }
                catch
                {
                    MessageBox.Show("Vonaljegyek számának egész számnak kell lennie!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txvondb.Text="0";
                    txvondb.Focus();
                }
            }
            szamolas();
        }

        private void txvonteljdb_TextChanged(object sender, EventArgs e)
        {
            if (txvonteljdb.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txvonteljdb.Text);
                    szamolas();
                }
                catch
                {
                    MessageBox.Show("Teljesárú bérletek számának egész számnak kell lennie!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txvonteljdb.Text="0";
                    txvonteljdb.Focus();
                }
            }
            szamolas();
        }

        private void txdiakdb_TextChanged(object sender, EventArgs e)
        {
            if (txdiakdb.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txdiakdb.Text);
                }
                catch
                {
                    MessageBox.Show("Diák bérletek számának egész számnak kell lennie!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txdiakdb.Text="0";
                    txdiakdb.Focus();
                }
            }
            szamolas();
        }

        private void btfizetes_Click(object sender, EventArgs e)
        {
            if (File.Exists("..\\..\\src\\jegyadatok.txt"))
            {
                FileStream fs = new FileStream("..\\..\\src\\jegyadatok.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("\n" + vondb.ToString() + ";" + vonosszeg.ToString() + ";" + tdb.ToString() + ";" + tosszeg.ToString() + ";" + ddb.ToString() + ";" + dosszeg.ToString());

                sw.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("..\\..\\src\\jegyadatok.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(vondb.ToString() + ";" + vonosszeg.ToString() + ";" + tdb.ToString() + ";" + tosszeg.ToString() + ";" + ddb.ToString() + ";" + dosszeg.ToString());

                sw.Close();
                fs.Close();
            }
            txdiakdb.Clear();
            txvondb.Clear();
            txvonteljdb.Clear();
            szamolas();
            MessageBox.Show("Sikeres fizetés!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
