namespace CalculateControlDigit
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.enterNumberTxtBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterNumberTxtBox
            // 
            this.enterNumberTxtBox.Location = new System.Drawing.Point(42, 34);
            this.enterNumberTxtBox.Name = "enterNumberTxtBox";
            this.enterNumberTxtBox.Size = new System.Drawing.Size(100, 20);
            this.enterNumberTxtBox.TabIndex = 0;
            this.enterNumberTxtBox.TextChanged += new System.EventHandler(this.enterNumberTxtBox_TextChanged);
            this.enterNumberTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterNumberTxtBox_KeyDown);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(42, 77);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn.TabIndex = 1;
            this.calculateBtn.Text = "Изчисли";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.ForeColor = System.Drawing.Color.Red;
            this.resultLabel.Location = new System.Drawing.Point(0, 119);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(192, 42);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 161);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.enterNumberTxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterNumberTxtBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label resultLabel;
    }
}

