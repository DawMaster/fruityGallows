using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace fruityGallows
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;
        List<Question> questions = new List<Question> { };
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sp.Stop();
            Form2 f2 = new Form2(this);
            f2.Show();
           
        }

       

      private void Form1_Load(object sender, EventArgs e)
        {

            Stream str = Properties.Resources.welcome;
            sp = new SoundPlayer(str);
            sp.PlayLooping();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
            this.Hide();
        }
    }
}
