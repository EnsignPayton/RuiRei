namespace RuiRei.WinForms.Views
{
    partial class SenseView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblPartsOfSpeech = new System.Windows.Forms.Label();
            this.lblMeanings = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblPartsOfSpeech, 0, 0);
            this.tlpMain.Controls.Add(this.lblMeanings, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(147, 50);
            this.tlpMain.TabIndex = 0;
            // 
            // lblPartsOfSpeech
            // 
            this.lblPartsOfSpeech.AutoSize = true;
            this.lblPartsOfSpeech.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPartsOfSpeech.Location = new System.Drawing.Point(3, 3);
            this.lblPartsOfSpeech.Margin = new System.Windows.Forms.Padding(3);
            this.lblPartsOfSpeech.Name = "lblPartsOfSpeech";
            this.lblPartsOfSpeech.Size = new System.Drawing.Size(40, 15);
            this.lblPartsOfSpeech.TabIndex = 0;
            this.lblPartsOfSpeech.Text = "Noun.";
            // 
            // lblMeanings
            // 
            this.lblMeanings.AutoSize = true;
            this.lblMeanings.Location = new System.Drawing.Point(3, 24);
            this.lblMeanings.Margin = new System.Windows.Forms.Padding(3);
            this.lblMeanings.Name = "lblMeanings";
            this.lblMeanings.Size = new System.Drawing.Size(63, 15);
            this.lblMeanings.TabIndex = 1;
            this.lblMeanings.Text = "table; desk";
            // 
            // SenseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "SenseView";
            this.Size = new System.Drawing.Size(147, 50);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Label lblPartsOfSpeech;
        private Label lblMeanings;
    }
}
