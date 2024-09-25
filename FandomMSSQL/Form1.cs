using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FandomMSSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNames_Click(object sender, EventArgs e)
        {
            string tmp = string.Empty;
            List<string> _lstNames = LinqToSqlClass.GetNames();
            foreach (var item in LinqToSqlClass.GetNames())
            {
                tmp += item + "\r\n"; // Перевод на новую строку в Windows-приложениях
            }
            MessageBox.Show(tmp);            
            dgvTable.DataSource = ConvertMetods.ListOfStrings2DataSet(_lstNames);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> _lstNames = LinqToSqlClass.GetNames(tBSearch.Text);
            dgvTable.DataSource = ConvertMetods.ListOfStrings2DataSet(_lstNames);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (LinqToSqlClass.ReplaceName(tBFind.Text, tBReplace.Text))
            {
                List<string> _lstNames = LinqToSqlClass.GetNames(tBSearch.Text);
                dgvTable.DataSource = ConvertMetods.ListOfStrings2DataSet(_lstNames);
            }
        }
    }
}
