namespace MilightCLient
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
            this.buttonOn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuWheather = new System.Windows.Forms.Button();
            this.menuBrightness = new System.Windows.Forms.Button();
            this.menuColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelWorkArea = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOn
            // 
            this.buttonOn.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOn.Location = new System.Drawing.Point(0, 0);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(387, 99);
            this.buttonOn.TabIndex = 0;
            this.buttonOn.Text = "On";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(387, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(387, 99);
            this.button2.TabIndex = 1;
            this.button2.Text = "Off";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.menuWheather);
            this.panel1.Controls.Add(this.menuBrightness);
            this.panel1.Controls.Add(this.menuColor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 507);
            this.panel1.TabIndex = 2;
            // 
            // menuWheather
            // 
            this.menuWheather.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuWheather.FlatAppearance.BorderSize = 0;
            this.menuWheather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuWheather.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuWheather.Location = new System.Drawing.Point(0, 192);
            this.menuWheather.Name = "menuWheather";
            this.menuWheather.Size = new System.Drawing.Size(160, 46);
            this.menuWheather.TabIndex = 3;
            this.menuWheather.Text = "Wheather";
            this.menuWheather.UseVisualStyleBackColor = true;
            this.menuWheather.Click += new System.EventHandler(this.menuWheather_Click);
            // 
            // menuBrightness
            // 
            this.menuBrightness.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBrightness.FlatAppearance.BorderSize = 0;
            this.menuBrightness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBrightness.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuBrightness.Location = new System.Drawing.Point(0, 146);
            this.menuBrightness.Name = "menuBrightness";
            this.menuBrightness.Size = new System.Drawing.Size(160, 46);
            this.menuBrightness.TabIndex = 2;
            this.menuBrightness.Text = "Brightness";
            this.menuBrightness.UseVisualStyleBackColor = true;
            this.menuBrightness.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuColor
            // 
            this.menuColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuColor.FlatAppearance.BorderSize = 0;
            this.menuColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuColor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuColor.Location = new System.Drawing.Point(0, 100);
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(160, 46);
            this.menuColor.TabIndex = 1;
            this.menuColor.Text = "Color";
            this.menuColor.UseVisualStyleBackColor = true;
            this.menuColor.Click += new System.EventHandler(this.menuColor_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "LED Controller\r\nby \r\nDawid Lubczyński";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.buttonOn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(162, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 101);
            this.panel2.TabIndex = 3;
            // 
            // panelWorkArea
            // 
            this.panelWorkArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkArea.Location = new System.Drawing.Point(162, 101);
            this.panelWorkArea.Name = "panelWorkArea";
            this.panelWorkArea.Size = new System.Drawing.Size(776, 406);
            this.panelWorkArea.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(938, 507);
            this.Controls.Add(this.panelWorkArea);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelWorkArea;
        private System.Windows.Forms.Button menuColor;
        private System.Windows.Forms.Button menuWheather;
        private System.Windows.Forms.Button menuBrightness;
    }
}

