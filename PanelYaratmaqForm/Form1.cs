using PanelYaratmaqForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelYaratmaqForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Populate();
        }
        public List<Person> people = new List<Person>();
        Part[] parts = new Part[3];

        public void CreatList()
        {
            people.Add(new Person
            {
                Fullname = "Mammadov Sanan",
                LastDate = $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}",
                Profil = Resources.facebook_new__1_
            });

            people.Add(new Person
            {
                Fullname = "Quliyev Kamran",
                LastDate = $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}",
                Profil = Resources.instagram
            });

            people.Add(new Person
            {
                Fullname = "Rzali Huseyn",
                LastDate = $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}",
                Profil = Resources.twitter
            });
        }

        public void Populate()
        {
            CreatList();
            for (int i = 0; i < 3; i++)
            {
                parts[i] = new Part();
                parts[i].FullName = people[i].Fullname;
                parts[i].LastEntry = people[i].LastDate;
                parts[i].Profile = people[i].Profil;
                //parts[i].Width = flowLayoutPanel1.Width;
                flowLayoutPanel1.Controls.Add(parts[i]);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //parts[0].IsHereRadio_CheckedChanged(sender, e);
            for (int i = 0; i < 3; i++)
            {
                parts[i].HamiBurdadir();
            }
        }

        public void KristalCountLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                parts[i].Enabled = false;
            }
            MentionAllRadio.Enabled = false;
            pictureBox1.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TopicTxt.Visible = true;
            for (int i = 0; i < 3; i++)
            {
                parts[i].Enabled = true;
            }
            MentionAllRadio.Enabled = true;

        }

        private void guna2CustomRadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
        }


        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
        }
    }
}
