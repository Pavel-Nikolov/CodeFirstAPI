
namespace GUIPresentationLayer
{
    partial class BrandsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.brandsDataGridView = new System.Windows.Forms.DataGridView();
            this.codeFirstAPIDataSet = new GUIPresentationLayer.BrandsDataSet();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandsTableAdapter = new GUIPresentationLayer.BrandsDataSetTableAdapters.BrandsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeFirstAPIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(98, 28);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(123, 20);
            this.nameTxtBox.TabIndex = 1;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(49, 70);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(70, 19);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(132, 70);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(70, 19);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(49, 92);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(70, 19);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(132, 92);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(70, 19);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // brandsDataGridView
            // 
            this.brandsDataGridView.AutoGenerateColumns = false;
            this.brandsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brandsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.brandsDataGridView.DataSource = this.brandsBindingSource;
            this.brandsDataGridView.Location = new System.Drawing.Point(28, 130);
            this.brandsDataGridView.Name = "brandsDataGridView";
            this.brandsDataGridView.Size = new System.Drawing.Size(376, 150);
            this.brandsDataGridView.TabIndex = 6;
            this.brandsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brandsDataGridView_CellClick);
            // 
            // codeFirstAPIDataSet
            // 
            this.codeFirstAPIDataSet.DataSetName = "CodeFirstAPIDataSet";
            this.codeFirstAPIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.codeFirstAPIDataSet;
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // BrandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 292);
            this.Controls.Add(this.brandsDataGridView);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BrandsForm";
            this.Text = "Brands Form";
            this.Load += new System.EventHandler(this.BrandsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeFirstAPIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataGridView brandsDataGridView;
        private BrandsDataSet codeFirstAPIDataSet;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private BrandsDataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}