namespace Eshop
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.UnitOfWorkBtn = new System.Windows.Forms.Button();
            this.IdentityMapBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lazy loading";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LazyLoadingBtn_Click);
            // 
            // UnitOfWorkBtn
            // 
            this.UnitOfWorkBtn.Location = new System.Drawing.Point(262, 68);
            this.UnitOfWorkBtn.Name = "UnitOfWorkBtn";
            this.UnitOfWorkBtn.Size = new System.Drawing.Size(121, 23);
            this.UnitOfWorkBtn.TabIndex = 1;
            this.UnitOfWorkBtn.Text = "UnitOfWork";
            this.UnitOfWorkBtn.UseVisualStyleBackColor = true;
            this.UnitOfWorkBtn.Click += new System.EventHandler(this.UnitOfWorkBtn_Click);
            // 
            // IdentityMapBtn
            // 
            this.IdentityMapBtn.Location = new System.Drawing.Point(468, 68);
            this.IdentityMapBtn.Name = "IdentityMapBtn";
            this.IdentityMapBtn.Size = new System.Drawing.Size(119, 23);
            this.IdentityMapBtn.TabIndex = 2;
            this.IdentityMapBtn.Text = "IdentityMap";
            this.IdentityMapBtn.UseVisualStyleBackColor = true;
            this.IdentityMapBtn.Click += new System.EventHandler(this.IdentityMapBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IdentityMapBtn);
            this.Controls.Add(this.UnitOfWorkBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UnitOfWorkBtn;
        private System.Windows.Forms.Button IdentityMapBtn;
    }
}

