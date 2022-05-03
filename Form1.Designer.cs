namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spielerRechts = new System.Windows.Forms.PictureBox();
            this.spielerLinks = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.spielerLinksScore = new System.Windows.Forms.Label();
            this.spielerRechtsScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spielerRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spielerLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // spielerRechts
            // 
            this.spielerRechts.BackColor = System.Drawing.Color.MediumBlue;
            this.spielerRechts.Location = new System.Drawing.Point(1262, 311);
            this.spielerRechts.Name = "spielerRechts";
            this.spielerRechts.Size = new System.Drawing.Size(35, 150);
            this.spielerRechts.TabIndex = 0;
            this.spielerRechts.TabStop = false;
            // 
            // spielerLinks
            // 
            this.spielerLinks.BackColor = System.Drawing.Color.DarkOrange;
            this.spielerLinks.Location = new System.Drawing.Point(12, 311);
            this.spielerLinks.Name = "spielerLinks";
            this.spielerLinks.Size = new System.Drawing.Size(35, 150);
            this.spielerLinks.TabIndex = 1;
            this.spielerLinks.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(641, 366);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(40, 40);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // spielerLinksScore
            // 
            this.spielerLinksScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spielerLinksScore.ForeColor = System.Drawing.Color.DarkOrange;
            this.spielerLinksScore.Location = new System.Drawing.Point(214, 290);
            this.spielerLinksScore.Name = "spielerLinksScore";
            this.spielerLinksScore.Size = new System.Drawing.Size(216, 192);
            this.spielerLinksScore.TabIndex = 3;
            this.spielerLinksScore.Text = "0";
            this.spielerLinksScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spielerRechtsScore
            // 
            this.spielerRechtsScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spielerRechtsScore.ForeColor = System.Drawing.Color.MediumBlue;
            this.spielerRechtsScore.Location = new System.Drawing.Point(933, 290);
            this.spielerRechtsScore.Name = "spielerRechtsScore";
            this.spielerRechtsScore.Size = new System.Drawing.Size(217, 192);
            this.spielerRechtsScore.TabIndex = 4;
            this.spielerRechtsScore.Text = "0";
            this.spielerRechtsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1309, 753);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.spielerLinks);
            this.Controls.Add(this.spielerRechts);
            this.Controls.Add(this.spielerRechtsScore);
            this.Controls.Add(this.spielerLinksScore);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.spielerRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spielerLinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox spielerRechts;
        private System.Windows.Forms.PictureBox spielerLinks;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label spielerLinksScore;
        private System.Windows.Forms.Label spielerRechtsScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

