namespace FandomMSSQL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btnNames = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.tBFind = new System.Windows.Forms.TextBox();
            this.tBReplace = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(12, 33);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(412, 225);
            this.dgvTable.TabIndex = 0;
            // 
            // btnNames
            // 
            this.btnNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNames.Location = new System.Drawing.Point(460, 33);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(145, 53);
            this.btnNames.TabIndex = 1;
            this.btnNames.Text = "Имена";
            this.btnNames.UseVisualStyleBackColor = true;
            this.btnNames.Click += new System.EventHandler(this.btnNames_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(628, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 53);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBSearch.Location = new System.Drawing.Point(460, 105);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(145, 29);
            this.tBSearch.TabIndex = 3;
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReplace.Location = new System.Drawing.Point(628, 205);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(145, 53);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Заменить";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // tBFind
            // 
            this.tBFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBFind.Location = new System.Drawing.Point(460, 187);
            this.tBFind.Name = "tBFind";
            this.tBFind.Size = new System.Drawing.Size(145, 29);
            this.tBFind.TabIndex = 5;
            // 
            // tBReplace
            // 
            this.tBReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBReplace.Location = new System.Drawing.Point(460, 244);
            this.tBReplace.Name = "tBReplace";
            this.tBReplace.Size = new System.Drawing.Size(145, 29);
            this.tBReplace.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBReplace);
            this.Controls.Add(this.tBFind);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNames);
            this.Controls.Add(this.dgvTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btnNames;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox tBFind;
        private System.Windows.Forms.TextBox tBReplace;
    }
}

