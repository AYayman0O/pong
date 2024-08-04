namespace pong
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
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.P1score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.BackColor = System.Drawing.Color.Chocolate;
            this.p1.Location = new System.Drawing.Point(7, 144);
            this.p1.MinimumSize = new System.Drawing.Size(10, 44);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(13, 44);
            this.p1.TabIndex = 1;
            this.p1.Text = "  ";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.BackColor = System.Drawing.Color.Chocolate;
            this.p2.Location = new System.Drawing.Point(780, 144);
            this.p2.MinimumSize = new System.Drawing.Size(0, 44);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(13, 44);
            this.p2.TabIndex = 2;
            this.p2.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ball.Location = new System.Drawing.Point(410, 175);
            this.ball.MinimumSize = new System.Drawing.Size(10, 9);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 13);
            this.ball.TabIndex = 4;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // p2Score
            // 
            this.p2Score.AutoSize = true;
            this.p2Score.Font = new System.Drawing.Font("Tahoma", 50F);
            this.p2Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p2Score.Location = new System.Drawing.Point(600, 9);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(72, 81);
            this.p2Score.TabIndex = 6;
            this.p2Score.Text = "0";
            // 
            // P1score
            // 
            this.P1score.AutoSize = true;
            this.P1score.Font = new System.Drawing.Font("Tahoma", 50F);
            this.P1score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P1score.Location = new System.Drawing.Point(120, 9);
            this.P1score.Name = "P1score";
            this.P1score.Size = new System.Drawing.Size(72, 81);
            this.P1score.TabIndex = 7;
            this.P1score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.P1score);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label p2Score;
        private System.Windows.Forms.Label P1score;
    }
}

