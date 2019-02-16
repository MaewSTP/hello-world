using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PackStation
{
    public partial class FrmSKUDetail : Form
    {
        public FrmSKUDetail()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSKUDetail_Load(object sender, EventArgs e)
        {
            DataTable _dt = new DataTable(); 
            txtSKU.Text = Program.SKU;
            _dt = Program.webService.PackStation_ShowSKUDetailInPackage(Program.COUID, txtSKU.Text);
            dgData.AutoGenerateColumns = false;
            dgData.DataSource = _dt; 
     
        }
    }
}