using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;

namespace HRManage
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SystemInfo.SystemDefaultSkin);

            XmlOpt xc = new XmlOpt();
            string skinName = xc.GetNodeValue("Skin");
            //skinName = string.IsNullOrEmpty(skinName) ? SystemInfo.SystemDefaultSkin : skinName;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName);

            //DevExpress.UserSkins.BonusSkins.Register();
            //DevExpress.Skins.SkinManager.EnableFormSkins();
            //DevExpress.Skins.SkinManager.EnableMdiFormSkins();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CHS");
            Application.Run(new frmLogin());
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CHS");
        }
    }
}
