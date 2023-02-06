namespace laba6
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.col1 = new System.Windows.Forms.ComboBox();
            this.columnsFirst = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.val1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.columnsSecond = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.col2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.val2 = new System.Windows.Forms.ComboBox();
            this.col3 = new System.Windows.Forms.ComboBox();
            this.val3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.execute1 = new System.Windows.Forms.Button();
            this.execute2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            //this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.columnsThird = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.col4 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pattern = new System.Windows.Forms.TextBox();
            this.execute3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "FROM Database WHERE\r\n";
            // 
            // col1
            // 
            this.col1.FormattingEnabled = true;
            this.col1.Location = new System.Drawing.Point(443, 66);
            this.col1.Name = "col1";
            this.col1.Size = new System.Drawing.Size(121, 28);
            this.col1.TabIndex = 3;
            this.col1.SelectedIndexChanged += new System.EventHandler(this.col1_SelectedIndexChanged);
            // 
            // columnsFirst
            // 
            this.columnsFirst.FormattingEnabled = true;
            this.columnsFirst.Location = new System.Drawing.Point(116, 66);
            this.columnsFirst.Name = "columnsFirst";
            this.columnsFirst.Size = new System.Drawing.Size(120, 96);
            this.columnsFirst.TabIndex = 4;
            this.columnsFirst.SelectedIndexChanged += new System.EventHandler(this.columnsFirst_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            // 
            // val1
            // 
            this.val1.FormattingEnabled = true;
            this.val1.Location = new System.Drawing.Point(614, 66);
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(121, 28);
            this.val1.TabIndex = 6;
            this.val1.SelectedIndexChanged += new System.EventHandler(this.val1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "SELECT";
            // 
            // columnsSecond
            // 
            this.columnsSecond.FormattingEnabled = true;
            this.columnsSecond.Location = new System.Drawing.Point(117, 222);
            this.columnsSecond.Name = "columnsSecond";
            this.columnsSecond.Size = new System.Drawing.Size(120, 96);
            this.columnsSecond.TabIndex = 8;
            this.columnsSecond.SelectedIndexChanged += new System.EventHandler(this.columnsSecond_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "FROM Database WHERE\r\n";
            // 
            // col2
            // 
            this.col2.FormattingEnabled = true;
            this.col2.Location = new System.Drawing.Point(445, 213);
            this.col2.Name = "col2";
            this.col2.Size = new System.Drawing.Size(121, 28);
            this.col2.TabIndex = 10;
            this.col2.SelectedIndexChanged += new System.EventHandler(this.col2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "=";
            // 
            // val2
            // 
            this.val2.FormattingEnabled = true;
            this.val2.Location = new System.Drawing.Point(614, 213);
            this.val2.Name = "val2";
            this.val2.Size = new System.Drawing.Size(121, 28);
            this.val2.TabIndex = 12;
            this.val2.SelectedIndexChanged += new System.EventHandler(this.val2_SelectedIndexChanged);
            // 
            // col3
            // 
            this.col3.FormattingEnabled = true;
            this.col3.Location = new System.Drawing.Point(805, 213);
            this.col3.Name = "col3";
            this.col3.Size = new System.Drawing.Size(121, 28);
            this.col3.TabIndex = 13;
            this.col3.SelectedIndexChanged += new System.EventHandler(this.col3_SelectedIndexChanged);
            // 
            // val3
            // 
            this.val3.FormattingEnabled = true;
            this.val3.Location = new System.Drawing.Point(1000, 213);
            this.val3.Name = "val3";
            this.val3.Size = new System.Drawing.Size(121, 28);
            this.val3.TabIndex = 14;
            this.val3.SelectedIndexChanged += new System.EventHandler(this.val3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(753, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "and";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(955, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "=";
            // 
            // execute1
            // 
            this.execute1.Location = new System.Drawing.Point(805, 60);
            this.execute1.Name = "execute1";
            this.execute1.Size = new System.Drawing.Size(159, 38);
            this.execute1.TabIndex = 17;
            this.execute1.Text = "Execute";
            this.execute1.UseVisualStyleBackColor = true;
            this.execute1.Click += new System.EventHandler(this.execute1_Click);
            // 
            // execute2
            // 
            this.execute2.Location = new System.Drawing.Point(1145, 206);
            this.execute2.Name = "execute2";
            this.execute2.Size = new System.Drawing.Size(142, 41);
            this.execute2.TabIndex = 18;
            this.execute2.Text = "Execute";
            this.execute2.UseVisualStyleBackColor = true;
            this.execute2.Click += new System.EventHandler(this.execute2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(947, 333);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(411, 201);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // textBox1
            // 
            //this.textBox1.Location = new System.Drawing.Point(287, 426);
            //this.textBox1.Multiline = true;
            //this.textBox1.Name = "textBox1";
            //this.textBox1.Size = new System.Drawing.Size(354, 117);
            //this.textBox1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "SELECT";
            // 
            // columnsThird
            // 
            this.columnsThird.FormattingEnabled = true;
            this.columnsThird.Location = new System.Drawing.Point(117, 371);
            this.columnsThird.Name = "columnsThird";
            this.columnsThird.Size = new System.Drawing.Size(120, 119);
            this.columnsThird.TabIndex = 22;
            this.columnsThird.SelectedIndexChanged += new System.EventHandler(this.columnsThird_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "FROM Database WHERE\r\n";
            // 
            // col4
            // 
            this.col4.FormattingEnabled = true;
            this.col4.Location = new System.Drawing.Point(457, 368);
            this.col4.Name = "col4";
            this.col4.Size = new System.Drawing.Size(121, 28);
            this.col4.TabIndex = 24;
            this.col4.SelectedIndexChanged += new System.EventHandler(this.col4_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(597, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "LIKE";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pattern
            // 
            this.pattern.Location = new System.Drawing.Point(657, 365);
            this.pattern.Multiline = true;
            this.pattern.Name = "pattern";
            this.pattern.Size = new System.Drawing.Size(145, 31);
            this.pattern.TabIndex = 26;
            this.pattern.TextChanged += new System.EventHandler(this.pattern_TextChanged);
            // 
            // execute3
            // 
            this.execute3.Location = new System.Drawing.Point(822, 360);
            this.execute3.Name = "execute3";
            this.execute3.Size = new System.Drawing.Size(104, 43);
            this.execute3.TabIndex = 27;
            this.execute3.Text = "Execute";
            this.execute3.UseVisualStyleBackColor = true;
            this.execute3.Click += new System.EventHandler(this.execute3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 565);
            this.Controls.Add(this.execute3);
            this.Controls.Add(this.pattern);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.col4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.columnsThird);
            this.Controls.Add(this.label9);
           // this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.execute2);
            this.Controls.Add(this.execute1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.val3);
            this.Controls.Add(this.col3);
            this.Controls.Add(this.val2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.col2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.columnsSecond);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.val1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.columnsFirst);
            this.Controls.Add(this.col1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "SQL-query";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox col1;
        private System.Windows.Forms.CheckedListBox columnsFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox val1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox columnsSecond;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox col2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox val2;
        private System.Windows.Forms.ComboBox col3;
        private System.Windows.Forms.ComboBox val3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button execute1;
        private System.Windows.Forms.Button execute2;
        private System.Windows.Forms.DataGridView dataGridView2;
       // private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox columnsThird;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox col4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pattern;
        private System.Windows.Forms.Button execute3;
    }
}