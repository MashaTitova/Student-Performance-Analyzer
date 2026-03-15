using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Security.Policy;
using System.Windows.Forms.VisualStyles;
using static WorkWithBase;

namespace Student_Performance_Analyzer
{
    public partial class Analyzer_form : Form
    {
        private DataGridViewRowCollection mainData;
        private string selectedFilePath = "";
        DataTable inputDataTable = new DataTable();

        public Analyzer_form()
        {
            InitializeComponent();
            StudentInfo_dataGridView.Columns.Clear();
            StudentInfo_dataGridView.DataSource = inputDataTable;
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            var tmp = (Button)sender;
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
                    NameUnit_label.Text = "Построение рейтингов по общему среднему баллу";
                    Rating_panel.Visible = true;
                    Chart_panel.Visible = true;
                    Base_panel.Visible = true;
                    Apply_button.Text = "Показать диаграммы";
                    Remove_button.Text = "Скрыть диаграммы";
                }
                if (tmp.Name == "ExitApp_button")
                {
                    DialogResult result = MessageBox.Show(
                       "Вы уверены, что хотите закрыть приложение?",
                       "Подтверждение",
                       MessageBoxButtons.YesNo
                    );
                    // Если пользователь выбрал "Нет", отменяем закрытие
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
                HomeButtons_flowLayoutPanel.Visible = false;
                Apply_button.Visible = true;
                Remove_button.Visible = true;
                Return_button.Visible = true;
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
            NameUnit_label.Text = "Анализатор успеваемости студентов";
        }

        private void LoadFile_button_Click(object sender, EventArgs e)
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
        private void FillTable()
        {
            string[] def = new string[16];
            StreamReader f = new StreamReader(selectedFilePath);
            string[] lines = File.ReadAllLines(selectedFilePath);
            int numberOfLines = lines.Length;
            def = f.ReadLine().Split(";");
            for (int i = 0; i <= 15; i++)
            {
                inputDataTable.Columns.Add(def[i]);
                if (i >= 4 && i <= 13)
                {
                    
                    ChooseSortParam_comboBox.Items.Add(def[i]);
                    ChooseFindParam_comboBox.Items.Add(def[i]);
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



        public static bool Calculate(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case ">":
                    return num1 > num2;
                case ">=":
                    return num1 >= num2;
                case "<":
                    return num1 < num2;
                case "<=":
                    return num1 <= num2;
                case "=":
                    return num1 == num2;
                default:
                    return false;
            }
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            if (WorkWithBase_panel.Visible == true)
            {
                if (SortDirection_comboBox.Text != "" &&
                ChooseSortParam_comboBox.Text != "")
                    WorkWithBase.CustomSort(StudentInfo_dataGridView, SortDirection_comboBox.Text, ChooseSortParam_comboBox.Text);
                if ((ChooseFindParam_comboBox.Text != "" && FindRatio_comboBox.Text != "" && ChooseFind_textBox.Text != ""));
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
                    if(ChooseFindParam_comboBox.Text == "ФИО студента" &&  FindRatio_comboBox.Text == "=")
                    {
                        WorkWithBase.FilterString(StudentInfo_dataGridView, ChooseFind_textBox.Text, "ФИО студента");
                        StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
                    }
                    else
                    {
                        WorkWithBase.FilterNums(StudentInfo_dataGridView, ChooseFind_textBox.Text, ChooseFindParam_comboBox.Text, FindRatio_comboBox.Text);
                        StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
                    }
                }
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            if(WorkWithBase_panel.Visible == true)
            {
                ChooseSortParam_comboBox.SelectedItem = null;
                SortDirection_comboBox.SelectedItem = null;
                ChooseFindParam_comboBox.SelectedItem = null;
                FindRatio_comboBox.SelectedItem = null;
                ChooseGroupParam_comboBox.SelectedItem = null;
                ChooseFind_textBox.Text = null;
                ChooseGroup_textBox.Text = null;
                if (StudentInfo_dataGridView.DataSource is DataTable table)
                {
                    table.DefaultView.Sort = null;
                    table.DefaultView.RowFilter = null;
                }
                StatInfoNum_label.Text = $"{StudentInfo_dataGridView.Rows.Count}";
            }
            
        }
    }

}
