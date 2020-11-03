using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemBanh
{
    public partial class fStaffManager : Form
    {
        public fStaffManager()
        {
            InitializeComponent();
            lbDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
