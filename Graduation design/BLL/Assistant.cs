using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;

namespace BLL
{
    public class Assistant
    {
        /// <summary>控件显示提示信息</summary>
        public static void DisplayInfoUseTooltip(Control ctr, string infor, int delay)
        {
            ToolTip toolTip = new ToolTip();
            if (delay == -1) delay = 1000;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "提示";
            toolTip.Show(infor, ctr, delay);
            ctr.Focus();
        }

        public static void ClearControls(Control item)
        {
            if (item is TextBox)   //  如果 item 是 TextBox 对象
            {
                TextBox tb = item as TextBox;    // 将 item 实例化为 tb
                tb.Text = string.Empty;      // 将所有 TextBox 对象全部清空；
            }
            else if (item is ucCheckbox)   
            {
                ucCheckbox uc = item as ucCheckbox;   
                uc.IsClear(true);    
            }
            else if (item is System.Windows.Forms.ComboBox)
            {
                System.Windows.Forms.ComboBox cbb = item as System.Windows.Forms.ComboBox;
                cbb.SelectedIndex = -1;
            }
            else if (item is DateTimePicker)
            {
                DateTimePicker dtp = item as DateTimePicker;
                dtp.Text = string.Empty;
            }
            else if (item.HasChildren)
            {

                foreach (Control subControl in item.Controls)
                {
                    ClearControls(subControl);
                }
            }
        }

        /// <summary>检测输入的数据是否为数字</summary>
        public static void CheckIsNums(KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }  
        }

        /// <summary>弹出信息对话框</summary>
        /// <param name="msg">信息字符串</param>
        public static void ShowMessage(string msg)
        {
            XtraMessageBox.Show(msg, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>检查Dt是否为空</summary>
        /// <param name="dt">待检验的数据集</param>
        /// <returns>bool</returns>
        public static bool IsDtNull(DataTable dt)
        {
            if (dt == null || dt.Columns.Count == 0 || dt.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>可以让用户选择是否确认的对话框</summary>
        /// <param name="msg">信息字符串</param>
        /// /// <returns>bool</returns>
        public static bool ConfirmMessage(string msg)
        {
            DialogResult dr = XtraMessageBox.Show(msg, "系统信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK) { return true; }
            else { return false; }
        }

        /// <summary> 显示dgv行号 </summary>
        public static void ShowRowNum(DataGridViewRowPostPaintEventArgs e, DataGridView dgv)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font, rectangle, dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
    }
}
