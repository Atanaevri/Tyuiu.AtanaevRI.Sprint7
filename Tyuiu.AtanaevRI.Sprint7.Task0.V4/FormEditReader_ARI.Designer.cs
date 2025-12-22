namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    partial class FormEditReader_ARI
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxCardNumber;
        private TextBox textBoxFullName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelCardNumber;
        private Label labelFullName;
        private Label labelAddress;
        private Label labelPhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxCardNumber = new TextBox();
            textBoxFullName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhone = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            labelCardNumber = new Label();
            labelFullName = new Label();
            labelAddress = new Label();
            labelPhone = new Label();
            SuspendLayout();
            // 
            // textBoxCardNumber
            // 
            textBoxCardNumber.Location = new Point(137, 23);
            textBoxCardNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxCardNumber.Name = "textBoxCardNumber";
            textBoxCardNumber.Size = new Size(228, 27);
            textBoxCardNumber.TabIndex = 1;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(137, 76);
            textBoxFullName.Margin = new Padding(3, 4, 3, 4);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(342, 27);
            textBoxFullName.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(137, 129);
            textBoxAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(342, 27);
            textBoxAddress.TabIndex = 3;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(137, 183);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(228, 27);
            textBoxPhone.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(297, 240);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(86, 40);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(394, 240);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 40);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // labelCardNumber
            // 
            labelCardNumber.AutoSize = true;
            labelCardNumber.Location = new Point(23, 27);
            labelCardNumber.Name = "labelCardNumber";
            labelCardNumber.Size = new Size(112, 20);
            labelCardNumber.TabIndex = 0;
            labelCardNumber.Text = "Номер билета:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(23, 80);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(45, 20);
            labelFullName.TabIndex = 2;
            labelFullName.Text = "ФИО:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(23, 133);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(54, 20);
            labelAddress.TabIndex = 4;
            labelAddress.Text = "Адрес:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(23, 187);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(72, 20);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Телефон:";
            // 
            // FormEditReader_ARI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 307);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(textBoxFullName);
            Controls.Add(labelFullName);
            Controls.Add(textBoxCardNumber);
            Controls.Add(labelCardNumber);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditReader_ARI";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование читателя";
            Load += FormEditReader_ARI_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}