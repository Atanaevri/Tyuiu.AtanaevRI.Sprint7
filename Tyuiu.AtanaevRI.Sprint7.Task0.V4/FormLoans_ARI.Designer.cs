namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    partial class FormLoans_ARI
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

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FormLoans_ARI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FormLoans_ARI";
            Text = "Выдача и возврат книг - ARI";
            Load += FormLoans_ARI_Load;
            ResumeLayout(false);
        }
    }
}