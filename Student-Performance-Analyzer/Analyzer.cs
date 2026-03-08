using System.Windows.Forms.VisualStyles;

namespace Student_Performance_Analyzer
{
    public partial class Analyzer_form : Form
    {

        public Analyzer_form()
        {
            InitializeComponent();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            var tmp = (Button)sender;
            if (tmp.Name == "DataSetHome_button")
            {
                HomeButtons_panel.Visible = false;
                NameUnit_label.Text = "Работа с базой данных";
                WorkWithBase_panel.Visible = true;
                Base_panel.Visible = true;
                Button_panel.Visible = true;
                Apply_button.Visible = true;
                Remove_button.Visible = true;
                Return_button.Visible = true;


            }
        }

        private void ReturnInMenu_button_Click(object sender, EventArgs e)
        {
            var tmp = (Button)sender;
            if (tmp.Name == "WorkWithBaseReturn_button")
                WorkWithBase_panel.Visible = false;
        }

        private void LoadFile_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Настройка диалогового окна
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Отображение диалогового окна
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

            }
        }

        private void Analyzer_form_SizeChanged(object sender, EventArgs e)
        {
            Base_panel.Width = Home_panel.Width - WorkWithBase_panel.Width;
            Base_panel.Height = Home_panel.Height - Button_panel.Height - NameUnit_label.Height;
        }
    }

}
