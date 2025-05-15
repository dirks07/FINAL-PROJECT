namespace FINAL_PROJECT
{
    partial class REGISTRATION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRATION));
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label6 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(180, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(479, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(304, 271);
            button1.Name = "button1";
            button1.Size = new Size(127, 47);
            button1.TabIndex = 2;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(226, 117);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 3;
            label6.Text = "Username:";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(400, 119);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(225, 23);
            textBox6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(226, 160);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 5;
            label5.Text = "Email:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.Location = new Point(400, 165);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(225, 23);
            textBox5.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(226, 251);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 7;
            label4.Text = "Verification Code:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(400, 253);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 23);
            textBox4.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(226, 210);
            label8.Name = "label8";
            label8.Size = new Size(190, 25);
            label8.TabIndex = 10;
            label8.Text = "Verification sent to: ";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(226, 293);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 11;
            label7.Text = "Password:";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.Location = new Point(400, 295);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(225, 23);
            textBox7.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(226, 335);
            label9.Name = "label9";
            label9.Size = new Size(37, 25);
            label9.TabIndex = 13;
            label9.Text = "ID:";
            label9.Click += label9_Click;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.ForeColor = Color.Transparent;
            textBox8.Location = new Point(400, 337);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(225, 23);
            textBox8.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(194, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 349);
            panel1.TabIndex = 15;
            // 
            // REGISTRATION
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 101, 112);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox8);
            Controls.Add(pictureBox2);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(panel1);
            Name = "REGISTRATION";
            Text = "REGISTRATION";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button button1;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Panel panel1;
    }
}