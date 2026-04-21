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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            NameUnit_label = new Label();
            DataSetHome_button = new Button();
            StatisticalIndicatorsHome_button = new Button();
            ExportingReportsHome_button = new Button();
            ExitApp_button = new Button();
            Home_panel = new Panel();
            panel_Anomalies = new Panel();
            label_AmonaliesParametr = new Label();
            label_AnomaliesResearch = new Label();
            comboBox_Anomalies = new ComboBox();
            WorkWithBase_panel = new Panel();
            SortDirection_label = new Label();
            SortDirection_comboBox = new ComboBox();
            ChooseFind_textBox = new TextBox();
            ChooseSort_label = new Label();
            Sort_label = new Label();
            Group_label = new Label();
            Find_label = new Label();
            ChooseFind_label = new Label();
            ChooseGroup_label = new Label();
            ChooseGroupParam_comboBox = new ComboBox();
            ChooseSortParam_comboBox = new ComboBox();
            FindRatio_comboBox = new ComboBox();
            ChooseFindParam_comboBox = new ComboBox();
            Chart_panel = new Panel();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            RatingCriteria_comboBox = new ComboBox();
            RatingCriteria_label = new Label();
            StatisticalIndicators_panel = new Panel();
            ChooseColumn_comboBox = new ComboBox();
            ChooseColumn_label = new Label();
            Max_label = new Label();
            Max_textBox = new TextBox();
            Min_label = new Label();
            Min_textBox = new TextBox();
            Median_label = new Label();
            Median_textBox = new TextBox();
            Average_label = new Label();
            Average_textBox = new TextBox();
            Rating_panel = new Panel();
            checkBox_GroupRating = new CheckBox();
            checkBox_StudentRating = new CheckBox();
            StatInfo_panel = new Panel();
            StatInfo_label = new Label();
            StatInfoNum_label = new Label();
            Base_panel = new Panel();
            StudentInfo_dataGridView = new DataGridView();
            Button_panel = new Panel();
            Apply_button = new Button();
            Remove_button = new Button();
            Return_button = new Button();
            Info_button = new Button();
            HomeButtons_flowLayoutPanel = new FlowLayoutPanel();
            LoadFile_button = new Button();
            button_Anomalies = new Button();
            BuildingRatingsHome_button = new Button();
            Home_panel.SuspendLayout();
            panel_Anomalies.SuspendLayout();
            WorkWithBase_panel.SuspendLayout();
            Chart_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            StatisticalIndicators_panel.SuspendLayout();
            Rating_panel.SuspendLayout();
            StatInfo_panel.SuspendLayout();
            Base_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentInfo_dataGridView).BeginInit();
            Button_panel.SuspendLayout();
            HomeButtons_flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NameUnit_label
            // 
            NameUnit_label.BackColor = Color.Transparent;
            NameUnit_label.Dock = DockStyle.Top;
            NameUnit_label.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameUnit_label.Location = new Point(0, 0);
            NameUnit_label.Margin = new Padding(4, 0, 4, 0);
            NameUnit_label.Name = "NameUnit_label";
            NameUnit_label.Size = new Size(1384, 64);
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
            ExportingReportsHome_button.Location = new Point(4, 472);
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
            ExitApp_button.Location = new Point(4, 566);
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
            Home_panel.Controls.Add(panel_Anomalies);
            Home_panel.Controls.Add(WorkWithBase_panel);
            Home_panel.Controls.Add(Chart_panel);
            Home_panel.Controls.Add(StatisticalIndicators_panel);
            Home_panel.Controls.Add(Rating_panel);
            Home_panel.Controls.Add(StatInfo_panel);
            Home_panel.Controls.Add(Base_panel);
            Home_panel.Controls.Add(NameUnit_label);
            Home_panel.Controls.Add(Button_panel);
            Home_panel.Controls.Add(HomeButtons_flowLayoutPanel);
            Home_panel.Dock = DockStyle.Fill;
            Home_panel.Location = new Point(0, 0);
            Home_panel.Margin = new Padding(4, 2, 4, 2);
            Home_panel.Name = "Home_panel";
            Home_panel.Size = new Size(1384, 1028);
            Home_panel.TabIndex = 7;
            // 
            // panel_Anomalies
            // 
            panel_Anomalies.Controls.Add(label_AmonaliesParametr);
            panel_Anomalies.Controls.Add(label_AnomaliesResearch);
            panel_Anomalies.Controls.Add(comboBox_Anomalies);
            panel_Anomalies.Location = new Point(0, 90);
            panel_Anomalies.Name = "panel_Anomalies";
            panel_Anomalies.Size = new Size(503, 737);
            panel_Anomalies.TabIndex = 28;
            panel_Anomalies.Visible = false;
            // 
            // label_AmonaliesParametr
            // 
            label_AmonaliesParametr.Anchor = AnchorStyles.None;
            label_AmonaliesParametr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label_AmonaliesParametr.Location = new Point(35, 89);
            label_AmonaliesParametr.Margin = new Padding(4, 0, 4, 0);
            label_AmonaliesParametr.Name = "label_AmonaliesParametr";
            label_AmonaliesParametr.Size = new Size(435, 45);
            label_AmonaliesParametr.TabIndex = 30;
            label_AmonaliesParametr.Text = "Выберите параметр поиска";
            label_AmonaliesParametr.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_AnomaliesResearch
            // 
            label_AnomaliesResearch.Anchor = AnchorStyles.None;
            label_AnomaliesResearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label_AnomaliesResearch.Location = new Point(113, 31);
            label_AnomaliesResearch.Margin = new Padding(4, 0, 4, 0);
            label_AnomaliesResearch.Name = "label_AnomaliesResearch";
            label_AnomaliesResearch.Size = new Size(288, 45);
            label_AnomaliesResearch.TabIndex = 28;
            label_AnomaliesResearch.Text = "Поиск аномалий";
            label_AnomaliesResearch.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox_Anomalies
            // 
            comboBox_Anomalies.Anchor = AnchorStyles.None;
            comboBox_Anomalies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Anomalies.ForeColor = Color.Black;
            comboBox_Anomalies.FormattingEnabled = true;
            comboBox_Anomalies.Items.AddRange(new object[] { "Кол-во задолженностей", "Общий средний балл" });
            comboBox_Anomalies.Location = new Point(27, 163);
            comboBox_Anomalies.Margin = new Padding(4, 2, 4, 2);
            comboBox_Anomalies.Name = "comboBox_Anomalies";
            comboBox_Anomalies.Size = new Size(435, 40);
            comboBox_Anomalies.TabIndex = 29;
            // 
            // WorkWithBase_panel
            // 
            WorkWithBase_panel.Controls.Add(SortDirection_label);
            WorkWithBase_panel.Controls.Add(SortDirection_comboBox);
            WorkWithBase_panel.Controls.Add(ChooseFind_textBox);
            WorkWithBase_panel.Controls.Add(ChooseSort_label);
            WorkWithBase_panel.Controls.Add(Sort_label);
            WorkWithBase_panel.Controls.Add(Group_label);
            WorkWithBase_panel.Controls.Add(Find_label);
            WorkWithBase_panel.Controls.Add(ChooseFind_label);
            WorkWithBase_panel.Controls.Add(ChooseGroup_label);
            WorkWithBase_panel.Controls.Add(ChooseGroupParam_comboBox);
            WorkWithBase_panel.Controls.Add(ChooseSortParam_comboBox);
            WorkWithBase_panel.Controls.Add(FindRatio_comboBox);
            WorkWithBase_panel.Controls.Add(ChooseFindParam_comboBox);
            WorkWithBase_panel.Location = new Point(0, 90);
            WorkWithBase_panel.Margin = new Padding(4, 2, 4, 2);
            WorkWithBase_panel.Name = "WorkWithBase_panel";
            WorkWithBase_panel.Size = new Size(510, 736);
            WorkWithBase_panel.TabIndex = 30;
            WorkWithBase_panel.Visible = false;
            // 
            // SortDirection_label
            // 
            SortDirection_label.Anchor = AnchorStyles.None;
            SortDirection_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            SortDirection_label.Location = new Point(35, 149);
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
            SortDirection_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortDirection_comboBox.FormattingEnabled = true;
            SortDirection_comboBox.Items.AddRange(new object[] { "Возрастание", "Убывание" });
            SortDirection_comboBox.Location = new Point(35, 199);
            SortDirection_comboBox.Margin = new Padding(4, 2, 4, 2);
            SortDirection_comboBox.Name = "SortDirection_comboBox";
            SortDirection_comboBox.Size = new Size(435, 40);
            SortDirection_comboBox.TabIndex = 26;
            // 
            // ChooseFind_textBox
            // 
            ChooseFind_textBox.Anchor = AnchorStyles.None;
            ChooseFind_textBox.Location = new Point(35, 459);
            ChooseFind_textBox.Margin = new Padding(4, 2, 4, 2);
            ChooseFind_textBox.Name = "ChooseFind_textBox";
            ChooseFind_textBox.Size = new Size(435, 39);
            ChooseFind_textBox.TabIndex = 24;
            // 
            // ChooseSort_label
            // 
            ChooseSort_label.Anchor = AnchorStyles.None;
            ChooseSort_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ChooseSort_label.Location = new Point(43, 49);
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
            Sort_label.Location = new Point(121, 13);
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
            Group_label.Location = new Point(96, 557);
            Group_label.Margin = new Padding(4, 0, 4, 0);
            Group_label.Name = "Group_label";
            Group_label.Size = new Size(288, 38);
            Group_label.TabIndex = 10;
            Group_label.Text = "Группировка студентов";
            Group_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Find_label
            // 
            Find_label.Anchor = AnchorStyles.None;
            Find_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Find_label.Location = new Point(100, 299);
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
            ChooseFind_label.Location = new Point(35, 339);
            ChooseFind_label.Margin = new Padding(4, 0, 4, 0);
            ChooseFind_label.Name = "ChooseFind_label";
            ChooseFind_label.Size = new Size(427, 45);
            ChooseFind_label.TabIndex = 13;
            ChooseFind_label.Text = "Введите параметр поиска";
            ChooseFind_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseGroup_label
            // 
            ChooseGroup_label.Anchor = AnchorStyles.None;
            ChooseGroup_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ChooseGroup_label.Location = new Point(31, 598);
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
            ChooseGroupParam_comboBox.Items.AddRange(new object[] { "Курс", "Группа" });
            ChooseGroupParam_comboBox.Location = new Point(31, 636);
            ChooseGroupParam_comboBox.Margin = new Padding(4, 2, 4, 2);
            ChooseGroupParam_comboBox.Name = "ChooseGroupParam_comboBox";
            ChooseGroupParam_comboBox.Size = new Size(435, 40);
            ChooseGroupParam_comboBox.TabIndex = 19;
            // 
            // ChooseSortParam_comboBox
            // 
            ChooseSortParam_comboBox.Anchor = AnchorStyles.None;
            ChooseSortParam_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ChooseSortParam_comboBox.ForeColor = Color.Black;
            ChooseSortParam_comboBox.FormattingEnabled = true;
            ChooseSortParam_comboBox.Items.AddRange(new object[] { "ФИО студента", "Общий средний балл", "Количество задолженностей" });
            ChooseSortParam_comboBox.Location = new Point(35, 105);
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
            FindRatio_comboBox.Location = new Point(376, 386);
            FindRatio_comboBox.Margin = new Padding(4, 2, 4, 2);
            FindRatio_comboBox.Name = "FindRatio_comboBox";
            FindRatio_comboBox.Size = new Size(94, 40);
            FindRatio_comboBox.TabIndex = 17;
            // 
            // ChooseFindParam_comboBox
            // 
            ChooseFindParam_comboBox.Anchor = AnchorStyles.None;
            ChooseFindParam_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ChooseFindParam_comboBox.FormattingEnabled = true;
            ChooseFindParam_comboBox.Items.AddRange(new object[] { "ФИО студента", "Общий средний балл", "Кол-во задолженностей" });
            ChooseFindParam_comboBox.Location = new Point(35, 386);
            ChooseFindParam_comboBox.Margin = new Padding(4, 2, 4, 2);
            ChooseFindParam_comboBox.Name = "ChooseFindParam_comboBox";
            ChooseFindParam_comboBox.Size = new Size(312, 40);
            ChooseFindParam_comboBox.TabIndex = 16;
            // 
            // Chart_panel
            // 
            Chart_panel.AutoSize = true;
            Chart_panel.Controls.Add(chart);
            Chart_panel.Controls.Add(RatingCriteria_comboBox);
            Chart_panel.Controls.Add(RatingCriteria_label);
            Chart_panel.Location = new Point(0, 90);
            Chart_panel.Margin = new Padding(4, 2, 4, 2);
            Chart_panel.Name = "Chart_panel";
            Chart_panel.Size = new Size(514, 743);
            Chart_panel.TabIndex = 30;
            Chart_panel.Visible = false;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(8, 97);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(502, 634);
            chart.TabIndex = 34;
            chart.Visible = false;
            // 
            // RatingCriteria_comboBox
            // 
            RatingCriteria_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RatingCriteria_comboBox.FormattingEnabled = true;
            RatingCriteria_comboBox.Items.AddRange(new object[] { "Общий средний балл", "Кол-во задолженностей" });
            RatingCriteria_comboBox.Location = new Point(0, 49);
            RatingCriteria_comboBox.Name = "RatingCriteria_comboBox";
            RatingCriteria_comboBox.Size = new Size(510, 40);
            RatingCriteria_comboBox.TabIndex = 33;
            // 
            // RatingCriteria_label
            // 
            RatingCriteria_label.Anchor = AnchorStyles.None;
            RatingCriteria_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RatingCriteria_label.Location = new Point(0, 0);
            RatingCriteria_label.Name = "RatingCriteria_label";
            RatingCriteria_label.Size = new Size(511, 42);
            RatingCriteria_label.TabIndex = 32;
            RatingCriteria_label.Text = "Выберете критерий построения рейтингов";
            RatingCriteria_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // StatisticalIndicators_panel
            // 
            StatisticalIndicators_panel.Controls.Add(ChooseColumn_comboBox);
            StatisticalIndicators_panel.Controls.Add(ChooseColumn_label);
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
            StatisticalIndicators_panel.Size = new Size(518, 743);
            StatisticalIndicators_panel.TabIndex = 25;
            StatisticalIndicators_panel.Visible = false;
            // 
            // ChooseColumn_comboBox
            // 
            ChooseColumn_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ChooseColumn_comboBox.FormattingEnabled = true;
            ChooseColumn_comboBox.Items.AddRange(new object[] { "Общий средний балл", "Кол-во задолженностей" });
            ChooseColumn_comboBox.Location = new Point(32, 106);
            ChooseColumn_comboBox.Name = "ChooseColumn_comboBox";
            ChooseColumn_comboBox.Size = new Size(327, 40);
            ChooseColumn_comboBox.TabIndex = 31;
            // 
            // ChooseColumn_label
            // 
            ChooseColumn_label.Anchor = AnchorStyles.None;
            ChooseColumn_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ChooseColumn_label.Location = new Point(30, 19);
            ChooseColumn_label.Margin = new Padding(4, 0, 4, 0);
            ChooseColumn_label.Name = "ChooseColumn_label";
            ChooseColumn_label.Size = new Size(394, 81);
            ChooseColumn_label.TabIndex = 30;
            ChooseColumn_label.Text = "Выберете столбец, по которому будут проводиться вычисления";
            // 
            // Max_label
            // 
            Max_label.Anchor = AnchorStyles.None;
            Max_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Max_label.Location = new Point(34, 606);
            Max_label.Margin = new Padding(4, 0, 4, 0);
            Max_label.Name = "Max_label";
            Max_label.Size = new Size(305, 45);
            Max_label.TabIndex = 28;
            Max_label.Text = "Максимальное значение";
            // 
            // Max_textBox
            // 
            Max_textBox.Anchor = AnchorStyles.None;
            Max_textBox.Location = new Point(32, 677);
            Max_textBox.Margin = new Padding(4, 2, 4, 2);
            Max_textBox.Name = "Max_textBox";
            Max_textBox.ReadOnly = true;
            Max_textBox.Size = new Size(329, 39);
            Max_textBox.TabIndex = 29;
            // 
            // Min_label
            // 
            Min_label.Anchor = AnchorStyles.None;
            Min_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Min_label.Location = new Point(32, 459);
            Min_label.Margin = new Padding(4, 0, 4, 0);
            Min_label.Name = "Min_label";
            Min_label.Size = new Size(305, 45);
            Min_label.TabIndex = 26;
            Min_label.Text = "Минимальное значение";
            // 
            // Min_textBox
            // 
            Min_textBox.Anchor = AnchorStyles.None;
            Min_textBox.Location = new Point(32, 538);
            Min_textBox.Margin = new Padding(4, 2, 4, 2);
            Min_textBox.Name = "Min_textBox";
            Min_textBox.ReadOnly = true;
            Min_textBox.Size = new Size(327, 39);
            Min_textBox.TabIndex = 27;
            // 
            // Median_label
            // 
            Median_label.Anchor = AnchorStyles.None;
            Median_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Median_label.Location = new Point(32, 322);
            Median_label.Margin = new Padding(4, 0, 4, 0);
            Median_label.Name = "Median_label";
            Median_label.Size = new Size(163, 45);
            Median_label.TabIndex = 24;
            Median_label.Text = "Медиана";
            // 
            // Median_textBox
            // 
            Median_textBox.Anchor = AnchorStyles.None;
            Median_textBox.Location = new Point(34, 393);
            Median_textBox.Margin = new Padding(4, 2, 4, 2);
            Median_textBox.Name = "Median_textBox";
            Median_textBox.ReadOnly = true;
            Median_textBox.Size = new Size(327, 39);
            Median_textBox.TabIndex = 25;
            // 
            // Average_label
            // 
            Average_label.Anchor = AnchorStyles.None;
            Average_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Average_label.Location = new Point(30, 181);
            Average_label.Margin = new Padding(4, 0, 4, 0);
            Average_label.Name = "Average_label";
            Average_label.Size = new Size(327, 45);
            Average_label.TabIndex = 12;
            Average_label.Text = "Среднее арифметическое";
            // 
            // Average_textBox
            // 
            Average_textBox.Anchor = AnchorStyles.None;
            Average_textBox.Location = new Point(32, 249);
            Average_textBox.Margin = new Padding(4, 2, 4, 2);
            Average_textBox.Name = "Average_textBox";
            Average_textBox.ReadOnly = true;
            Average_textBox.Size = new Size(325, 39);
            Average_textBox.TabIndex = 23;
            // 
            // Rating_panel
            // 
            Rating_panel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Rating_panel.Controls.Add(checkBox_GroupRating);
            Rating_panel.Controls.Add(checkBox_StudentRating);
            Rating_panel.Location = new Point(936, 917);
            Rating_panel.Margin = new Padding(4, 2, 4, 2);
            Rating_panel.Name = "Rating_panel";
            Rating_panel.Size = new Size(446, 107);
            Rating_panel.TabIndex = 33;
            Rating_panel.Visible = false;
            // 
            // checkBox_GroupRating
            // 
            checkBox_GroupRating.Anchor = AnchorStyles.None;
            checkBox_GroupRating.AutoSize = true;
            checkBox_GroupRating.Location = new Point(19, 55);
            checkBox_GroupRating.Name = "checkBox_GroupRating";
            checkBox_GroupRating.Size = new Size(203, 36);
            checkBox_GroupRating.TabIndex = 1;
            checkBox_GroupRating.Text = "Рейтинг групп";
            checkBox_GroupRating.UseVisualStyleBackColor = true;
            checkBox_GroupRating.CheckedChanged += checkBox_GroupRating_CheckedChanged;
            // 
            // checkBox_StudentRating
            // 
            checkBox_StudentRating.Anchor = AnchorStyles.None;
            checkBox_StudentRating.AutoSize = true;
            checkBox_StudentRating.Location = new Point(19, 1);
            checkBox_StudentRating.Name = "checkBox_StudentRating";
            checkBox_StudentRating.Size = new Size(250, 36);
            checkBox_StudentRating.TabIndex = 0;
            checkBox_StudentRating.Text = "Рейтинг студентов";
            checkBox_StudentRating.UseVisualStyleBackColor = true;
            checkBox_StudentRating.CheckedChanged += checkBox_StudentRating_CheckedChanged;
            // 
            // StatInfo_panel
            // 
            StatInfo_panel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StatInfo_panel.AutoSize = true;
            StatInfo_panel.Controls.Add(StatInfo_label);
            StatInfo_panel.Controls.Add(StatInfoNum_label);
            StatInfo_panel.Location = new Point(940, 849);
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
            StudentInfo_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            StudentInfo_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentInfo_dataGridView.Dock = DockStyle.Fill;
            StudentInfo_dataGridView.Location = new Point(0, 0);
            StudentInfo_dataGridView.Margin = new Padding(4, 2, 4, 2);
            StudentInfo_dataGridView.Name = "StudentInfo_dataGridView";
            StudentInfo_dataGridView.RowHeadersWidth = 82;
            StudentInfo_dataGridView.Size = new Size(860, 743);
            StudentInfo_dataGridView.TabIndex = 8;
            // 
            // Button_panel
            // 
            Button_panel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button_panel.BackColor = Color.Transparent;
            Button_panel.Controls.Add(Apply_button);
            Button_panel.Controls.Add(Remove_button);
            Button_panel.Controls.Add(Return_button);
            Button_panel.Controls.Add(Info_button);
            Button_panel.Location = new Point(0, 862);
            Button_panel.Margin = new Padding(4, 2, 4, 2);
            Button_panel.Name = "Button_panel";
            Button_panel.Size = new Size(923, 162);
            Button_panel.TabIndex = 29;
            // 
            // Apply_button
            // 
            Apply_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Apply_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Apply_button.Location = new Point(232, 29);
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
            Remove_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Remove_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Remove_button.Location = new Point(462, 29);
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
            Return_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Return_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Return_button.Location = new Point(695, 29);
            Return_button.Margin = new Padding(4, 2, 4, 2);
            Return_button.Name = "Return_button";
            Return_button.Size = new Size(225, 90);
            Return_button.TabIndex = 27;
            Return_button.Text = "Возврат в главное меню";
            Return_button.UseVisualStyleBackColor = true;
            Return_button.Visible = false;
            Return_button.Click += ReturnInMenu_button_Click;
            // 
            // Info_button
            // 
            Info_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Info_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Info_button.Location = new Point(0, 29);
            Info_button.Margin = new Padding(4, 2, 4, 2);
            Info_button.Name = "Info_button";
            Info_button.Size = new Size(225, 90);
            Info_button.TabIndex = 7;
            Info_button.Text = "Справка пользователя";
            Info_button.UseVisualStyleBackColor = true;
            Info_button.Click += Get_Inf;
            // 
            // HomeButtons_flowLayoutPanel
            // 
            HomeButtons_flowLayoutPanel.Anchor = AnchorStyles.None;
            HomeButtons_flowLayoutPanel.AutoSize = true;
            HomeButtons_flowLayoutPanel.BackColor = Color.Transparent;
            HomeButtons_flowLayoutPanel.Controls.Add(LoadFile_button);
            HomeButtons_flowLayoutPanel.Controls.Add(DataSetHome_button);
            HomeButtons_flowLayoutPanel.Controls.Add(StatisticalIndicatorsHome_button);
            HomeButtons_flowLayoutPanel.Controls.Add(button_Anomalies);
            HomeButtons_flowLayoutPanel.Controls.Add(BuildingRatingsHome_button);
            HomeButtons_flowLayoutPanel.Controls.Add(ExportingReportsHome_button);
            HomeButtons_flowLayoutPanel.Controls.Add(ExitApp_button);
            HomeButtons_flowLayoutPanel.Location = new Point(431, 160);
            HomeButtons_flowLayoutPanel.Margin = new Padding(4, 2, 4, 2);
            HomeButtons_flowLayoutPanel.MaximumSize = new Size(700, 800);
            HomeButtons_flowLayoutPanel.MinimumSize = new Size(496, 582);
            HomeButtons_flowLayoutPanel.Name = "HomeButtons_flowLayoutPanel";
            HomeButtons_flowLayoutPanel.Size = new Size(554, 664);
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
            // button_Anomalies
            // 
            button_Anomalies.AutoSize = true;
            button_Anomalies.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_Anomalies.Location = new Point(4, 284);
            button_Anomalies.Margin = new Padding(4, 2, 4, 2);
            button_Anomalies.Name = "button_Anomalies";
            button_Anomalies.Size = new Size(546, 90);
            button_Anomalies.TabIndex = 8;
            button_Anomalies.Text = "Поиск аномалий";
            button_Anomalies.UseVisualStyleBackColor = true;
            button_Anomalies.Click += Home_button_Click;
            // 
            // BuildingRatingsHome_button
            // 
            BuildingRatingsHome_button.AutoSize = true;
            BuildingRatingsHome_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BuildingRatingsHome_button.Location = new Point(4, 378);
            BuildingRatingsHome_button.Margin = new Padding(4, 2, 4, 2);
            BuildingRatingsHome_button.Name = "BuildingRatingsHome_button";
            BuildingRatingsHome_button.Size = new Size(546, 90);
            BuildingRatingsHome_button.TabIndex = 3;
            BuildingRatingsHome_button.Text = "Построение рейтингов";
            BuildingRatingsHome_button.UseVisualStyleBackColor = true;
            BuildingRatingsHome_button.Click += Home_button_Click;
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
            FormClosing += Analyzer_form_FormClosing;
            Home_panel.ResumeLayout(false);
            Home_panel.PerformLayout();
            panel_Anomalies.ResumeLayout(false);
            WorkWithBase_panel.ResumeLayout(false);
            WorkWithBase_panel.PerformLayout();
            Chart_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            StatisticalIndicators_panel.ResumeLayout(false);
            StatisticalIndicators_panel.PerformLayout();
            Rating_panel.ResumeLayout(false);
            Rating_panel.PerformLayout();
            StatInfo_panel.ResumeLayout(false);
            Base_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentInfo_dataGridView).EndInit();
            Button_panel.ResumeLayout(false);
            HomeButtons_flowLayoutPanel.ResumeLayout(false);
            HomeButtons_flowLayoutPanel.PerformLayout();
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
        private Button Info_button;
        private DataGridView StudentInfo_dataGridView;
        private Panel WorkWithBase_panel;
        private Label Average_label;
        private Label Sort_label;
        private Label Group_label;
        private Label Find_label;
        private TextBox Average_textBox;
        private Label ChooseFind_label;
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
        private Panel Chart_panel;
        private Panel Rating_panel;
        private Label SortDirection_label;
        private ComboBox SortDirection_comboBox;
        private Label ChooseColumn_label;
        private ComboBox ChooseColumn_comboBox;
        private ComboBox RatingCriteria_comboBox;
        private Label RatingCriteria_label;
        private CheckBox checkBox_GroupRating;
        private CheckBox checkBox_StudentRating;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Button button_Anomalies;
        private Panel panel_Anomalies;
        private Label label_AmonaliesParametr;
        private Label label_AnomaliesResearch;
        private ComboBox comboBox_Anomalies;
    }
}
