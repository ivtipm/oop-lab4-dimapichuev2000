namespace DBase
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрогаммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManufLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.BodyLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufTextBox = new System.Windows.Forms.TextBox();
            this.BodyTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelAllButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.comboBoxChoiceSort = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manuf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.AutoSaveLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.файлToolStripMenuItem.Text = "Файл ";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.ФайлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.открытьToolStripMenuItem.Text = "Открыть ";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.создатьToolStripMenuItem.Text = "Создать ";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.СоздатьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить     ";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрогаммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.справкаToolStripMenuItem.Text = "О программе ";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.ОпрограммеToolStripMenuItem_Click);
            // 
            // оПрогаммеToolStripMenuItem
            // 
            this.оПрогаммеToolStripMenuItem.Name = "оПрогаммеToolStripMenuItem";
            this.оПрогаммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрогаммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрогаммеToolStripMenuItem_Click);
            // 
            // ManufLabel
            // 
            this.ManufLabel.AutoSize = true;
            this.ManufLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ManufLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufLabel.ForeColor = System.Drawing.Color.White;
            this.ManufLabel.Location = new System.Drawing.Point(21, 87);
            this.ManufLabel.Name = "ManufLabel";
            this.ManufLabel.Size = new System.Drawing.Size(184, 21);
            this.ManufLabel.TabIndex = 1;
            this.ManufLabel.Text = "Страна производителя: ";
            this.ManufLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YearLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.ForeColor = System.Drawing.Color.White;
            this.YearLabel.Location = new System.Drawing.Point(345, 88);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(108, 21);
            this.YearLabel.TabIndex = 2;
            this.YearLabel.Text = "Год выпуска: ";
            // 
            // BodyLabel
            // 
            this.BodyLabel.AutoSize = true;
            this.BodyLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BodyLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyLabel.ForeColor = System.Drawing.Color.White;
            this.BodyLabel.Location = new System.Drawing.Point(345, 138);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(61, 21);
            this.BodyLabel.TabIndex = 3;
            this.BodyLabel.Text = "Кузов: ";
            this.BodyLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ModelLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.ForeColor = System.Drawing.Color.White;
            this.ModelLabel.Location = new System.Drawing.Point(21, 137);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(67, 21);
            this.ModelLabel.TabIndex = 4;
            this.ModelLabel.Text = "Марка: ";
            // 
            // ManufTextBox
            // 
            this.ManufTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufTextBox.Location = new System.Drawing.Point(211, 87);
            this.ManufTextBox.Name = "ManufTextBox";
            this.ManufTextBox.Size = new System.Drawing.Size(100, 22);
            this.ManufTextBox.TabIndex = 5;
            // 
            // BodyTextBox
            // 
            this.BodyTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyTextBox.Location = new System.Drawing.Point(459, 138);
            this.BodyTextBox.Name = "BodyTextBox";
            this.BodyTextBox.Size = new System.Drawing.Size(100, 22);
            this.BodyTextBox.TabIndex = 6;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearTextBox.Location = new System.Drawing.Point(459, 88);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 22);
            this.YearTextBox.TabIndex = 7;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTextBox.Location = new System.Drawing.Point(211, 137);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(100, 22);
            this.ModelTextBox.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(594, 98);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(158, 48);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить запись";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelAllButton
            // 
            this.DelAllButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DelAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelAllButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelAllButton.ForeColor = System.Drawing.Color.White;
            this.DelAllButton.Location = new System.Drawing.Point(594, 200);
            this.DelAllButton.Name = "DelAllButton";
            this.DelAllButton.Size = new System.Drawing.Size(158, 32);
            this.DelAllButton.TabIndex = 10;
            this.DelAllButton.Text = "Удалить всё";
            this.DelAllButton.UseVisualStyleBackColor = false;
            this.DelAllButton.Click += new System.EventHandler(this.DelAllButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButton.ForeColor = System.Drawing.Color.White;
            this.DelButton.Location = new System.Drawing.Point(594, 162);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(158, 32);
            this.DelButton.TabIndex = 11;
            this.DelButton.Text = "Удалить запись";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SortButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.ForeColor = System.Drawing.Color.White;
            this.SortButton.Location = new System.Drawing.Point(25, 187);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(158, 30);
            this.SortButton.TabIndex = 12;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // comboBoxChoiceSort
            // 
            this.comboBoxChoiceSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiceSort.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChoiceSort.FormattingEnabled = true;
            this.comboBoxChoiceSort.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.comboBoxChoiceSort.Location = new System.Drawing.Point(211, 191);
            this.comboBoxChoiceSort.Name = "comboBoxChoiceSort";
            this.comboBoxChoiceSort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxChoiceSort.TabIndex = 25;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Manuf,
            this.model,
            this.body,
            this.Year});
            this.dataGridView.Location = new System.Drawing.Point(25, 237);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(561, 235);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_CellBeginEdit);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Manuf
            // 
            this.Manuf.HeaderText = "Страна производитель ";
            this.Manuf.Name = "Manuf";
            this.Manuf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // model
            // 
            this.model.HeaderText = "Марка";
            this.model.Name = "model";
            this.model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // body
            // 
            this.body.HeaderText = "Кузов ";
            this.body.Name = "body";
            this.body.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год выпуска";
            this.Year.Name = "Year";
            this.Year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(594, 256);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(158, 32);
            this.SearchButton.TabIndex = 27;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(594, 316);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(160, 22);
            this.SearchTextBox.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(99, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 27);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(62, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 27);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // SaveLabel
            // 
            this.SaveLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveLabel.ForeColor = System.Drawing.Color.White;
            this.SaveLabel.Location = new System.Drawing.Point(656, 36);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(96, 17);
            this.SaveLabel.TabIndex = 34;
            this.SaveLabel.Text = "Сохранение...";
            this.SaveLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // AutoSaveLabel
            // 
            this.AutoSaveLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AutoSaveLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoSaveLabel.ForeColor = System.Drawing.Color.White;
            this.AutoSaveLabel.Location = new System.Drawing.Point(640, 36);
            this.AutoSaveLabel.Name = "AutoSaveLabel";
            this.AutoSaveLabel.Size = new System.Drawing.Size(112, 17);
            this.AutoSaveLabel.TabIndex = 35;
            this.AutoSaveLabel.Text = "Автосохранение...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(764, 484);
            this.Controls.Add(this.AutoSaveLabel);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.comboBoxChoiceSort);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.DelAllButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.BodyTextBox);
            this.Controls.Add(this.ManufTextBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BodyLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.ManufLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "База данных авто";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label ManufLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label BodyLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ManufTextBox;
        private System.Windows.Forms.TextBox BodyTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelAllButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.ComboBox comboBoxChoiceSort;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manuf;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn body;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem оПрогаммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Label AutoSaveLabel;
    }
}

