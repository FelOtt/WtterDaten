namespace WtterDaten
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
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(13, 13);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(137, 54);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "Alles";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(13, 73);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(137, 54);
            this.btnAverage.TabIndex = 1;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 373);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 54);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 313);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 54);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 253);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 54);
            this.button7.TabIndex = 4;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(157, 13);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.ReadOnly = true;
            this.txtAusgabe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAusgabe.Size = new System.Drawing.Size(631, 414);
            this.txtAusgabe.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtAusgabe;
    }
}

