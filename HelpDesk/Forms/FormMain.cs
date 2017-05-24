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

        private void FormMain_Load(object sender, EventArgs e)
        {
            //
        }

        private void gridControlСотрудник_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.Custom:
                    break;
                case NavigatorButtonType.First:
                    break;
                case NavigatorButtonType.PrevPage:
                    break;
                case NavigatorButtonType.Prev:
                    break;
                case NavigatorButtonType.Next:
                    break;
                case NavigatorButtonType.NextPage:
                    break;
                case NavigatorButtonType.Last:
                    break;
                case NavigatorButtonType.Append:
                    break;
                case NavigatorButtonType.Remove:
                    break;
                case NavigatorButtonType.Edit:
                    break;
                case NavigatorButtonType.EndEdit:
                    break;
                case NavigatorButtonType.CancelEdit:
                    break;
                default:
                    break;
            }
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "helpDesk_NewDataSet.dbo_Сотрудник". При необходимости она может быть перемещена или удалена.
            SplashImagePainter.Painter.ViewInfo.Stage = "Подключение к таблице [dbo.Сотрудник]";
            this.dbo_СотрудникTableAdapter.Fill(this.helpDesk_NewDataSet.dbo_Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "helpDesk_NewDataSet.dbo_Статус_Сотрудника". При необходимости она может быть перемещена или удалена.
            SplashImagePainter.Painter.ViewInfo.Stage = "Подключение к таблице [dbo.Статус_Сотрудника]";
            this.dbo_Статус_СотрудникаTableAdapter.Fill(this.helpDesk_NewDataSet.dbo_Статус_Сотрудника);
            /*
            var qStatus = this.helpDesk_NewDataSet.dbo_Статус_Сотрудника.OrderBy(x => x.Статус).Select(x => x);

            if (qStatus.Count() > 0)
            {
                List<StatusList> stList = new List<StatusList>(qStatus.Count());
                int iRow = 1;
                foreach (var rStatus in qStatus)
                {
                    stList.Add(new StatusList() { Статус_ID = rStatus.Статус_ID, Статус = rStatus.Статус, Записал = rStatus.Записал, Дата_Записи = rStatus.Дата_Записи });
                    SplashImagePainter.Painter.ViewInfo.Counter = (int)(iRow / (double)qStatus.Count() * 100);
                    SplashScreenManager.Default.Invalidate();
                    iRow++;

                    for (int i = 1; i <= 100; i++)
                    {
                        System.Threading.Thread.Sleep(20);
                    }
                }

                this.repositoryItemLookUpEditСтатус.DataSource = stList;
            }
            */
            // TODO: данная строка кода позволяет загрузить данные в таблицу "helpDesk_NewDataSet.dbo_Должности". При необходимости она может быть перемещена или удалена.
            this.dbo_ДолжностиTableAdapter.Fill(this.helpDesk_NewDataSet.dbo_Должности);
            SplashImagePainter.Painter.ViewInfo.Stage = "Подключение к таблице [dbo.Должность]";
            /*
            var qJob = this.helpDesk_NewDataSet.dbo_Должности.OrderBy(x => x.Наименование_должности).Select(x => x);

            if (qJob.Count() > 0)
            {
                List<JobList> jbList = new List<JobList>(qJob.Count());
                int iRow = 1;
                foreach (var rJob in qJob)
                {
                    jbList.Add(new JobList() { КодID = rJob.КодID, Код = rJob.Код, КЧ = rJob.КЧ, Наименование_должности = rJob.Наименование_должности,
                                               Код_категории = rJob.Код_категории, Код_по_ОКЗ = rJob.Код_по_ОКЗ, Записал = rJob.Записал, Дата_Записи = rJob.Дата_записи });
                    SplashImagePainter.Painter.ViewInfo.Counter = (int)(iRow / (double)qJob.Count() * 100);
                    SplashScreenManager.Default.Invalidate();
                    iRow++;
                }

                this.repositoryItemLookUpEditДолжность.DataSource = jbList;
            }*/
        }

        #endregion
    }
}