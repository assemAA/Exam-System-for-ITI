namespace ExamSystem
{
    partial class FinalExamScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalExamScreen));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_question = new System.Windows.Forms.Label();
            this.rdn_chOne = new System.Windows.Forms.RadioButton();
            this.btn_submit = new System.Windows.Forms.Button();
            this.dgv_ans = new System.Windows.Forms.DataGridView();
            this.rdn_chTwo = new System.Windows.Forms.RadioButton();
            this.rdn_chThree = new System.Windows.Forms.RadioButton();
            this.rdn_chFour = new System.Windows.Forms.RadioButton();
            this.lbl_tittle = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ans)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Brown;
            this.textBox1.Location = new System.Drawing.Point(0, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1645, 37);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Brown;
            this.textBox2.Location = new System.Drawing.Point(-4, 674);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1649, 42);
            this.textBox2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1490, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_question.Location = new System.Drawing.Point(51, 198);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(97, 41);
            this.lbl_question.TabIndex = 12;
            this.lbl_question.Text = "label1";
            // 
            // rdn_chOne
            // 
            this.rdn_chOne.AutoSize = true;
            this.rdn_chOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdn_chOne.Location = new System.Drawing.Point(51, 302);
            this.rdn_chOne.Name = "rdn_chOne";
            this.rdn_chOne.Size = new System.Drawing.Size(149, 32);
            this.rdn_chOne.TabIndex = 13;
            this.rdn_chOne.TabStop = true;
            this.rdn_chOne.Text = "radioButton1";
            this.rdn_chOne.UseVisualStyleBackColor = true;
            this.rdn_chOne.CheckedChanged += new System.EventHandler(this.rdn_chOne_CheckedChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Ivory;
            this.btn_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_submit.BackgroundImage")));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_submit.Location = new System.Drawing.Point(920, 302);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(302, 190);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // dgv_ans
            // 
            this.dgv_ans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ans.Location = new System.Drawing.Point(526, 184);
            this.dgv_ans.Name = "dgv_ans";
            this.dgv_ans.RowHeadersWidth = 51;
            this.dgv_ans.RowTemplate.Height = 29;
            this.dgv_ans.Size = new System.Drawing.Size(570, 362);
            this.dgv_ans.TabIndex = 15;
            this.dgv_ans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ans_CellContentClick);
            // 
            // rdn_chTwo
            // 
            this.rdn_chTwo.AutoSize = true;
            this.rdn_chTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdn_chTwo.Location = new System.Drawing.Point(51, 365);
            this.rdn_chTwo.Name = "rdn_chTwo";
            this.rdn_chTwo.Size = new System.Drawing.Size(149, 32);
            this.rdn_chTwo.TabIndex = 16;
            this.rdn_chTwo.TabStop = true;
            this.rdn_chTwo.Text = "radioButton2";
            this.rdn_chTwo.UseVisualStyleBackColor = true;
            this.rdn_chTwo.CheckedChanged += new System.EventHandler(this.rdn_chTwo_CheckedChanged);
            // 
            // rdn_chThree
            // 
            this.rdn_chThree.AutoSize = true;
            this.rdn_chThree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdn_chThree.Location = new System.Drawing.Point(51, 428);
            this.rdn_chThree.Name = "rdn_chThree";
            this.rdn_chThree.Size = new System.Drawing.Size(149, 32);
            this.rdn_chThree.TabIndex = 17;
            this.rdn_chThree.TabStop = true;
            this.rdn_chThree.Text = "radioButton3";
            this.rdn_chThree.UseVisualStyleBackColor = true;
            this.rdn_chThree.CheckedChanged += new System.EventHandler(this.rdn_chThree_CheckedChanged);
            // 
            // rdn_chFour
            // 
            this.rdn_chFour.AutoSize = true;
            this.rdn_chFour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdn_chFour.Location = new System.Drawing.Point(51, 496);
            this.rdn_chFour.Name = "rdn_chFour";
            this.rdn_chFour.Size = new System.Drawing.Size(149, 32);
            this.rdn_chFour.TabIndex = 18;
            this.rdn_chFour.TabStop = true;
            this.rdn_chFour.Text = "radioButton4";
            this.rdn_chFour.UseVisualStyleBackColor = true;
            this.rdn_chFour.CheckedChanged += new System.EventHandler(this.rdn_chFour_CheckedChanged);
            // 
            // lbl_tittle
            // 
            this.lbl_tittle.AutoSize = true;
            this.lbl_tittle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tittle.Location = new System.Drawing.Point(421, 53);
            this.lbl_tittle.Name = "lbl_tittle";
            this.lbl_tittle.Size = new System.Drawing.Size(130, 54);
            this.lbl_tittle.TabIndex = 19;
            this.lbl_tittle.Text = "label2";
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_next.BackgroundImage")));
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.Location = new System.Drawing.Point(337, 583);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(110, 75);
            this.btn_next.TabIndex = 20;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(90, 583);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(110, 75);
            this.btn_back.TabIndex = 21;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_time.Location = new System.Drawing.Point(1083, 66);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(108, 54);
            this.lbl_time.TabIndex = 22;
            this.lbl_time.Text = "label";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FinalExamScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1644, 713);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_tittle);
            this.Controls.Add(this.rdn_chFour);
            this.Controls.Add(this.rdn_chThree);
            this.Controls.Add(this.rdn_chTwo);
            this.Controls.Add(this.dgv_ans);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.rdn_chOne);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "FinalExamScreen";
            this.Text = "FinalExamScreen";
            this.Load += new System.EventHandler(this.FinalExamScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label lbl_question;
        private RadioButton rdn_chOne;
        private Button btn_submit;
        private DataGridView dgv_ans;
        private RadioButton rdn_chTwo;
        private RadioButton rdn_chThree;
        private RadioButton rdn_chFour;
        private Label lbl_tittle;
        private Button btn_next;
        private Button btn_back;
        private Label lbl_time;
        private System.Windows.Forms.Timer timer;
    }
}