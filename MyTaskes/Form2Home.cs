using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTaskes
{
    public partial class Form2Home : Form
    {
        public Form2Home()
        {
            InitializeComponent();
        }
        void LoadTodaysDate()
        {
            label3.Text = DateTime.Now.ToString("dddd/MMM/yyyy");

        }

        void LoadTodayTime()
        {
            label4.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        //void LoadcatogirestoAllTasks(bool all=true)
        //{
        //    foreach ( ListViewGroup lve in LVallTasks.Groups )
        //    {
        //        CbCategory.Items.Add(lve.Header);
                
        //    }
        //    CbCategory.SelectedIndex = 0;

        //}
        private void frmsign_Load(object sender, EventArgs e)
        {
            LoadTodaysDate();
            LoadTodayTime();
      //      LoadcatogirestoAllTasks();
      //      CbPriority.SelectedIndex = 0;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadTodayTime();
        }




        bool checkIsExisteTaskINListView(string TitleTask,ListView LV)
        {
            foreach (ListView item in LV.Items )
            { if(item.Text == TitleTask)
                {
                    return true;
                }
                
            }

            return false;
        }
        void UpdateTaskLabelCounter(ListView lv,Label lbl)
        {
            lbl.Text=lv.Items.Count.ToString();
        }

        void UpdateProgresslABEL(int value, Label progresslbl)
        {
            progresslbl.Text=value+ " % ";
        }

        void showNotificationIcon(string text ,string title,NotifyIcon notifyIcon)
        {
            notifyIcon.Icon = SystemIcons.Shield;
            notifyIcon.BalloonTipText = text;
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.ShowBalloonTip(10);
        }

        void Updateprogressbar(ProgressBar progressbar , ListView  LV, Label lbl, string notificationIcon)
        {

            if(LV.Items.Count == 0)
            {
                progressbar.Value = 0;
                UpdateProgresslABEL(progressbar.Value, lbl);
                return;
            }

            int Formola= ( 100 / ((int)LV.Items.Count) ) *LV.CheckedItems.Count;
            if(LV.CheckedItems.Count==LV.Items.Count)
            {

                Formola = 100;
                showNotificationIcon("All Daily Tasks Have Done !", "Great Work", notifyIcon1);
            }
            progressbar.Value= Formola;
            UpdateProgresslABEL(progressbar.Value, lbl);

        }
        void AddTaskTodaylistview()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Empty field enter task to add ", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (checkIsExisteTaskINListView(TitleTask:textBox1.Text, LV:listView1))
            {
                MessageBox.Show("Task Exist", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            ListViewItem item = new ListViewItem(textBox1.Text);
            listView1.Items.Add(item);

            UpdateTaskLabelCounter(listView1, label6);
            Updateprogressbar(PgbTodayTasks, listView1, lblTodaysTaskPgb, "d");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddTaskTodaylistview();
        }
        //------------------------------

        //----------------------------
        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

      

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
