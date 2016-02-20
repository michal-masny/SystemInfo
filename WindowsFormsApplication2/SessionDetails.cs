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
    public partial class SessionDetails : Form
    {
        public List<SessionListItem> SessionDetailsList;
        public SessionDetails()
        {

            InitializeComponent();

        }

        private void SessionDetails_Load(object sender, EventArgs e)
        {
            dgvSessionDetails.AutoGenerateColumns = true;
            try
            {
                dgvSessionDetails.DataSource = SessionDetailsList;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            dgvSessionDetails.AutoResizeColumns();
        }
    }
}
