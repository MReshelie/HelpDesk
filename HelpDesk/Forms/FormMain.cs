using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HelpDesk.Classes;
using DevExpress.XtraSplashScreen;

namespace HelpDesk
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();

            BaseInitialization();
            LoadData();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SplashScreenManager.HideImage();
        }





        #region #Пользовательские функции и процедуры
        void BaseInitialization()
        {
            SplashImagePainter.Painter.ViewInfo.Stage = "Загрузка компонентов";
            for (int i = 1; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(20);
                SplashImagePainter.Painter.ViewInfo.Counter = i;
                SplashScreenManager.Default.Invalidate();
            }

       
        }

        void LoadData()
        {
            SplashImagePainter.Painter.ViewInfo.Counter = 0;
            SplashImagePainter.Painter.ViewInfo.Stage = "Подключение к БД";
            SplashScreenManager.Default.Invalidate();

            for (int i = 1; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(20);
                SplashImagePainter.Painter.ViewInfo.Counter = i;
                SplashScreenManager.Default.Invalidate();
            }


        }
        #endregion


    }
}