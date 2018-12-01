namespace Family_Schedule
{
    partial class CreateSchedule
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
            this.labelDescipt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.labelMsg1 = new System.Windows.Forms.Label();
            this.labelMsg2 = new System.Windows.Forms.Label();
            this.labelMsg3 = new System.Windows.Forms.Label();
            this.labelNoMore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDescipt
            // 
            this.labelDescipt.AutoSize = true;
            this.labelDescipt.Location = new System.Drawing.Point(23, 153);
            this.labelDescipt.Name = "labelDescipt";
            this.labelDescipt.Size = new System.Drawing.Size(91, 13);
            this.labelDescipt.TabIndex = 8;
            this.labelDescipt.Text = "Short Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 9;
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(23, 226);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(124, 13);
            this.labelSelect.TabIndex = 10;
            this.labelSelect.Text = "Select Family Member(s):";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2018, 11, 18, 0, 0, 0, 0);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(24, 24);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(66, 13);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "Select Date:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(14, 356);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 33);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add Event";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(98, 356);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(79, 33);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete Event";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(183, 355);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(88, 34);
            this.buttonView.TabIndex = 19;
            this.buttonView.Text = "View Calendar";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Mom",
            "Dad",
            "Travis",
            "Amy",
            "Ian"});
            this.checkedListBox1.Location = new System.Drawing.Point(27, 242);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(142, 79);
            this.checkedListBox1.TabIndex = 20;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(24, 81);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(58, 13);
            this.labelTime.TabIndex = 21;
            this.labelTime.Text = "Start Time:";
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(27, 97);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(141, 21);
            this.comboBoxTime.TabIndex = 22;
            // 
            // labelMsg1
            // 
            this.labelMsg1.AutoSize = true;
            this.labelMsg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg1.ForeColor = System.Drawing.Color.Red;
            this.labelMsg1.Location = new System.Drawing.Point(28, 121);
            this.labelMsg1.Name = "labelMsg1";
            this.labelMsg1.Size = new System.Drawing.Size(54, 13);
            this.labelMsg1.TabIndex = 23;
            this.labelMsg1.Text = "Hide Me";
            // 
            // labelMsg2
            // 
            this.labelMsg2.AutoSize = true;
            this.labelMsg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg2.ForeColor = System.Drawing.Color.Red;
            this.labelMsg2.Location = new System.Drawing.Point(28, 192);
            this.labelMsg2.Name = "labelMsg2";
            this.labelMsg2.Size = new System.Drawing.Size(54, 13);
            this.labelMsg2.TabIndex = 24;
            this.labelMsg2.Text = "Hide Me";
            // 
            // labelMsg3
            // 
            this.labelMsg3.AutoSize = true;
            this.labelMsg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg3.ForeColor = System.Drawing.Color.Red;
            this.labelMsg3.Location = new System.Drawing.Point(28, 324);
            this.labelMsg3.Name = "labelMsg3";
            this.labelMsg3.Size = new System.Drawing.Size(54, 13);
            this.labelMsg3.TabIndex = 25;
            this.labelMsg3.Text = "Hide Me";
            // 
            // labelNoMore
            // 
            this.labelNoMore.AutoSize = true;
            this.labelNoMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMore.ForeColor = System.Drawing.Color.Red;
            this.labelNoMore.Location = new System.Drawing.Point(28, 403);
            this.labelNoMore.Name = "labelNoMore";
            this.labelNoMore.Size = new System.Drawing.Size(54, 13);
            this.labelNoMore.TabIndex = 26;
            this.labelNoMore.Text = "Hide Me";
            // 
            // CreateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 425);
            this.Controls.Add(this.labelNoMore);
            this.Controls.Add(this.labelMsg3);
            this.Controls.Add(this.labelMsg2);
            this.Controls.Add(this.labelMsg1);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDescipt);
            this.Name = "CreateSchedule";
            this.Text = "Family Schedule";
            this.Load += new System.EventHandler(this.Family_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDescipt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label labelMsg1;
        private System.Windows.Forms.Label labelMsg2;
        private System.Windows.Forms.Label labelMsg3;
        private System.Windows.Forms.Label labelNoMore;
    }
}

