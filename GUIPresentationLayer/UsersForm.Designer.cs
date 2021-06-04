
namespace GUIPresentationLayer
{
    partial class UsersForm
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
            this.UsersDgv = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new GUIPresentationLayer.UsersDataSet();
            this.usersTableAdapter = new GUIPresentationLayer.UsersDataSetTableAdapters.UsersTableAdapter();
            this.productsLsb = new System.Windows.Forms.ListBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataSet = new GUIPresentationLayer.ProductsDataSet();
            this.productsTableAdapter = new GUIPresentationLayer.ProductsDataSetTableAdapters.ProductsTableAdapter();
            this.Nametxtbox = new System.Windows.Forms.TextBox();
            this.ageChb = new System.Windows.Forms.CheckBox();
            this.ageNud = new System.Windows.Forms.NumericUpDown();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNud)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersDgv
            // 
            this.UsersDgv.AutoGenerateColumns = false;
            this.UsersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.UsersDgv.DataSource = this.usersBindingSource;
            this.UsersDgv.Location = new System.Drawing.Point(429, 35);
            this.UsersDgv.Name = "UsersDgv";
            this.UsersDgv.Size = new System.Drawing.Size(343, 175);
            this.UsersDgv.TabIndex = 0;
            this.UsersDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDgv_CellClick);
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
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.usersDataSetBindingSource;
            // 
            // usersDataSetBindingSource
            // 
            this.usersDataSetBindingSource.DataSource = this.usersDataSet;
            this.usersDataSetBindingSource.Position = 0;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // productsLsb
            // 
            this.productsLsb.DataSource = this.productsBindingSource;
            this.productsLsb.DisplayMember = "Name";
            this.productsLsb.FormattingEnabled = true;
            this.productsLsb.Location = new System.Drawing.Point(429, 251);
            this.productsLsb.Name = "productsLsb";
            this.productsLsb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.productsLsb.Size = new System.Drawing.Size(120, 95);
            this.productsLsb.TabIndex = 1;
            this.productsLsb.ValueMember = "Barcode";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productsDataSet;
            // 
            // productsDataSet
            // 
            this.productsDataSet.DataSetName = "ProductsDataSet";
            this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Nametxtbox
            // 
            this.Nametxtbox.Location = new System.Drawing.Point(88, 80);
            this.Nametxtbox.Name = "Nametxtbox";
            this.Nametxtbox.Size = new System.Drawing.Size(100, 20);
            this.Nametxtbox.TabIndex = 2;
            // 
            // ageChb
            // 
            this.ageChb.AutoSize = true;
            this.ageChb.Location = new System.Drawing.Point(40, 125);
            this.ageChb.Name = "ageChb";
            this.ageChb.Size = new System.Drawing.Size(151, 17);
            this.ageChb.TabIndex = 3;
            this.ageChb.Text = "I would like to give my age";
            this.ageChb.UseVisualStyleBackColor = true;
            this.ageChb.CheckedChanged += new System.EventHandler(this.ageChb_CheckedChanged);
            // 
            // ageNud
            // 
            this.ageNud.Location = new System.Drawing.Point(68, 148);
            this.ageNud.Name = "ageNud";
            this.ageNud.Size = new System.Drawing.Size(120, 20);
            this.ageNud.TabIndex = 4;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(40, 252);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 5;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(184, 251);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(40, 309);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(184, 310);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Users:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Products:";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ageNud);
            this.Controls.Add(this.ageChb);
            this.Controls.Add(this.Nametxtbox);
            this.Controls.Add(this.productsLsb);
            this.Controls.Add(this.UsersDgv);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersDgv;
        private System.Windows.Forms.BindingSource usersDataSetBindingSource;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox productsLsb;
        private ProductsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProductsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.TextBox Nametxtbox;
        private System.Windows.Forms.CheckBox ageChb;
        private System.Windows.Forms.NumericUpDown ageNud;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}