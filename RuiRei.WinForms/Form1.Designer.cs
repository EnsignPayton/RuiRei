namespace RuiRei.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dictionaryView1 = new RuiRei.WinForms.Views.DictionaryView();
            this.SuspendLayout();
            // 
            // dictionaryView1
            // 
            this.dictionaryView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dictionaryView1.Location = new System.Drawing.Point(0, 0);
            this.dictionaryView1.Name = "dictionaryView1";
            this.dictionaryView1.Size = new System.Drawing.Size(800, 450);
            this.dictionaryView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dictionaryView1);
            this.Name = "Form1";
            this.Text = "RuiRei Search";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.DictionaryView dictionaryView1;
    }
}