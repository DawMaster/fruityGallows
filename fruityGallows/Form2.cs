
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace fruityGallows
{
   public partial class Form2 : Form
    {
        private List<Question> questions;
        String actualQuestion;
        int countOfLetters;
        int wrong;
        int countOfQuestions;
        Form1 f;
     
        public Form2(Form1 f)
        {
            this.f = f;   
            InitializeComponent();
            setQuestions();
            setQuestion();
            wrong = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

           


        }
       
       

        private void butns_Click(object sender, EventArgs e,PictureBox letter)
        {
            checkLetter(letter.Name);
            letter.Image = null;
            letter.Enabled = false;


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

            countOfQuestions = questions.Count();
        }

        public void setQuestion() {
            nextPB.Visible = false;
            correctPB.Visible = false;
            if (questions.Count > 0)
            {
                Random rnd = new Random();
                int quest = rnd.Next(0, questions.Count);
                actualQuestion = questions.ElementAt(quest).getName();
                questionPB.Image = questions.ElementAt(quest).getImage();
                questions.RemoveAt(quest);
                countOfLetters = 0;
                setAlphabets();
            }
            else {
               
                MessageBox.Show("You pass the test with "+ wrong +" mistakes");
                f.Show();
                this.Dispose();
            }           
        }

        public void setAlphabets() {
            flw.Controls.Clear();
            int x = 110;
            int y = 610;
            String[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            for (int i = 0; i < letters.Length; i++)
            {
                PictureBox pics = new PictureBox();
                //pics[i].Location = new Point(953, 95 + brh);
                pics.Name = letters[i];
                pics.Size = new Size(40, 40);
                pics.SizeMode = PictureBoxSizeMode.Zoom;
                pics.BackColor = System.Drawing.Color.Transparent;
                pics.Image = (Image)Properties.Resources.ResourceManager.GetObject(letters[i]);
                pics.Click += (sender, e) => butns_Click(sender, e, pics);
                x += 60;
                flw.Controls.Add(pics);
            }
            flw2.Controls.Clear();
            int a = actualQuestion.Length * 60 + 10;
            flw2.Size = new Size(a, 80);

                int position = (1000-a)/2;
                flw2.Location = new Point(position, 357);
            for (int i = 0; i < actualQuestion.Length; i++) {
                PictureBox pics = new PictureBox();              
                pics.Size = new Size(50, 50);
                pics.SizeMode = PictureBoxSizeMode.Zoom;
                System.Drawing.Color c = System.Drawing.Color.Gray;
                pics.BackColor = System.Drawing.Color.FromArgb(127, c.R,c.G,c.B);              
                flw2.Controls.Add(pics);
                flw2.Controls.SetChildIndex(pics, i);
            }
           
        }

        private void questionPB_MouseDown(object sender, MouseEventArgs e)
        {         
            setAlphabets();
           
        }

        public void checkLetter(String letter) {
            var foundIndexes = new List<int>();
            actualQuestion = actualQuestion.ToUpper();
            for (int i = actualQuestion.IndexOf(letter); i > -1; i = actualQuestion.IndexOf(letter, i + 1))
            {
                foundIndexes.Add(i);
            }
            if (foundIndexes.Count < 1) 
            {
                Stream str = Properties.Resources.no;
                SoundPlayer snd = new SoundPlayer(str);
                snd.PlaySync();
                gallowPB.BackColor = System.Drawing.Color.Transparent;
                wrong = wrong + 1;
                if (wrong == 6)
                {
                    gallowPB.Image = (Image)Properties.Resources.ResourceManager.GetObject("gallow" + wrong);
                    MessageBox.Show("Game Over");
                    f.Show();
                    this.Dispose();
                    
                }
                else {
                    gallowPB.Image = (Image)Properties.Resources.ResourceManager.GetObject("gallow" + wrong);
                }
            }
            else {
                Stream str = Properties.Resources.yes;
                SoundPlayer snd = new SoundPlayer(str);
                snd.Play();

                for (int i = 0; i < foundIndexes.Count; i++) {
                    insertLetters(letter, foundIndexes.ElementAt(i));
                }
            }
            
        }

        public void insertLetters(String letter, int position)
        {
            countOfLetters = countOfLetters + 1;
            PictureBox pics = new PictureBox();
            pics.Name = "r" + letter;
            pics.Size = new Size(50, 50);
            pics.SizeMode = PictureBoxSizeMode.Zoom;
            pics.BackColor = System.Drawing.Color.Transparent;
            pics.Image = (Image)Properties.Resources.ResourceManager.GetObject(letter);
            Control c = flw2.Controls[position];
            c.Dispose();
            flw2.Controls.Add(pics);
            flw2.Controls.SetChildIndex(pics, position);
            if (countOfLetters == actualQuestion.Count())
            {
                nextPB.Visible = true;
                correctPB.Visible = true;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
            f.Show();
        }

        private void next_Click(object sender, EventArgs e)
        {
            setQuestion();
        }
    }
}
