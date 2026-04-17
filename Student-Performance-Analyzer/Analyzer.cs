using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Student_Performance_Analyzer
{
    public partial class Analyzer_form : Form
    {
        private string selectedFilePath = "";
        private Student[] studentArray = new Student[0];
        private Student[] originalStudentArray = new Student[0];
        private BindingSource bindingSource = new BindingSource();
        private string report = "Отчёт о работе с данными об успеваемости студентов.\n";

        public Analyzer_form()
        {
            InitializeComponent();
            bindingSource.DataSource = studentArray;
            StudentInfo_dataGridView.DataSource = bindingSource;
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
                if (studentArray.Length == 0)
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
                    StatInfoNum_label.Text = $"{studentArray.Length}";

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
            Remove_button_Click(sender, e);
            HomeButtons_flowLayoutPanel.Visible = true;
            Apply_button.Visible = false;
            Remove_button.Visible = false;
            Return_button.Visible = false;
            Base_panel.Visible = false;

            if (NameUnit_label.Text == "Работа с базой данных")
            {
                WorkWithBase_panel.Visible = false;
                StatInfo_panel.Visible = false;
                studentArray = (Student[])originalStudentArray.Clone();
                UpdateDataGridView();
                StatInfoNum_label.Text = $"{studentArray.Length}";
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
                StatInfo_panel.Visible = false;
                Rating_panel.Visible = false;
                Chart_panel.Visible = false;
            }
            NameUnit_label.Text = "Анализатор успеваемости студентов";
        }

        private void LoadFile_button_Click(object sender, EventArgs e)
        {
            if (studentArray.Length == 0)
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
                    studentArray = Array.Empty<Student>();
                    originalStudentArray = Array.Empty<Student>();
                    ClearReport_Click(sender, e);
                    LoadFile();
                }
            }
        }

        private void LoadFile()
        {
            report = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Настройка диалогового окна
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                if (string.IsNullOrEmpty(selectedFilePath))
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

        private void FillTable()
        {
            string[] def = new string[16];
            try
            {
                string[] lines = File.ReadAllLines(selectedFilePath);
                def = lines[0].Split(';');

                // Заполняем ComboBox
                for (int i = 4; i <= 13; i++)
                {
                    ChooseColumn_comboBox.Items.Add(def[i]);
                    ChooseSortParam_comboBox.Items.Add(def[i]);
                    ChooseFindParam_comboBox.Items.Add(def[i]);
                    RatingCriteria_comboBox.Items.Add(def[i]);
                }

                var tempList = new List<Student>();
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(';');
                    if (values.Length >= 16)
                    {
                        Student student = new Student(
                            int.Parse(values[0]),
                    values[1],
                    int.Parse(values[2]),
                    values[3],
                    double.Parse(values[4]),
                    double.Parse(values[5]),
                    double.Parse(values[6]),
                    double.Parse(values[7]),
                    double.Parse(values[8]),
                    double.Parse(values[9]),
                    double.Parse(values[10]),
                    double.Parse(values[11]),
                    double.Parse(values[12]),
                    double.Parse(values[13]),
                    double.Parse(values[14]),
                    int.Parse(values[15])
                );
                        tempList.Add(student);
                    }
                }
                studentArray = tempList.ToArray();
                originalStudentArray = (Student[])studentArray.Clone();

                UpdateDataGridView();
                StatInfoNum_label.Text = $"{studentArray.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (studentArray.Length == 0)
            {
                MessageBox.Show(
                    "Загрузите файл",
                    "Нет файла",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Сохранить отчёт";
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveDialog.FileName;
                    File.WriteAllText(filePath, report);
                    MessageBox.Show("Отчёт сохранён успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearReport_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении отчёта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void GetTab()
        {
            report += "ID;ФИО студента;Курс;Группа;Физика;Английский язык;История;Физическая культура;Культурология;Информатика;Психология;Математика;Биология;Химия;Общий средний балл;Кол-во задолженностей\n";
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            if (WorkWithBase_panel.Visible == true)
            {
                GetTab();

                Student[] currentStudents = (Student[])studentArray.Clone();

                if (SortDirection_comboBox.Text != "" && ChooseSortParam_comboBox.Text != "")
                {
                    WorkWithBase.CustomSort(ref currentStudents, SortDirection_comboBox.Text, ChooseSortParam_comboBox.Text);
                    report += $"Сортировка по параметру {ChooseSortParam_comboBox.Text}. Направление сортировки: {SortDirection_comboBox.Text}\n";
                }

                if (ChooseFindParam_comboBox.Text != "" && FindRatio_comboBox.Text != "" && ChooseFind_textBox.Text != "")
                {
                    try
                    {
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

                    report += $"Поиск значений по параметру {ChooseFindParam_comboBox.Text}. Условие поиска {FindRatio_comboBox.Text} {ChooseFind_textBox.Text}\n";
                    currentStudents = WorkWithBase.FilterNums(currentStudents, ChooseFind_textBox.Text, ChooseFindParam_comboBox.Text, FindRatio_comboBox.Text);
                }

                if (ChooseGroupParam_comboBox.Text != "")
                {
                    report += $"Группировка по параметру {ChooseGroupParam_comboBox.Text}.\n";

                    var groupedStudents = WorkWithBase.Group(currentStudents, ChooseGroupParam_comboBox.Text);
                    var displayList = new List<Student>();

                    foreach (var group in groupedStudents)
                    {
                        report += $"Группа: {group.Key} ({group.Value.Length} студентов)\n";
                        displayList.AddRange(group.Value);
                    }

                    studentArray = displayList.ToArray();
                }
                else
                {
                    studentArray = currentStudents;
                }

                UpdateDataGridView();
                StatInfoNum_label.Text = $"{studentArray.Length}";

                for (int i = 0; i < StudentInfo_dataGridView.Rows.Count; i++)
                {
                    DataGridViewRow row = StudentInfo_dataGridView.Rows[i];
                    List<string> cellValues = new List<string>();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cellValues.Add(cell.Value?.ToString() ?? "null");
                    }
                    report += $"{string.Join(";", cellValues)}\n";
                }
            }

            if (StatisticalIndicators_panel.Visible == true && ChooseColumn_comboBox.Text != "")
            {
                try
                {
                    double average = CalculateStatisticalIndicators.CalculateAverage(studentArray, ChooseColumn_comboBox.Text);
                    double median = CalculateStatisticalIndicators.CalculateMedian(studentArray, ChooseColumn_comboBox.Text);
                    var (min, max) = CalculateStatisticalIndicators.CalculateMinMax(studentArray, ChooseColumn_comboBox.Text);

                    Average_textBox.Text = average.ToString();
                    Median_textBox.Text = median.ToString();
                    Min_textBox.Text = min.ToString();
                    Max_textBox.Text = max.ToString();

                    report += $"Статистические показатели по {ChooseColumn_comboBox.Text}:\n";
                    report += $"Среднее: {average}, Медиана: {median}, Минимум: {min}, Максимум: {max}\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка расчёта статистических показателей: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (Chart_panel.Visible == true)
            {
                Rating_Mode();
            }
        }
        private void RestoreOriginalData(bool forceOriginal = false)
        {
            if (forceOriginal)
            {
                studentArray = (Student[])originalStudentArray.Clone();
            }

            UpdateDataGridView();
            StatInfoNum_label.Text = $"{studentArray.Length}";

            foreach (DataGridViewColumn column in StudentInfo_dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            chart.Visible = false;
            chart.Series.Clear();
            chart.Titles.Clear();
        }
        private void UpdateDataGridView()
        {
            var dataTable = CreateDataTableFromStudentArray(studentArray);
            StudentInfo_dataGridView.DataSource = dataTable;
        }

        private DataTable CreateDataTableFromStudentArray(Student[] students)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ФИО студента", typeof(string));
            dt.Columns.Add("Курс", typeof(int));
            dt.Columns.Add("Группа", typeof(string));
            dt.Columns.Add("Физика", typeof(double));
            dt.Columns.Add("Английский язык", typeof(double));
            dt.Columns.Add("История", typeof(double));
            dt.Columns.Add("Физическая культура", typeof(double));
            dt.Columns.Add("Культурология", typeof(double));
            dt.Columns.Add("Информатика", typeof(double));
            dt.Columns.Add("Психология", typeof(double));
            dt.Columns.Add("Математика", typeof(double));
            dt.Columns.Add("Биология", typeof(double));
            dt.Columns.Add("Химия", typeof(double));
            dt.Columns.Add("Общий средний балл", typeof(double));
            dt.Columns.Add("Кол-во задолженностей", typeof(int));

            foreach (var student in students)
            {
                dt.Rows.Add(
                    student.ID,
                    student.FullName,
                    student.Course,
                    student.Group,
                    student.Physics,
                    student.English,
                    student.History,
                    student.PhysicalEducation,
                    student.CulturalStudies,
                    student.Informatics,
                    student.Psychology,
                    student.Mathematics,
                    student.Biology,
                    student.Chemistry,
                    student.AverageGrade,
                    student.DebtCount
                );
            }

            return dt;
        }
        private void Remove_button_Click(object sender, EventArgs e)
        {
            StudentInfo_dataGridView.DataSource = CreateDataTableFromStudentArray(originalStudentArray);

            if (WorkWithBase_panel.Visible == true)
            {
                ChooseSortParam_comboBox.SelectedItem = null;
                SortDirection_comboBox.SelectedItem = null;
                ChooseFindParam_comboBox.SelectedItem = null;
                FindRatio_comboBox.SelectedItem = null;
                ChooseGroupParam_comboBox.SelectedItem = null;
                ChooseFind_textBox.Text = "";

                RestoreOriginalData(true);
            }

            if (StatisticalIndicators_panel.Visible == true)
            {
                ChooseColumn_comboBox.SelectedItem = null;
                Average_textBox.Text = string.Empty;
                Median_textBox.Text = string.Empty;
                Min_textBox.Text = string.Empty;
                Max_textBox.Text = string.Empty;
            }

            if (Chart_panel.Visible == true)
            {
                RatingCriteria_comboBox.SelectedItem = null;
                checkBox_GroupRating.Checked = false;
                checkBox_StudentRating.Checked = false;

                RestoreOriginalData(true);

                chart.Series.Clear();
                chart.Titles.Clear();
                chart.Visible = false;
            }
        }
        private void Rating_Mode()
        {
            GetTab();
            chart.Visible = true;

            if (string.IsNullOrEmpty(RatingCriteria_comboBox.Text))
            {
                MessageBox.Show("Параметр рейтинга не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable inputDataTable = CreateDataTableFromStudentArray(studentArray);

            // Ищем нужные колонки
            DataColumn column = inputDataTable.Columns
                .Cast<DataColumn>()
                .FirstOrDefault(c => c.ColumnName == RatingCriteria_comboBox.Text);

            DataColumn groupColumn = inputDataTable.Columns
                .Cast<DataColumn>()
                .FirstOrDefault(c => c.ColumnName == "Группа");

            if (column == null)
            {
                MessageBox.Show("Выбранный критерий не найден в данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable deepCopyTable = inputDataTable.Clone();
            foreach (DataRow row in inputDataTable.Rows)
            {
                deepCopyTable.ImportRow(row);
            }

            if (checkBox_StudentRating.Checked)
            {
                BuildStudentRatingFromDataTable(deepCopyTable, column.ColumnName);
            }
            else
            {
                if (groupColumn == null)
                {
                    MessageBox.Show("Колонка «Группа» не найдена в данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BuildGroupRatingFromDataTable(deepCopyTable, column.ColumnName, groupColumn.ColumnName);
            }
        }

        private void BuildGroupRatingChartAbsolute(IEnumerable<KeyValuePair<string, double>> sortedGroups)
        {
            chart.Series.Clear();
            chart.Titles.Clear();

            Title title = new Title($"Рейтинг групп по критерию {RatingCriteria_comboBox.Text}");
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            chart.Titles.Add(title);

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

            chart.Series.Add(series);

            // Настройка ChartArea
            ChartArea chartArea = chart.ChartAreas[0];

            // Настраиваем оси
            chartArea.AxisX.Title = "Группы";
            chartArea.AxisY.Title = "Средний балл";
            chartArea.AxisY.Interval = 1;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 5;
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.MajorGrid.Enabled = false;

            // Устраняем наложение столбцов
            series.CustomProperties = "PointWidth=0.6, GapDepth=100, Overlap=0";
            series["PointWidth"] = "0.5";
            series["ColumnWidth"] = "0.6";

            // Дополнительные настройки
            series.Palette = ChartColorPalette.Pastel;

            // Выравнивание точек под метками
            chart.AlignDataPointsByAxisLabel();

            chart.Visible = true;

            // Формируем отчёт
            report += $"Построен рейтинг групп по критерию {RatingCriteria_comboBox.Text}:\n";
            int i = 1;
            foreach (var group in sortedGroups)
            {
                report += $"{i++}. Группа {group.Key}: средний балл {group.Value}\n";
            }
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

            // Формируем отчёт
            report += $"Распределение оценок по критерию {ratingCriteria} (всего студентов: {totalStudents}):\n";
            foreach (var group in gradeGroups)
            {
                double percentage = (double)group.Count / totalStudents * 100;
                report += $"Оценка {group.Grade}: {group.Count} студентов ({percentage:0.0}%)\n";
            }
        }
        private void BuildStudentRatingFromDataTable(DataTable dataTable, string ratingCriteria)
        {
            report += $"Построение рейтинга студентов по параметру {ratingCriteria}\n";

            // Сортируем по критерию в порядке убывания
            dataTable.DefaultView.Sort = $"{ratingCriteria} DESC";
            DataTable sortedTable = dataTable.DefaultView.ToTable();

            // Фильтруем нужные колонки
            DataTable filteredTable = sortedTable.DefaultView.ToTable(
                false,
                "ID",
                "ФИО студента", 
                ratingCriteria);

            // Добавляем нумерацию
            for (int i = 0; i < filteredTable.Rows.Count; i++)
            {
                filteredTable.Rows[i]["ID"] = i + 1;
            }

            StudentInfo_dataGridView.DataSource = filteredTable;

            // Настраиваем заголовки колонок
            if (StudentInfo_dataGridView.Columns.Contains("ID"))
                StudentInfo_dataGridView.Columns["ID"].HeaderText = "Номер в рейтинге";
            if (StudentInfo_dataGridView.Columns.Contains(ratingCriteria))
                StudentInfo_dataGridView.Columns[ratingCriteria].HeaderText = RatingCriteria_comboBox.Text;

            StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count - 1}";

            BuildStudentRatingBarChart(filteredTable, ratingCriteria);
           
        }
        private void BuildGroupRatingFromDataTable(DataTable dataTable, string ratingCriteria, string groupColumn)
        {
            report += $"Построение рейтинга групп по параметру {ratingCriteria}\n";

            // Проверяем существование колонок
            if (!dataTable.Columns.Contains(ratingCriteria))
            {
                MessageBox.Show($"Колонка '{ratingCriteria}' не найдена в данных", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!dataTable.Columns.Contains(groupColumn))
            {
                MessageBox.Show($"Колонка '{groupColumn}' не найдена в данных", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Группируем по группам и считаем средние оценки
            var groupAverage = dataTable.AsEnumerable()
                .GroupBy(row => row[groupColumn].ToString())
                .Select(g => new KeyValuePair<string, double>(
                    g.Key,
                    Math.Round(g.Average(r => Convert.ToDouble(r[ratingCriteria])), 2)
                ))
                .OrderByDescending(kvp => kvp.Value)
                .ToList();

            BuildGroupRatingChartAbsolute(groupAverage);

            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Номер в рейтинге", typeof(int));
            filteredTable.Columns.Add("Группа", typeof(string));
            filteredTable.Columns.Add($"Средний балл по {ratingCriteria}", typeof(double));

            int rank = 1;
            foreach (var group in groupAverage)
            {
                filteredTable.Rows.Add(rank++, group.Key, group.Value);
            }

            StudentInfo_dataGridView.DataSource = filteredTable;
            StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count - 1}";
        }
        private void checkBox_GroupRating_CheckedChanged(object sender, EventArgs e)
        {
            if (chart.Visible && checkBox_GroupRating.Checked)
            {
                checkBox_StudentRating.Checked = false;
                Rating_Mode();
            }
        }

        private void checkBox_StudentRating_CheckedChanged(object sender, EventArgs e)
        {
            if (chart.Visible && checkBox_StudentRating.Checked)
            {
                checkBox_GroupRating.Checked = false;
                Rating_Mode(); 
            }
        }

        private void ClearReport_Click(object sender, EventArgs e)
        {
            report = "Отчёт о работе с данными об успеваемости студентов.\n";
            MessageBox.Show("Отчёт очищен", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Analyzer_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите закрыть приложение?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}