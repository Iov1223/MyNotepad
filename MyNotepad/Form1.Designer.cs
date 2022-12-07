namespace MyNotepad
{
    partial class MyForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboStyle = new System.Windows.Forms.ComboBox();
            this.comboOutline = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.buttonTime = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxContent.Location = new System.Drawing.Point(0, 28);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(800, 422);
            this.richTextBoxContent.TabIndex = 0;
            this.richTextBoxContent.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenКакToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // OpenКакToolStripMenuItem
            // 
            this.OpenКакToolStripMenuItem.Name = "OpenКакToolStripMenuItem";
            this.OpenКакToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.OpenКакToolStripMenuItem.Text = "Открыть";
            this.OpenКакToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem1
            // 
            this.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1";
            this.SaveAsToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.SaveAsToolStripMenuItem1.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem1.Click += new System.EventHandler(this.SaveAsToolStripMenuItem1_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.InsertToolStripMenuItem,
            this.CutToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // InsertToolStripMenuItem
            // 
            this.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem";
            this.InsertToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.InsertToolStripMenuItem.Text = "Вставить";
            this.InsertToolStripMenuItem.Click += new System.EventHandler(this.InsertToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.FontToolStripMenuItem.Text = "Шрифт";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Красный ",
            "Зелёный",
            "Синий",
            "Чёрный"});
            this.comboBoxColor.Location = new System.Drawing.Point(8, 38);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxColor.TabIndex = 2;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // comboStyle
            // 
            this.comboStyle.FormattingEnabled = true;
            this.comboStyle.Location = new System.Drawing.Point(58, 123);
            this.comboStyle.Name = "comboStyle";
            this.comboStyle.Size = new System.Drawing.Size(121, 24);
            this.comboStyle.TabIndex = 3;
            this.comboStyle.SelectedIndexChanged += new System.EventHandler(this.comboStyle_SelectedIndexChanged_1);
            // 
            // comboOutline
            // 
            this.comboOutline.FormattingEnabled = true;
            this.comboOutline.Location = new System.Drawing.Point(214, 241);
            this.comboOutline.Name = "comboOutline";
            this.comboOutline.Size = new System.Drawing.Size(121, 24);
            this.comboOutline.TabIndex = 4;
            this.comboOutline.SelectedIndexChanged += new System.EventHandler(this.comboOutline_SelectedIndexChanged_1);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(532, 307);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSize.TabIndex = 5;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged_1);
            // 
            // buttonTime
            // 
            this.buttonTime.Location = new System.Drawing.Point(532, 241);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(75, 23);
            this.buttonTime.TabIndex = 6;
            this.buttonTime.Text = "button1";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTime_MouseClick_1);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboOutline);
            this.Controls.Add(this.comboStyle);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyForm";
            this.Text = "MyNotepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboStyle;
        private System.Windows.Forms.ComboBox comboOutline;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Button buttonTime;
    }
}

