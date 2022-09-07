namespace _3._9_Objekt
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
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.tbxY = new System.Windows.Forms.TextBox();
            this.btnFlytta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(333, 99);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(14, 15);
            this.lblx.TabIndex = 0;
            this.lblx.Text = "X";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(438, 99);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(14, 15);
            this.lbly.TabIndex = 1;
            this.lbly.Text = "Y";
            this.lbly.Click += new System.EventHandler(this.lbly_Click);
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(300, 117);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(100, 23);
            this.tbxX.TabIndex = 2;
            this.tbxX.TextChanged += new System.EventHandler(this.tbxX_TextChanged);
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(406, 117);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(100, 23);
            this.tbxY.TabIndex = 3;
            this.tbxY.TextChanged += new System.EventHandler(this.tbxY_TextChanged_1);
            // 
            // btnFlytta
            // 
            this.btnFlytta.Location = new System.Drawing.Point(366, 191);
            this.btnFlytta.Name = "btnFlytta";
            this.btnFlytta.Size = new System.Drawing.Size(75, 23);
            this.btnFlytta.TabIndex = 4;
            this.btnFlytta.Text = "Flytta";
            this.btnFlytta.UseVisualStyleBackColor = true;
            this.btnFlytta.Click += new System.EventHandler(this.btnFlytta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFlytta);
            this.Controls.Add(this.tbxY);
            this.Controls.Add(this.tbxX);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblx;
        private Label lbly;
        private TextBox tbxX;
        private TextBox tbxY;
        private Button btnFlytta;
    }
}