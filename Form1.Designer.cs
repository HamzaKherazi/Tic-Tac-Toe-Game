namespace Tic_Tac_Toe_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(395, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.original_3f431eb30765ab8eb359cfe1142d6fc0;
            this.pictureBox1.Location = new System.Drawing.Point(111, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btn1.Location = new System.Drawing.Point(415, 137);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 82);
            this.btn1.TabIndex = 9;
            this.btn1.Tag = "";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.Location = new System.Drawing.Point(729, 137);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(103, 82);
            this.btn3.TabIndex = 8;
            this.btn3.Tag = "";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.Location = new System.Drawing.Point(729, 283);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(103, 82);
            this.btn6.TabIndex = 7;
            this.btn6.Tag = "";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Image = ((System.Drawing.Image)(resources.GetObject("btn9.Image")));
            this.btn9.Location = new System.Drawing.Point(729, 427);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(103, 82);
            this.btn9.TabIndex = 6;
            this.btn9.Tag = "";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.Location = new System.Drawing.Point(574, 283);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(103, 82);
            this.btn5.TabIndex = 5;
            this.btn5.Tag = "";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.Location = new System.Drawing.Point(574, 427);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(103, 82);
            this.btn8.TabIndex = 4;
            this.btn8.Tag = "";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.Location = new System.Drawing.Point(415, 427);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(103, 82);
            this.btn7.TabIndex = 3;
            this.btn7.Tag = "";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.Location = new System.Drawing.Point(415, 283);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(103, 82);
            this.btn4.TabIndex = 2;
            this.btn4.Tag = "";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btn2.Location = new System.Drawing.Point(574, 137);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(103, 82);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(140, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 41);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(113, 267);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(150, 41);
            this.lblTurn.TabIndex = 12;
            this.lblTurn.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(118, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 41);
            this.label4.TabIndex = 13;
            this.label4.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(89, 399);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(199, 41);
            this.lblWinner.TabIndex = 14;
            this.lblWinner.Text = "In Progress";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(85, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "Restart Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(999, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button button1;
    }
}

