using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kütüphane
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=kutuphane.mdb;");
      
       

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM kullanicilar";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            baglanti.Open();

            OleDbDataReader oku = komut.ExecuteReader();
            oku.Read();

            if (oku.GetValue(1).ToString() == textBox1.Text && oku.GetValue(2).ToString() == textBox2.Text)
            {
                Form1 form1 = new Form1();
                form1.Show();
            
            }
            
                
                
            
                
        }
    }
}
