namespace People
{
    partial class FrmPeople
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
            this.ID_ = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this._name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this._phone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this._age = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.brExit = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.dgViewPeople = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_
            // 
            this.ID_.AutoSize = true;
            this.ID_.Location = new System.Drawing.Point(40, 48);
            this.ID_.Name = "ID_";
            this.ID_.Size = new System.Drawing.Size(18, 13);
            this.ID_.TabIndex = 0;
            this.ID_.Text = "ID";
            this.ID_.UseMnemonic = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // _name
            // 
            this._name.AutoSize = true;
            this._name.Location = new System.Drawing.Point(40, 87);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(35, 13);
            this._name.TabIndex = 0;
            this._name.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // _phone
            // 
            this._phone.AutoSize = true;
            this._phone.Location = new System.Drawing.Point(40, 124);
            this._phone.Name = "_phone";
            this._phone.Size = new System.Drawing.Size(38, 13);
            this._phone.TabIndex = 0;
            this._phone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(125, 116);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // _age
            // 
            this._age.AutoSize = true;
            this._age.Location = new System.Drawing.Point(40, 160);
            this._age.Name = "_age";
            this._age.Size = new System.Drawing.Size(26, 13);
            this._age.TabIndex = 0;
            this._age.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(125, 152);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(43, 190);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(125, 190);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(206, 190);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(287, 190);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // brExit
            // 
            this.brExit.Location = new System.Drawing.Point(368, 190);
            this.brExit.Name = "brExit";
            this.brExit.Size = new System.Drawing.Size(75, 23);
            this.brExit.TabIndex = 2;
            this.brExit.Text = "Exit";
            this.brExit.UseVisualStyleBackColor = true;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(243, 38);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(25, 23);
            this.btFind.TabIndex = 2;
            this.btFind.Text = "...";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btClean_Click);
            // 
            // dgViewPeople
            // 
            this.dgViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewPeople.Location = new System.Drawing.Point(12, 219);
            this.dgViewPeople.Name = "dgViewPeople";
            this.dgViewPeople.Size = new System.Drawing.Size(475, 150);
            this.dgViewPeople.TabIndex = 3;
            this.dgViewPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewPeople_CellContentClick_1);
            // 
            // FrmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 430);
            this.Controls.Add(this.dgViewPeople);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.brExit);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this._age);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this._phone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this._name);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ID_);
            this.Name = "FrmPeople";
            this.Text = "Form - People Using LINQ ";
            this.Load += new System.EventHandler(this.FrmPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label _name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label _phone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label _age;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button brExit;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.DataGridView dgViewPeople;
    }
}

