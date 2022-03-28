
namespace Wasm_Cache_Reader
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
            this.components = new System.ComponentModel.Container();
            this.cmbBrowser = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.dgvCacheIndex = new System.Windows.Forms.DataGridView();
            this.SmallLastUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LargelastUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LargeFileStreamSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ByteCodeHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smallFilenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largeFilenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallCacheStructureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacheIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overallCacheStructureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBrowser
            // 
            this.cmbBrowser.FormattingEnabled = true;
            this.cmbBrowser.Items.AddRange(new object[] {
            "Chrome",
            "Edge"});
            this.cmbBrowser.Location = new System.Drawing.Point(270, 31);
            this.cmbBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBrowser.Name = "cmbBrowser";
            this.cmbBrowser.Size = new System.Drawing.Size(176, 24);
            this.cmbBrowser.TabIndex = 0;
            this.cmbBrowser.Text = "Chrome";
            this.cmbBrowser.SelectedIndexChanged += new System.EventHandler(this.cmbBrowser_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(633, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(591, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "C:\\Users\\johnh\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Code Cache\\wasm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Path:";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(1265, 23);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 39);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dgvCacheIndex
            // 
            this.dgvCacheIndex.AllowUserToAddRows = false;
            this.dgvCacheIndex.AllowUserToDeleteRows = false;
            this.dgvCacheIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCacheIndex.AutoGenerateColumns = false;
            this.dgvCacheIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCacheIndex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.smallFilenameDataGridViewTextBoxColumn,
            this.SmallLastUsed,
            this.largeFilenameDataGridViewTextBoxColumn,
            this.LargelastUsed,
            this.keyDataGridViewTextBoxColumn,
            this.resourceNameDataGridViewTextBoxColumn,
            this.domainNameDataGridViewTextBoxColumn,
            this.LargeFileStreamSize,
            this.ByteCodeHash});
            this.dgvCacheIndex.DataSource = this.overallCacheStructureBindingSource;
            this.dgvCacheIndex.Location = new System.Drawing.Point(60, 108);
            this.dgvCacheIndex.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCacheIndex.Name = "dgvCacheIndex";
            this.dgvCacheIndex.ReadOnly = true;
            this.dgvCacheIndex.RowHeadersWidth = 51;
            this.dgvCacheIndex.Size = new System.Drawing.Size(1280, 546);
            this.dgvCacheIndex.TabIndex = 4;
            // 
            // SmallLastUsed
            // 
            this.SmallLastUsed.DataPropertyName = "SmallLastUsed";
            this.SmallLastUsed.HeaderText = "SmallLastUsed";
            this.SmallLastUsed.MinimumWidth = 6;
            this.SmallLastUsed.Name = "SmallLastUsed";
            this.SmallLastUsed.ReadOnly = true;
            this.SmallLastUsed.Width = 125;
            // 
            // LargelastUsed
            // 
            this.LargelastUsed.DataPropertyName = "LargelastUsed";
            this.LargelastUsed.HeaderText = "LargelastUsed";
            this.LargelastUsed.MinimumWidth = 6;
            this.LargelastUsed.Name = "LargelastUsed";
            this.LargelastUsed.ReadOnly = true;
            this.LargelastUsed.Width = 125;
            // 
            // LargeFileStreamSize
            // 
            this.LargeFileStreamSize.DataPropertyName = "LargeFileStreamSize";
            this.LargeFileStreamSize.HeaderText = "LargeFileStreamSize";
            this.LargeFileStreamSize.MinimumWidth = 6;
            this.LargeFileStreamSize.Name = "LargeFileStreamSize";
            this.LargeFileStreamSize.ReadOnly = true;
            this.LargeFileStreamSize.Width = 125;
            // 
            // ByteCodeHash
            // 
            this.ByteCodeHash.DataPropertyName = "ByteCodeHash";
            this.ByteCodeHash.HeaderText = "ByteCodeHash";
            this.ByteCodeHash.MinimumWidth = 6;
            this.ByteCodeHash.Name = "ByteCodeHash";
            this.ByteCodeHash.ReadOnly = true;
            this.ByteCodeHash.Width = 125;
            // 
            // smallFilenameDataGridViewTextBoxColumn
            // 
            this.smallFilenameDataGridViewTextBoxColumn.DataPropertyName = "SmallFilename";
            this.smallFilenameDataGridViewTextBoxColumn.HeaderText = "SmallFilename";
            this.smallFilenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.smallFilenameDataGridViewTextBoxColumn.Name = "smallFilenameDataGridViewTextBoxColumn";
            this.smallFilenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.smallFilenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // largeFilenameDataGridViewTextBoxColumn
            // 
            this.largeFilenameDataGridViewTextBoxColumn.DataPropertyName = "LargeFilename";
            this.largeFilenameDataGridViewTextBoxColumn.HeaderText = "LargeFilename";
            this.largeFilenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.largeFilenameDataGridViewTextBoxColumn.Name = "largeFilenameDataGridViewTextBoxColumn";
            this.largeFilenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.largeFilenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "Key";
            this.keyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            this.keyDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyDataGridViewTextBoxColumn.Width = 125;
            // 
            // resourceNameDataGridViewTextBoxColumn
            // 
            this.resourceNameDataGridViewTextBoxColumn.DataPropertyName = "ResourceName";
            this.resourceNameDataGridViewTextBoxColumn.HeaderText = "ResourceName";
            this.resourceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resourceNameDataGridViewTextBoxColumn.Name = "resourceNameDataGridViewTextBoxColumn";
            this.resourceNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.resourceNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // domainNameDataGridViewTextBoxColumn
            // 
            this.domainNameDataGridViewTextBoxColumn.DataPropertyName = "DomainName";
            this.domainNameDataGridViewTextBoxColumn.HeaderText = "DomainName";
            this.domainNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.domainNameDataGridViewTextBoxColumn.Name = "domainNameDataGridViewTextBoxColumn";
            this.domainNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.domainNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // overallCacheStructureBindingSource
            // 
            this.overallCacheStructureBindingSource.DataSource = typeof(Wasm_Cache_Library.Classes.OverallCacheStructure);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Browser:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 702);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCacheIndex);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbBrowser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CodeCacheView";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacheIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overallCacheStructureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBrowser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView dgvCacheIndex;
        private System.Windows.Forms.BindingSource overallCacheStructureBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn smallFilenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SmallLastUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn largeFilenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LargelastUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LargeFileStreamSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ByteCodeHash;
        private System.Windows.Forms.Label label2;
    }
}

