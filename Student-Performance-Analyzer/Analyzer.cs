using System.Data;
using System.Data.Common;
using System.Windows.Forms.DataVisualization.Charting;


namespace Student_Performance_Analyzer
{
    public partial class Analyzer_form : Form
    {
        private string selectedFilePath = "";
        DataTable inputDataTable = new DataTable();

        public Analyzer_form()
        {
            InitializeComponent();
            StudentInfo_dataGridView.Columns.Clear();
            StudentInfo_dataGridView.DataSource = inputDataTable;
            foreach (DataGridViewColumn column in StudentInfo_dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            var tmp = (Button)sender;
            if (tmp.Name == "ExitApp_button")
            {
                DialogResult result = MessageBox.Show(
                   "Вы уверены, что хотите закрыть приложение?",
                   "Подтверждение",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                if (StudentInfo_dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Загрузите файл",
                        "Нет файла",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    DataSetHome_button.Enabled = true;
                    StatisticalIndicatorsHome_button.Enabled = true;
                    BuildingRatingsHome_button.Enabled = true;
                    ExportingReportsHome_button.Enabled = true;
                    StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
                    if (tmp.Name == "DataSetHome_button")
                    {
                        NameUnit_label.Text = "Работа с базой данных";
                        WorkWithBase_panel.Visible = true;
                        Base_panel.Visible = true;
                        StatInfo_panel.Visible = true;
                        Apply_button.Text = "Применить обработку";
                        Remove_button.Text = "Снять обработку";
                    }
                    if (tmp.Name == "StatisticalIndicatorsHome_button")
                    {
                        NameUnit_label.Text = "Вычисление статистических показателей";
                        StatisticalIndicators_panel.Visible = true;
                        Base_panel.Visible = true;
                        Apply_button.Text = "Посчитать значения";
                        Remove_button.Text = "Очистить поля";
                    }
                    if (tmp.Name == "BuildingRatingsHome_button")
                    {
                        NameUnit_label.Text = "Построение рейтингов";
                        Rating_panel.Visible = true;
                        Chart_panel.Visible = true;
                        Base_panel.Visible = true;
                        StatInfo_panel.Visible = true;
                        Apply_button.Text = "Построить рейтинг";
                        Remove_button.Text = "Скрыть рейтинг";
                    }
                    HomeButtons_flowLayoutPanel.Visible = false;
                    Apply_button.Visible = true;
                    Remove_button.Visible = true;
                    Return_button.Visible = true;
                }
            }


        }

        private void ReturnInMenu_button_Click(object sender, EventArgs e)
        {
            HomeButtons_flowLayoutPanel.Visible = true;
            Apply_button.Visible = false;
            Remove_button.Visible = false;
            Return_button.Visible = false;
            Base_panel.Visible = false;
            if (NameUnit_label.Text == "Работа с базой данных")
            {
                WorkWithBase_panel.Visible = false;
                StatInfo_panel.Visible = false;
                if (StudentInfo_dataGridView.DataSource is DataTable table)
                {
                    table.DefaultView.Sort = null;
                    table.DefaultView.RowFilter = null;
                }
                StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
            }
            if (NameUnit_label.Text == "Вычисление статистических показателей")
            {
                StatisticalIndicators_panel.Visible = false;
            }
            if (NameUnit_label.Text == "Построение рейтингов по общему среднему баллу")
            {
                Rating_panel.Visible = false;
                Chart_panel.Visible = false;
            }
            if (Chart_panel.Visible == true)
            {
                StatisticalIndicators_panel.Visible = false;
                Rating_panel.Visible = false;
                Chart_panel.Visible = false;
            }
            NameUnit_label.Text = "Анализатор успеваемости студентов";
        }

        private void LoadFile_button_Click(object sender, EventArgs e)
        {
            if (inputDataTable.Rows.Count == 0)
            {
                LoadFile();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                   "Вы уверены, что хотите перезаписать файл?",
                   "Предупреждение",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    inputDataTable.Clear();
                    inputDataTable.Columns.Clear();
                    LoadFile();
                }
            }

        }
        private void LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Настройка диалогового окна
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                if (selectedFilePath == "")
                {
                    MessageBox.Show(
                        "Файл не найден",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                FillTable();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (StudentInfo_dataGridView.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Загрузите файл",
                    "Нет файла",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Сохранить отчет";
                saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Получаем путь к файлу
                        string filePath = saveDialog.FileName;

                        // Пример сохранения текста в файл
                        //File.WriteAllText(filePath, NameUnit_label.Text);

                        MessageBox.Show("Отчет сохранен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }
        private void FillTable()
        {
            string[] def = new string[16];
            try
            {
                StreamReader g = new StreamReader(selectedFilePath);
            }
            catch (IOException ex)
            {
                if (ex.Message.Contains("being used by another process"))
                {
                    MessageBox.Show(
                       "Файл занят другим процессом. " +
                       "Закройте все приложения, использующие этот файл.",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(
                       "Ошибка при работе с файлом",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
                return;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                      "Нет доступа к файлу",
                      "Ошибка",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Непредвиденная ошибка",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;

            }
            StreamReader f = new StreamReader(selectedFilePath);
            string[] lines = File.ReadAllLines(selectedFilePath);
            int numberOfLines = lines.Length;
            def = f.ReadLine().Split(";");
            for (int i = 0; i <= 15; i++)
            {
                inputDataTable.Columns.Add(def[i]);
                if (i >= 4 && i <= 13)
                {
                    ChooseColumn_comboBox.Items.Add(def[i]);
                    ChooseSortParam_comboBox.Items.Add(def[i]);
                    ChooseFindParam_comboBox.Items.Add(def[i]);
                    RatingCriteria_comboBox.Items.Add(def[i]);
                }
            }
            for (int i = 1; i < numberOfLines; i++)
            {
                DataRow dr = inputDataTable.NewRow();
                def = f.ReadLine().Split(";");
                try
                {
                    Convert.ToInt32(def[0]);
                    Convert.ToInt32(def[2]);
                    Convert.ToInt32(def[15]);
                    for (int j = 4; j <= 14; j++)
                    {
                        Convert.ToDouble(def[j]);
                    }
                    for (int k = 0; k < inputDataTable.Columns.Count; k++)
                    {
                        dr[k] = def[k];
                    }
                    inputDataTable.Rows.Add(dr);
                }
                catch (Exception)
                {
                    MessageBox.Show(
                   "Значение в таблице введено неверно \n" +
                   $"Ошибка в строке {i}",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    return;
                }
            }
        }


        private void Apply_button_Click(object sender, EventArgs e)
        {
            if (WorkWithBase_panel.Visible == true)
            {
                if (SortDirection_comboBox.Text != "" &&
                ChooseSortParam_comboBox.Text != "")
                    AnalyzerClassLibrary.CustomSort(StudentInfo_dataGridView, SortDirection_comboBox.Text, ChooseSortParam_comboBox.Text);
                if (ChooseFindParam_comboBox.Text != "" && FindRatio_comboBox.Text != "" && ChooseFind_textBox.Text != "") ;
                {
                    try
                    {
                        if (ChooseFind_textBox.Text != "")
                            Convert.ToDouble(ChooseFind_textBox.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                        "Значение параметра поиска введено неверно",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        return;
                    }
                    if (ChooseFindParam_comboBox.Text == "ФИО студента" && FindRatio_comboBox.Text == "=")
                    {
                        AnalyzerClassLibrary.FilterString(StudentInfo_dataGridView, ChooseFind_textBox.Text, "ФИО студента");
                        StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
                    }
                    else
                    {
                        AnalyzerClassLibrary.FilterNums(StudentInfo_dataGridView, ChooseFind_textBox.Text, ChooseFindParam_comboBox.Text, FindRatio_comboBox.Text);
                        StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
                    }
                }
                if (ChooseGroupParam_comboBox.Text != "")
                {
                    AnalyzerClassLibrary.Group(StudentInfo_dataGridView, ChooseGroupParam_comboBox.Text);
                }
            }
            if (StatisticalIndicators_panel.Visible == true)
            {
                if (ChooseColumn_comboBox.Text != "")
                {
                    Fill_Statistical_Indicators();
                }
            }
            if (Chart_panel.Visible == true)
            {
                Rating_Mode();
            }
        }
        private void BuildGroupRatingChartAbsolute(IEnumerable<KeyValuePair<string, double>> sortedGroups)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            // Заголовок
            Title title = new Title($"Рейтинг групп по критерию {RatingCriteria_comboBox.Text}");
            chart.Titles.Add(title);

            // Серия
            Series series = new Series
            {
                Name = "Рейтинг групп",
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = false,
                LabelFormat = ""
            };

            // Добавляем данные
            foreach (var group in sortedGroups)
            {
                series.Points.AddXY(group.Key, group.Value);
            }

            // Добавляем серию на диаграмму
            chart.Series.Add(series);

            // Настройка ChartArea
            ChartArea chartArea = chart.ChartAreas[0];

            // Настраиваем оси
            chartArea.AxisX.Title = "Группы";
            chartArea.AxisY.Title = "Средний балл";
            chartArea.AxisY.Interval = 1;
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.AxisX.MajorGrid.Enabled = true;

            // Устраняем наложение столбцов
            series.CustomProperties = "PointWidth=0.6, GapDepth=100, Overlap=0";
            series["PointWidth"] = "0.5"; 

            // Дополнительные настройки
            series["ColumnWidth"] = "0.6";
            series.Palette = ChartColorPalette.Pastel;

            // Выравнивание точек под метками
            chart.AlignDataPointsByAxisLabel();
        }
        private void BuildStudentRatingBarChart(DataTable filteredTable, string ratingCriteria)
        {
            var gradeGroups = filteredTable.AsEnumerable()
                .GroupBy(row => row[ratingCriteria])
                .Select(group => new
                {
                    Grade = group.Key, 
                    Count = group.Count() 
                })
                .ToList();
            chart.Series.Clear();
            chart.Titles.Clear();

            var title = new Title($"Распределение оценок по критерию: {RatingCriteria_comboBox.Text}");
            chart.Titles.Add(title);

            var series = new Series
            {
                Name = "Распределение оценок",
                ChartType = SeriesChartType.Pie, 
                IsValueShownAsLabel = true 
            };

            foreach (var group in gradeGroups)
            {
                series.Points.AddXY(group.Grade, group.Count);
            }

            chart.Series.Add(series);

            var chartArea = chart.ChartAreas[0];
            chartArea.AxisX.Title = "Оценки";
            chartArea.AxisY.Title = "Количество учеников";

            series.Palette = ChartColorPalette.Fire;

            series["PieLabelStyle"] = "Percentage";

            int totalStudents = gradeGroups.Sum(g => g.Count);

        }
        private void Rating_Mode()
        {
            chart.Visible = true;
            if (RatingCriteria_comboBox.Text == "")
            {
                MessageBox.Show(
                 "Параметр рейтинга не выбран",
                 "Ошибка",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                return;
            }
            if(!checkBox_GroupRating.Checked && !checkBox_StudentRating.Checked)
            {
                MessageBox.Show(
                "Выберите рейтинг студентов или рейтинг групп",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            DataColumn column = inputDataTable.Columns
                .Cast<DataColumn>()
                .FirstOrDefault(c => c.ColumnName == RatingCriteria_comboBox.Text);
            DataColumn Group = inputDataTable.Columns
                .Cast<DataColumn>()
                .FirstOrDefault(c => c.ColumnName == "Группа");

            DataTable deepCopyTable = inputDataTable.Clone();
            foreach (DataRow row in inputDataTable.Rows)
            {
                deepCopyTable.ImportRow(row);
            }
            if (checkBox_StudentRating.Checked)
            {
                // Сортируем по столбцу из DataTable
                deepCopyTable.DefaultView.Sort = $"{column.ColumnName} DESC";
                DataTable sortedTable = deepCopyTable.DefaultView.ToTable();

                // Фильтруем, используя имя столбца из DataTable
                DataTable filteredTable = sortedTable.DefaultView.ToTable(
                    false,
                    "ID",
                    "ФИО студента",
                    column.ColumnName);

                for (int i = 0; i < filteredTable.Rows.Count; i++)
                {
                    filteredTable.Rows[i]["ID"] = i + 1;
                }

                StudentInfo_dataGridView.DataSource = filteredTable;


                StudentInfo_dataGridView.Columns["ID"].HeaderText = "Номер в рейтинге";
                StudentInfo_dataGridView.Columns[column.ColumnName].HeaderText = $"{RatingCriteria_comboBox.Text}";
                StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
                BuildStudentRatingBarChart(filteredTable, RatingCriteria_comboBox.Text);
            }
            
            else
            {

                Dictionary<string, double> groupAverage = new Dictionary<string, double>();

                deepCopyTable.DefaultView.Sort = Group.ColumnName + " ASC";
                DataTable sortedTable = deepCopyTable.DefaultView.ToTable();

                // Проходим по всем строкам и считаем средние оценки
                double total = 0;
                int count = 0;
                string currentGroup = "";

                for (int i = 0; i < inputDataTable.Rows.Count; i++)
                {
                    string group = Convert.ToString(inputDataTable.Rows[i][3]);

                    if (group != currentGroup)
                    {
                        // Если группа изменилась - сохраняем предыдущую
                        if (!string.IsNullOrEmpty(currentGroup) && count > 0)
                        {
                            groupAverage[currentGroup] = total / count;
                        }

                        // Начинаем считать новую группу
                        currentGroup = group;
                        total = 0;
                        count = 0;
                    }

                    // Суммируем оценки
                    total += Convert.ToDouble(inputDataTable.Rows[i][column.ColumnName]);
                    count++;
                }

                // Сохраняем последнюю группу
                if (!string.IsNullOrEmpty(currentGroup) && count > 0)
                {
                    groupAverage[currentGroup] = total / count;
                }

                // Сортируем группы по среднему баллу в порядке убывания
                var sortedGroups = groupAverage.OrderByDescending(x => x.Value);

                // Создаем новую таблицу для отображения рейтинга
                DataTable filteredTable = new DataTable();
                filteredTable.Columns.Add("Номер в рейтинге", typeof(int));
                filteredTable.Columns.Add("Группа", typeof(string));
                filteredTable.Columns.Add($"Средний балл {RatingCriteria_comboBox.Text}", typeof(double));

                int rank = 1;
                foreach (var group in sortedGroups)
                {
                    filteredTable.Rows.Add(
                        rank++,
                        group.Key,
                        Math.Round(group.Value, 2)
                    );
                }

                // Привязываем таблицу к DataGridView
                StudentInfo_dataGridView.DataSource = filteredTable;
                StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
                BuildGroupRatingChartAbsolute(sortedGroups);
            }
        }

        private void Fill_Statistical_Indicators()
        {
            Average_textBox.Text = Convert.ToString(CalculateStatisticalIndicators.CalculateAverage(StudentInfo_dataGridView, ChooseColumn_comboBox.Text));
            Median_textBox.Text = Convert.ToString(CalculateStatisticalIndicators.CalculateMedian(StudentInfo_dataGridView, ChooseColumn_comboBox.Text));
            Min_textBox.Text = Convert.ToString(CalculateStatisticalIndicators.CalculateMinMax(StudentInfo_dataGridView, ChooseColumn_comboBox.Text)[0]);
            Max_textBox.Text = Convert.ToString(CalculateStatisticalIndicators.CalculateMinMax(StudentInfo_dataGridView, ChooseColumn_comboBox.Text)[1]);
        }
        private void Remove_button_Click(object sender, EventArgs e)
        {
            if (WorkWithBase_panel.Visible == true)
            {
                ChooseSortParam_comboBox.SelectedItem = null;
                SortDirection_comboBox.SelectedItem = null;
                ChooseFindParam_comboBox.SelectedItem = null;
                FindRatio_comboBox.SelectedItem = null;
                ChooseGroupParam_comboBox.SelectedItem = null;
                ChooseFind_textBox.Text = null;
                if (StudentInfo_dataGridView.DataSource is DataTable table)
                {
                    table.DefaultView.Sort = null;
                    table.DefaultView.RowFilter = null;
                }
                StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
            }
            if (StatisticalIndicators_panel.Visible == true)
            {
                ChooseColumn_comboBox.Text = null;
                Average_textBox.Text = null;
                Median_textBox.Text = null;
                Min_textBox.Text = null;
                Max_textBox.Text = null;
            }
            if(Chart_panel.Visible == true)
            {
                RatingCriteria_comboBox.Text = "";
                checkBox_GroupRating.Checked = false;
                checkBox_StudentRating.Checked = false;
                StudentInfo_dataGridView.DataSource = inputDataTable;
                StudentInfo_dataGridView.Columns["ID"].HeaderText = "ID";
                StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
            }


        }
        private void Get_Inf(object sender, EventArgs e)
        {
            if (HomeButtons_flowLayoutPanel.Visible == true)
            {
                MessageBox.Show(
                  "Приложение для работы с данными об успеваемости студентов по 10 предметам.\n" +
                  "При нажатии кнопки \"Работа с базой данных\" вы сможете применить сортировку, группировку и поиск по таблице с данными.\n" +
                  "При нажатии кнопки \"Вычисление статистических показателей\" вы сможете увидеть такие показатели, как:\n" +
                  "Среднее арифметическое, медиану, минимальное и максимальное значения для выбранного столбца.\n" +
                  "При нажатии кнопки \"Построение рейтингов\" вы сможете увидеть рейтинг студента по выбранным показателям и визуализацию этого рейтинга.\n" +
                  "Перед началом работы необходимо загрузить файл с данными:\n" +
                  "Нажмите на кнопку \"Загрузить файл\" и выберете нужный файл формата csv.\n" +
                  "По окончании работы вы можете сохранить отчет в текстовый файл, нажав на кнопку \"Экспорт отчета\" и выбрав место для сохранения.\n",
                  "Справка пользователя",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Asterisk);
            }
            if (WorkWithBase_panel.Visible == true)
            {
                MessageBox.Show(
                 "В данном разделе вы можете применить к выбранной базе данных сортировку, группировку и поиск с использованием фильтров.\n" +
                 "Для нужных действий выберете столбец, к которому будет применено действие и нужные параметры.\n" +
                 "При нажатии кнопки \"Применить обработку\" таблица будет показана в соответствии с выставленными требованими.\n" +
                 "При нажатии кнопки \"Снять обработку\" таблица будет возвращена к исходному состоянию.\n",
                 "Справка пользователя",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Asterisk);
            }
            if (StatisticalIndicators_panel.Visible == true)
            {
                MessageBox.Show(
                 "В данном разделе происходит вычисление таких статистических показателей, как:\n" +
                 "Среднее арифметическое, медиану, минимальное и максимальное значения для выбранного столбца.\n" +
                 "В соответствующем поле нужно выбрать столбец, по которому будет производиться вычисления.\n",
                 "Справка пользователя",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Asterisk);
            }
            if (Chart_panel.Visible == true)
            {
                MessageBox.Show(
                "В данном разделе происходит построение рейтингов студентов и групп по заданным критериям.\n" +
                "Выберете критерий построения рейтингов - столбец, по которому бедет строиться рейтинг.\n" +
                "С помощью кнопок в правом нижнем углу выберете бедет ли построен рейтинг групп или рейтинг студентов.\n" +
                "При нажатии кнопки \"Построить рейтинг\" будет построен рейтинг и показаны диаграммы, визуализирующие рейтинг. \n" +
                "При нажатии кнопки \"Скрыть рейтинг\" диаграммы и рейтинг будут скрыты.\n",
                "Справка пользователя",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
            }
        }

        private void checkBox_StudentRating_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_StudentRating.Checked == true)
            {
                checkBox_GroupRating.Enabled = false;
            }
            else
            {
                checkBox_GroupRating.Enabled = true;
            }
        }

        private void checkBox_GroupRating_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_GroupRating.Checked == true)
            {
                checkBox_StudentRating.Enabled = false;
            }
            else
            {
                checkBox_StudentRating.Enabled = true;
            }
        }
    }

}
