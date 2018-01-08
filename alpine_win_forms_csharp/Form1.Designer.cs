namespace alpine_win_forms_csharp
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
            this.lblSeparator = new System.Windows.Forms.Label();
            this.cboSeparator = new System.Windows.Forms.ComboBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.dGVParentAndChild = new System.Windows.Forms.DataGridView();
            this.dGVSearchResult = new System.Windows.Forms.DataGridView();
            this.rbExtendedSearch = new System.Windows.Forms.RadioButton();
            this.txtChildSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblParentSearch = new System.Windows.Forms.Label();
            this.txtParentSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVParentAndChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(14, 17);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(97, 13);
            this.lblSeparator.TabIndex = 0;
            this.lblSeparator.Text = "Elválasztó karakter";
            // 
            // cboSeparator
            // 
            this.cboSeparator.FormattingEnabled = true;
            this.cboSeparator.Location = new System.Drawing.Point(117, 13);
            this.cboSeparator.Name = "cboSeparator";
            this.cboSeparator.Size = new System.Drawing.Size(121, 21);
            this.cboSeparator.TabIndex = 1;
            this.cboSeparator.SelectedValueChanged += new System.EventHandler(this.cboSeparator_SelectedValueChanged);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(313, 14);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(183, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(502, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Tallózás";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(284, 17);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(23, 13);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Fájl";
            // 
            // dGVParentAndChild
            // 
            this.dGVParentAndChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVParentAndChild.Location = new System.Drawing.Point(17, 68);
            this.dGVParentAndChild.Name = "dGVParentAndChild";
            this.dGVParentAndChild.Size = new System.Drawing.Size(248, 324);
            this.dGVParentAndChild.TabIndex = 5;
            // 
            // dGVSearchResult
            // 
            this.dGVSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSearchResult.Location = new System.Drawing.Point(313, 151);
            this.dGVSearchResult.Name = "dGVSearchResult";
            this.dGVSearchResult.Size = new System.Drawing.Size(232, 241);
            this.dGVSearchResult.TabIndex = 6;
            // 
            // rbExtendedSearch
            // 
            this.rbExtendedSearch.AutoSize = true;
            this.rbExtendedSearch.Location = new System.Drawing.Point(313, 41);
            this.rbExtendedSearch.Name = "rbExtendedSearch";
            this.rbExtendedSearch.Size = new System.Drawing.Size(117, 17);
            this.rbExtendedSearch.TabIndex = 7;
            this.rbExtendedSearch.TabStop = true;
            this.rbExtendedSearch.Text = "Többszintű keresés";
            this.rbExtendedSearch.UseVisualStyleBackColor = true;
            // 
            // txtChildSearch
            // 
            this.txtChildSearch.Location = new System.Drawing.Point(431, 64);
            this.txtChildSearch.Name = "txtChildSearch";
            this.txtChildSearch.Size = new System.Drawing.Size(168, 20);
            this.txtChildSearch.TabIndex = 8;
            this.txtChildSearch.TextChanged += new System.EventHandler(this.txtChildSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Leszármazott keresése";
            // 
            // lblParentSearch
            // 
            this.lblParentSearch.AutoSize = true;
            this.lblParentSearch.Location = new System.Drawing.Point(310, 93);
            this.lblParentSearch.Name = "lblParentSearch";
            this.lblParentSearch.Size = new System.Drawing.Size(79, 13);
            this.lblParentSearch.TabIndex = 11;
            this.lblParentSearch.Text = "Szülő keresése";
            // 
            // txtParentSearch
            // 
            this.txtParentSearch.Location = new System.Drawing.Point(431, 90);
            this.txtParentSearch.Name = "txtParentSearch";
            this.txtParentSearch.Size = new System.Drawing.Size(168, 20);
            this.txtParentSearch.TabIndex = 10;
            this.txtParentSearch.TextChanged += new System.EventHandler(this.txtParentSearch_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 415);
            this.Controls.Add(this.lblParentSearch);
            this.Controls.Add(this.txtParentSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChildSearch);
            this.Controls.Add(this.rbExtendedSearch);
            this.Controls.Add(this.dGVSearchResult);
            this.Controls.Add(this.dGVParentAndChild);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.cboSeparator);
            this.Controls.Add(this.lblSeparator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGVParentAndChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.ComboBox cboSeparator;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.DataGridView dGVParentAndChild;
        private System.Windows.Forms.DataGridView dGVSearchResult;
        private System.Windows.Forms.RadioButton rbExtendedSearch;
        private System.Windows.Forms.TextBox txtChildSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParentSearch;
        private System.Windows.Forms.TextBox txtParentSearch;
    }
}

