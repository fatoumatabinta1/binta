using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesCom.Entity
{
    public partial class Article1 : Form
    {
        public Article1()
        {
            InitializeComponent();
            Service.ListerArticle1(dtgvArticle);

        }
        private void FrmArticle1_Load(object sender, EventArgs e)
        {
            Service.ListerArticle1(dtgvArticle);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Article1 article = new Article1();
            {
                Reference = txtReference.Text,
                Libelle = txtLibelle.Text,
                
            }
        }

        
        

        
    }
}
