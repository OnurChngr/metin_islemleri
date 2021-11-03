
namespace metin_islemleri
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
            this.btnTikla = new System.Windows.Forms.Button();
            this.lstAlfabe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTikla
            // 
            this.btnTikla.Location = new System.Drawing.Point(318, 165);
            this.btnTikla.Name = "btnTikla";
            this.btnTikla.Size = new System.Drawing.Size(108, 61);
            this.btnTikla.TabIndex = 0;
            this.btnTikla.Text = "Tıkla";
            this.btnTikla.UseVisualStyleBackColor = true;
            this.btnTikla.Click += new System.EventHandler(this.btnTikla_Click);
            // 
            // lstAlfabe
            // 
            this.lstAlfabe.FormattingEnabled = true;
            this.lstAlfabe.Location = new System.Drawing.Point(130, 101);
            this.lstAlfabe.Name = "lstAlfabe";
            this.lstAlfabe.Size = new System.Drawing.Size(120, 147);
            this.lstAlfabe.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAlfabe);
            this.Controls.Add(this.btnTikla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTikla;
        private System.Windows.Forms.ListBox lstAlfabe;
    }
}

