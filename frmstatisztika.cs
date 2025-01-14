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
    public partial class frmstatisztika : Form
    {
        List<Jegyek> lista = new List<Jegyek>();
        void betoltes()
        {
            lista.Clear();
            dgadatok.Rows.Clear();
            FileStream fs = new FileStream("..\\..\\src\\jegyadatok.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            int vonaldb = 0;
            int vonalosszeg = 0;
            int teljesdb = 0;
            int teljesosszeg = 0;
            int diakdb = 0;
            int diakosszeg = 0;
            int teljesbevetel = 0;

            while (!sr.EndOfStream)
            {
                Jegyek j = new Jegyek(sr.ReadLine());
                lista.Add(j);
                dgadatok.Rows.Add(j.Vdb, j.Vosszeg, j.Tdb, j.Tosszeg, j.Ddb, j.Dosszeg, j.FizetendoSzamitas());
                vonaldb += j.Vdb;
                vonalosszeg += j.Vosszeg;
                teljesdb += j.Tdb;
                teljesosszeg += j.Tosszeg;
                diakdb += j.Ddb;
                diakosszeg += j.Dosszeg;
                teljesbevetel += j.FizetendoSzamitas();
            }
            sr.Close();
            fs.Close();
            dgadatok.Rows.Add(vonaldb, vonalosszeg, teljesdb, teljesosszeg, diakdb, diakosszeg, teljesbevetel);
        }
        public frmstatisztika()
        {
            InitializeComponent();
        }

        private void frmstatisztika_Load(object sender, EventArgs e)
        {
            betoltes();
        }
    }
}
