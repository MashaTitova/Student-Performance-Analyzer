

namespace Student_Performance_Analyzer
{
    public partial class Analyzer_form : Form
    {
        private string selectedFilePath = "";
        public Analyzer_form()
        {
            InitializeComponent();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            var tmp = (Button)sender;

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
            if (NameUnit_label.Text == "Построение рейтингов")
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
    }

}
