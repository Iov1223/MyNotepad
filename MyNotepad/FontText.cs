using System.Windows.Forms;
using System.Drawing;
using System;

namespace MyNotepad
{
    internal class FontText
    {
        //private ComboBox refTextStyle = new ComboBox();
        //private ComboBox refTextOutline = new ComboBox();
        //private ComboBox refTextSize = new ComboBox();
        //private ComboBox refTextColor = new ComboBox();
        //MyForm _myForm = new MyForm();

        //private Control[] CreateElements()
        //{
        //    Control[] elements = new Control[5];
        //    ComboBox comboBoxStyle = new ComboBox();
        //    comboBoxStyle.Text = "Шрифт";
        //    comboBoxStyle.Items.Add("Arial");
        //    comboBoxStyle.Items.Add("Times New Roman");
        //    comboBoxStyle.Items.Add("Comic Sans MS");
        //    refTextStyle = comboBoxStyle;
        //    comboBoxStyle.SelectedIndexChanged += comboStyle_SelectedIndexChanged;
        //    elements[0] = comboBoxStyle;

        //    ComboBox comboBoxOutline = new ComboBox();
        //    comboBoxOutline.Text = "Начертание";
        //    comboBoxOutline.Items.Add("обычный");
        //    comboBoxOutline.Items.Add("наклонный");
        //    comboBoxOutline.Items.Add("полужирный");
        //    comboBoxOutline.Items.Add("перечёркнутый");
        //    refTextOutline = comboBoxOutline;
        //    comboBoxOutline.SelectedIndexChanged += comboOutline_SelectedIndexChanged;
        //    elements[1] = comboBoxOutline;

        //    ComboBox comboBoxSise = new ComboBox();
        //    comboBoxSise.Text = "Размер";
        //    comboBoxSise.Items.Add("8");
        //    comboBoxSise.Items.Add("9");
        //    comboBoxSise.Items.Add("10");
        //    comboBoxSise.Items.Add("11");
        //    comboBoxSise.Items.Add("12");
        //    refTextSize = comboBoxSise;
        //    comboBoxSise.SelectedIndexChanged += comboBoxSize_SelectedIndexChanged;
        //    elements[2] = comboBoxSise;

        //    ComboBox comboBoxColor = new ComboBox();
        //    comboBoxColor.Text = "Цвет";
        //    comboBoxColor.Items.Add("Красный");
        //    comboBoxColor.Items.Add("Зелёный");
        //    comboBoxColor.Items.Add("Синий");
        //    comboBoxColor.Items.Add("Чёрный");
        //    refTextColor = comboBoxColor;
        //    comboBoxColor.SelectedValueChanged += _myForm.comboBoxColor_SelectedValueChanged;
        //    elements[3] = comboBoxColor;

        //    Button buttonTime = new Button();
        //    buttonTime.Text = "Вставить время";
        //    buttonTime.Size = new Size(122, 22);
        //    buttonTime.MouseClick += buttonTime_MouseClick_1;
        //    elements[4] = buttonTime;

        //    return elements;
        //}
        //public void GetComboBoxes(out ComboBox Color)
        //{
        //    Color = refTextColor; 
        //}
        //public void AddElement()
        //{
        //    Form formFormatText = new Form();
        //    Control[] elements = CreateElements();
        //    formFormatText.Text = "Окно форматирования";

        //    Point locationS = elements[0].Location;
        //    formFormatText.Controls.Add(elements[0]);
        //    locationS.X = 5;
        //    locationS.Y = 5;
        //    elements[0].Location = locationS;

        //    Point locationO = elements[1].Location;
        //    formFormatText.Controls.Add(elements[1]);
        //    locationO.X = 5;
        //    locationO.Y = 50;
        //    elements[1].Location = locationO;

        //    Point locationB = elements[2].Location;
        //    formFormatText.Controls.Add(elements[2]);
        //    locationB.X = 5;
        //    locationB.Y = 95;
        //    elements[2].Location = locationB;

        //    Point locationC = elements[3].Location;
        //    formFormatText.Controls.Add(elements[3]);
        //    locationC.X = 5;
        //    locationC.Y = 140;
        //    elements[3].Location = locationC;

        //    Point locationT = elements[4].Location;
        //    formFormatText.Controls.Add(elements[4]);
        //    locationT.X = 5;
        //    locationT.Y = 185;
        //    elements[4].Location = locationT;

        //    Size min, max;
        //    SetSizeForm(out min, out max);
        //    formFormatText.MaximumSize = min;
        //    formFormatText.MinimumSize = max;
        //    formFormatText.Show();
        //}
        //private void SetSizeForm(out Size min, out Size max)
        //{
        //    var MSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
        //    Form formFormatText = new Form();
        //    formFormatText.MaximumSize = new Size(MSize.Width / 6, MSize.Height / 3);
        //    formFormatText.MinimumSize = new Size(MSize.Width / 6, MSize.Height / 3);
        //    min = formFormatText.MinimumSize;
        //    max = formFormatText.MaximumSize;
        //}

        //private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (refTextColor.SelectedItem.ToString())
        //    {
        //        case "Красный":
        //            _myForm.richTextBoxContent.SelectionColor = Color.Red;
        //            break;
        //        case "Зелёный":
        //            _myForm.richTextBoxContent.SelectionColor = Color.Green;
        //            break;
        //        case "Синий":
        //            _myForm.richTextBoxContent.SelectionColor = Color.Blue;
        //            break;
        //        case "Чёрный":
        //            _myForm.richTextBoxContent.SelectionColor = Color.Black;
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void comboStyle_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    var _sizeFont = _myForm.richTextBoxContent.SelectionFont.Size;
        //    switch (refTextStyle.SelectedItem.ToString())
        //    {
        //        case "Arial":
        //            _myForm.richTextBoxContent.SelectionFont = new Font("Arial", _sizeFont);
        //            break;
        //        case "Times New Roman":
        //            _myForm.richTextBoxContent.SelectionFont = new Font("Times New Roman", _sizeFont);
        //            break;
        //        case "Comic Sans MS":
        //            _myForm.richTextBoxContent.SelectionFont = new Font("Comic Sans MS", _sizeFont);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void comboOutline_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    switch (refTextOutline.SelectedItem.ToString())
        //    {
        //        case "обычный":
        //            _myForm.richTextBoxContent.SelectionFont = new Font(_myForm.richTextBoxContent.SelectionFont, FontStyle.Regular);
        //            break;
        //        case "наклонный":
        //            _myForm.richTextBoxContent.SelectionFont = new Font(_myForm.richTextBoxContent.SelectionFont, FontStyle.Italic);
        //            break;
        //        case "полужирный":
        //            _myForm.richTextBoxContent.SelectionFont = new Font(_myForm.richTextBoxContent.SelectionFont, FontStyle.Bold);
        //            break;
        //        case "перечёркнутый":
        //            _myForm.richTextBoxContent.SelectionFont = new Font(_myForm.richTextBoxContent.SelectionFont, FontStyle.Strikeout);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void comboBoxSize_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    var _styleFont = _myForm.richTextBoxContent.SelectionFont.FontFamily;
        //    switch (refTextSize.SelectedItem.ToString())
        //    {
        //        case "8":
        //            _myForm.richTextBoxContent.SelectionFont = new Font(_styleFont, 8);
        //            break;
        //        case "9":
        //            _myForm.richTextBoxContent.SelectionFont = new Font(_styleFont, 9);
        //            break;
        //        case "10":
        //            _myForm.richTextBoxContent.SelectionFont = new Font(_styleFont, 10);
        //            break;
        //        case "11":
        //            _myForm.richTextBoxContent.SelectionFont = new Font(_styleFont, 11);
        //            break;
        //        case "12":
        //            _myForm.richTextBoxContent.SelectionFont = new Font(_styleFont, 12);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void buttonTime_MouseClick_1(object sender, MouseEventArgs e)
        //{
        //    DateTime dt = DateTime.Now;
        //    string time = dt.ToString("dd.MM.yyyy HH:mm:ss");
        //    _myForm.richTextBoxContent.SelectedText = time;
        //}
    }
}
