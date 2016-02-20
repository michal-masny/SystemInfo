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
    public partial class QueryErrors : Form
    {
        public string QueryErrorsText;
        public QueryErrors()
        {
            InitializeComponent();
            tbQueryErrors.Text = QueryErrorsText;
        }
    }
}
