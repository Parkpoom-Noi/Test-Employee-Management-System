namespace Employee_Management_System_VC
{
    partial class frmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.tbID = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(275, 33);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(72, 23);
            this.tbID.TabIndex = 46;
            this.tbID.Visible = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label8.Location = new System.Drawing.Point(10, 19);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(200, 37);
            this.Label8.TabIndex = 45;
            this.Label8.Text = "Edit Employee";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Location = new System.Drawing.Point(10, 61);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(337, 15);
            this.Label7.TabIndex = 44;
            this.Label7.Text = "__________________________________________________________________";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.Blue;
            this.Label6.Location = new System.Drawing.Point(13, 373);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(337, 15);
            this.Label6.TabIndex = 43;
            this.Label6.Text = "__________________________________________________________________";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(253, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(10, 346);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(337, 23);
            this.cbPosition.TabIndex = 40;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.rbFemale);
            this.Panel1.Controls.Add(this.rbMale);
            this.Panel1.Location = new System.Drawing.Point(10, 261);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(337, 54);
            this.Panel1.TabIndex = 39;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(142, 15);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 19);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(3, 15);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 19);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 328);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 15);
            this.Label5.TabIndex = 38;
            this.Label5.Text = "Position :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 243);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 15);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "Gender :";
            // 
            // dtpBirth
            // 
            this.dtpBirth.CustomFormat = "";
            this.dtpBirth.Location = new System.Drawing.Point(10, 213);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(337, 23);
            this.dtpBirth.TabIndex = 36;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 195);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(57, 15);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Birthday :";
            // 
            // tbSname
            // 
            this.tbSname.Location = new System.Drawing.Point(10, 158);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(337, 23);
            this.tbSname.TabIndex = 34;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 140);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 15);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "Surname :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(10, 107);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(337, 23);
            this.tbName.TabIndex = 32;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 89);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 15);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "Name :";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(361, 445);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEdit";
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tbID;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.ComboBox cbPosition;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.RadioButton rbFemale;
        internal System.Windows.Forms.RadioButton rbMale;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker dtpBirth;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tbSname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox tbName;
        internal System.Windows.Forms.Label Label1;
    }
}