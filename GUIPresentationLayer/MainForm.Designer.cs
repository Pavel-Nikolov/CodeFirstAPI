
namespace GUIPresentationLayer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.brandsBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brandsBtn
            // 
            this.brandsBtn.Location = new System.Drawing.Point(146, 54);
            this.brandsBtn.Name = "brandsBtn";
            this.brandsBtn.Size = new System.Drawing.Size(94, 29);
            this.brandsBtn.TabIndex = 0;
            this.brandsBtn.Text = "Brands";
            this.brandsBtn.UseVisualStyleBackColor = true;
            this.brandsBtn.Click += new System.EventHandler(this.brandsBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Location = new System.Drawing.Point(293, 54);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(94, 29);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // customersBtn
            // 
            this.customersBtn.Location = new System.Drawing.Point(146, 120);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(94, 29);
            this.customersBtn.TabIndex = 2;
            this.customersBtn.Text = "Customers";
            this.customersBtn.UseVisualStyleBackColor = true;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(293, 120);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 29);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.customersBtn);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.brandsBtn);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brandsBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

