using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();

        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.KULLANICI==textBox1.Text && x.SIFRE == textBox2.Text select x;
            if (sorgu.Any()) // sorgu bir şey döndürüyorsu true oluyorsa bu işlem gerçekleşecek
            {
                frmAnaForm fr = new frmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }

        }
    }
}
