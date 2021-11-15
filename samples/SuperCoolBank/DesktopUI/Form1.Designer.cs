namespace DesktopUI
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
            this.getAll_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addInterest_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // getAll_btn
            // 
            this.getAll_btn.Location = new System.Drawing.Point(22, 29);
            this.getAll_btn.Name = "getAll_btn";
            this.getAll_btn.Size = new System.Drawing.Size(161, 23);
            this.getAll_btn.TabIndex = 0;
            this.getAll_btn.Text = "Get All Accounts";
            this.getAll_btn.UseVisualStyleBackColor = true;
            this.getAll_btn.Click += new System.EventHandler(this.getAll_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name});
            this.dataGridView1.Location = new System.Drawing.Point(22, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(472, 178);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // addInterest_btn
            // 
            this.addInterest_btn.Location = new System.Drawing.Point(214, 29);
            this.addInterest_btn.Name = "addInterest_btn";
            this.addInterest_btn.Size = new System.Drawing.Size(125, 23);
            this.addInterest_btn.TabIndex = 2;
            this.addInterest_btn.Text = "Add Interest Rate";
            this.addInterest_btn.UseVisualStyleBackColor = true;
            this.addInterest_btn.Click += new System.EventHandler(this.addInterest_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addInterest_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getAll_btn);
            //this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button getAll_btn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private Button addInterest_btn;
    }
}