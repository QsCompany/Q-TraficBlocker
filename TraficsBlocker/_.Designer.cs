namespace _
{
    partial class _
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
        private void _____()
        {
            this.______ = new System.Windows.Forms.DataGridView();
            this.Browser = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.New = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OUT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Strategy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.______)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Explorer
            // 
            this.______.AllowUserToOrderColumns = true;
            this.______.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.______.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.New,
            this._Name,
            this.PID,
            this.Path,
            this.Blocked,
            this.IN,
            this.OUT,
            this.Strategy,
            this.ID});
            this.______.Dock = System.Windows.Forms.DockStyle.Fill;
            this.______.Location = new System.Drawing.Point(0, 35);
            this.______.Name = "Explorer";
            this.______.Size = new System.Drawing.Size(865, 287);
            this.______.TabIndex = 0;
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Right;
            this.Browser.Location = new System.Drawing.Point(788, 0);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(77, 35);
            this.Browser.TabIndex = 1;
            this.Browser.Text = "Browser";
            this.Browser.UseVisualStyleBackColor = true;
            this.Browser.Click += new System.EventHandler(this.________________);
            // 
            // Apply
            // 
            this.Apply.Dock = System.Windows.Forms.DockStyle.Right;
            this.Apply.Location = new System.Drawing.Point(711, 0);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(77, 35);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Update
            // 
            this.Update.Dock = System.Windows.Forms.DockStyle.Right;
            this.Update.Location = new System.Drawing.Point(636, 0);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 35);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.__________);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.Apply);
            this.panel1.Controls.Add(this.Browser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 35);
            this.panel1.TabIndex = 2;
            // 
            // New
            // 
            this.New.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.New.HeaderText = "";
            this.New.Name = "New";
            this.New.ReadOnly = true;
            this.New.Width = 21;
            // 
            // _Name
            // 
            this._Name.HeaderText = "Name";
            this._Name.Name = "_Name";
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // Blocked
            // 
            this.Blocked.HeaderText = "Blocked";
            this.Blocked.Name = "Blocked";
            // 
            // IN
            // 
            this.IN.HeaderText = "IN";
            this.IN.Name = "IN";
            this.IN.TrueValue = "";
            // 
            // OUT
            // 
            this.OUT.HeaderText = "OUT";
            this.OUT.Name = "OUT";
            // 
            // Strategy
            // 
            this.Strategy.HeaderText = "Strategy";
            this.Strategy.Name = "Strategy";
            this.Strategy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Strategy.Text = "NotSet";
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 2F;
            this.ID.HeaderText = "";
            this.ID.MinimumWidth = 2;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Visible = false;
            this.ID.Width = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(865, 322);
            this.Controls.Add(this.______);
            this.Controls.Add(this.panel1);
            this.Name = "_";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.______)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ______;
        private System.Windows.Forms.Button Browser;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn New;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Blocked;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OUT;
        private System.Windows.Forms.DataGridViewButtonColumn Strategy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

