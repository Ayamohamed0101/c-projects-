using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// define struct
// take object from struct
// upload phote
// visible for lbl sign up --> enter
// visible for lbl sign in --> text change
// check
// load  default info
namespace MyTaskes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 
        struct StAccountInfo
        {
            public string admin;
            public string password;
            public string AvatarFilePath;

        }
        StAccountInfo accountInfo;
Form2Home home=new Form2Home();
        void upLOADphotoe()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "select photo";
            ofd.Filter= "(All Images Files)|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(ofd.FileName);

            }



        }
     
        private void button3_Click(object sender, EventArgs e)
        {
       
            upLOADphotoe();

        }

        //      --------------------------------------------------------
      //  text changeing      and label false
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // label2.Visible = false;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          //  label3.Visible = false;

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = false;

        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = false;
        }


        // text change sign in 
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        //--------------------------------
        void LoadDefaultAccountInfo()
        {
            accountInfo.admin = "admin";
            accountInfo.password = "admin1";
            accountInfo.AvatarFilePath = null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDefaultAccountInfo();
        }
        void AssignAccountInfo()
        {
            accountInfo.admin = textBox1.Text;
            accountInfo.password = textBox2.Text;

        }

    
        private void button1_Click(object sender, EventArgs e)
        {
          signUP();
        }

        //==================================




       
       

     

       
        bool checksignInAdmin()
        {
            return textBox3.Text == accountInfo.admin;
        }

        bool checksignInPassword()
        {
            return textBox4.Text == accountInfo.password;
        }

        bool checkSignUpAdmin()
        {
            return !string.IsNullOrEmpty(textBox1.Text);
        }
        bool checkSignUpPassword()
        {
            return textBox2.Text.Length >= 6;
        }
//
        bool signin()
        {   bool isAdmin =checksignInAdmin();
            bool isPassword=checksignInPassword();
            if(!isAdmin)
            {
                label4.Visible = true;
                textBox3.Text = string.Empty;
            }
            if ( !isPassword )
            {
                label5.Visible = true;
                textBox4.Text = string.Empty;
            }
            if(isAdmin&&isPassword)
            {
                MessageBox.Show("Sign In Success", "Sign In Up",
                MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                return true;
            }
            return false;

        }

        public string GetAdminName()
        {
            return accountInfo.admin;
        }
        bool signUP()
        {
            bool isAdmin    = checkSignUpAdmin();
            bool isPassword = checkSignUpPassword();
            if (!isAdmin)
            {
                label2.Visible = true;
                textBox1.Text = string.Empty;
            }
            if (!isPassword)
            {
                label3.Visible = true;
                textBox2.Text = string.Empty;
            }
            if (isAdmin && isPassword)
            {
                MessageBox.Show("Sign up Success", "Sign Up",
                MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                AssignAccountInfo();
                return true;
            }
            return false;

        }
 
        
        
        
        
        
        private void button2_Click(object sender, EventArgs e)
        {

            if (signin() == true)
            {
                home.lblAdmin.Text = GetAdminName();
                this.Visible = false;
                home.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }





    }



}
