namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    partial class FormEditBook_ARI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditBook_ARI));
            panelEditBook_ARI = new Panel();
            textBoxAnnotation_ARI = new TextBox();
            labelAnnotation_ARI = new Label();
            checkBoxIsNewEdition_ARI = new CheckBox();
            numericUpDownPrice_ARI = new NumericUpDown();
            labelPrice_ARI = new Label();
            numericUpDownYear_ARI = new NumericUpDown();
            labelYear_ARI = new Label();
            textBoxTitle_ARI = new TextBox();
            labelTitle_ARI = new Label();
            textBoxAuthor_ARI = new TextBox();
            labelAuthor_ARI = new Label();
            numericUpDownId_ARI = new NumericUpDown();
            labelId_ARI = new Label();
            panelEditButtons_ARI = new Panel();
            buttonCancel_ARI = new Button();
            buttonSave_ARI = new Button();
            panelEditBook_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice_ARI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear_ARI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId_ARI).BeginInit();
            panelEditButtons_ARI.SuspendLayout();
            SuspendLayout();
            // 
            // panelEditBook_ARI
            // 
            panelEditBook_ARI.Controls.Add(textBoxAnnotation_ARI);
            panelEditBook_ARI.Controls.Add(labelAnnotation_ARI);
            panelEditBook_ARI.Controls.Add(checkBoxIsNewEdition_ARI);
            panelEditBook_ARI.Controls.Add(numericUpDownPrice_ARI);
            panelEditBook_ARI.Controls.Add(labelPrice_ARI);
            panelEditBook_ARI.Controls.Add(numericUpDownYear_ARI);
            panelEditBook_ARI.Controls.Add(labelYear_ARI);
            panelEditBook_ARI.Controls.Add(textBoxTitle_ARI);
            panelEditBook_ARI.Controls.Add(labelTitle_ARI);
            panelEditBook_ARI.Controls.Add(textBoxAuthor_ARI);
            panelEditBook_ARI.Controls.Add(labelAuthor_ARI);
            panelEditBook_ARI.Controls.Add(numericUpDownId_ARI);
            panelEditBook_ARI.Controls.Add(labelId_ARI);
            panelEditBook_ARI.Dock = DockStyle.Fill;
            panelEditBook_ARI.Location = new Point(0, 0);
            panelEditBook_ARI.Name = "panelEditBook_ARI";
            panelEditBook_ARI.Size = new Size(500, 400);
            panelEditBook_ARI.TabIndex = 0;
            // 
            // textBoxAnnotation_ARI
            // 
            textBoxAnnotation_ARI.Location = new Point(150, 250);
            textBoxAnnotation_ARI.Multiline = true;
            textBoxAnnotation_ARI.Name = "textBoxAnnotation_ARI";
            textBoxAnnotation_ARI.ScrollBars = ScrollBars.Vertical;
            textBoxAnnotation_ARI.Size = new Size(330, 100);
            textBoxAnnotation_ARI.TabIndex = 12;
            // 
            // labelAnnotation_ARI
            // 
            labelAnnotation_ARI.AutoSize = true;
            labelAnnotation_ARI.Location = new Point(20, 253);
            labelAnnotation_ARI.Name = "labelAnnotation_ARI";
            labelAnnotation_ARI.Size = new Size(124, 15);
            labelAnnotation_ARI.TabIndex = 11;
            labelAnnotation_ARI.Text = "Аннотация (опция):";
            // 
            // checkBoxIsNewEdition_ARI
            // 
            checkBoxIsNewEdition_ARI.AutoSize = true;
            checkBoxIsNewEdition_ARI.Location = new Point(150, 220);
            checkBoxIsNewEdition_ARI.Name = "checkBoxIsNewEdition_ARI";
            checkBoxIsNewEdition_ARI.Size = new Size(110, 19);
            checkBoxIsNewEdition_ARI.TabIndex = 10;
            checkBoxIsNewEdition_ARI.Text = "Новое издание";
            checkBoxIsNewEdition_ARI.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPrice_ARI
            // 
            numericUpDownPrice_ARI.DecimalPlaces = 2;
            numericUpDownPrice_ARI.Location = new Point(150, 190);
            numericUpDownPrice_ARI.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrice_ARI.Name = "numericUpDownPrice_ARI";
            numericUpDownPrice_ARI.Size = new Size(150, 23);
            numericUpDownPrice_ARI.TabIndex = 9;
            // 
            // labelPrice_ARI
            // 
            labelPrice_ARI.AutoSize = true;
            labelPrice_ARI.Location = new Point(20, 193);
            labelPrice_ARI.Name = "labelPrice_ARI";
            labelPrice_ARI.Size = new Size(38, 15);
            labelPrice_ARI.TabIndex = 8;
            labelPrice_ARI.Text = "Цена:";
            // 
            // numericUpDownYear_ARI
            // 
            numericUpDownYear_ARI.Location = new Point(150, 160);
            numericUpDownYear_ARI.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDownYear_ARI.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownYear_ARI.Name = "numericUpDownYear_ARI";
            numericUpDownYear_ARI.Size = new Size(150, 23);
            numericUpDownYear_ARI.TabIndex = 7;
            numericUpDownYear_ARI.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // labelYear_ARI
            // 
            labelYear_ARI.AutoSize = true;
            labelYear_ARI.Location = new Point(20, 163);
            labelYear_ARI.Name = "labelYear_ARI";
            labelYear_ARI.Size = new Size(113, 15);
            labelYear_ARI.TabIndex = 6;
            labelYear_ARI.Text = "Год издания (гггг):";
            // 
            // textBoxTitle_ARI
            // 
            textBoxTitle_ARI.Location = new Point(150, 100);
            textBoxTitle_ARI.Multiline = true;
            textBoxTitle_ARI.Name = "textBoxTitle_ARI";
            textBoxTitle_ARI.Size = new Size(330, 50);
            textBoxTitle_ARI.TabIndex = 5;
            // 
            // labelTitle_ARI
            // 
            labelTitle_ARI.AutoSize = true;
            labelTitle_ARI.Location = new Point(20, 103);
            labelTitle_ARI.Name = "labelTitle_ARI";
            labelTitle_ARI.Size = new Size(65, 15);
            labelTitle_ARI.TabIndex = 4;
            labelTitle_ARI.Text = "Название:";
            // 
            // textBoxAuthor_ARI
            // 
            textBoxAuthor_ARI.Location = new Point(150, 70);
            textBoxAuthor_ARI.Name = "textBoxAuthor_ARI";
            textBoxAuthor_ARI.Size = new Size(330, 23);
            textBoxAuthor_ARI.TabIndex = 3;
            // 
            // labelAuthor_ARI
            // 
            labelAuthor_ARI.AutoSize = true;
            labelAuthor_ARI.Location = new Point(20, 73);
            labelAuthor_ARI.Name = "labelAuthor_ARI";
            labelAuthor_ARI.Size = new Size(43, 15);
            labelAuthor_ARI.TabIndex = 2;
            labelAuthor_ARI.Text = "Автор:";
            // 
            // numericUpDownId_ARI
            // 
            numericUpDownId_ARI.Location = new Point(150, 40);
            numericUpDownId_ARI.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownId_ARI.Name = "numericUpDownId_ARI";
            numericUpDownId_ARI.Size = new Size(150, 23);
            numericUpDownId_ARI.TabIndex = 1;
            // 
            // labelId_ARI
            // 
            labelId_ARI.AutoSize = true;
            labelId_ARI.Location = new Point(20, 43);
            labelId_ARI.Name = "labelId_ARI";
            labelId_ARI.Size = new Size(68, 15);
            labelId_ARI.TabIndex = 0;
            labelId_ARI.Text = "ID (номер):";
            // 
            // panelEditButtons_ARI
            // 
            panelEditButtons_ARI.Controls.Add(buttonCancel_ARI);
            panelEditButtons_ARI.Controls.Add(buttonSave_ARI);
            panelEditButtons_ARI.Dock = DockStyle.Bottom;
            panelEditButtons_ARI.Location = new Point(0, 400);
            panelEditButtons_ARI.Name = "panelEditButtons_ARI";
            panelEditButtons_ARI.Size = new Size(500, 50);
            panelEditButtons_ARI.TabIndex = 1;
            // 
            // buttonCancel_ARI
            // 
            buttonCancel_ARI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel_ARI.DialogResult = DialogResult.Cancel;
            buttonCancel_ARI.Image = (Image)resources.GetObject("buttonCancel_ARI.Image");
            buttonCancel_ARI.Location = new Point(260, 8);
            buttonCancel_ARI.Name = "buttonCancel_ARI";
            buttonCancel_ARI.Size = new Size(100, 35);
            buttonCancel_ARI.TabIndex = 1;
            buttonCancel_ARI.Text = "Отмена";
            buttonCancel_ARI.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancel_ARI.UseVisualStyleBackColor = true;
            buttonCancel_ARI.Click += ButtonCancel_ARI_Click;
            // 
            // buttonSave_ARI
            // 
            buttonSave_ARI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave_ARI.Image = (Image)resources.GetObject("buttonSave_ARI.Image");
            buttonSave_ARI.Location = new Point(380, 8);
            buttonSave_ARI.Name = "buttonSave_ARI";
            buttonSave_ARI.Size = new Size(100, 35);
            buttonSave_ARI.TabIndex = 0;
            buttonSave_ARI.Text = "Сохранить";
            buttonSave_ARI.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSave_ARI.UseVisualStyleBackColor = true;
            buttonSave_ARI.Click += ButtonSave_ARI_Click;
            // 
            // FormEditBook_ARI
            // 
            AcceptButton = buttonSave_ARI;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel_ARI;
            ClientSize = new Size(500, 450);
            Controls.Add(panelEditBook_ARI);
            Controls.Add(panelEditButtons_ARI);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditBook_ARI";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление новой книги - ARI";
            Load += FormEditBook_ARI_Load;
            panelEditBook_ARI.ResumeLayout(false);
            panelEditBook_ARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice_ARI).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear_ARI).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId_ARI).EndInit();
            panelEditButtons_ARI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEditBook_ARI;
        private Panel panelEditButtons_ARI;
        private Button buttonSave_ARI;
        private Button buttonCancel_ARI;
        private TextBox textBoxAnnotation_ARI;
        private Label labelAnnotation_ARI;
        private CheckBox checkBoxIsNewEdition_ARI;
        private NumericUpDown numericUpDownPrice_ARI;
        private Label labelPrice_ARI;
        private NumericUpDown numericUpDownYear_ARI;
        private Label labelYear_ARI;
        private TextBox textBoxTitle_ARI;
        private Label labelTitle_ARI;
        private TextBox textBoxAuthor_ARI;
        private Label labelAuthor_ARI;
        private NumericUpDown numericUpDownId_ARI;
        private Label labelId_ARI;
    }
}