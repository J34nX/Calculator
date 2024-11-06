namespace Calculator_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CalculateBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstnumTB = new System.Windows.Forms.TextBox();
            this.SignCB = new System.Windows.Forms.ComboBox();
            this.SecondNumTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnserTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateBT
            // 
            this.CalculateBT.Location = new System.Drawing.Point(316, 70);
            this.CalculateBT.Name = "CalculateBT";
            this.CalculateBT.Size = new System.Drawing.Size(75, 23);
            this.CalculateBT.TabIndex = 0;
            this.CalculateBT.Text = "Calculate";
            this.CalculateBT.UseVisualStyleBackColor = true;
            this.CalculateBT.Click += new System.EventHandler(this.CalculateBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculator";
            // 
            // FirstnumTB
            // 
            this.FirstnumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnumTB.Location = new System.Drawing.Point(12, 38);
            this.FirstnumTB.Name = "FirstnumTB";
            this.FirstnumTB.Size = new System.Drawing.Size(100, 26);
            this.FirstnumTB.TabIndex = 2;
            // 
            // SignCB
            // 
            this.SignCB.FormattingEnabled = true;
            this.SignCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.SignCB.Location = new System.Drawing.Point(118, 43);
            this.SignCB.Name = "SignCB";
            this.SignCB.Size = new System.Drawing.Size(44, 21);
            this.SignCB.TabIndex = 3;
            // 
            // SecondNumTB
            // 
            this.SecondNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumTB.Location = new System.Drawing.Point(168, 38);
            this.SecondNumTB.Name = "SecondNumTB";
            this.SecondNumTB.Size = new System.Drawing.Size(100, 26);
            this.SecondNumTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // AnserTB
            // 
            this.AnserTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnserTB.Location = new System.Drawing.Point(305, 38);
            this.AnserTB.Name = "AnserTB";
            this.AnserTB.Size = new System.Drawing.Size(100, 26);
            this.AnserTB.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(418, 115);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnserTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondNumTB);
            this.Controls.Add(this.SignCB);
            this.Controls.Add(this.FirstnumTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstnumTB;
        private System.Windows.Forms.ComboBox SignCB;
        private System.Windows.Forms.TextBox SecondNumTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnserTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

