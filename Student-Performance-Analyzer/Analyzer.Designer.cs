namespace Student_Performance_Analyzer
{
    partial class Analyzer_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameUnit_label = new Label();
            DataSetHome_button = new Button();
            StatisticalIndicatorsHome_button = new Button();
            ExportingReportsHome_button = new Button();
            ExitApp_button = new Button();
            Home_panel = new Panel();
            WorkWithBase_panel = new Panel();
            SortDirection_label = new Label();
            SortDirection_comboBox = new ComboBox();
            ChooseFind_textBox = new TextBox();
            ChooseSort_label = new Label();
            Sort_label = new Label();
            Group_label = new Label();
            ChooseGroup_textBox = new TextBox();
            Find_label = new Label();
            ChooseFind_label = new Label();
            GroupRatio_label = new Label();
            ChooseGroup_label = new Label();
            ChooseGroupParam_comboBox = new ComboBox();
            ChooseSortParam_comboBox = new ComboBox();
            FindRatio_comboBox = new ComboBox();
            ChooseFindParam_comboBox = new ComboBox();
            HomeButtons_flowLayoutPanel = new FlowLayoutPanel();
            LoadFile_button = new Button();
            BuildingRatingsHome_button = new Button();
            Rating_panel = new Panel();
            RatingStudent_button = new Button();
            Group_button = new Button();
            Chart_panel = new Panel();
            BarСhart_pictureBox = new PictureBox();
            CircleChart_pictureBox = new PictureBox();
            StatisticalIndicators_panel = new Panel();
            Max_label = new Label();
            Max_textBox = new TextBox();
            Min_label = new Label();
            Min_textBox = new TextBox();
            Median_label = new Label();
            Median_textBox = new TextBox();
            Average_label = new Label();
            Average_textBox = new TextBox();
            StatInfo_panel = new Panel();
            StatInfo_label = new Label();
            StatInfoNum_label = new Label();
            Base_panel = new Panel();
            StudentInfo_dataGridView = new DataGridView();
            StudentsID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Cours = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            Subject1 = new DataGridViewTextBoxColumn();
            Subject2 = new DataGridViewTextBoxColumn();
            Subject3 = new DataGridViewTextBoxColumn();
            Subject4 = new DataGridViewTextBoxColumn();
            Subject5 = new DataGridViewTextBoxColumn();
            Subject6 = new DataGridViewTextBoxColumn();
            Subject7 = new DataGridViewTextBoxColumn();
            Subject8 = new DataGridViewTextBoxColumn();
            Subject9 = new DataGridViewTextBoxColumn();
            Subject10 = new DataGridViewTextBoxColumn();
            AverageScore = new DataGridViewTextBoxColumn();
            ArrearsNumber = new DataGridViewTextBoxColumn();
            Button_panel = new Panel();
            Apply_button = new Button();
            Remove_button = new Button();
            Return_button = new Button();
            WorkWithBaseInfo_button = new Button();
            Home_panel.SuspendLayout();
            WorkWithBase_panel.SuspendLayout();
            HomeButtons_flowLayoutPanel.SuspendLayout();
            Rating_panel.SuspendLayout();
            Chart_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BarСhart_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CircleChart_pictureBox).BeginInit();
            StatisticalIndicators_panel.SuspendLayout();
            StatInfo_panel.SuspendLayout();
            Base_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentInfo_dataGridView).BeginInit();
            Button_panel.SuspendLayout();
            SuspendLayout();
            // 
            // NameUnit_label
            // 
            NameUnit_label.Anchor = AnchorStyles.Top;
            NameUnit_label.BackColor = Color.Transparent;
            NameUnit_label.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameUnit_label.Location = new Point(15, 15);
            NameUnit_label.Margin = new Padding(4, 0, 4, 0);
            NameUnit_label.Name = "NameUnit_label";
            NameUnit_label.Size = new Size(1359, 64);
            NameUnit_label.TabIndex = 0;
            NameUnit_label.Text = "Анализатор успеваемости студентов";
            NameUnit_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // DataSetHome_button
            // 
            DataSetHome_button.AutoSize = true;
            DataSetHome_button.BackColor = Color.Transparent;
            DataSetHome_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DataSetHome_button.Location = new Point(4, 96);
            DataSetHome_button.Margin = new Padding(4, 2, 4, 2);
            DataSetHome_button.Name = "DataSetHome_button";
            DataSetHome_button.Size = new Size(546, 90);
            DataSetHome_button.TabIndex = 1;
            DataSetHome_button.Text = "Работа с базой данных";
            DataSetHome_button.UseVisualStyleBackColor = false;
            DataSetHome_button.Click += Home_button_Click;
            // 
            // StatisticalIndicatorsHome_button
            // 
            StatisticalIndicatorsHome_button.AutoSize = true;
            StatisticalIndicatorsHome_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StatisticalIndicatorsHome_button.Location = new Point(4, 190);
            StatisticalIndicatorsHome_button.Margin = new Padding(4, 2, 4, 2);
            StatisticalIndicatorsHome_button.Name = "StatisticalIndicatorsHome_button";
            StatisticalIndicatorsHome_button.Size = new Size(546, 90);
            StatisticalIndicatorsHome_button.TabIndex = 2;
            StatisticalIndicatorsHome_button.Text = "Вычисление статистических показателей";
            StatisticalIndicatorsHome_button.UseVisualStyleBackColor = true;
            StatisticalIndicatorsHome_button.Click += Home_button_Click;
            // 
            // ExportingReportsHome_button
            // 
            ExportingReportsHome_button.AutoSize = true;
            ExportingReportsHome_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExportingReportsHome_button.Location = new Point(4, 378);
            ExportingReportsHome_button.Margin = new Padding(4, 2, 4, 2);
            ExportingReportsHome_button.Name = "ExportingReportsHome_button";
            ExportingReportsHome_button.Size = new Size(546, 90);
            ExportingReportsHome_button.TabIndex = 4;
            ExportingReportsHome_button.Text = "Экспорт отчета";
            ExportingReportsHome_button.UseVisualStyleBackColor = true;
            ExportingReportsHome_button.Click += Save_Click;
            // 
            // ExitApp_button
            // 
            ExitApp_button.AutoSize = true;
            ExitApp_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitApp_button.Location = new Point(4, 472);
            ExitApp_button.Margin = new Padding(4, 2, 4, 2);
            ExitApp_button.Name = "ExitApp_button";
            ExitApp_button.Size = new Size(546, 90);
            ExitApp_button.TabIndex = 6;
            ExitApp_button.Text = "Выход из приложения";
            ExitApp_button.UseVisualStyleBackColor = true;
            ExitApp_button.Click += Home_button_Click;
            // 
            // Home_panel
            // 
            Home_panel.BackColor = Color.Transparent;
            Home_panel.Controls.Add(WorkWithBase_panel);
            Home_panel.Controls.Add(HomeButtons_flowLayoutPanel);
            Home_panel.Controls.Add(Rating_panel);
            Home_panel.Controls.Add(Chart_panel);
            Home_panel.Controls.Add(StatisticalIndicators_panel);
            Home_panel.Controls.Add(StatInfo_panel);
            Home_panel.Controls.Add(Base_panel);
            Home_panel.Controls.Add(NameUnit_label);
            Home_panel.Controls.Add(Button_panel);
            Home_panel.Dock = DockStyle.Fill;
            Home_panel.Location = new Point(0, 0);
            Home_panel.Margin = new Padding(4, 2, 4, 2);
            Home_panel.Name = "Home_panel";
            Home_panel.Size = new Size(1384, 1028);
            Home_panel.TabIndex = 7;
            // 
            // WorkWithBase_panel
            // 
            WorkWithBase_panel.Controls.Add(SortDirection_label);
            WorkWithBase_panel.Controls.Add(SortDirection_comboBox);
            WorkWithBase_panel.Controls.Add(ChooseFind_textBox);
            WorkWithBase_panel.Controls.Add(ChooseSort_label);
            WorkWithBase_panel.Controls.Add(Sort_label);
            WorkWithBase_panel.Controls.Add(Group_label);
            WorkWithBase_panel.Controls.Add(ChooseGroup_textBox);
            WorkWithBase_panel.Controls.Add(Find_label);
            WorkWithBase_panel.Controls.Add(ChooseFind_label);
            WorkWithBase_panel.Controls.Add(GroupRatio_label);
            WorkWithBase_panel.Controls.Add(ChooseGroup_label);
            WorkWithBase_panel.Controls.Add(ChooseGroupParam_comboBox);
            WorkWithBase_panel.Controls.Add(ChooseSortParam_comboBox);
            WorkWithBase_panel.Controls.Add(FindRatio_comboBox);
            WorkWithBase_panel.Controls.Add(ChooseFindParam_comboBox);
            WorkWithBase_panel.Location = new Point(0, 90);
            WorkWithBase_panel.Margin = new Padding(4, 2, 4, 2);
            WorkWithBase_panel.Name = "WorkWithBase_panel";
            WorkWithBase_panel.Size = new Size(457, 736);
            WorkWithBase_panel.TabIndex = 30;
            WorkWithBase_panel.Visible = false;
            // 
            // SortDirection_label
            // 
            SortDirection_label.Anchor = AnchorStyles.None;
            SortDirection_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            SortDirection_label.Location = new Point(7, 151);
            SortDirection_label.Margin = new Padding(4, 0, 4, 0);
            SortDirection_label.Name = "SortDirection_label";
            SortDirection_label.Size = new Size(435, 45);
            SortDirection_label.TabIndex = 27;
            SortDirection_label.Text = "Направление сортировки";
            SortDirection_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // SortDirection_comboBox
            // 
            SortDirection_comboBox.Anchor = AnchorStyles.None;
            SortDirection_comboBox.FormattingEnabled = true;
            SortDirection_comboBox.Items.AddRange(new object[] { "Возрастание", "Убывание" });
            SortDirection_comboBox.Location = new Point(7, 201);
            SortDirection_comboBox.Margin = new Padding(4, 2, 4, 2);
            SortDirection_comboBox.Name = "SortDirection_comboBox";
            SortDirection_comboBox.Size = new Size(435, 40);
            SortDirection_comboBox.TabIndex = 26;
            // 
            // ChooseFind_textBox
            // 
            ChooseFind_textBox.Anchor = AnchorStyles.None;
            ChooseFind_textBox.Location = new Point(4, 425);
            ChooseFind_textBox.Margin = new Padding(4, 2, 4, 2);
            ChooseFind_textBox.Name = "ChooseFind_textBox";
            ChooseFind_textBox.Size = new Size(435, 39);
            ChooseFind_textBox.TabIndex = 24;
            // 
            // ChooseSort_label
            // 
            ChooseSort_label.Anchor = AnchorStyles.None;
            ChooseSort_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ChooseSort_label.Location = new Point(15, 51);
            ChooseSort_label.Margin = new Padding(4, 0, 4, 0);
            ChooseSort_label.Name = "ChooseSort_label";
            ChooseSort_label.Size = new Size(435, 45);
            ChooseSort_label.TabIndex = 25;
            ChooseSort_label.Text = "Выберите параметр сортировки";
            ChooseSort_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Sort_label
            // 
            Sort_label.Anchor = AnchorStyles.None;
            Sort_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Sort_label.Location = new Point(93, 15);
            Sort_label.Margin = new Padding(4, 0, 4, 0);
            Sort_label.Name = "Sort_label";
            Sort_label.Size = new Size(288, 45);
            Sort_label.TabIndex = 9;
            Sort_label.Text = "Сортировка студентов";
            Sort_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Group_label
            // 
            Group_label.Anchor = AnchorStyles.None;
            Group_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Group_label.Location = new Point(69, 486);
            Group_label.Margin = new Padding(4, 0, 4, 0);
            Group_label.Name = "Group_label";
            Group_label.Size = new Size(288, 38);
            Group_label.TabIndex = 10;
            Group_label.Text = "Группировка студентов";
            Group_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseGroup_textBox
            // 
            ChooseGroup_textBox.Anchor = AnchorStyles.None;
            ChooseGroup_textBox.Location = new Point(4, 627);
            ChooseGroup_textBox.Margin = new Padding(4, 2, 4, 2);
            ChooseGroup_textBox.Name = "ChooseGroup_textBox";
            ChooseGroup_textBox.Size = new Size(435, 39);
            ChooseGroup_textBox.TabIndex = 24;
            // 
            // Find_label
            // 
            Find_label.Anchor = AnchorStyles.None;
            Find_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Find_label.Location = new Point(69, 265);
            Find_label.Margin = new Padding(4, 0, 4, 0);
            Find_label.Name = "Find_label";
            Find_label.Size = new Size(288, 41);
            Find_label.TabIndex = 11;
            Find_label.Text = "Поиск студентов";
            Find_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseFind_label
            // 
            ChooseFind_label.Anchor = AnchorStyles.None;
            ChooseFind_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ChooseFind_label.Location = new Point(-4, 305);
            ChooseFind_label.Margin = new Padding(4, 0, 4, 0);
            ChooseFind_label.Name = "ChooseFind_label";
            ChooseFind_label.Size = new Size(435, 45);
            ChooseFind_label.TabIndex = 13;
            ChooseFind_label.Text = "Введите параметр поиска";
            ChooseFind_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // GroupRatio_label
            // 
            GroupRatio_label.Anchor = AnchorStyles.None;
            GroupRatio_label.BorderStyle = BorderStyle.FixedSingle;
            GroupRatio_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            GroupRatio_label.Location = new Point(345, 572);
            GroupRatio_label.Margin = new Padding(4, 0, 4, 0);
            GroupRatio_label.Name = "GroupRatio_label";
            GroupRatio_label.Size = new Size(93, 40);
            GroupRatio_label.TabIndex = 22;
            GroupRatio_label.Text = "=";
            GroupRatio_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseGroup_label
            // 
            ChooseGroup_label.Anchor = AnchorStyles.None;
            ChooseGroup_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ChooseGroup_label.Location = new Point(4, 527);
            ChooseGroup_label.Margin = new Padding(4, 0, 4, 0);
            ChooseGroup_label.Name = "ChooseGroup_label";
            ChooseGroup_label.Size = new Size(435, 36);
            ChooseGroup_label.TabIndex = 14;
            ChooseGroup_label.Text = "Введите параметр группировки";
            ChooseGroup_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseGroupParam_comboBox
            // 
            ChooseGroupParam_comboBox.Anchor = AnchorStyles.None;
            ChooseGroupParam_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ChooseGroupParam_comboBox.FormattingEnabled = true;
            ChooseGroupParam_comboBox.Items.AddRange(new object[] { "Курс студента", "Группа студента" });
            ChooseGroupParam_comboBox.Location = new Point(4, 565);
            ChooseGroupParam_comboBox.Margin = new Padding(4, 2, 4, 2);
            ChooseGroupParam_comboBox.Name = "ChooseGroupParam_comboBox";
            ChooseGroupParam_comboBox.Size = new Size(312, 40);
            ChooseGroupParam_comboBox.TabIndex = 19;
            // 
            // ChooseSortParam_comboBox
            // 
            ChooseSortParam_comboBox.Anchor = AnchorStyles.None;
            ChooseSortParam_comboBox.ForeColor = Color.Black;
            ChooseSortParam_comboBox.FormattingEnabled = true;
            ChooseSortParam_comboBox.Items.AddRange(new object[] { "ФИО студента", "Общий средний балл", "Количество задолженностей" });
            ChooseSortParam_comboBox.Location = new Point(7, 107);
            ChooseSortParam_comboBox.Margin = new Padding(4, 2, 4, 2);
            ChooseSortParam_comboBox.Name = "ChooseSortParam_comboBox";
            ChooseSortParam_comboBox.Size = new Size(435, 40);
            ChooseSortParam_comboBox.TabIndex = 15;
            // 
            // FindRatio_comboBox
            // 
            FindRatio_comboBox.Anchor = AnchorStyles.None;
            FindRatio_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FindRatio_comboBox.FormattingEnabled = true;
            FindRatio_comboBox.Items.AddRange(new object[] { "=", ">", ">=", "<", "<=" });
            FindRatio_comboBox.Location = new Point(345, 352);
            FindRatio_comboBox.Margin = new Padding(4, 2, 4, 2);
            FindRatio_comboBox.Name = "FindRatio_comboBox";
            FindRatio_comboBox.Size = new Size(91, 40);
            FindRatio_comboBox.TabIndex = 17;
            // 
            // ChooseFindParam_comboBox
            // 
            ChooseFindParam_comboBox.Anchor = AnchorStyles.None;
            ChooseFindParam_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ChooseFindParam_comboBox.FormattingEnabled = true;
            ChooseFindParam_comboBox.Items.AddRange(new object[] { "ФИО студента", "Общий средний балл", "Кол-во задолженностей" });
            ChooseFindParam_comboBox.Location = new Point(4, 352);
            ChooseFindParam_comboBox.Margin = new Padding(4, 2, 4, 2);
            ChooseFindParam_comboBox.Name = "ChooseFindParam_comboBox";
            ChooseFindParam_comboBox.Size = new Size(312, 40);
            ChooseFindParam_comboBox.TabIndex = 16;
            // 
            // HomeButtons_flowLayoutPanel
            // 
            HomeButtons_flowLayoutPanel.Anchor = AnchorStyles.None;
            HomeButtons_flowLayoutPanel.AutoSize = true;
            HomeButtons_flowLayoutPanel.BackColor = Color.Transparent;
            HomeButtons_flowLayoutPanel.Controls.Add(LoadFile_button);
            HomeButtons_flowLayoutPanel.Controls.Add(DataSetHome_button);
            HomeButtons_flowLayoutPanel.Controls.Add(StatisticalIndicatorsHome_button);
            HomeButtons_flowLayoutPanel.Controls.Add(BuildingRatingsHome_button);
            HomeButtons_flowLayoutPanel.Controls.Add(ExportingReportsHome_button);
            HomeButtons_flowLayoutPanel.Controls.Add(ExitApp_button);
            HomeButtons_flowLayoutPanel.Location = new Point(431, 218);
            HomeButtons_flowLayoutPanel.Margin = new Padding(4, 2, 4, 2);
            HomeButtons_flowLayoutPanel.MaximumSize = new Size(700, 800);
            HomeButtons_flowLayoutPanel.MinimumSize = new Size(496, 582);
            HomeButtons_flowLayoutPanel.Name = "HomeButtons_flowLayoutPanel";
            HomeButtons_flowLayoutPanel.Size = new Size(554, 582);
            HomeButtons_flowLayoutPanel.TabIndex = 9;
            // 
            // LoadFile_button
            // 
            LoadFile_button.AutoSize = true;
            LoadFile_button.BackColor = Color.Transparent;
            LoadFile_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoadFile_button.Location = new Point(4, 2);
            LoadFile_button.Margin = new Padding(4, 2, 4, 2);
            LoadFile_button.Name = "LoadFile_button";
            LoadFile_button.Size = new Size(546, 90);
            LoadFile_button.TabIndex = 7;
            LoadFile_button.Text = "Загрузить файл";
            LoadFile_button.UseVisualStyleBackColor = false;
            LoadFile_button.Click += LoadFile_button_Click;
            // 
            // BuildingRatingsHome_button
            // 
            BuildingRatingsHome_button.AutoSize = true;
            BuildingRatingsHome_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BuildingRatingsHome_button.Location = new Point(4, 284);
            BuildingRatingsHome_button.Margin = new Padding(4, 2, 4, 2);
            BuildingRatingsHome_button.Name = "BuildingRatingsHome_button";
            BuildingRatingsHome_button.Size = new Size(546, 90);
            BuildingRatingsHome_button.TabIndex = 3;
            BuildingRatingsHome_button.Text = "Построение рейтингов";
            BuildingRatingsHome_button.UseVisualStyleBackColor = true;
            BuildingRatingsHome_button.Click += Home_button_Click;
            // 
            // Rating_panel
            // 
            Rating_panel.AutoSize = true;
            Rating_panel.Controls.Add(RatingStudent_button);
            Rating_panel.Controls.Add(Group_button);
            Rating_panel.Location = new Point(936, 862);
            Rating_panel.Margin = new Padding(4, 2, 4, 2);
            Rating_panel.Name = "Rating_panel";
            Rating_panel.Size = new Size(446, 162);
            Rating_panel.TabIndex = 33;
            Rating_panel.Visible = false;
            // 
            // RatingStudent_button
            // 
            RatingStudent_button.Anchor = AnchorStyles.None;
            RatingStudent_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RatingStudent_button.Location = new Point(4, 34);
            RatingStudent_button.Margin = new Padding(4, 2, 4, 2);
            RatingStudent_button.Name = "RatingStudent_button";
            RatingStudent_button.Size = new Size(225, 90);
            RatingStudent_button.TabIndex = 29;
            RatingStudent_button.Text = "Рейтинг студентов";
            RatingStudent_button.UseVisualStyleBackColor = true;
            // 
            // Group_button
            // 
            Group_button.Anchor = AnchorStyles.None;
            Group_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Group_button.Location = new Point(236, 34);
            Group_button.Margin = new Padding(4, 2, 4, 2);
            Group_button.Name = "Group_button";
            Group_button.Size = new Size(206, 90);
            Group_button.TabIndex = 28;
            Group_button.Text = "Рейтинг групп";
            Group_button.UseVisualStyleBackColor = true;
            // 
            // Chart_panel
            // 
            Chart_panel.AutoSize = true;
            Chart_panel.Controls.Add(BarСhart_pictureBox);
            Chart_panel.Controls.Add(CircleChart_pictureBox);
            Chart_panel.Location = new Point(0, 90);
            Chart_panel.Margin = new Padding(4, 2, 4, 2);
            Chart_panel.Name = "Chart_panel";
            Chart_panel.Size = new Size(514, 743);
            Chart_panel.TabIndex = 30;
            Chart_panel.Visible = false;
            // 
            // BarСhart_pictureBox
            // 
            BarСhart_pictureBox.Anchor = AnchorStyles.None;
            BarСhart_pictureBox.BackColor = Color.Transparent;
            BarСhart_pictureBox.Location = new Point(-4, 363);
            BarСhart_pictureBox.Margin = new Padding(4, 2, 4, 2);
            BarСhart_pictureBox.Name = "BarСhart_pictureBox";
            BarСhart_pictureBox.Size = new Size(514, 378);
            BarСhart_pictureBox.TabIndex = 31;
            BarСhart_pictureBox.TabStop = false;
            // 
            // CircleChart_pictureBox
            // 
            CircleChart_pictureBox.Anchor = AnchorStyles.None;
            CircleChart_pictureBox.BackColor = Color.Transparent;
            CircleChart_pictureBox.Location = new Point(-4, 2);
            CircleChart_pictureBox.Margin = new Padding(4, 2, 4, 2);
            CircleChart_pictureBox.Name = "CircleChart_pictureBox";
            CircleChart_pictureBox.Size = new Size(514, 365);
            CircleChart_pictureBox.TabIndex = 30;
            CircleChart_pictureBox.TabStop = false;
            // 
            // StatisticalIndicators_panel
            // 
            StatisticalIndicators_panel.Controls.Add(Max_label);
            StatisticalIndicators_panel.Controls.Add(Max_textBox);
            StatisticalIndicators_panel.Controls.Add(Min_label);
            StatisticalIndicators_panel.Controls.Add(Min_textBox);
            StatisticalIndicators_panel.Controls.Add(Median_label);
            StatisticalIndicators_panel.Controls.Add(Median_textBox);
            StatisticalIndicators_panel.Controls.Add(Average_label);
            StatisticalIndicators_panel.Controls.Add(Average_textBox);
            StatisticalIndicators_panel.Location = new Point(0, 90);
            StatisticalIndicators_panel.Margin = new Padding(4, 2, 4, 2);
            StatisticalIndicators_panel.Name = "StatisticalIndicators_panel";
            StatisticalIndicators_panel.Size = new Size(518, 730);
            StatisticalIndicators_panel.TabIndex = 25;
            StatisticalIndicators_panel.Visible = false;
            // 
            // Max_label
            // 
            Max_label.Anchor = AnchorStyles.None;
            Max_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Max_label.Location = new Point(41, 493);
            Max_label.Margin = new Padding(4, 0, 4, 0);
            Max_label.Name = "Max_label";
            Max_label.Size = new Size(305, 45);
            Max_label.TabIndex = 28;
            Max_label.Text = "Максимальное значение";
            Max_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Max_textBox
            // 
            Max_textBox.Anchor = AnchorStyles.None;
            Max_textBox.Location = new Point(41, 565);
            Max_textBox.Margin = new Padding(4, 2, 4, 2);
            Max_textBox.Name = "Max_textBox";
            Max_textBox.Size = new Size(325, 39);
            Max_textBox.TabIndex = 29;
            // 
            // Min_label
            // 
            Min_label.Anchor = AnchorStyles.None;
            Min_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Min_label.Location = new Point(41, 314);
            Min_label.Margin = new Padding(4, 0, 4, 0);
            Min_label.Name = "Min_label";
            Min_label.Size = new Size(305, 45);
            Min_label.TabIndex = 26;
            Min_label.Text = "Минимальное значение";
            Min_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Min_textBox
            // 
            Min_textBox.Anchor = AnchorStyles.None;
            Min_textBox.Location = new Point(41, 386);
            Min_textBox.Margin = new Padding(4, 2, 4, 2);
            Min_textBox.Name = "Min_textBox";
            Min_textBox.Size = new Size(327, 39);
            Min_textBox.TabIndex = 27;
            // 
            // Median_label
            // 
            Median_label.Anchor = AnchorStyles.None;
            Median_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Median_label.Location = new Point(41, 162);
            Median_label.Margin = new Padding(4, 0, 4, 0);
            Median_label.Name = "Median_label";
            Median_label.Size = new Size(163, 45);
            Median_label.TabIndex = 24;
            Median_label.Text = "Медиана";
            Median_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Median_textBox
            // 
            Median_textBox.Anchor = AnchorStyles.None;
            Median_textBox.Location = new Point(41, 235);
            Median_textBox.Margin = new Padding(4, 2, 4, 2);
            Median_textBox.Name = "Median_textBox";
            Median_textBox.Size = new Size(327, 39);
            Median_textBox.TabIndex = 25;
            // 
            // Average_label
            // 
            Average_label.Anchor = AnchorStyles.None;
            Average_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Average_label.Location = new Point(41, 15);
            Average_label.Margin = new Padding(4, 0, 4, 0);
            Average_label.Name = "Average_label";
            Average_label.Size = new Size(327, 45);
            Average_label.TabIndex = 12;
            Average_label.Text = "Среднее арифметическое";
            Average_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Average_textBox
            // 
            Average_textBox.Anchor = AnchorStyles.None;
            Average_textBox.Location = new Point(41, 85);
            Average_textBox.Margin = new Padding(4, 2, 4, 2);
            Average_textBox.Name = "Average_textBox";
            Average_textBox.Size = new Size(325, 39);
            Average_textBox.TabIndex = 23;
            // 
            // StatInfo_panel
            // 
            StatInfo_panel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StatInfo_panel.AutoSize = true;
            StatInfo_panel.Controls.Add(StatInfo_label);
            StatInfo_panel.Controls.Add(StatInfoNum_label);
            StatInfo_panel.Location = new Point(955, 875);
            StatInfo_panel.Margin = new Padding(4, 2, 4, 2);
            StatInfo_panel.Name = "StatInfo_panel";
            StatInfo_panel.Size = new Size(403, 64);
            StatInfo_panel.TabIndex = 32;
            StatInfo_panel.Visible = false;
            // 
            // StatInfo_label
            // 
            StatInfo_label.Dock = DockStyle.Fill;
            StatInfo_label.Location = new Point(0, 0);
            StatInfo_label.Margin = new Padding(4, 0, 4, 0);
            StatInfo_label.Name = "StatInfo_label";
            StatInfo_label.Size = new Size(247, 64);
            StatInfo_label.TabIndex = 1;
            StatInfo_label.Text = "Количество записей:";
            // 
            // StatInfoNum_label
            // 
            StatInfoNum_label.Dock = DockStyle.Right;
            StatInfoNum_label.Location = new Point(247, 0);
            StatInfoNum_label.Margin = new Padding(4, 0, 4, 0);
            StatInfoNum_label.Name = "StatInfoNum_label";
            StatInfoNum_label.Size = new Size(156, 64);
            StatInfoNum_label.TabIndex = 0;
            StatInfoNum_label.Text = "0";
            // 
            // Base_panel
            // 
            Base_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Base_panel.AutoSize = true;
            Base_panel.BackColor = Color.Transparent;
            Base_panel.Controls.Add(StudentInfo_dataGridView);
            Base_panel.Location = new Point(518, 90);
            Base_panel.Margin = new Padding(4, 2, 4, 2);
            Base_panel.Name = "Base_panel";
            Base_panel.Size = new Size(860, 743);
            Base_panel.TabIndex = 9;
            Base_panel.Visible = false;
            // 
            // StudentInfo_dataGridView
            // 
            StudentInfo_dataGridView.AllowUserToAddRows = false;
            StudentInfo_dataGridView.AllowUserToDeleteRows = false;
            StudentInfo_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            StudentInfo_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentInfo_dataGridView.Columns.AddRange(new DataGridViewColumn[] { StudentsID, StudentName, Cours, Group, Subject1, Subject2, Subject3, Subject4, Subject5, Subject6, Subject7, Subject8, Subject9, Subject10, AverageScore, ArrearsNumber });
            StudentInfo_dataGridView.Dock = DockStyle.Fill;
            StudentInfo_dataGridView.Location = new Point(0, 0);
            StudentInfo_dataGridView.Margin = new Padding(4, 2, 4, 2);
            StudentInfo_dataGridView.Name = "StudentInfo_dataGridView";
            StudentInfo_dataGridView.RowHeadersWidth = 82;
            StudentInfo_dataGridView.Size = new Size(860, 743);
            StudentInfo_dataGridView.TabIndex = 8;
            // 
            // StudentsID
            // 
            StudentsID.HeaderText = "ID";
            StudentsID.MinimumWidth = 10;
            StudentsID.Name = "StudentsID";
            StudentsID.Width = 82;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "ФИО студента";
            StudentName.MinimumWidth = 10;
            StudentName.Name = "StudentName";
            StudentName.Width = 197;
            // 
            // Cours
            // 
            Cours.HeaderText = "Курс ";
            Cours.MinimumWidth = 10;
            Cours.Name = "Cours";
            Cours.Width = 117;
            // 
            // Group
            // 
            Group.HeaderText = "Группа ";
            Group.MinimumWidth = 10;
            Group.Name = "Group";
            Group.Width = 143;
            // 
            // Subject1
            // 
            Subject1.HeaderText = "Предмет1";
            Subject1.MinimumWidth = 10;
            Subject1.Name = "Subject1";
            Subject1.Width = 169;
            // 
            // Subject2
            // 
            Subject2.HeaderText = "Предмет2";
            Subject2.MinimumWidth = 10;
            Subject2.Name = "Subject2";
            Subject2.Width = 169;
            // 
            // Subject3
            // 
            Subject3.HeaderText = "Предмет3";
            Subject3.MinimumWidth = 10;
            Subject3.Name = "Subject3";
            Subject3.Width = 169;
            // 
            // Subject4
            // 
            Subject4.HeaderText = "Предмет4";
            Subject4.MinimumWidth = 10;
            Subject4.Name = "Subject4";
            Subject4.Width = 169;
            // 
            // Subject5
            // 
            Subject5.HeaderText = "Предмет5";
            Subject5.MinimumWidth = 10;
            Subject5.Name = "Subject5";
            Subject5.Width = 169;
            // 
            // Subject6
            // 
            Subject6.HeaderText = "Предмет6";
            Subject6.MinimumWidth = 10;
            Subject6.Name = "Subject6";
            Subject6.Width = 169;
            // 
            // Subject7
            // 
            Subject7.HeaderText = "Предмет7";
            Subject7.MinimumWidth = 10;
            Subject7.Name = "Subject7";
            Subject7.Width = 169;
            // 
            // Subject8
            // 
            Subject8.HeaderText = "Предмет8";
            Subject8.MinimumWidth = 10;
            Subject8.Name = "Subject8";
            Subject8.Width = 169;
            // 
            // Subject9
            // 
            Subject9.HeaderText = "Предмет9";
            Subject9.MinimumWidth = 10;
            Subject9.Name = "Subject9";
            Subject9.Width = 169;
            // 
            // Subject10
            // 
            Subject10.HeaderText = "Предмет10";
            Subject10.MinimumWidth = 10;
            Subject10.Name = "Subject10";
            Subject10.Width = 182;
            // 
            // AverageScore
            // 
            AverageScore.HeaderText = "Общий средний балл ";
            AverageScore.MinimumWidth = 10;
            AverageScore.Name = "AverageScore";
            AverageScore.Width = 225;
            // 
            // ArrearsNumber
            // 
            ArrearsNumber.HeaderText = "Кол-во задолженностей";
            ArrearsNumber.MinimumWidth = 10;
            ArrearsNumber.Name = "ArrearsNumber";
            ArrearsNumber.Width = 299;
            // 
            // Button_panel
            // 
            Button_panel.Controls.Add(Apply_button);
            Button_panel.Controls.Add(Remove_button);
            Button_panel.Controls.Add(Return_button);
            Button_panel.Controls.Add(WorkWithBaseInfo_button);
            Button_panel.Location = new Point(0, 862);
            Button_panel.Margin = new Padding(4, 2, 4, 2);
            Button_panel.Name = "Button_panel";
            Button_panel.Size = new Size(923, 169);
            Button_panel.TabIndex = 29;
            // 
            // Apply_button
            // 
            Apply_button.Anchor = AnchorStyles.None;
            Apply_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Apply_button.Location = new Point(236, 36);
            Apply_button.Margin = new Padding(4, 2, 4, 2);
            Apply_button.Name = "Apply_button";
            Apply_button.Size = new Size(225, 90);
            Apply_button.TabIndex = 25;
            Apply_button.Text = "Применить";
            Apply_button.UseVisualStyleBackColor = true;
            Apply_button.Visible = false;
            Apply_button.Click += Apply_button_Click;
            // 
            // Remove_button
            // 
            Remove_button.Anchor = AnchorStyles.None;
            Remove_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Remove_button.Location = new Point(464, 36);
            Remove_button.Margin = new Padding(4, 2, 4, 2);
            Remove_button.Name = "Remove_button";
            Remove_button.Size = new Size(225, 90);
            Remove_button.TabIndex = 26;
            Remove_button.Text = "Очистить";
            Remove_button.UseVisualStyleBackColor = true;
            Remove_button.Visible = false;
            Remove_button.Click += Remove_button_Click;
            // 
            // Return_button
            // 
            Return_button.Anchor = AnchorStyles.None;
            Return_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Return_button.Location = new Point(695, 36);
            Return_button.Margin = new Padding(4, 2, 4, 2);
            Return_button.Name = "Return_button";
            Return_button.Size = new Size(225, 90);
            Return_button.TabIndex = 27;
            Return_button.Text = "Возврат в главное меню";
            Return_button.UseVisualStyleBackColor = true;
            Return_button.Visible = false;
            Return_button.Click += ReturnInMenu_button_Click;
            // 
            // WorkWithBaseInfo_button
            // 
            WorkWithBaseInfo_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WorkWithBaseInfo_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WorkWithBaseInfo_button.Location = new Point(4, 36);
            WorkWithBaseInfo_button.Margin = new Padding(4, 2, 4, 2);
            WorkWithBaseInfo_button.Name = "WorkWithBaseInfo_button";
            WorkWithBaseInfo_button.Size = new Size(225, 90);
            WorkWithBaseInfo_button.TabIndex = 7;
            WorkWithBaseInfo_button.Text = "Справка пользователя";
            WorkWithBaseInfo_button.UseVisualStyleBackColor = true;
            // 
            // Analyzer_form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1384, 1028);
            Controls.Add(Home_panel);
            DoubleBuffered = true;
            Margin = new Padding(4, 2, 4, 2);
            MinimumSize = new Size(1391, 1031);
            Name = "Analyzer_form";
            Text = "Анализатор успеваемости студентов ";
            Home_panel.ResumeLayout(false);
            Home_panel.PerformLayout();
            WorkWithBase_panel.ResumeLayout(false);
            WorkWithBase_panel.PerformLayout();
            HomeButtons_flowLayoutPanel.ResumeLayout(false);
            HomeButtons_flowLayoutPanel.PerformLayout();
            Rating_panel.ResumeLayout(false);
            Chart_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BarСhart_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CircleChart_pictureBox).EndInit();
            StatisticalIndicators_panel.ResumeLayout(false);
            StatisticalIndicators_panel.PerformLayout();
            StatInfo_panel.ResumeLayout(false);
            Base_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentInfo_dataGridView).EndInit();
            Button_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label NameUnit_label;
        private Button DataSetHome_button;
        private Button StatisticalIndicatorsHome_button;
        private Button ExportingReportsHome_button;
        private Button ExitApp_button;
        private Panel Home_panel;
        private Button LoadFile_button;
        private Button BuildingRatingsHome_button;
        private Panel Button_panel;
        private Button Apply_button;
        private Button Remove_button;
        private Button Return_button;
        private Button WorkWithBaseInfo_button;
        private DataGridView StudentInfo_dataGridView;
        private Panel WorkWithBase_panel;
        private Label Average_label;
        private Label Sort_label;
        private Label Group_label;
        private TextBox ChooseGroup_textBox;
        private Label Find_label;
        private TextBox Average_textBox;
        private Label ChooseFind_label;
        private Label GroupRatio_label;
        private Label ChooseGroup_label;
        private ComboBox ChooseGroupParam_comboBox;
        private ComboBox ChooseSortParam_comboBox;
        private ComboBox FindRatio_comboBox;
        private ComboBox ChooseFindParam_comboBox;
        private Panel Base_panel;
        private Panel StatInfo_panel;
        private Label StatInfoNum_label;
        private Label StatInfo_label;
        private FlowLayoutPanel HomeButtons_flowLayoutPanel;
        private Panel StatisticalIndicators_panel;
        private Label Max_label;
        private TextBox Max_textBox;
        private Label Min_label;
        private TextBox Min_textBox;
        private Label Median_label;
        private TextBox Median_textBox;
        private TextBox ChooseFind_textBox;
        private Label ChooseSort_label;
        private PictureBox BarСhart_pictureBox;
        private PictureBox CircleChart_pictureBox;
        private Panel Chart_panel;
        private Panel Rating_panel;
        private Button Group_button;
        private Button RatingStudent_button;
        private Label SortDirection_label;
        private ComboBox SortDirection_comboBox;
        private DataGridViewTextBoxColumn StudentsID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Cours;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn Subject1;
        private DataGridViewTextBoxColumn Subject2;
        private DataGridViewTextBoxColumn Subject3;
        private DataGridViewTextBoxColumn Subject4;
        private DataGridViewTextBoxColumn Subject5;
        private DataGridViewTextBoxColumn Subject6;
        private DataGridViewTextBoxColumn Subject7;
        private DataGridViewTextBoxColumn Subject8;
        private DataGridViewTextBoxColumn Subject9;
        private DataGridViewTextBoxColumn Subject10;
        private DataGridViewTextBoxColumn AverageScore;
        private DataGridViewTextBoxColumn ArrearsNumber;
    }
}
