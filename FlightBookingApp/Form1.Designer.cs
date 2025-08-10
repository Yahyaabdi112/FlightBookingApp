namespace FlightBookingApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldocnum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbid = new System.Windows.Forms.RadioButton();
            this.rbpassport = new System.Windows.Forms.RadioButton();
            this.txtdocnum = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblissuedate = new System.Windows.Forms.Label();
            this.lblexpirydate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(118, 35);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(100, 20);
            this.txtto.TabIndex = 1;
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(355, 35);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(100, 20);
            this.txtfrom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(168, 84);
            this.monthCalendar1.MaxDate = new System.DateTime(2019, 10, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2000, 10, 25, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2018, 10, 20, 0, 0, 0, 0), new System.DateTime(2018, 10, 26, 0, 0, 0, 0));
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(159, 264);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 6;
            this.txtfname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "FirstName:";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(412, 264);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(100, 20);
            this.txtlname.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "MiddleName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Travel Document:";
            // 
            // lbldocnum
            // 
            this.lbldocnum.AutoSize = true;
            this.lbldocnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldocnum.Location = new System.Drawing.Point(449, 313);
            this.lbldocnum.Name = "lbldocnum";
            this.lbldocnum.Size = new System.Drawing.Size(123, 20);
            this.lbldocnum.TabIndex = 10;
            this.lbldocnum.Text = "Document No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbid);
            this.groupBox1.Controls.Add(this.rbpassport);
            this.groupBox1.Location = new System.Drawing.Point(219, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 41);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbid
            // 
            this.rbid.AutoSize = true;
            this.rbid.Location = new System.Drawing.Point(138, 19);
            this.rbid.Name = "rbid";
            this.rbid.Size = new System.Drawing.Size(60, 17);
            this.rbid.TabIndex = 1;
            this.rbid.TabStop = true;
            this.rbid.Text = "ID card";
            this.rbid.UseVisualStyleBackColor = true;
            this.rbid.CheckedChanged += new System.EventHandler(this.rbid_CheckedChanged);
            // 
            // rbpassport
            // 
            this.rbpassport.AutoSize = true;
            this.rbpassport.Location = new System.Drawing.Point(23, 18);
            this.rbpassport.Name = "rbpassport";
            this.rbpassport.Size = new System.Drawing.Size(66, 17);
            this.rbpassport.TabIndex = 0;
            this.rbpassport.TabStop = true;
            this.rbpassport.Text = "Passport";
            this.rbpassport.UseVisualStyleBackColor = true;
            this.rbpassport.CheckedChanged += new System.EventHandler(this.rbpassport_CheckedChanged);
            // 
            // txtdocnum
            // 
            this.txtdocnum.Location = new System.Drawing.Point(578, 313);
            this.txtdocnum.Name = "txtdocnum";
            this.txtdocnum.Size = new System.Drawing.Size(100, 20);
            this.txtdocnum.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 362);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.lblissuedate_ValueChanged);
            // 
            // lblissuedate
            // 
            this.lblissuedate.AutoSize = true;
            this.lblissuedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblissuedate.Location = new System.Drawing.Point(64, 362);
            this.lblissuedate.Name = "lblissuedate";
            this.lblissuedate.Size = new System.Drawing.Size(184, 20);
            this.lblissuedate.TabIndex = 14;
            this.lblissuedate.Text = "Document Issue Date";
            // 
            // lblexpirydate
            // 
            this.lblexpirydate.AutoSize = true;
            this.lblexpirydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpirydate.Location = new System.Drawing.Point(419, 362);
            this.lblexpirydate.Name = "lblexpirydate";
            this.lblexpirydate.Size = new System.Drawing.Size(193, 20);
            this.lblexpirydate.TabIndex = 16;
            this.lblexpirydate.Text = "Document Expiry Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(618, 362);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(159, 402);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Baggage:";
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.Color.IndianRed;
            this.btnbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbook.Location = new System.Drawing.Point(-19, 425);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(840, 34);
            this.btnbook.TabIndex = 19;
            this.btnbook.Text = "Book (without paying)";
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblexpirydate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblissuedate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtdocnum);
            this.Controls.Add(this.lbldocnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldocnum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbid;
        private System.Windows.Forms.RadioButton rbpassport;
        private System.Windows.Forms.TextBox txtdocnum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblissuedate;
        private System.Windows.Forms.Label lblexpirydate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnbook;
    }
}

