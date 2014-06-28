namespace StoresOnlineSupplierExtractor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputDir = new System.Windows.Forms.TextBox();
            this.btnBrowseInputDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.btnBrowseOutputDir = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Directory";
            // 
            // txtInputDir
            // 
            this.txtInputDir.Location = new System.Drawing.Point(94, 6);
            this.txtInputDir.Name = "txtInputDir";
            this.txtInputDir.Size = new System.Drawing.Size(555, 20);
            this.txtInputDir.TabIndex = 1;
            // 
            // btnBrowseInputDir
            // 
            this.btnBrowseInputDir.Location = new System.Drawing.Point(655, 4);
            this.btnBrowseInputDir.Name = "btnBrowseInputDir";
            this.btnBrowseInputDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInputDir.TabIndex = 2;
            this.btnBrowseInputDir.Text = "Browse";
            this.btnBrowseInputDir.UseVisualStyleBackColor = true;
            this.btnBrowseInputDir.Click += new System.EventHandler(this.btnBrowseInputDir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output File";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(94, 40);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(555, 20);
            this.txtOutputFile.TabIndex = 4;
            // 
            // btnBrowseOutputDir
            // 
            this.btnBrowseOutputDir.Location = new System.Drawing.Point(655, 38);
            this.btnBrowseOutputDir.Name = "btnBrowseOutputDir";
            this.btnBrowseOutputDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutputDir.TabIndex = 5;
            this.btnBrowseOutputDir.Text = "Browse";
            this.btnBrowseOutputDir.UseVisualStyleBackColor = true;
            this.btnBrowseOutputDir.Click += new System.EventHandler(this.btnBrowseOutputDir_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(655, 102);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 6;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.Window;
            this.txtResults.Location = new System.Drawing.Point(94, 102);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(555, 341);
            this.txtResults.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnBrowseOutputDir);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseInputDir);
            this.Controls.Add(this.txtInputDir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Supplier Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputDir;
        private System.Windows.Forms.Button btnBrowseInputDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button btnBrowseOutputDir;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label label3;
    }
}

