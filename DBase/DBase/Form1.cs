using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBase
{
    public partial class Form1 : Form
    {
        DataBase data = new DataBase();
        string oldValue = "";
        string filename = "";
        
        public Form1()
        {
            InitializeComponent();
            dataGridView.Rows[0].ReadOnly = true; 
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";// фильтр для записи в текстовый файл с расширением .txt
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";// тоже самое только сохр
            SaveLabel.Visible = false;
            comboBoxChoiceSort.Text = comboBoxChoiceSort.Items[0].ToString();
            InitializeTimers();
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox4, "Открыть файл (Ctrl+O)");
            t.SetToolTip(pictureBox1, "Сохранить файл (Ctrl+S)");
            t.SetToolTip(pictureBox3, "О приложении");
        }
        /// <summary>
        /// Таймер для автосохранения раз в 2 минуты
        /// и таймер для отображения надписи, свидетельствующей о сохранении файла
        /// длительностью 3 сек
        /// </summary>
        private void InitializeTimers()
        {
            
            timer1.Interval = 120000;
            timer1.Tick += new EventHandler(Timer1_Tick);

            
            timer2.Interval = 3000;
            timer2.Tick += new EventHandler(Timer2_Tick);
        }
        public ushort randID()
        {
            Random r = new Random();
            int id = r.Next(0, 1000);
            for (int i = 0; i < data.CarFiles.Count; i++)
            {
                CarFile car = (CarFile)data.CarFiles[i];
                if (car.IDCar == id)
                {
                    i = 0;
                    id = r.Next(0, 1000);
                }
            }
            return (ushort)id;
        }

        private void DataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// кнопка поиска
        /// </summary>
      
        private void Button1_Click(object sender, EventArgs e)
        {
            if ((data.CarFiles.Count == 0) || (SearchTextBox.Text == ""))
                return;
            dataGridView.ClearSelection();
            List<int> fe = data.SearchFile(SearchTextBox.Text);
            if (fe[0] == -1)
            {
                MessageBox.Show("Ничего не удалось найти!");
                return;
            }
            dataGridView.CurrentCell = dataGridView[0, fe[0]];
            for (int i = 0; i < fe.Count; i++)
            {
                dataGridView.Rows[fe[i]].Selected = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            СохранитьToolStripMenuItem_Click(сохранитьToolStripMenuItem, null);
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ОПрогаммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///  Запрещает  редактировать столбец по указанному индексу 
        /// </summary>
        private void BanChangeColumn(int index) =>
            dataGridView.Rows[index].Cells[0].ReadOnly = true;
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string manuf = ManufTextBox.Text;
                string model = ModelTextBox.Text;
                ushort year = (ushort)Convert.ToInt32(YearTextBox.Text);
                string body = BodyTextBox.Text;
                ManufTextBox.Text = "";
                ModelTextBox.Text = "";
                YearTextBox.Text = "";
                BodyTextBox .Text = "";
                CarFile carFile = new CarFile(randID(), manuf, model, year, body);
                data.AddFile(carFile);
                int n = data.CarFiles.Count;
                CarFile car = (CarFile)data.CarFiles[n - 1];
                dataGridView.Rows.Add(car.IDCar, manuf, model, year, body);
                BanChangeColumn(n - 1);
                if ((!timer1.Enabled) && (filename != ""))
                {
                    timer1.Enabled = true;
                    timer1.Start();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }
        }

        private void DelAllButton_Click(object sender, EventArgs e)
        {
            if(data.CarFiles.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены," +
                    "что хотите удалить все элементы?", "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    data.DeleteAll ();// отчистка коллекции 
                    dataGridView.Rows.Clear();// отчистка табл
                }
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            int count = dataGridView.Rows.Count;
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                int index = row.Index; // индекс выбранной строки
                if (index == count - 1) return;
                data.DeleteFile(index);
                dataGridView.Rows.RemoveAt(index);
            }
        }
        /// <summary>
        /// Режим правки для выбранной ячейки 
        /// </summary>
    
        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int indRow = dataGridView.Rows[e.RowIndex].Index;
            int indColumn = dataGridView.Columns[e.ColumnIndex].Index;
            object value = dataGridView.Rows[indRow].Cells[indColumn].Value;
            // Если значение не было введено, то оставляем старое
            if (value is null)
            {
                MessageBox.Show("Вы не ввели значение.");
                dataGridView.Rows[indRow].Cells[indColumn].Value = oldValue;
                return;
            }
            if (indColumn == 1)
            {
                data.ChangeManuf((string)value, indRow);
            }
            else
            if (indColumn == 2)
            {
                data.ChangeModel((string)value, indRow);
            }
            else
            if (indColumn == 3)
            {
                try
                {
                    data.ChangeYearRelease((ushort)Convert.ToInt32(value), indRow);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка: {exception.Message}");
                    dataGridView.Rows[indRow].Cells[indColumn].Value = oldValue;
                }
            }
            else
            if (indColumn == 4)
            {
                data.ChangeBody((string)value, indRow);
            }
        }

        /// <summary>
        /// Остановка режима правки для выбранной ячейки 
        /// </summary>
        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                oldValue = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            this.Text = filename + " - База данных авто";
            dataGridView.Rows.Clear();
            data.OpenFile(filename);
            WriteToDataGrid();
        }

        private void СоздатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((data.CarFiles.Count != 0) || (filename != ""))
            {
                DialogResult dialogResult = MessageBox.Show("Уверены," +
                    "что хотите создать новый файл?" + "\r\n" +
                    "Изменения в текущем не сохранятся!", "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                // После подтверждения делаем остановку всех таймеров
                if (dialogResult == DialogResult.Yes)
                {
                    this.Text = "База данных авто";
                    filename = "";
                    data.DeleteAll();
                    dataGridView.Rows.Clear();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Stop();
                    timer2.Enabled = false;
                }
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filename = saveFileDialog1.FileName;
                this.Text = filename + " - База данных авто";
            }
            // Если сохранение произошло первый раз, то запускаем 
            // таймер для автосохранения
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            // При каждом сохранении будет появляться надпись "Сохранение..."
            SaveLabel.Visible = true;
            timer2.Enabled = true;
            timer2.Start();

            data.SaveToFile(filename);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {

            if (AutoSaveLabel.Visible)
            {
                AutoSaveLabel.Visible = false;
            }
            else
            {
                SaveLabel.Visible = false;
            }
            timer2.Enabled = false;
            timer2.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
            data.SaveToFile(filename);
            AutoSaveLabel.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            ОткрытьToolStripMenuItem_Click(открытьToolStripMenuItem, null);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            string Info = "База данных авто" + "\n\n" +
                "Работал над программой Пичуев ДА" + "\n\n" +
                "Github:https://github.com/dimapichuev2000" + "\n\n" +
                "Дата релиза 15.05.2020, версия 2.0";
            MessageBox.Show(Info, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void WriteToDataGrid()
        {
            for (int i = 0; i < data.CarFiles.Count; i++)
            {
                CarFile car = (CarFile)data.CarFiles[i];
                dataGridView.Rows.Add(car.IDCar, car.ManufCar,
                    car.ModelCar, car.YearCar, car.BodyCar);
                BanChangeColumn(i);
            }
            // последнюю строку запрещаем редактировать
            dataGridView.Rows[data.CarFiles.Count].ReadOnly = true;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (data.CarFiles.Count != 0)
            {
                dataGridView.Rows.Clear();
                if (comboBoxChoiceSort.SelectedIndex == 0)
                {
                    data.Sort(SortDirection.Ascending);
                }
                else
                {
                    data.Sort(SortDirection.Descending);
                }
                WriteToDataGrid();
            }
        }

        private void ОпрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox3_Click(pictureBox3, null);
        }
    }
}
