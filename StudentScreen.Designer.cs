namespace ExamSystem
{
    partial class StudentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_signOut = new System.Windows.Forms.Button();
            this.btn_changepassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dept = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_start = new System.Windows.Forms.Button();
            this.cmb_exams = new System.Windows.Forms.ComboBox();
            this.cmb_courses = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_results = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1209, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Brown;
            this.textBox2.Location = new System.Drawing.Point(-1, 649);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1355, 42);
            this.textBox2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(80, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 234);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(-1, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1355, 618);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btn_signOut);
            this.tabPage2.Controls.Add(this.btn_changepassword);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbl_dept);
            this.tabPage2.Controls.Add(this.lbl_age);
            this.tabPage2.Controls.Add(this.lbl_name);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1347, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personal Info";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_signOut
            // 
            this.btn_signOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_signOut.BackgroundImage")));
            this.btn_signOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_signOut.Location = new System.Drawing.Point(1234, 18);
            this.btn_signOut.Name = "btn_signOut";
            this.btn_signOut.Size = new System.Drawing.Size(101, 81);
            this.btn_signOut.TabIndex = 15;
            this.btn_signOut.UseVisualStyleBackColor = true;
            this.btn_signOut.Click += new System.EventHandler(this.btn_signOut_Click);
            // 
            // btn_changepassword
            // 
            this.btn_changepassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_changepassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_changepassword.BackgroundImage")));
            this.btn_changepassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_changepassword.Location = new System.Drawing.Point(1105, 18);
            this.btn_changepassword.Name = "btn_changepassword";
            this.btn_changepassword.Size = new System.Drawing.Size(101, 81);
            this.btn_changepassword.TabIndex = 14;
            this.btn_changepassword.UseVisualStyleBackColor = false;
            this.btn_changepassword.Click += new System.EventHandler(this.btn_changepassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(427, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 81);
            this.label4.TabIndex = 13;
            this.label4.Text = "ITI Student Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(370, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "departement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(370, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 41);
            this.label2.TabIndex = 11;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(370, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student name";
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dept.Location = new System.Drawing.Point(703, 295);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(97, 41);
            this.lbl_dept.TabIndex = 9;
            this.lbl_dept.Text = "label3";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_age.Location = new System.Drawing.Point(703, 209);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(97, 41);
            this.lbl_age.TabIndex = 8;
            this.lbl_age.Text = "label2";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(703, 132);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(97, 41);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "label1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_start);
            this.tabPage1.Controls.Add(this.cmb_exams);
            this.tabPage1.Controls.Add(this.cmb_courses);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1347, 574);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Exams";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_start.Location = new System.Drawing.Point(547, 425);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(201, 74);
            this.btn_start.TabIndex = 12;
            this.btn_start.Text = "Start Exam";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // cmb_exams
            // 
            this.cmb_exams.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_exams.FormattingEnabled = true;
            this.cmb_exams.Location = new System.Drawing.Point(490, 315);
            this.cmb_exams.Name = "cmb_exams";
            this.cmb_exams.Size = new System.Drawing.Size(334, 39);
            this.cmb_exams.TabIndex = 11;
            // 
            // cmb_courses
            // 
            this.cmb_courses.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_courses.FormattingEnabled = true;
            this.cmb_courses.Location = new System.Drawing.Point(490, 194);
            this.cmb_courses.Name = "cmb_courses";
            this.cmb_courses.Size = new System.Drawing.Size(334, 39);
            this.cmb_courses.TabIndex = 10;
            this.cmb_courses.SelectedIndexChanged += new System.EventHandler(this.cmb_courses_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(287, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 41);
            this.label7.TabIndex = 9;
            this.label7.Text = "Exam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(287, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(435, 48);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(389, 81);
            this.label5.TabIndex = 7;
            this.label5.Text = "Choose Exam";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1002, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(221, 237);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_results);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1347, 574);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Grades";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_results
            // 
            this.dgv_results.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_results.Enabled = false;
            this.dgv_results.Location = new System.Drawing.Point(59, 37);
            this.dgv_results.Name = "dgv_results";
            this.dgv_results.ReadOnly = true;
            this.dgv_results.RowHeadersWidth = 51;
            this.dgv_results.RowTemplate.Height = 29;
            this.dgv_results.Size = new System.Drawing.Size(1023, 515);
            this.dgv_results.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1116, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(210, 267);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Brown;
            this.textBox1.Location = new System.Drawing.Point(-5, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1359, 39);
            this.textBox1.TabIndex = 8;
            // 
            // StudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 687);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox2);
            this.Name = "StudentScreen";
            this.Text = "StudentScreen";
            this.Load += new System.EventHandler(this.StudentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label lbl_age;
        private Label lbl_name;
        private TabPage tabPage1;
        private PictureBox pictureBox3;
        private TabPage tabPage3;
        private PictureBox pictureBox4;
        private Label lbl_dept;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button btn_start;
        private ComboBox cmb_exams;
        private ComboBox cmb_courses;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgv_results;
        private Button btn_signOut;
        private Button btn_changepassword;
    }
}