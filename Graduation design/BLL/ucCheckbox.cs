using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public partial class ucCheckbox : UserControl
    {
        public ucCheckbox()
        {
            InitializeComponent();
        }

        private void checktrue_CheckedChanged(object sender, EventArgs e)
        {
            checkfalse.Checked = checktrue.Checked ? false : true;
        }

        private void checkfalse_CheckedChanged(object sender, EventArgs e)
        {
            checktrue.Checked = checkfalse.Checked ? false : true;
        }

        //选中状态
        public bool Checked
        {
            get { return checktrue.Checked ? true : false; }
            set 
            {
                this.checktrue.Checked = value;
                this.checkfalse.Checked = !value;
            }
        }

        public void IsClear(bool isClear)
        {
            this.checktrue.Checked = this.checkfalse.Checked = isClear; 
        }

        public string trueText
        {
            get { return this.checktrue.Text;}
            set { this.checktrue.Text = value; }
        }

        public string falseText
        {
            get { return this.checkfalse.Text; }
            set { this.checkfalse.Text = value; }
        }
    }
}