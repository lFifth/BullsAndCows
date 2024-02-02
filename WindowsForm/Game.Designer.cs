namespace WindowsForm
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Console = new System.Windows.Forms.Label();
            this.Attempts = new System.Windows.Forms.Label();
            this.Field1 = new System.Windows.Forms.TextBox();
            this.Field2 = new System.Windows.Forms.TextBox();
            this.StatusBox = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(908, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 17;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(604, 574);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 31);
            this.textBox1.TabIndex = 20;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Console
            // 
            this.Console.AutoSize = true;
            this.Console.Location = new System.Drawing.Point(599, 70);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(96, 25);
            this.Console.TabIndex = 21;
            this.Console.Text = "Консоль";
            // 
            // Attempts
            // 
            this.Attempts.AutoSize = true;
            this.Attempts.Location = new System.Drawing.Point(37, 116);
            this.Attempts.Name = "Attempts";
            this.Attempts.Size = new System.Drawing.Size(99, 25);
            this.Attempts.TabIndex = 23;
            this.Attempts.Text = "Попытки";
            // 
            // Field1
            // 
            this.Field1.BackColor = System.Drawing.SystemColors.Control;
            this.Field1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Field1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Field1.Location = new System.Drawing.Point(42, 162);
            this.Field1.Multiline = true;
            this.Field1.Name = "Field1";
            this.Field1.ReadOnly = true;
            this.Field1.Size = new System.Drawing.Size(277, 434);
            this.Field1.TabIndex = 24;
            // 
            // Field2
            // 
            this.Field2.BackColor = System.Drawing.SystemColors.Control;
            this.Field2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Field2.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Field2.Location = new System.Drawing.Point(325, 162);
            this.Field2.Multiline = true;
            this.Field2.Name = "Field2";
            this.Field2.ReadOnly = true;
            this.Field2.Size = new System.Drawing.Size(277, 434);
            this.Field2.TabIndex = 25;
            // 
            // StatusBox
            // 
            this.StatusBox.AutoSize = true;
            this.StatusBox.Font = new System.Drawing.Font("Cascadia Mono", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBox.Location = new System.Drawing.Point(775, 40);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(155, 75);
            this.StatusBox.TabIndex = 22;
            this.StatusBox.Text = "Быки и Коровы\r\nv0.12.6\r\nby Fifth\r\n";
            this.StatusBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(575, 36);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(358, 87);
            this.textBox2.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "i";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 608);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Field2);
            this.Controls.Add(this.Field1);
            this.Controls.Add(this.Attempts);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulls and Cows";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Console;
        private System.Windows.Forms.Label Attempts;
        private System.Windows.Forms.TextBox Field1;
        private System.Windows.Forms.TextBox Field2;
        private System.Windows.Forms.Label StatusBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}