using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruityGallows
{
    public partial class Form3 : Form
    {
        
        List<Question> questions;
        int post;
        Form1 f;
        public Form3(Form1 f)
        {
            this.f = f;
            post = 0;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            setQuestions();         
            setQuestion(post);
        }

        public void setQuestions() {
            questions = new List<Question> { };
            questions.Add(new Question("apple", "apple"));
            questions.Add(new Question("pineapple", "pineapple"));
            questions.Add(new Question("banana", "banana"));
            questions.Add(new Question("strawberry", "strawberry"));
            questions.Add(new Question("orange", "orange"));
            questions.Add(new Question("tangerine", "tangerine"));
            questions.Add(new Question("kiwi", "kiwi"));
            questions.Add(new Question("grapefruit", "grapefruit"));
            questions.Add(new Question("pear", "pear"));
            questions.Add(new Question("raspberry", "redraspberries"));
            questions.Add(new Question("cranberry", "cranberry"));
            questions.Add(new Question("grape", "grape"));
            questions.Add(new Question("pomegranate", "pomegranate"));
            questions.Add(new Question("lemon", "lemon"));
            questions.Add(new Question("lime", "lime"));
            questions.Add(new Question("blueberry", "blueberry"));
            questions.Add(new Question("nectarine", "nectarine"));
            questions.Add(new Question("plum", "plum"));
            questions.Add(new Question("apricot", "apricot"));
            questions.Add(new Question("blackberry", "blackberry"));
            questions.Add(new Question("coconut", "coconut"));
            questions.Add(new Question("gooseberry", "gooseberry"));
            questions.Add(new Question("blackcurrant", "blackcurrant"));
            questions.Add(new Question("papaya", "papaya"));
            questions.Add(new Question("avocado", "avocado"));
            questions.Add(new Question("mango", "mango"));

        }

        public void setQuestion(int position) {
            if (position == 0)
            {
                backPB.Visible = false;
            }
            else {
                backPB.Visible = true;
            }

           

            Question quest = questions.ElementAt(position);
            
            questionPB.Image = quest.getImage();

            char[] arr;
            arr = quest.getName().ToUpper().ToCharArray(0, quest.getName().Length);
            int a = (1000 - (quest.getName().Length * 60) + 10);
            flw3.Controls.Clear();
            flw3.Size = new Size((quest.getName().Length * 60) + 10, 100);
            flw3.Location = new Point(a/2, 560);
            flw3.BackColor = Color.Transparent;
            
            foreach (char c in arr)
            {
                PictureBox pics = new PictureBox();
                pics.Name = c.ToString();
                pics.Size = new Size(50, 50);
                pics.SizeMode = PictureBoxSizeMode.Zoom;
                pics.BackColor = System.Drawing.Color.Transparent;
                pics.Image = (Image)Properties.Resources.ResourceManager.GetObject(c.ToString());
                flw3.Controls.Add(pics);
              } 
    }

        private void nextPB_Click(object sender, EventArgs e)
        {
            if (post == questions.Count-1)
            {
                this.Dispose();
                f.Show();
            }
            else {
                post = post + 1;
                setQuestion(post);
            }            
        }

        private void backPB_Click(object sender, EventArgs e)
        {
            post = post - 1;
            setQuestion(post);
        }
    }
}
