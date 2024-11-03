namespace CompressFiles
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.showFileNameTxt = new System.Windows.Forms.TextBox();
            this.compressBtn = new System.Windows.Forms.Button();
            this.decompressBtn = new System.Windows.Forms.Button();
            this.savedSpacelbl = new System.Windows.Forms.Label();
            this.compressedFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LostSpaceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(638, 26);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(101, 23);
            this.selectFileBtn.TabIndex = 0;
            this.selectFileBtn.Text = "Datei auswahlen";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // showFileNameTxt
            // 
            this.showFileNameTxt.Location = new System.Drawing.Point(92, 24);
            this.showFileNameTxt.Name = "showFileNameTxt";
            this.showFileNameTxt.Size = new System.Drawing.Size(349, 20);
            this.showFileNameTxt.TabIndex = 1;
            // 
            // compressBtn
            // 
            this.compressBtn.Location = new System.Drawing.Point(638, 84);
            this.compressBtn.Name = "compressBtn";
            this.compressBtn.Size = new System.Drawing.Size(101, 23);
            this.compressBtn.TabIndex = 2;
            this.compressBtn.Text = "Komprimieren";
            this.compressBtn.UseVisualStyleBackColor = true;
            this.compressBtn.Click += new System.EventHandler(this.compressBtn_Click);
            // 
            // decompressBtn
            // 
            this.decompressBtn.Location = new System.Drawing.Point(638, 55);
            this.decompressBtn.Name = "decompressBtn";
            this.decompressBtn.Size = new System.Drawing.Size(101, 23);
            this.decompressBtn.TabIndex = 3;
            this.decompressBtn.Text = "Dekomprimieren";
            this.decompressBtn.UseVisualStyleBackColor = true;
            this.decompressBtn.Click += new System.EventHandler(this.decompressBtn_Click);
            // 
            // savedSpacelbl
            // 
            this.savedSpacelbl.AutoSize = true;
            this.savedSpacelbl.Location = new System.Drawing.Point(467, 31);
            this.savedSpacelbl.Name = "savedSpacelbl";
            this.savedSpacelbl.Size = new System.Drawing.Size(0, 13);
            this.savedSpacelbl.TabIndex = 4;
            // 
            // compressedFileName
            // 
            this.compressedFileName.Location = new System.Drawing.Point(92, 84);
            this.compressedFileName.Name = "compressedFileName";
            this.compressedFileName.Size = new System.Drawing.Size(349, 20);
            this.compressedFileName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datei:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ziel:";
            // 
            // LostSpaceLbl
            // 
            this.LostSpaceLbl.AutoSize = true;
            this.LostSpaceLbl.Location = new System.Drawing.Point(467, 91);
            this.LostSpaceLbl.Name = "LostSpaceLbl";
            this.LostSpaceLbl.Size = new System.Drawing.Size(0, 13);
            this.LostSpaceLbl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 147);
            this.Controls.Add(this.LostSpaceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compressedFileName);
            this.Controls.Add(this.savedSpacelbl);
            this.Controls.Add(this.decompressBtn);
            this.Controls.Add(this.compressBtn);
            this.Controls.Add(this.showFileNameTxt);
            this.Controls.Add(this.selectFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.TextBox showFileNameTxt;
        private System.Windows.Forms.Button compressBtn;
        private System.Windows.Forms.Button decompressBtn;
        private System.Windows.Forms.Label savedSpacelbl;
        private System.Windows.Forms.TextBox compressedFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LostSpaceLbl;
    }
}

