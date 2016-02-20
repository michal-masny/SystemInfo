using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemInfo
{
    public partial class ProfileDetails : Form
    {
        public List<ProfileListItem> ProfileDetailsList;
        public ProfileDetails()
        {
            InitializeComponent();
        }

        private void ProfileDetails_Load(object sender, EventArgs e)
        {
            dgvProfileDetails.AutoGenerateColumns = true;
            try
            {
                dgvProfileDetails.DataSource = ProfileDetailsList;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            dgvProfileDetails.AutoResizeColumns();
        }
        //private void ProfileDetails_FormClosing(object sender, FormClosingEventArgs e)
        //{
          //Hiding the window, because closing it makes the window unaccessible.
        //    this.Hide();
            //this.Parent = null;
        //    e.Cancel = true; //hides the form, cancels closing event
        //}
    }
}
