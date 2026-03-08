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
            Base_panel = new Panel();
            StudentInfo_dataGridView = new DataGridView();
            StudentName = new DataGridViewTextBoxColumn();
            Cours = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            AverageScore = new DataGridViewTextBoxColumn();
            ArrearsNumber = new DataGridViewTextBoxColumn();
            WorkWithBase_panel = new Panel();
            ChooseSort_label = new Label();
            Sort_label = new Label();
            Group_label = new Label();
            ChooseGroup_textBox = new TextBox();
            Find_label = new Label();
            ChooseFind_textBox = new TextBox();
            ChooseFind_label = new Label();
            GroupRatio_label = new Label();
            ChooseGroup_label = new Label();
            ChooseGroupParam_comboBox = new ComboBox();
            ChooseSortParam_comboBox = new ComboBox();
            FindRatio_comboBox = new ComboBox();
            ChooseFindParam_comboBox = new ComboBox();
            HomeButtons_panel = new Panel();
            BuildingRatingsHome_button = new Button();
            LoadFile_button = new Button();
            Button_panel = new Panel();
            Apply_button = new Button();
            Remove_button = new Button();
            Return_button = new Button();
            WorkWithBaseInfo_button = new Button();
            Home_panel.SuspendLayout();
            Base_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentInfo_dataGridView).BeginInit();
            WorkWithBase_panel.SuspendLayout();
            HomeButtons_panel.SuspendLayout();
            Button_panel.SuspendLayout();
            SuspendLayout();
            // 
            // NameUnit_label
            // 
            NameUnit_label.Anchor = AnchorStyles.Top;
            NameUnit_label.BackColor = Color.Transparent;
            NameUnit_label.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameUnit_label.Location = new Point(11, 14);
            NameUnit_label.Name = "NameUnit_label";
            NameUnit_label.Size = new Size(1359, 64);
            NameUnit_label.TabIndex = 0;
            NameUnit_label.Text = "Анализатор успеваемости студентов";
            NameUnit_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // DataSetHome_button
            // 
            DataSetHome_button.Anchor = AnchorStyles.None;
            DataSetHome_button.BackColor = Color.Transparent;
            DataSetHome_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DataSetHome_button.Location = new Point(54, 104);
            DataSetHome_button.Name = "DataSetHome_button";
            DataSetHome_button.Size = new Size(488, 90);
            DataSetHome_button.TabIndex = 1;
            DataSetHome_button.Text = "Работа с базой данных";
            DataSetHome_button.UseVisualStyleBackColor = false;
            DataSetHome_button.Click += Home_button_Click;
            // 
            // StatisticalIndicatorsHome_button
            // 
            StatisticalIndicatorsHome_button.Anchor = AnchorStyles.None;
            StatisticalIndicatorsHome_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StatisticalIndicatorsHome_button.Location = new Point(54, 200);
            StatisticalIndicatorsHome_button.Name = "StatisticalIndicatorsHome_button";
            StatisticalIndicatorsHome_button.Size = new Size(488, 90);
            StatisticalIndicatorsHome_button.TabIndex = 2;
            StatisticalIndicatorsHome_button.Text = "Вычисление статистических показателей";
            StatisticalIndicatorsHome_button.UseVisualStyleBackColor = true;
            // 
            // ExportingReportsHome_button
            // 
            ExportingReportsHome_button.Anchor = AnchorStyles.None;
            ExportingReportsHome_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExportingReportsHome_button.Location = new Point(54, 392);
            ExportingReportsHome_button.Name = "ExportingReportsHome_button";
            ExportingReportsHome_button.Size = new Size(488, 90);
            ExportingReportsHome_button.TabIndex = 4;
            ExportingReportsHome_button.Text = "Экспорт отчетов";
            ExportingReportsHome_button.UseVisualStyleBackColor = true;
            // 
            // ExitApp_button
            // 
            ExitApp_button.Anchor = AnchorStyles.None;
            ExitApp_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitApp_button.Location = new Point(54, 488);
            ExitApp_button.Name = "ExitApp_button";
            ExitApp_button.Size = new Size(488, 90);
            ExitApp_button.TabIndex = 6;
            ExitApp_button.Text = "Выход из приложения";
            ExitApp_button.UseVisualStyleBackColor = true;
            // 
            // Home_panel
            // 
            Home_panel.BackColor = Color.Transparent;
            Home_panel.Controls.Add(Base_panel);
            Home_panel.Controls.Add(WorkWithBase_panel);
            Home_panel.Controls.Add(HomeButtons_panel);
            Home_panel.Controls.Add(NameUnit_label);
            Home_panel.Controls.Add(Button_panel);
            Home_panel.Dock = DockStyle.Fill;
            Home_panel.Location = new Point(0, 0);
            Home_panel.Name = "Home_panel";
            Home_panel.Size = new Size(1374, 997);
            Home_panel.TabIndex = 7;
            // 
            // Base_panel
            // 
            Base_panel.Anchor = AnchorStyles.None;
            Base_panel.Controls.Add(StudentInfo_dataGridView);
            Base_panel.Location = new Point(471, 90);
            Base_panel.Name = "Base_panel";
            Base_panel.Size = new Size(896, 735);
            Base_panel.TabIndex = 9;
            Base_panel.Visible = false;
            // 
            // StudentInfo_dataGridView
            // 
            StudentInfo_dataGridView.Anchor = AnchorStyles.None;
            StudentInfo_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentInfo_dataGridView.Columns.AddRange(new DataGridViewColumn[] { StudentName, Cours, Group, Subject, AverageScore, ArrearsNumber });
            StudentInfo_dataGridView.Location = new Point(0, 0);
            StudentInfo_dataGridView.Name = "StudentInfo_dataGridView";
            StudentInfo_dataGridView.RowHeadersWidth = 82;
            StudentInfo_dataGridView.Size = new Size(896, 735);
            StudentInfo_dataGridView.TabIndex = 8;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "ФИО студента";
            StudentName.MinimumWidth = 10;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 200;
            // 
            // Cours
            // 
            Cours.HeaderText = "Курс студента";
            Cours.MinimumWidth = 10;
            Cours.Name = "Cours";
            Cours.ReadOnly = true;
            Cours.Width = 200;
            // 
            // Group
            // 
            Group.HeaderText = "Группа студента";
            Group.MinimumWidth = 10;
            Group.Name = "Group";
            Group.ReadOnly = true;
            Group.Width = 200;
            // 
            // Subject
            // 
            Subject.HeaderText = "Предмет";
            Subject.MinimumWidth = 10;
            Subject.Name = "Subject";
            Subject.ReadOnly = true;
            Subject.Width = 200;
            // 
            // AverageScore
            // 
            AverageScore.HeaderText = "Средний балл";
            AverageScore.MinimumWidth = 10;
            AverageScore.Name = "AverageScore";
            AverageScore.ReadOnly = true;
            AverageScore.Width = 200;
            // 
            // ArrearsNumber
            // 
            ArrearsNumber.HeaderText = "Количество задолженностей";
            ArrearsNumber.MinimumWidth = 10;
            ArrearsNumber.Name = "ArrearsNumber";
            ArrearsNumber.ReadOnly = true;
            ArrearsNumber.Width = 200;
            // 
            // WorkWithBase_panel
            // 
            WorkWithBase_panel.Anchor = AnchorStyles.Left;
            WorkWithBase_panel.Controls.Add(ChooseSort_label);
            WorkWithBase_panel.Controls.Add(Sort_label);
            WorkWithBase_panel.Controls.Add(Group_label);
            WorkWithBase_panel.Controls.Add(ChooseGroup_textBox);
            WorkWithBase_panel.Controls.Add(Find_label);
            WorkWithBase_panel.Controls.Add(ChooseFind_textBox);
            WorkWithBase_panel.Controls.Add(ChooseFind_label);
            WorkWithBase_panel.Controls.Add(GroupRatio_label);
            WorkWithBase_panel.Controls.Add(ChooseGroup_label);
            WorkWithBase_panel.Controls.Add(ChooseGroupParam_comboBox);
            WorkWithBase_panel.Controls.Add(ChooseSortParam_comboBox);
            WorkWithBase_panel.Controls.Add(FindRatio_comboBox);
            WorkWithBase_panel.Controls.Add(ChooseFindParam_comboBox);
            WorkWithBase_panel.Location = new Point(0, 90);
            WorkWithBase_panel.Name = "WorkWithBase_panel";
            WorkWithBase_panel.Size = new Size(466, 735);
            WorkWithBase_panel.TabIndex = 30;
            WorkWithBase_panel.Visible = false;
            // 
            // ChooseSort_label
            // 
            ChooseSort_label.Anchor = AnchorStyles.None;
            ChooseSort_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ChooseSort_label.Location = new Point(36, 107);
            ChooseSort_label.Name = "ChooseSort_label";
            ChooseSort_label.Size = new Size(435, 45);
            ChooseSort_label.TabIndex = 12;
            ChooseSort_label.Text = "Выберете параметр сортировки";
            ChooseSort_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Sort_label
            // 
            Sort_label.Anchor = AnchorStyles.None;
            Sort_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Sort_label.Location = new Point(94, 63);
            Sort_label.Name = "Sort_label";
            Sort_label.Size = new Size(287, 44);
            Sort_label.TabIndex = 9;
            Sort_label.Text = "Сортировка студентов";
            Sort_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Group_label
            // 
            Group_label.Anchor = AnchorStyles.None;
            Group_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Group_label.Location = new Point(74, 455);
            Group_label.Name = "Group_label";
            Group_label.Size = new Size(287, 39);
            Group_label.TabIndex = 10;
            Group_label.Text = "Группировка студентов";
            Group_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseGroup_textBox
            // 
            ChooseGroup_textBox.Anchor = AnchorStyles.None;
            ChooseGroup_textBox.Location = new Point(9, 595);
            ChooseGroup_textBox.Name = "ChooseGroup_textBox";
            ChooseGroup_textBox.Size = new Size(435, 39);
            ChooseGroup_textBox.TabIndex = 24;
            // 
            // Find_label
            // 
            Find_label.Anchor = AnchorStyles.None;
            Find_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Find_label.Location = new Point(74, 230);
            Find_label.Name = "Find_label";
            Find_label.Size = new Size(287, 40);
            Find_label.TabIndex = 11;
            Find_label.Text = "Поиск студентов";
            Find_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseFind_textBox
            // 
            ChooseFind_textBox.Anchor = AnchorStyles.None;
            ChooseFind_textBox.Location = new Point(9, 381);
            ChooseFind_textBox.Name = "ChooseFind_textBox";
            ChooseFind_textBox.Size = new Size(435, 39);
            ChooseFind_textBox.TabIndex = 23;
            // 
            // ChooseFind_label
            // 
            ChooseFind_label.Anchor = AnchorStyles.None;
            ChooseFind_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ChooseFind_label.Location = new Point(3, 270);
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
            GroupRatio_label.Location = new Point(351, 539);
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
            ChooseGroup_label.Location = new Point(9, 494);
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
            ChooseGroupParam_comboBox.Location = new Point(9, 533);
            ChooseGroupParam_comboBox.Name = "ChooseGroupParam_comboBox";
            ChooseGroupParam_comboBox.Size = new Size(312, 40);
            ChooseGroupParam_comboBox.TabIndex = 19;
            // 
            // ChooseSortParam_comboBox
            // 
            ChooseSortParam_comboBox.Anchor = AnchorStyles.None;
            ChooseSortParam_comboBox.FormattingEnabled = true;
            ChooseSortParam_comboBox.Items.AddRange(new object[] { "Фамилия студента", "Средний балл", "Количество задолженностей" });
            ChooseSortParam_comboBox.Location = new Point(9, 155);
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
            FindRatio_comboBox.Location = new Point(352, 318);
            FindRatio_comboBox.Name = "FindRatio_comboBox";
            FindRatio_comboBox.Size = new Size(92, 40);
            FindRatio_comboBox.TabIndex = 17;
            // 
            // ChooseFindParam_comboBox
            // 
            ChooseFindParam_comboBox.Anchor = AnchorStyles.None;
            ChooseFindParam_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ChooseFindParam_comboBox.FormattingEnabled = true;
            ChooseFindParam_comboBox.Items.AddRange(new object[] { "ФИО студента", "Курс студента", "Группа студента", "Предмет", "Средний балл", "Количество задолженностей" });
            ChooseFindParam_comboBox.Location = new Point(9, 318);
            ChooseFindParam_comboBox.Name = "ChooseFindParam_comboBox";
            ChooseFindParam_comboBox.Size = new Size(312, 40);
            ChooseFindParam_comboBox.TabIndex = 16;
            // 
            // HomeButtons_panel
            // 
            HomeButtons_panel.Anchor = AnchorStyles.None;
            HomeButtons_panel.Controls.Add(StatisticalIndicatorsHome_button);
            HomeButtons_panel.Controls.Add(ExportingReportsHome_button);
            HomeButtons_panel.Controls.Add(DataSetHome_button);
            HomeButtons_panel.Controls.Add(ExitApp_button);
            HomeButtons_panel.Controls.Add(BuildingRatingsHome_button);
            HomeButtons_panel.Controls.Add(LoadFile_button);
            HomeButtons_panel.Location = new Point(397, 175);
            HomeButtons_panel.Name = "HomeButtons_panel";
            HomeButtons_panel.Size = new Size(563, 603);
            HomeButtons_panel.TabIndex = 31;
            // 
            // BuildingRatingsHome_button
            // 
            BuildingRatingsHome_button.Anchor = AnchorStyles.None;
            BuildingRatingsHome_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BuildingRatingsHome_button.Location = new Point(54, 296);
            BuildingRatingsHome_button.Name = "BuildingRatingsHome_button";
            BuildingRatingsHome_button.Size = new Size(488, 90);
            BuildingRatingsHome_button.TabIndex = 3;
            BuildingRatingsHome_button.Text = "Построение рейтингов";
            BuildingRatingsHome_button.UseVisualStyleBackColor = true;
            // 
            // LoadFile_button
            // 
            LoadFile_button.Anchor = AnchorStyles.None;
            LoadFile_button.BackColor = Color.Transparent;
            LoadFile_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoadFile_button.Location = new Point(54, 8);
            LoadFile_button.Name = "LoadFile_button";
            LoadFile_button.Size = new Size(488, 90);
            LoadFile_button.TabIndex = 7;
            LoadFile_button.Text = "Загрузить файл";
            LoadFile_button.UseVisualStyleBackColor = false;
            LoadFile_button.Click += LoadFile_button_Click;
            // 
            // Button_panel
            // 
            Button_panel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button_panel.Controls.Add(Apply_button);
            Button_panel.Controls.Add(Remove_button);
            Button_panel.Controls.Add(Return_button);
            Button_panel.Controls.Add(WorkWithBaseInfo_button);
            Button_panel.Location = new Point(0, 829);
            Button_panel.Name = "Button_panel";
            Button_panel.Size = new Size(1359, 168);
            Button_panel.TabIndex = 29;
            // 
            // Apply_button
            // 
            Apply_button.Anchor = AnchorStyles.None;
            Apply_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Apply_button.Location = new Point(250, 47);
            Apply_button.Name = "Apply_button";
            Apply_button.Size = new Size(225, 90);
            Apply_button.TabIndex = 25;
            Apply_button.Text = "Применить обработку";
            Apply_button.UseVisualStyleBackColor = true;
            Apply_button.Visible = false;
            // 
            // Remove_button
            // 
            Remove_button.Anchor = AnchorStyles.None;
            Remove_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Remove_button.Location = new Point(481, 47);
            Remove_button.Name = "Remove_button";
            Remove_button.Size = new Size(225, 90);
            Remove_button.TabIndex = 26;
            Remove_button.Text = "Снять обработку";
            Remove_button.UseVisualStyleBackColor = true;
            Remove_button.Visible = false;
            // 
            // Return_button
            // 
            Return_button.Anchor = AnchorStyles.None;
            Return_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Return_button.Location = new Point(712, 47);
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
            WorkWithBaseInfo_button.Location = new Point(18, 47);
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
            ClientSize = new Size(1374, 997);
            Controls.Add(Home_panel);
            DoubleBuffered = true;
            Name = "Analyzer_form";
            Text = "Анализатор успеваемости студентов ";
            SizeChanged += Analyzer_form_SizeChanged;
            Home_panel.ResumeLayout(false);
            Base_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentInfo_dataGridView).EndInit();
            WorkWithBase_panel.ResumeLayout(false);
            WorkWithBase_panel.PerformLayout();
            HomeButtons_panel.ResumeLayout(false);
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
        private Label ChooseSort_label;
        private Label Sort_label;
        private Label Group_label;
        private TextBox ChooseGroup_textBox;
        private Label Find_label;
        private TextBox ChooseFind_textBox;
        private Label ChooseFind_label;
        private Label GroupRatio_label;
        private Label ChooseGroup_label;
        private ComboBox ChooseGroupParam_comboBox;
        private ComboBox ChooseSortParam_comboBox;
        private ComboBox FindRatio_comboBox;
        private ComboBox ChooseFindParam_comboBox;
        private Panel HomeButtons_panel;
        private Panel Base_panel;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Cours;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn AverageScore;
        private DataGridViewTextBoxColumn ArrearsNumber;
    }
}
