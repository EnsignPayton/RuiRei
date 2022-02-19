namespace RuiRei.WinForms.Views
{
    partial class DefinitionView
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
            this.lblTerm = new System.Windows.Forms.Label();
            this.lbSenses = new System.Windows.Forms.ListBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblTerm, 0, 0);
            this.tlpMain.Controls.Add(this.lbSenses, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(8);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(517, 295);
            this.tlpMain.TabIndex = 0;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTerm.Location = new System.Drawing.Point(0, 0);
            this.lblTerm.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(53, 45);
            this.lblTerm.TabIndex = 0;
            this.lblTerm.Text = "卓";
            // 
            // lbSenses
            // 
            this.lbSenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSenses.FormattingEnabled = true;
            this.lbSenses.ItemHeight = 15;
            this.lbSenses.Location = new System.Drawing.Point(0, 53);
            this.lbSenses.Margin = new System.Windows.Forms.Padding(0);
            this.lbSenses.Name = "lbSenses";
            this.lbSenses.Size = new System.Drawing.Size(517, 242);
            this.lbSenses.TabIndex = 1;
            // 
            // DefinitionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "DefinitionView";
            this.Size = new System.Drawing.Size(517, 295);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Label lblTerm;
        private ListBox lbSenses;
    }
}
