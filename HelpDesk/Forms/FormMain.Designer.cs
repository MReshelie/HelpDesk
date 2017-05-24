namespace HelpDesk
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.eployeesTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.customersTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlСотрудник = new DevExpress.XtraGrid.GridControl();
            this.gridViewСотрудник = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colСотрудник_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colФамилия = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colИмя = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colОтчество = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colДолжность_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditДолжность = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colСтатус_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditСтатус = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colПомещение_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colНомерТабельный = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colДатаРождения = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colПол = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBoxПол = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colЗаписал = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colДатаЗаписи = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colИсправил = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colДатаИсправления = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colПримечание = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEditСотрудникПримечание = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.helpDesk_NewDataSet = new HelpDesk.DataBase.HelpDesk_NewDataSet();
            this.dboСотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_СотрудникTableAdapter = new HelpDesk.DataBase.HelpDesk_NewDataSetTableAdapters.dbo_СотрудникTableAdapter();
            this.dboСтатусСотрудникаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_Статус_СотрудникаTableAdapter = new HelpDesk.DataBase.HelpDesk_NewDataSetTableAdapters.dbo_Статус_СотрудникаTableAdapter();
            this.dboДолжностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_ДолжностиTableAdapter = new HelpDesk.DataBase.HelpDesk_NewDataSetTableAdapters.dbo_ДолжностиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlСотрудник)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСотрудник)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditДолжность)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditСтатус)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxПол)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditСотрудникПримечание)).BeginInit();
            this.customersNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpDesk_NewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboСотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboСтатусСотрудникаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboДолжностиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 3;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.eployeesTileBarItem;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(784, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.eployeesTileBarItem);
            this.tileBarGroupTables.Items.Add(this.customersTileBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // eployeesTileBarItem
            // 
            this.eployeesTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.eployeesTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.eployeesTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.ImageUri.Uri = "Paste;Size32x32;GrayScaled";
            tileItemElement9.Text = "Сотрудники";
            this.eployeesTileBarItem.Elements.Add(tileItemElement9);
            this.eployeesTileBarItem.Name = "eployeesTileBarItem";
            // 
            // customersTileBarItem
            // 
            this.customersTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement10.ImageUri.Uri = "Customization;Size32x32;GrayScaled";
            tileItemElement10.Text = "Заказ";
            this.customersTileBarItem.Elements.Add(tileItemElement10);
            this.customersTileBarItem.Id = 2;
            this.customersTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.customersTileBarItem.Name = "customersTileBarItem";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 110);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage});
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(784, 451);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Caption = "employeesNavigationPage";
            this.employeesNavigationPage.Controls.Add(this.gridControlСотрудник);
            this.employeesNavigationPage.Controls.Add(this.employeesLabelControl);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(784, 451);
            // 
            // gridControlСотрудник
            // 
            this.gridControlСотрудник.DataSource = this.dboСотрудникBindingSource;
            this.gridControlСотрудник.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlСотрудник.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlСотрудник_EmbeddedNavigator_ButtonClick);
            this.gridControlСотрудник.Location = new System.Drawing.Point(0, 0);
            this.gridControlСотрудник.MainView = this.gridViewСотрудник;
            this.gridControlСотрудник.Name = "gridControlСотрудник";
            this.gridControlСотрудник.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditСтатус,
            this.repositoryItemLookUpEditДолжность,
            this.repositoryItemMemoEditСотрудникПримечание,
            this.repositoryItemComboBoxПол});
            this.gridControlСотрудник.Size = new System.Drawing.Size(784, 451);
            this.gridControlСотрудник.TabIndex = 3;
            this.gridControlСотрудник.UseEmbeddedNavigator = true;
            this.gridControlСотрудник.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewСотрудник});
            // 
            // gridViewСотрудник
            // 
            this.gridViewСотрудник.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colСотрудник_ID,
            this.colФамилия,
            this.colИмя,
            this.colОтчество,
            this.colДолжность_ID,
            this.colСтатус_ID,
            this.colПомещение_ID,
            this.colНомерТабельный,
            this.colДатаРождения,
            this.colПол,
            this.colЗаписал,
            this.colДатаЗаписи,
            this.colИсправил,
            this.colДатаИсправления,
            this.colПримечание});
            this.gridViewСотрудник.GridControl = this.gridControlСотрудник;
            this.gridViewСотрудник.Name = "gridViewСотрудник";
            this.gridViewСотрудник.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewСотрудник.OptionsView.EnableAppearanceOddRow = true;
            // 
            // colСотрудник_ID
            // 
            this.colСотрудник_ID.Caption = "Код";
            this.colСотрудник_ID.FieldName = "Сотрудник_ID";
            this.colСотрудник_ID.Name = "colСотрудник_ID";
            this.colСотрудник_ID.OptionsColumn.ReadOnly = true;
            this.colСотрудник_ID.Visible = true;
            this.colСотрудник_ID.VisibleIndex = 0;
            // 
            // colФамилия
            // 
            this.colФамилия.FieldName = "Фамилия";
            this.colФамилия.Name = "colФамилия";
            this.colФамилия.Visible = true;
            this.colФамилия.VisibleIndex = 2;
            // 
            // colИмя
            // 
            this.colИмя.FieldName = "Имя";
            this.colИмя.Name = "colИмя";
            this.colИмя.Visible = true;
            this.colИмя.VisibleIndex = 3;
            // 
            // colОтчество
            // 
            this.colОтчество.FieldName = "Отчество";
            this.colОтчество.Name = "colОтчество";
            this.colОтчество.Visible = true;
            this.colОтчество.VisibleIndex = 4;
            // 
            // colДолжность_ID
            // 
            this.colДолжность_ID.Caption = "Занимаемая должность";
            this.colДолжность_ID.ColumnEdit = this.repositoryItemLookUpEditДолжность;
            this.colДолжность_ID.FieldName = "Должность_ID";
            this.colДолжность_ID.Name = "colДолжность_ID";
            this.colДолжность_ID.Visible = true;
            this.colДолжность_ID.VisibleIndex = 7;
            // 
            // repositoryItemLookUpEditДолжность
            // 
            this.repositoryItemLookUpEditДолжность.AutoHeight = false;
            this.repositoryItemLookUpEditДолжность.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditДолжность.DataSource = this.dboДолжностиBindingSource;
            this.repositoryItemLookUpEditДолжность.DisplayMember = "Наименование должности";
            this.repositoryItemLookUpEditДолжность.Name = "repositoryItemLookUpEditДолжность";
            this.repositoryItemLookUpEditДолжность.ValueMember = "КодID";
            // 
            // colСтатус_ID
            // 
            this.colСтатус_ID.Caption = "Статус";
            this.colСтатус_ID.ColumnEdit = this.repositoryItemLookUpEditСтатус;
            this.colСтатус_ID.FieldName = "Статус_ID";
            this.colСтатус_ID.Name = "colСтатус_ID";
            this.colСтатус_ID.Visible = true;
            this.colСтатус_ID.VisibleIndex = 8;
            // 
            // repositoryItemLookUpEditСтатус
            // 
            this.repositoryItemLookUpEditСтатус.AutoHeight = false;
            this.repositoryItemLookUpEditСтатус.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditСтатус.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Статус_ID", "Код записи", 76, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Статус", "Статус", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Записал", "Записал", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Дата Записи", "Дата Записи", 74, DevExpress.Utils.FormatType.DateTime, "dd.MM.yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Исправил", "Исправил", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Дата Исправления", "Дата Исправления", 105, DevExpress.Utils.FormatType.DateTime, "dd.MM.yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Примечание", "Примечание", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditСтатус.DataSource = this.dboСтатусСотрудникаBindingSource;
            this.repositoryItemLookUpEditСтатус.DisplayMember = "Статус";
            this.repositoryItemLookUpEditСтатус.Name = "repositoryItemLookUpEditСтатус";
            this.repositoryItemLookUpEditСтатус.ValueMember = "Статус_ID";
            // 
            // colПомещение_ID
            // 
            this.colПомещение_ID.Caption = "№ комнаты";
            this.colПомещение_ID.FieldName = "Помещение_ID";
            this.colПомещение_ID.Name = "colПомещение_ID";
            this.colПомещение_ID.Visible = true;
            this.colПомещение_ID.VisibleIndex = 9;
            // 
            // colНомерТабельный
            // 
            this.colНомерТабельный.Caption = "Таб. №";
            this.colНомерТабельный.FieldName = "Номер Табельный";
            this.colНомерТабельный.Name = "colНомерТабельный";
            this.colНомерТабельный.Visible = true;
            this.colНомерТабельный.VisibleIndex = 1;
            // 
            // colДатаРождения
            // 
            this.colДатаРождения.Caption = "Дата рождения";
            this.colДатаРождения.FieldName = "Дата Рождения";
            this.colДатаРождения.Name = "colДатаРождения";
            this.colДатаРождения.Visible = true;
            this.colДатаРождения.VisibleIndex = 6;
            // 
            // colПол
            // 
            this.colПол.Caption = "Пол";
            this.colПол.ColumnEdit = this.repositoryItemComboBoxПол;
            this.colПол.FieldName = "Пол";
            this.colПол.Name = "colПол";
            this.colПол.Visible = true;
            this.colПол.VisibleIndex = 5;
            // 
            // repositoryItemComboBoxПол
            // 
            this.repositoryItemComboBoxПол.AutoHeight = false;
            this.repositoryItemComboBoxПол.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxПол.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.repositoryItemComboBoxПол.Name = "repositoryItemComboBoxПол";
            // 
            // colЗаписал
            // 
            this.colЗаписал.Caption = "Записал";
            this.colЗаписал.FieldName = "Записал";
            this.colЗаписал.Name = "colЗаписал";
            this.colЗаписал.Visible = true;
            this.colЗаписал.VisibleIndex = 10;
            // 
            // colДатаЗаписи
            // 
            this.colДатаЗаписи.Caption = "Дата записи";
            this.colДатаЗаписи.FieldName = "Дата Записи";
            this.colДатаЗаписи.Name = "colДатаЗаписи";
            this.colДатаЗаписи.Visible = true;
            this.colДатаЗаписи.VisibleIndex = 11;
            // 
            // colИсправил
            // 
            this.colИсправил.Caption = "Исправил";
            this.colИсправил.FieldName = "Исправил";
            this.colИсправил.Name = "colИсправил";
            this.colИсправил.Visible = true;
            this.colИсправил.VisibleIndex = 12;
            // 
            // colДатаИсправления
            // 
            this.colДатаИсправления.Caption = "Дата исправления";
            this.colДатаИсправления.FieldName = "Дата Исправления";
            this.colДатаИсправления.Name = "colДатаИсправления";
            this.colДатаИсправления.Visible = true;
            this.colДатаИсправления.VisibleIndex = 13;
            // 
            // colПримечание
            // 
            this.colПримечание.Caption = "Примечание";
            this.colПримечание.ColumnEdit = this.repositoryItemMemoEditСотрудникПримечание;
            this.colПримечание.FieldName = "Примечание";
            this.colПримечание.Name = "colПримечание";
            this.colПримечание.Visible = true;
            this.colПримечание.VisibleIndex = 14;
            // 
            // repositoryItemMemoEditСотрудникПримечание
            // 
            this.repositoryItemMemoEditСотрудникПримечание.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEditСотрудникПримечание.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEditСотрудникПримечание.Name = "repositoryItemMemoEditСотрудникПримечание";
            // 
            // employeesLabelControl
            // 
            this.employeesLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.employeesLabelControl.Appearance.Options.UseFont = true;
            this.employeesLabelControl.Appearance.Options.UseForeColor = true;
            this.employeesLabelControl.Appearance.Options.UseTextOptions = true;
            this.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesLabelControl.Location = new System.Drawing.Point(0, 0);
            this.employeesLabelControl.Name = "employeesLabelControl";
            this.employeesLabelControl.Size = new System.Drawing.Size(784, 451);
            this.employeesLabelControl.TabIndex = 2;
            this.employeesLabelControl.Text = "Employees";
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Caption = "customersNavigationPage";
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(784, 451);
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(784, 451);
            this.customersLabelControl.TabIndex = 2;
            this.customersLabelControl.Text = "Customers";
            // 
            // helpDesk_NewDataSet
            // 
            this.helpDesk_NewDataSet.DataSetName = "HelpDesk_NewDataSet";
            this.helpDesk_NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dboСотрудникBindingSource
            // 
            this.dboСотрудникBindingSource.DataMember = "dbo_Сотрудник";
            this.dboСотрудникBindingSource.DataSource = this.helpDesk_NewDataSet;
            // 
            // dbo_СотрудникTableAdapter
            // 
            this.dbo_СотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // dboСтатусСотрудникаBindingSource
            // 
            this.dboСтатусСотрудникаBindingSource.DataMember = "dbo_Статус Сотрудника";
            this.dboСтатусСотрудникаBindingSource.DataSource = this.helpDesk_NewDataSet;
            // 
            // dbo_Статус_СотрудникаTableAdapter
            // 
            this.dbo_Статус_СотрудникаTableAdapter.ClearBeforeFill = true;
            // 
            // dboДолжностиBindingSource
            // 
            this.dboДолжностиBindingSource.DataMember = "dbo_Должности";
            this.dboДолжностиBindingSource.DataSource = this.helpDesk_NewDataSet;
            // 
            // dbo_ДолжностиTableAdapter
            // 
            this.dbo_ДолжностиTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlСотрудник)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСотрудник)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditДолжность)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditСтатус)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxПол)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditСотрудникПримечание)).EndInit();
            this.customersNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.helpDesk_NewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboСотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboСтатусСотрудникаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboДолжностиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem eployeesTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem customersTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraGrid.GridControl gridControlСотрудник;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewСотрудник;
    //    private HELPDESK_NEW_DataSetTableAdapters.dbo_СотрудникTableAdapter dbo_СотрудникTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colСотрудник_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colСтатус_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colДолжность_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colПомещение_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colНомерТабельный;
        private DevExpress.XtraGrid.Columns.GridColumn colФамилия;
        private DevExpress.XtraGrid.Columns.GridColumn colИмя;
        private DevExpress.XtraGrid.Columns.GridColumn colОтчество;
        private DevExpress.XtraGrid.Columns.GridColumn colДатаРождения;
        private DevExpress.XtraGrid.Columns.GridColumn colПол;
        private DevExpress.XtraGrid.Columns.GridColumn colЗаписал;
        private DevExpress.XtraGrid.Columns.GridColumn colДатаЗаписи;
        private DevExpress.XtraGrid.Columns.GridColumn colИсправил;
        private DevExpress.XtraGrid.Columns.GridColumn colДатаИсправления;
        private DevExpress.XtraGrid.Columns.GridColumn colПримечание;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditСтатус;
     //   private HELPDESK_NEW_DataSetTableAdapters.dbo_Статус_СотрудникаTableAdapter dbo_Статус_СотрудникаTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditДолжность;
     //   private HELPDESK_NEW_DataSetTableAdapters.dbo_ДолжностьTableAdapter dbo_ДолжностьTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxПол;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEditСотрудникПримечание;
        private DataBase.HelpDesk_NewDataSet helpDesk_NewDataSet;
        private System.Windows.Forms.BindingSource dboСотрудникBindingSource;
        private DataBase.HelpDesk_NewDataSetTableAdapters.dbo_СотрудникTableAdapter dbo_СотрудникTableAdapter;
        private System.Windows.Forms.BindingSource dboСтатусСотрудникаBindingSource;
        private DataBase.HelpDesk_NewDataSetTableAdapters.dbo_Статус_СотрудникаTableAdapter dbo_Статус_СотрудникаTableAdapter;
        private System.Windows.Forms.BindingSource dboДолжностиBindingSource;
        private DataBase.HelpDesk_NewDataSetTableAdapters.dbo_ДолжностиTableAdapter dbo_ДолжностиTableAdapter;
    }
}