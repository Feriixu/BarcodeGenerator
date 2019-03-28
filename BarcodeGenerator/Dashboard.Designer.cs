namespace BarcodeGenerator
{
    partial class Dashboard
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
            this.textBoxBarcodeText = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGenerateAll = new System.Windows.Forms.Button();
            this.backgroundWorkerGenAll = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewCodes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.dialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBarcodeText
            // 
            this.textBoxBarcodeText.Location = new System.Drawing.Point(56, 12);
            this.textBoxBarcodeText.Name = "textBoxBarcodeText";
            this.textBoxBarcodeText.Size = new System.Drawing.Size(732, 20);
            this.textBoxBarcodeText.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(433, 38);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBarcode.Location = new System.Drawing.Point(12, 136);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(496, 302);
            this.pictureBoxBarcode.TabIndex = 2;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scale:";
            // 
            // buttonGenerateAll
            // 
            this.buttonGenerateAll.Location = new System.Drawing.Point(514, 38);
            this.buttonGenerateAll.Name = "buttonGenerateAll";
            this.buttonGenerateAll.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateAll.TabIndex = 5;
            this.buttonGenerateAll.Text = "Gen All";
            this.buttonGenerateAll.UseVisualStyleBackColor = true;
            this.buttonGenerateAll.Click += new System.EventHandler(this.buttonGenerateAll_Click);
            // 
            // dataGridViewCodes
            // 
            this.dataGridViewCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCodes.Location = new System.Drawing.Point(514, 67);
            this.dataGridViewCodes.Name = "dataGridViewCodes";
            this.dataGridViewCodes.Size = new System.Drawing.Size(508, 371);
            this.dataGridViewCodes.TabIndex = 7;
            this.dataGridViewCodes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCodes_CellClick);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(904, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "UpdateDB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(56, 64);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(100, 20);
            this.textBoxScale.TabIndex = 9;
            this.textBoxScale.Text = "5";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(56, 38);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 9;
            this.textBoxHeight.Text = "200";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewCodes);
            this.Controls.Add(this.buttonGenerateAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBarcode);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxBarcodeText);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBarcodeText;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGenerateAll;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGenAll;
        private System.Windows.Forms.DataGridView dataGridViewCodes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.SaveFileDialog dialog;
    }
}

