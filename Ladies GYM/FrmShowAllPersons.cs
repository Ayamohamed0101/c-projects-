#pragma warning disable IDE0005 // Using directive is unnecessary.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ladies_GYM.ClsControlFilesGYM;
namespace Ladies_GYM
{
    public partial class FrmShowAllPersons : Form
    {
        public FrmShowAllPersons()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmShowAllPersons_Load(object sender, EventArgs e)
        {
            // here form event when click show all particpant
            // form control file take object
           // make array store into data from control file--> load data
            // 
            ClsControlFilesGYM controlfile = new ClsControlFilesGYM();
            playerInfo[] player1 = new playerInfo[50];
            player1 = controlfile.LoadinfotoFile();

            for(int i =0;i < player1.Length ;i++)
            {

                if (player1[i].ID==0)
                {
                    break;
                }
              ListViewItem   list=new ListViewItem(player1[i].ID.ToString () );
                list.SubItems.Add(player1[i].Name);
                list.SubItems.Add(player1[i].Number);
                list.SubItems.Add(player1[i].Height.ToString() );
                list.SubItems.Add(player1[i].Weight.ToString());
                list.SubItems.Add(player1[i].Age.ToString () );
                list.SubItems.Add(player1[i].Cost.ToString ());
                list.SubItems.Add(player1[i].Level);




            }







        }
    }
}
