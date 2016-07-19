using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using System.Collections;
using DevExpress.XtraBars.Helpers;
using DevExpress.UserSkins;


namespace DXApplication1
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            barManager.ForceInitialize();
            SkinHelper.InitSkinPopupMenu(mPaintStyle);

        }

    }
}