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
    public partial class Part : UserControl
    {
        public Part()
        {
            InitializeComponent();
        }

        public int Xristal { get => KristalSayi(); }

        #region Properties

        private string _fullname;
        private string _lastEntry;
        private Image _profile;

        public string FullName
        {
            get { return _fullname; }
            set { _fullname = value; FullnameLbl.Text = value; }
        }

        

        public string LastEntry
        {
            get { return _lastEntry; }
            set { _lastEntry = value; TimeLbl.Text = value; }
        }

       

        public Image Profile
        {
            get { return _profile; }
            set { _profile = value; ProfilePic.Image = value; }
        }

        

        private Guna.UI2.WinForms.Guna2CustomRadioButton _hereradio;

        public Guna.UI2.WinForms.Guna2CustomRadioButton HereRadio
        {
            get { return _hereradio; }
            set { _hereradio = value;IsHereRadio = _hereradio; }
        }



        #endregion

        private void FirstDiamondPic_DoubleClick(object sender, EventArgs e)
        {
            FirstDiamondPic.Image = Resources.WhiteDiamond;
            SecondDiamondPic.Image = Resources.diamond__2_;
            ThirdDiamondPic.Image = Resources.diamond__2_;
            CrystalLbl.Text = 1.ToString();
        }

        private void SecondDiamondPic_DoubleClick(object sender, EventArgs e)
        {
            FirstDiamondPic.Image = Resources.WhiteDiamond;
            SecondDiamondPic.Image = Resources.WhiteDiamond;
            ThirdDiamondPic.Image = Resources.diamond__2_;
            CrystalLbl.Text = 2.ToString();
        }

        private void ThirdDiamondPic_DoubleClick(object sender, EventArgs e)
        {
            FirstDiamondPic.Image = Resources.WhiteDiamond;
            SecondDiamondPic.Image = Resources.WhiteDiamond;
            ThirdDiamondPic.Image = Resources.WhiteDiamond;
            CrystalLbl.Text = 3.ToString();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ProfilePic.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ProfilePic.Visible = false;
        }

        private void IsHereRadio_CheckedChanged(object sender, EventArgs e)
        {
            ClassWorkCombo.Enabled = true;
            HomeWorkCombo.Enabled = true;
            FirstDiamondPic.Enabled = true;
            SecondDiamondPic.Enabled = true;
            ThirdDiamondPic.Enabled = true;
            CommentTxt.Enabled = true;
            ClearKristalBtn.Enabled = true;

        }

        private void IsNotHereRadio_CheckedChanged(object sender, EventArgs e)
        {
            ClassWorkCombo.Enabled = false;
            HomeWorkCombo.Enabled = false;
            FirstDiamondPic.Enabled = false;
            SecondDiamondPic.Enabled = false;
            ThirdDiamondPic.Enabled = false;
            CommentTxt.Enabled = false;
            ClearKristalBtn.Enabled = false;
            ClassWorkCombo.Text = "";
            HomeWorkCombo.Text = "";
            FirstDiamondPic.Image = Resources.diamond__2_;
            SecondDiamondPic.Image = Resources.diamond__2_;
            ThirdDiamondPic.Image = Resources.diamond__2_;
            CommentTxt.Text = "";
            
        }


        public void HamiBurdadir()
        {
            IsHereRadio.Checked = true;
        }

        public int KristalSayi()
        {
             if (FirstDiamondPic.Image == Resources.diamond__2_)
                return 1;
             if (SecondDiamondPic.Image == Resources.WhiteDiamond && ThirdDiamondPic.Image == Resources.diamond__2_)
                return 2;
            if (ThirdDiamondPic.Image == Resources.WhiteDiamond)
                return 3;

            return 0;
        }

        private void ClearKristalBtn_Click(object sender, EventArgs e)
        {
            FirstDiamondPic.Image = Resources.diamond__2_;
            SecondDiamondPic.Image = Resources.diamond__2_;
            ThirdDiamondPic.Image = Resources.diamond__2_;
            CrystalLbl.Text = "0";
        }
    }
}
