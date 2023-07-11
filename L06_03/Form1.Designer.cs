namespace L06_03
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textColorTabPage = new System.Windows.Forms.TabPage();
            this.backColorTabPage = new System.Windows.Forms.TabPage();
            this.lblOut = new System.Windows.Forms.Label();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.grayRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.textColorTabPage.SuspendLayout();
            this.backColorTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.textColorTabPage);
            this.tabControl1.Controls.Add(this.backColorTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // textColorTabPage
            // 
            this.textColorTabPage.Controls.Add(this.redRadioButton);
            this.textColorTabPage.Controls.Add(this.blueRadioButton);
            this.textColorTabPage.Controls.Add(this.blackRadioButton);
            this.textColorTabPage.Location = new System.Drawing.Point(8, 39);
            this.textColorTabPage.Name = "textColorTabPage";
            this.textColorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.textColorTabPage.Size = new System.Drawing.Size(785, 53);
            this.textColorTabPage.TabIndex = 0;
            this.textColorTabPage.Text = "Text Color";
            this.textColorTabPage.UseVisualStyleBackColor = true;
            // 
            // backColorTabPage
            // 
            this.backColorTabPage.Controls.Add(this.whiteRadioButton);
            this.backColorTabPage.Controls.Add(this.grayRadioButton);
            this.backColorTabPage.Location = new System.Drawing.Point(8, 39);
            this.backColorTabPage.Name = "backColorTabPage";
            this.backColorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.backColorTabPage.Size = new System.Drawing.Size(785, 53);
            this.backColorTabPage.TabIndex = 1;
            this.backColorTabPage.Text = "Background Color";
            this.backColorTabPage.UseVisualStyleBackColor = true;
            // 
            // lblOut
            // 
            this.lblOut.BackColor = System.Drawing.Color.Gray;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(3, 95);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(798, 352);
            this.lblOut.TabIndex = 0;
            this.lblOut.Text = "A simple app using TabControl";
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Checked = true;
            this.blackRadioButton.Location = new System.Drawing.Point(6, 6);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(96, 29);
            this.blackRadioButton.TabIndex = 0;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Location = new System.Drawing.Point(155, 6);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(86, 29);
            this.blueRadioButton.TabIndex = 1;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(271, 6);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(82, 29);
            this.redRadioButton.TabIndex = 2;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            // 
            // grayRadioButton
            // 
            this.grayRadioButton.AutoSize = true;
            this.grayRadioButton.Checked = true;
            this.grayRadioButton.Location = new System.Drawing.Point(6, 6);
            this.grayRadioButton.Name = "grayRadioButton";
            this.grayRadioButton.Size = new System.Drawing.Size(89, 29);
            this.grayRadioButton.TabIndex = 0;
            this.grayRadioButton.TabStop = true;
            this.grayRadioButton.Text = "Gray";
            this.grayRadioButton.UseVisualStyleBackColor = true;
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.Location = new System.Drawing.Point(138, 6);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(98, 29);
            this.whiteRadioButton.TabIndex = 1;
            this.whiteRadioButton.TabStop = true;
            this.whiteRadioButton.Text = "White";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lesson 06 Solution 03";
            this.tabControl1.ResumeLayout(false);
            this.textColorTabPage.ResumeLayout(false);
            this.textColorTabPage.PerformLayout();
            this.backColorTabPage.ResumeLayout(false);
            this.backColorTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage textColorTabPage;
        private System.Windows.Forms.TabPage backColorTabPage;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton grayRadioButton;
    }
}

