using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyNotepad
{
    public partial class MyForm : Form
    {
        private ComboBox refTextStyle = new ComboBox();
        private ComboBox refTextOutline = new ComboBox();
        private ComboBox refTextSize = new ComboBox();
        private ComboBox refTextColor = new ComboBox();
       

        private Control[] CreateElements()
        {
            Control[] elements = new Control[5];
            ComboBox comboBoxStyle = new ComboBox();
            comboBoxStyle.Text = "Шрифт";
            comboBoxStyle.Items.Add("Arial");
            comboBoxStyle.Items.Add("Times New Roman");
            comboBoxStyle.Items.Add("Comic Sans MS");
            refTextStyle = comboBoxStyle;
            comboBoxStyle.SelectedIndexChanged += comboStyle_SelectedIndexChanged_1;
            elements[0] = comboBoxStyle;

            ComboBox comboBoxOutline = new ComboBox();
            comboBoxOutline.Text = "Начертание";
            comboBoxOutline.Items.Add("обычный");
            comboBoxOutline.Items.Add("наклонный");
            comboBoxOutline.Items.Add("полужирный");
            comboBoxOutline.Items.Add("перечёркнутый");
            refTextOutline = comboBoxOutline;
            comboBoxOutline.SelectedIndexChanged += comboOutline_SelectedIndexChanged_1;
            elements[1] = comboBoxOutline;

            ComboBox comboBoxSise = new ComboBox();
            comboBoxSise.Text = "Размер";
            comboBoxSise.Items.Add("8");
            comboBoxSise.Items.Add("9");
            comboBoxSise.Items.Add("10");
            comboBoxSise.Items.Add("11");
            comboBoxSise.Items.Add("12");
            refTextSize = comboBoxSise;
            comboBoxSise.SelectedIndexChanged += comboBoxSize_SelectedIndexChanged_1;
            elements[2] = comboBoxSise;

            ComboBox comboBoxColor = new ComboBox();
            comboBoxColor.Text = "Цвет";
            comboBoxColor.Items.Add("Красный");
            comboBoxColor.Items.Add("Зелёный");
            comboBoxColor.Items.Add("Синий");
            comboBoxColor.Items.Add("Чёрный");
            refTextColor = comboBoxColor;
            comboBoxColor.SelectedIndexChanged += comboBoxColor_SelectedIndexChanged;
            elements[3] = comboBoxColor;

            Button buttonTime = new Button();
            buttonTime.Text = "Вставить время";
            buttonTime.Size = new Size(122, 22);
            buttonTime.MouseClick += buttonTime_MouseClick_1;
            elements[4] = buttonTime;

            return elements;
        }
        public void GetComboBoxes(out ComboBox Color)
        {
            Color = refTextColor;
        }
        public void AddElement()
        {
            Form formFormatText = new Form();
            Control[] elements = CreateElements();
            formFormatText.Text = "Окно форматирования";

            Point locationS = elements[0].Location;
            formFormatText.Controls.Add(elements[0]);
            locationS.X = 5;
            locationS.Y = 5;
            elements[0].Location = locationS;

            Point locationO = elements[1].Location;
            formFormatText.Controls.Add(elements[1]);
            locationO.X = 5;
            locationO.Y = 50;
            elements[1].Location = locationO;

            Point locationB = elements[2].Location;
            formFormatText.Controls.Add(elements[2]);
            locationB.X = 5;
            locationB.Y = 95;
            elements[2].Location = locationB;

            Point locationC = elements[3].Location;
            formFormatText.Controls.Add(elements[3]);
            locationC.X = 5;
            locationC.Y = 140;
            elements[3].Location = locationC;

            Point locationT = elements[4].Location;
            formFormatText.Controls.Add(elements[4]);
            locationT.X = 5;
            locationT.Y = 185;
            elements[4].Location = locationT;

            Size min, max;
            SetSizeForm(out min, out max);
            formFormatText.MaximumSize = min;
            formFormatText.MinimumSize = max;
            formFormatText.Show();
        }
        private void SetSizeForm(out Size min, out Size max)
        {
            var MSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            Form formFormatText = new Form();
            formFormatText.MaximumSize = new Size(MSize.Width / 6, MSize.Height / 3);
            formFormatText.MinimumSize = new Size(MSize.Width / 6, MSize.Height / 3);
            min = formFormatText.MinimumSize;
            max = formFormatText.MaximumSize;
        }
        private string CurrentDoc;
        public MyForm()
        {
            InitializeComponent();

        }
        
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentDoc = FileIO.SaveAs();
                this.Text = "MyNotepad - " + CurrentDoc;
                richTextBoxContent.SaveFile(CurrentDoc);
            }
            catch 
            {
                MessageBox.Show("Не удалось создать файл!");
            }

        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentDoc = FileIO.Browse();
                richTextBoxContent.LoadFile(CurrentDoc);
                this.Text = "MyNotepad - " + CurrentDoc;
                var doc = new FileIO(CurrentDoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Text != "MyNotepad - " + CurrentDoc)
                {
                    CurrentDoc = FileIO.SaveAs();
                    this.Text = "MyNotepad - " + CurrentDoc;
                    richTextBoxContent.SaveFile(CurrentDoc);
                }
                else
                {
                    richTextBoxContent.SaveFile(CurrentDoc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentDoc = FileIO.SaveAs();
                this.Text = "MyNotepad - " + CurrentDoc;
                richTextBoxContent.SaveFile(CurrentDoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBoxContent.SelectedText);
        }

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxContent.SelectedText = Clipboard.GetText();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxContent.Cut();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddElement();
        }
        
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (refTextColor.SelectedItem.ToString())
            {
                case "Красный":
                    richTextBoxContent.SelectionColor = Color.Red;
                    break;
                case "Зелёный":
                    richTextBoxContent.SelectionColor = Color.Green;
                    break;
                case "Синий":
                    richTextBoxContent.SelectionColor = Color.Blue;
                    break;
                case "Чёрный":
                    richTextBoxContent.SelectionColor = Color.Black;
                    break;
                default:
                    break;
            }
        }

        private void comboStyle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var _sizeFont = richTextBoxContent.SelectionFont.Size;
            switch (refTextStyle.SelectedItem.ToString())
            {
                case "Arial":
                    richTextBoxContent.SelectionFont = new Font("Arial", _sizeFont);
                    break;
                case "Times New Roman":
                    richTextBoxContent.SelectionFont = new Font("Times New Roman", _sizeFont);
                    break;
                case "Comic Sans MS":
                    richTextBoxContent.SelectionFont = new Font("Comic Sans MS", _sizeFont);
                    break;
                default:
                    break;
            }
        }

        private void comboOutline_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (refTextOutline.SelectedItem.ToString())
            {
                case "обычный":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.SelectionFont, FontStyle.Regular);
                    break;
                case "наклонный":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.SelectionFont, FontStyle.Italic);
                    break;
                case "полужирный":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.SelectionFont, FontStyle.Bold);
                    break;
                case "перечёркнутый":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.SelectionFont, FontStyle.Strikeout);
                    break;
                default:
                    break;
            }
        }

        private void comboBoxSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var _styleFont = richTextBoxContent.SelectionFont.FontFamily;
            switch (refTextSize.SelectedItem.ToString())
            {
                case "8":
                    richTextBoxContent.SelectionFont = new Font(_styleFont, 8);
                    break;
                case "9":
                    richTextBoxContent.SelectionFont = new Font(_styleFont, 9);
                    break;
                case "10":
                    richTextBoxContent.SelectionFont = new Font(_styleFont, 10);
                    break;
                case "11":
                    richTextBoxContent.SelectionFont = new Font(_styleFont, 11);
                    break;
                case "12":
                    richTextBoxContent.SelectionFont = new Font(_styleFont, 12);
                    break;
                default:
                    break;
            }
        }

        private void buttonTime_MouseClick_1(object sender, MouseEventArgs e)
        {
            DateTime dt = DateTime.Now;
            string time = dt.ToString("dd.MM.yyyy HH:mm:ss");
            richTextBoxContent.SelectedText = time;
        }
    }
}
