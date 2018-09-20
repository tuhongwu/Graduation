using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;

namespace HRManage
{
    public partial class FormSkinSet : DevExpress.XtraEditors.XtraForm
    {
        XmlOpt xc;
        public FormSkinSet()
        {
            InitializeComponent();
            xc = new XmlOpt();
        }

        private void frmSkinSet_Load(object sender, EventArgs e)
        {
            this.LoadSkins();
            this.SetCurrentSkinSelected();
        }

        private void LoadSkins()
        {
            string[] bonus = DevExpress.Skins.SkinCollectionHelper.BonusSkins;
            string[] office = DevExpress.Skins.SkinCollectionHelper.OfficeSkins;
            string[] standard = DevExpress.Skins.SkinCollectionHelper.StandardSkins;
            string[] skins = MergerArray(bonus, office);
            //bonus.Union(office).Union(standard).ToArray();
            skins = this.MergerArray(skins, standard);
            for (int i = 0; i < skins.Length; i++)
            {
                if (i >= 8 && i <= 12) continue;
                string name = skins[i];
                if (name.Contains("Dark")) continue;
                if (name.Contains("Sharp Plus")) continue;
                if (name.Contains("Sharp")) continue;
                if (name.Contains("High Contrast")) continue;
                if (name.Contains("Blueprint")) continue;
                this.lstSkin.Items.Add(name);
            }
        }

        /// 合并数组
        /// <param name="First">第一个数组</param>
        /// <param name="Second">第二个数组</param>
        /// <returns>合并后的数组(第一个数组+第二个数组，长度为两个数组的长度)</returns>
        private string[] MergerArray(string[] First, string[] Second)
        {
            string[] result = new string[First.Length + Second.Length];
            First.CopyTo(result, 0);
            Second.CopyTo(result, First.Length);
            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstSkin.SelectedIndex < 0) return;
            this.txtSelectedSkin.Text = this.lstSkin.SelectedItem.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string selectedSkin = this.txtSelectedSkin.Text.Trim();
            if(string.IsNullOrEmpty(selectedSkin)) return;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(selectedSkin);
            xc.UpdateXMLValue("Skin", selectedSkin);
        }

        private void SetCurrentSkinSelected()
        {
            string currentSkin =xc.GetNodeValue("Skin");
            if (string.IsNullOrEmpty(currentSkin)) return;
            for (int i = 0; i < lstSkin.Items.Count; i++)
            {
                if(currentSkin.Equals(lstSkin.Items[i].ToString()))
                {
                    this.lstSkin.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}