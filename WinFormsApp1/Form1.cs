using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int[] currentArray = new int[0];
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 30; i++)
                comboBoxTask.Items.Add($"Завдання {i}");

            comboBoxTask.SelectedIndex = 0;
            numericUpDownSize.Value = 10;
            numericUpDownMin.Minimum = -100;
        }

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDownSize.Value;
            int min = (int)numericUpDownMin.Value;
            int max = (int)numericUpDownMax.Value;

            if (min >= max) { MessageBox.Show("Максимальне значення має бути більшим за мінімальне."); return; }

            currentArray = new int[n];
            for (int i = 0; i < n; i++)
                currentArray[i] = rnd.Next(min, max + 1);

            txtArray.Text = string.Join(", ", currentArray);
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string text;
                    using (var reader = new StreamReader(ofd.FileName, System.Text.Encoding.UTF8, true))
                    {
                        text = reader.ReadToEnd();
                    }

                    if (string.IsNullOrWhiteSpace(text))
                    {
                        MessageBox.Show("Файл пустой или содержит невидимые символы!");
                        return;
                    }

                    txtArray.Text = text;
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при завантаженні файлу: {ex.Message}");
                }
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            ParseArrayFromText();
        }

        private void ParseArrayFromText()
        {
            string txt = txtArray.Text ?? "";

            // Заменяем запятые, точки с запятой и другие разделители на пробел
            char[] separators = new char[] {' ', ',', ';', '\n', '\r', '\t' };
            var parts = txt.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Преобразуем каждый элемент в int (включая отрицательные)
            var list = new List<int>();
            foreach (var s in parts)
            {
                if (int.TryParse(s.Trim(), out int number))
                {
                    list.Add(number);
                }
            }

            currentArray = list.ToArray();

            // Обновляем текстовое поле и результат
            txtArray.Text = string.Join(", ", currentArray);
            txtResult.Text = $"Масив прийнято ({currentArray.Length} елементів).";
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (currentArray == null || currentArray.Length == 0)
            { MessageBox.Show("Масив порожній. Введіть, згенеруйте або завантажте масив."); 
              return; 
            }

            int task = comboBoxTask.SelectedIndex + 1;
            string result;

            try
            {
                switch (task)
                {
                    case 1:
                        result = Tasks.Task1(currentArray);
                        break;

                    case 2:
                        result = Tasks.Task2(currentArray);
                        break;

                    case 3:
                        result = Tasks.Task3(currentArray);
                        break;

                    case 4:
                        result = Tasks.Task4(currentArray);
                        break;

                    case 5:
                        result = Tasks.Task5(currentArray);
                        break;

                    case 6:
                        result = Tasks.Task6(currentArray);
                        break;

                    case 7:
                        result = Tasks.Task7(currentArray);
                        break;

                    case 8:
                        result = Tasks.Task8(currentArray);
                        break;
                    
                    case 9:
                        result = Tasks.Task9(currentArray);
                        break;

                    case 10:
                        result = Tasks.Task10(currentArray);
                        break;

                    case 11:
                        result = Tasks.Task11(currentArray);
                        break;

                    case 12:
                        result = Tasks.Task12(currentArray);
                        break;

                    case 13:
                        result = Tasks.Task13(currentArray);
                        break;

                    case 14:
                        result = Tasks.Task14(currentArray);
                        break;

                    case 15:
                        result = Tasks.Task15(currentArray);
                        break;

                    case 16:
                        result = Tasks.Task16(currentArray);
                        break;

                    case 17:
                        result = Tasks.Task17(currentArray);
                        break;

                    case 18:
                        result = Tasks.Task18(currentArray);
                        break;

                    case 19:
                        result = Tasks.Task19(currentArray);
                        break;
                    
                    case 20:
                        result = Tasks.Task20(currentArray);
                        break;

                    case 21:
                        result = Tasks.Task21(currentArray);
                        break;
                    
                    case 22:
                        result = Tasks.Task22(currentArray);
                        break;

                    case 23:
                        result = Tasks.Task23(currentArray);
                        break;

                    case 24:
                        result = Tasks.Task24(currentArray);
                        break;

                    case 25:
                        result = Tasks.Task25(currentArray);
                        break;

                    case 26:
                        result = Tasks.Task26(currentArray);
                        break;

                    case 27:
                        result = Tasks.Task27(currentArray);
                        break;
                    
                    case 28:
                        result = Tasks.Task28(currentArray);
                        break;

                    case 29:
                        result = Tasks.Task29(currentArray);
                        break;

                    case 30:
                        result = Tasks.Task30(currentArray);
                        break;

                    default:
                        result = "Невідоме завдання.";
                        break;

                }

            }

            catch (Exception ex)
            {
                result = $"Помилка при виконанні завдання: {ex.Message}";
            }

            txtResult.Text = result;

        }
    }
}
