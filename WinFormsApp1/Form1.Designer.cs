namespace WinFormsApp1
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
            panel1 = new Panel();
            CalculateButton = new Button();
            matrixComboBox = new ComboBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 330);
            panel1.TabIndex = 0;
            // 
            // CalculateButton
            // 
            CalculateButton.Dock = DockStyle.Left;
            CalculateButton.Location = new Point(0, 330);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(92, 31);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Рассчитать";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // matrixComboBox
            // 
            matrixComboBox.Dock = DockStyle.Right;
            matrixComboBox.FormattingEnabled = true;
            matrixComboBox.Location = new Point(343, 330);
            matrixComboBox.Name = "matrixComboBox";
            matrixComboBox.Size = new Size(121, 23);
            matrixComboBox.TabIndex = 2;
            matrixComboBox.SelectedIndexChanged += matrixComboBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 361);
            Controls.Add(matrixComboBox);
            Controls.Add(CalculateButton);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CalculateButton;
        private ComboBox matrixComboBox;
    }
}