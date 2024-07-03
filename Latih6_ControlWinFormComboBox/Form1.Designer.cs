namespace Latih6_ControlWinFormComboBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbManual = new ComboBox();
            cmbBinding = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbManual
            // 
            cmbManual.FormattingEnabled = true;
            cmbManual.Location = new Point(157, 175);
            cmbManual.Name = "cmbManual";
            cmbManual.Size = new Size(182, 33);
            cmbManual.TabIndex = 0;
            // 
            // cmbBinding
            // 
            cmbBinding.FormattingEnabled = true;
            cmbBinding.Location = new Point(430, 175);
            cmbBinding.Name = "cmbBinding";
            cmbBinding.Size = new Size(182, 33);
            cmbBinding.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 147);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 2;
            label1.Text = "Cara Manual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 147);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 3;
            label2.Text = "Cara Binding";
            // 
            // button1
            // 
            button1.Location = new Point(212, 276);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Delete Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbBinding);
            Controls.Add(cmbManual);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbManual;
        private ComboBox cmbBinding;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
