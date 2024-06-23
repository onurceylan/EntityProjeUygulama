using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EntityProjeUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORİ.ToList();
            dataGridView1.DataSource = kategoriler;
            // var bütün veri tiplerini (değişkenleri) üstüne aldığı için kullandık
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORİ t = new TBLKATEGORİ();
            t.AD = textBox2.Text;
            db.TBLKATEGORİ.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }
        
        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATEGORİ.Find(x);
            db.TBLKATEGORİ.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATEGORİ.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı");
             
        }
    }
}
