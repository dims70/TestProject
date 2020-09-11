namespace TestWF
{
    partial class MainForm
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
            this.listresearchs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.listhospitals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listresearchs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listhospitals)).BeginInit();
            this.SuspendLayout();
            // 
            // listresearchs
            // 
            this.listresearchs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listresearchs.Location = new System.Drawing.Point(14, 134);
            this.listresearchs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listresearchs.Name = "listresearchs";
            this.listresearchs.Size = new System.Drawing.Size(810, 602);
            this.listresearchs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список всех исследований и всех привязанных к лаборатории больниц";
            // 
            // listhospitals
            // 
            this.listhospitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listhospitals.Location = new System.Drawing.Point(834, 134);
            this.listhospitals.Margin = new System.Windows.Forms.Padding(5);
            this.listhospitals.Name = "listhospitals";
            this.listhospitals.Size = new System.Drawing.Size(485, 602);
            this.listhospitals.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 750);
            this.Controls.Add(this.listhospitals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listresearchs);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.listresearchs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listhospitals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listresearchs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listhospitals;
    }
}