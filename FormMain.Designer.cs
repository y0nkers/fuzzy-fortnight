
namespace RGR
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constellationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.constellationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.constellationsDataSet = new RGR.ConstellationsDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.constellationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatus = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.constellationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnRussianTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnLatinTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnBrigther6m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainerInfo = new System.Windows.Forms.SplitContainer();
            this.labelRussianTitle = new System.Windows.Forms.Label();
            this.labelLatinTitle = new System.Windows.Forms.Label();
            this.labelAbbreviation = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelBrigther6m = new System.Windows.Forms.Label();
            this.textBoxRussianTitle = new System.Windows.Forms.TextBox();
            this.textBoxLatinTitle = new System.Windows.Forms.TextBox();
            this.textBoxAbbreviation = new System.Windows.Forms.TextBox();
            this.numericUpDownArea = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBrigther6m = new System.Windows.Forms.NumericUpDown();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProviderRussianTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLatinTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAbbreviation = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderArea = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBrigther6m = new System.Windows.Forms.ErrorProvider(this.components);
            this.constellationsTableAdapter = new RGR.ConstellationsDataSetTableAdapters.ConstellationsTableAdapter();
            this.tableAdapterManager = new RGR.ConstellationsDataSetTableAdapters.TableAdapterManager();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constellationsBindingNavigator)).BeginInit();
            this.constellationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constellationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constellationsDataSet)).BeginInit();
            this.toolStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constellationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInfo)).BeginInit();
            this.splitContainerInfo.Panel1.SuspendLayout();
            this.splitContainerInfo.Panel2.SuspendLayout();
            this.splitContainerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrigther6m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.contextMenuStripImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRussianTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLatinTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAbbreviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBrigther6m)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1073, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.downloadToolStripMenuItem.Text = "Загрузить данные";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // constellationsBindingNavigator
            // 
            this.constellationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.constellationsBindingNavigator.BindingSource = this.constellationsBindingSource;
            this.constellationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.constellationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.constellationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.constellationsBindingNavigatorSaveItem});
            this.constellationsBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.constellationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.constellationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.constellationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.constellationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.constellationsBindingNavigator.Name = "constellationsBindingNavigator";
            this.constellationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.constellationsBindingNavigator.Size = new System.Drawing.Size(1073, 25);
            this.constellationsBindingNavigator.TabIndex = 1;
            this.constellationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // constellationsBindingSource
            // 
            this.constellationsBindingSource.DataMember = "Constellations";
            this.constellationsBindingSource.DataSource = this.constellationsDataSet;
            // 
            // constellationsDataSet
            // 
            this.constellationsDataSet.DataSetName = "ConstellationsDataSet";
            this.constellationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // constellationsBindingNavigatorSaveItem
            // 
            this.constellationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.constellationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("constellationsBindingNavigatorSaveItem.Image")));
            this.constellationsBindingNavigatorSaveItem.Name = "constellationsBindingNavigatorSaveItem";
            this.constellationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.constellationsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.constellationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.constellationsBindingNavigatorSaveItem_Click);
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelStatus});
            this.toolStripStatus.Location = new System.Drawing.Point(0, 491);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(1073, 25);
            this.toolStripStatus.TabIndex = 3;
            this.toolStripStatus.Text = "toolStrip1";
            // 
            // toolStripLabelStatus
            // 
            this.toolStripLabelStatus.Name = "toolStripLabelStatus";
            this.toolStripLabelStatus.Size = new System.Drawing.Size(0, 22);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 49);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.constellationsDataGridView);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerInfo);
            this.splitContainerMain.Size = new System.Drawing.Size(1073, 442);
            this.splitContainerMain.SplitterDistance = 701;
            this.splitContainerMain.TabIndex = 4;
            // 
            // constellationsDataGridView
            // 
            this.constellationsDataGridView.AllowUserToAddRows = false;
            this.constellationsDataGridView.AutoGenerateColumns = false;
            this.constellationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.constellationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnRussianTitle,
            this.dataGridViewTextBoxColumnLatinTitle,
            this.dataGridViewTextBoxColumnAbbreviation,
            this.dataGridViewTextBoxColumnArea,
            this.dataGridViewTextBoxColumnBrigther6m,
            this.dataGridViewImageColumnImage});
            this.constellationsDataGridView.DataSource = this.constellationsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.constellationsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.constellationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constellationsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.constellationsDataGridView.MultiSelect = false;
            this.constellationsDataGridView.Name = "constellationsDataGridView";
            this.constellationsDataGridView.ReadOnly = true;
            this.constellationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.constellationsDataGridView.Size = new System.Drawing.Size(701, 442);
            this.constellationsDataGridView.TabIndex = 2;
            this.constellationsDataGridView.SelectionChanged += new System.EventHandler(this.constellationsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumnRussianTitle
            // 
            this.dataGridViewTextBoxColumnRussianTitle.DataPropertyName = "RussianTitle";
            this.dataGridViewTextBoxColumnRussianTitle.HeaderText = "Русское название";
            this.dataGridViewTextBoxColumnRussianTitle.Name = "dataGridViewTextBoxColumnRussianTitle";
            this.dataGridViewTextBoxColumnRussianTitle.ReadOnly = true;
            this.dataGridViewTextBoxColumnRussianTitle.Width = 130;
            // 
            // dataGridViewTextBoxColumnLatinTitle
            // 
            this.dataGridViewTextBoxColumnLatinTitle.DataPropertyName = "LatinTitle";
            this.dataGridViewTextBoxColumnLatinTitle.HeaderText = "Латинское название";
            this.dataGridViewTextBoxColumnLatinTitle.Name = "dataGridViewTextBoxColumnLatinTitle";
            this.dataGridViewTextBoxColumnLatinTitle.ReadOnly = true;
            this.dataGridViewTextBoxColumnLatinTitle.Width = 130;
            // 
            // dataGridViewTextBoxColumnAbbreviation
            // 
            this.dataGridViewTextBoxColumnAbbreviation.DataPropertyName = "Abbreviation";
            this.dataGridViewTextBoxColumnAbbreviation.HeaderText = "Сокращение";
            this.dataGridViewTextBoxColumnAbbreviation.Name = "dataGridViewTextBoxColumnAbbreviation";
            this.dataGridViewTextBoxColumnAbbreviation.ReadOnly = true;
            this.dataGridViewTextBoxColumnAbbreviation.Width = 80;
            // 
            // dataGridViewTextBoxColumnArea
            // 
            this.dataGridViewTextBoxColumnArea.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumnArea.HeaderText = "Площадь (кв. градусы)";
            this.dataGridViewTextBoxColumnArea.Name = "dataGridViewTextBoxColumnArea";
            this.dataGridViewTextBoxColumnArea.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnBrigther6m
            // 
            this.dataGridViewTextBoxColumnBrigther6m.DataPropertyName = "Brigther6m";
            this.dataGridViewTextBoxColumnBrigther6m.HeaderText = "Число звёзд ярче 6.0m";
            this.dataGridViewTextBoxColumnBrigther6m.Name = "dataGridViewTextBoxColumnBrigther6m";
            this.dataGridViewTextBoxColumnBrigther6m.ReadOnly = true;
            // 
            // dataGridViewImageColumnImage
            // 
            this.dataGridViewImageColumnImage.DataPropertyName = "Photo";
            this.dataGridViewImageColumnImage.HeaderText = "Изображение";
            this.dataGridViewImageColumnImage.Name = "dataGridViewImageColumnImage";
            this.dataGridViewImageColumnImage.ReadOnly = true;
            // 
            // splitContainerInfo
            // 
            this.splitContainerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerInfo.Name = "splitContainerInfo";
            this.splitContainerInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerInfo.Panel1
            // 
            this.splitContainerInfo.Panel1.Controls.Add(this.labelRussianTitle);
            this.splitContainerInfo.Panel1.Controls.Add(this.labelLatinTitle);
            this.splitContainerInfo.Panel1.Controls.Add(this.labelAbbreviation);
            this.splitContainerInfo.Panel1.Controls.Add(this.labelArea);
            this.splitContainerInfo.Panel1.Controls.Add(this.labelBrigther6m);
            this.splitContainerInfo.Panel1.Controls.Add(this.textBoxRussianTitle);
            this.splitContainerInfo.Panel1.Controls.Add(this.textBoxLatinTitle);
            this.splitContainerInfo.Panel1.Controls.Add(this.textBoxAbbreviation);
            this.splitContainerInfo.Panel1.Controls.Add(this.numericUpDownArea);
            this.splitContainerInfo.Panel1.Controls.Add(this.numericUpDownBrigther6m);
            this.splitContainerInfo.Panel1.Controls.Add(this.labelPhoto);
            // 
            // splitContainerInfo.Panel2
            // 
            this.splitContainerInfo.Panel2.Controls.Add(this.pictureBoxPhoto);
            this.splitContainerInfo.Size = new System.Drawing.Size(368, 442);
            this.splitContainerInfo.SplitterDistance = 179;
            this.splitContainerInfo.TabIndex = 12;
            // 
            // labelRussianTitle
            // 
            this.labelRussianTitle.AutoSize = true;
            this.labelRussianTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRussianTitle.Location = new System.Drawing.Point(10, 10);
            this.labelRussianTitle.Name = "labelRussianTitle";
            this.labelRussianTitle.Size = new System.Drawing.Size(129, 19);
            this.labelRussianTitle.TabIndex = 6;
            this.labelRussianTitle.Text = "Русское название:";
            // 
            // labelLatinTitle
            // 
            this.labelLatinTitle.AutoSize = true;
            this.labelLatinTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLatinTitle.Location = new System.Drawing.Point(10, 40);
            this.labelLatinTitle.Name = "labelLatinTitle";
            this.labelLatinTitle.Size = new System.Drawing.Size(149, 19);
            this.labelLatinTitle.TabIndex = 7;
            this.labelLatinTitle.Text = "Латинское название:";
            // 
            // labelAbbreviation
            // 
            this.labelAbbreviation.AutoSize = true;
            this.labelAbbreviation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbbreviation.Location = new System.Drawing.Point(10, 70);
            this.labelAbbreviation.Name = "labelAbbreviation";
            this.labelAbbreviation.Size = new System.Drawing.Size(96, 19);
            this.labelAbbreviation.TabIndex = 8;
            this.labelAbbreviation.Text = "Сокращение:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(10, 100);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(163, 19);
            this.labelArea.TabIndex = 9;
            this.labelArea.Text = "Площадь (кв. градусы):";
            // 
            // labelBrigther6m
            // 
            this.labelBrigther6m.AutoSize = true;
            this.labelBrigther6m.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrigther6m.Location = new System.Drawing.Point(10, 130);
            this.labelBrigther6m.Name = "labelBrigther6m";
            this.labelBrigther6m.Size = new System.Drawing.Size(162, 19);
            this.labelBrigther6m.TabIndex = 10;
            this.labelBrigther6m.Text = "Число звёзд ярче 6.0m:";
            // 
            // textBoxRussianTitle
            // 
            this.textBoxRussianTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.constellationsBindingSource, "RussianTitle", true));
            this.textBoxRussianTitle.Location = new System.Drawing.Point(184, 10);
            this.textBoxRussianTitle.Name = "textBoxRussianTitle";
            this.textBoxRussianTitle.Size = new System.Drawing.Size(132, 20);
            this.textBoxRussianTitle.TabIndex = 0;
            this.textBoxRussianTitle.TextChanged += new System.EventHandler(this.textBoxRussianTitle_TextChanged);
            this.textBoxRussianTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CyrillicCharsPressed);
            // 
            // textBoxLatinTitle
            // 
            this.textBoxLatinTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.constellationsBindingSource, "LatinTitle", true));
            this.textBoxLatinTitle.Location = new System.Drawing.Point(184, 40);
            this.textBoxLatinTitle.Name = "textBoxLatinTitle";
            this.textBoxLatinTitle.Size = new System.Drawing.Size(132, 20);
            this.textBoxLatinTitle.TabIndex = 1;
            this.textBoxLatinTitle.TextChanged += new System.EventHandler(this.textBoxLatinTitle_TextChanged);
            this.textBoxLatinTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LatinCharsPressed);
            // 
            // textBoxAbbreviation
            // 
            this.textBoxAbbreviation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.constellationsBindingSource, "Abbreviation", true));
            this.textBoxAbbreviation.Location = new System.Drawing.Point(184, 70);
            this.textBoxAbbreviation.Name = "textBoxAbbreviation";
            this.textBoxAbbreviation.Size = new System.Drawing.Size(132, 20);
            this.textBoxAbbreviation.TabIndex = 2;
            this.textBoxAbbreviation.TextChanged += new System.EventHandler(this.textBoxAbbreviation_TextChanged);
            this.textBoxAbbreviation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LatinCharsPressed);
            // 
            // numericUpDownArea
            // 
            this.numericUpDownArea.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.constellationsBindingSource, "Area", true));
            this.numericUpDownArea.Location = new System.Drawing.Point(184, 100);
            this.numericUpDownArea.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownArea.Name = "numericUpDownArea";
            this.numericUpDownArea.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownArea.TabIndex = 3;
            this.numericUpDownArea.ValueChanged += new System.EventHandler(this.numericUpDownArea_ValueChanged);
            // 
            // numericUpDownBrigther6m
            // 
            this.numericUpDownBrigther6m.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.constellationsBindingSource, "Brigther6m", true));
            this.numericUpDownBrigther6m.Location = new System.Drawing.Point(184, 130);
            this.numericUpDownBrigther6m.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBrigther6m.Name = "numericUpDownBrigther6m";
            this.numericUpDownBrigther6m.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownBrigther6m.TabIndex = 4;
            this.numericUpDownBrigther6m.ValueChanged += new System.EventHandler(this.numericUpDownBrigther6m_ValueChanged);
            // 
            // labelPhoto
            // 
            this.labelPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoto.Location = new System.Drawing.Point(30, 160);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(103, 19);
            this.labelPhoto.TabIndex = 11;
            this.labelPhoto.Text = "Изображение:";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.ContextMenuStrip = this.contextMenuStripImage;
            this.pictureBoxPhoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.constellationsBindingSource, "Photo", true));
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(368, 259);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 5;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveImageToolStripMenuItem});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.contextMenuStripImage.Size = new System.Drawing.Size(134, 48);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadImageToolStripMenuItem.Text = "Загрузить";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveImageToolStripMenuItem.Text = "Сохранить";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // errorProviderRussianTitle
            // 
            this.errorProviderRussianTitle.BlinkRate = 0;
            this.errorProviderRussianTitle.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderRussianTitle.ContainerControl = this;
            // 
            // errorProviderLatinTitle
            // 
            this.errorProviderLatinTitle.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLatinTitle.ContainerControl = this;
            // 
            // errorProviderAbbreviation
            // 
            this.errorProviderAbbreviation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAbbreviation.ContainerControl = this;
            // 
            // errorProviderArea
            // 
            this.errorProviderArea.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderArea.ContainerControl = this;
            // 
            // errorProviderBrigther6m
            // 
            this.errorProviderBrigther6m.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderBrigther6m.ContainerControl = this;
            // 
            // constellationsTableAdapter
            // 
            this.constellationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConstellationsTableAdapter = this.constellationsTableAdapter;
            this.tableAdapterManager.UpdateOrder = RGR.ConstellationsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 516);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStripStatus);
            this.Controls.Add(this.constellationsBindingNavigator);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Созвездия";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constellationsBindingNavigator)).EndInit();
            this.constellationsBindingNavigator.ResumeLayout(false);
            this.constellationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constellationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constellationsDataSet)).EndInit();
            this.toolStripStatus.ResumeLayout(false);
            this.toolStripStatus.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.constellationsDataGridView)).EndInit();
            this.splitContainerInfo.Panel1.ResumeLayout(false);
            this.splitContainerInfo.Panel1.PerformLayout();
            this.splitContainerInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInfo)).EndInit();
            this.splitContainerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrigther6m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.contextMenuStripImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRussianTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLatinTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAbbreviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBrigther6m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ConstellationsDataSet constellationsDataSet;
        private System.Windows.Forms.BindingSource constellationsBindingSource;
        private ConstellationsDataSetTableAdapters.ConstellationsTableAdapter constellationsTableAdapter;
        private ConstellationsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator constellationsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton constellationsBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip toolStripStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabelStatus;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.Label labelBrigther6m;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelAbbreviation;
        private System.Windows.Forms.Label labelLatinTitle;
        private System.Windows.Forms.Label labelRussianTitle;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.NumericUpDown numericUpDownBrigther6m;
        private System.Windows.Forms.NumericUpDown numericUpDownArea;
        private System.Windows.Forms.TextBox textBoxAbbreviation;
        private System.Windows.Forms.TextBox textBoxLatinTitle;
        private System.Windows.Forms.TextBox textBoxRussianTitle;
        private System.Windows.Forms.SplitContainer splitContainerInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProviderRussianTitle;
        private System.Windows.Forms.ErrorProvider errorProviderLatinTitle;
        private System.Windows.Forms.ErrorProvider errorProviderAbbreviation;
        private System.Windows.Forms.ErrorProvider errorProviderArea;
        private System.Windows.Forms.ErrorProvider errorProviderBrigther6m;
        private System.Windows.Forms.DataGridView constellationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnRussianTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnLatinTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAbbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnBrigther6m;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumnImage;
    }
}

