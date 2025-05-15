namespace FINAL_PROJECT
{
    partial class RegisterVehicles
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
            textBox8 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.ForeColor = Color.Transparent;
            textBox8.Location = new Point(206, 184);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(225, 23);
            textBox8.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(32, 182);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 25;
            label9.Text = "Plate Number:";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.Location = new Point(206, 143);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(225, 23);
            textBox7.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(32, 141);
            label7.Name = "label7";
            label7.Size = new Size(134, 25);
            label7.TabIndex = 23;
            label7.Text = "Vehicle Color:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(369, 64);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 16;
            label6.Text = "Vehicle Brand:";
            label6.Click += label6_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(543, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 23);
            textBox4.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(543, 66);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(225, 23);
            textBox6.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 101);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 20;
            label4.Text = "Vehicle Model:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(369, 107);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 18;
            label5.Text = "Vehicle Model:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.Location = new Point(543, 112);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(225, 23);
            textBox5.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(337, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 349);
            panel1.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(304, 230);
            button1.Name = "button1";
            button1.Size = new Size(127, 47);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegisterVehicles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 101, 112);
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(panel1);
            Name = "RegisterVehicles";
            Text = "RegisterVehicles";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox8;
        private Label label9;
        private TextBox textBox7;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Panel panel1;
        private Button button1;
    }
}