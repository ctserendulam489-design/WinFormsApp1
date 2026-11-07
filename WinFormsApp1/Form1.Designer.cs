namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TreeNode treeNode11 = new TreeNode("Компьютерын ухаан, ");
            TreeNode treeNode12 = new TreeNode("Программ хангамж");
            TreeNode treeNode13 = new TreeNode("Мэдээллийн технологи", new TreeNode[] { treeNode12 });
            TreeNode treeNode14 = new TreeNode("Математик");
            TreeNode treeNode15 = new TreeNode("Байгалийн ухааны сургууль", new TreeNode[] { treeNode11, treeNode13, treeNode14 });
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            Програмчлал = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            treeView1 = new TreeView();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(610, 45);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(423, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(92, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Цэвэрлэх ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(12, 52);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Тэтгэлэгтэй ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 9);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 3;
            label2.Text = "Нийт:1 ";
            label2.Click += label2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 87);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(172, 29);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Өдрийн сургалт ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Програмчлал
            // 
            Програмчлал.FormattingEnabled = true;
            Програмчлал.Items.AddRange(new object[] { "Програмчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            Програмчлал.Location = new Point(12, 122);
            Програмчлал.Name = "Програмчлал";
            Програмчлал.Size = new Size(180, 144);
            Програмчлал.TabIndex = 8;
            Програмчлал.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Монгол", "Англи", "Орос", "Хятад", "Япон", "Солонгос" });
            checkedListBox1.Location = new Point(232, 75);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(157, 116);
            checkedListBox1.TabIndex = 9;
            checkedListBox1.ThreeDCheckBoxes = true;
            checkedListBox1.UseWaitCursor = true;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged_1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 284);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 21, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Мэдээллийн технологи " });
            comboBox2.Location = new Point(12, 369);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 33);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 408);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 31);
            textBox1.TabIndex = 14;
            textBox1.Text = "91510526";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(143, 34);
            button1.TabIndex = 15;
            button1.Text = "M.IT24D041";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(20, 529);
            button2.Name = "button2";
            button2.Size = new Size(164, 45);
            button2.TabIndex = 16;
            button2.Text = "Бүртгэх ";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(232, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 445);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 31);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(423, 207);
            treeView1.Name = "treeView1";
            treeNode11.Name = "Node1";
            treeNode11.Text = "Компьютерын ухаан, ";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Программ хангамж";
            treeNode13.Name = "Node2";
            treeNode13.Text = "Мэдээллийн технологи";
            treeNode14.Name = "Node4";
            treeNode14.Text = "Математик";
            treeNode15.Name = "Node0";
            treeNode15.Text = "Байгалийн ухааны сургууль";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode15 });
            treeView1.Size = new Size(346, 195);
            treeView1.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(232, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 203);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 166);
            label9.Name = "label9";
            label9.Size = new Size(126, 25);
            label9.TabIndex = 6;
            label9.Text = "Тэтгэлэг: Тийм";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 141);
            label8.Name = "label8";
            label8.Size = new Size(255, 25);
            label8.TabIndex = 5;
            label8.Text = "Хичээл: Визуаль програмчлал";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 116);
            label7.Name = "label7";
            label7.Size = new Size(212, 25);
            label7.TabIndex = 4;
            label7.Text = "Төрсөн өдөр:2007.05.26";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 91);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 3;
            label6.Text = "Нас:19";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 66);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 2;
            label5.Text = "Утас:91510526";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 41);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 1;
            label4.Text = "Код: M.IT24D041";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(197, 23);
            label3.TabIndex = 0;
            label3.Text = "ОЮУТНЫ БҮРТГЭЛ";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colName, colPhone });
            dataGridView2.Location = new Point(421, 61);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(316, 117);
            dataGridView2.TabIndex = 21;
            // 
            // colName
            // 
            colName.HeaderText = "Овог нэр";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.Width = 150;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Утас";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.Width = 150;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(20, 634);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(736, 29);
            progressBar1.TabIndex = 22;
            progressBar1.Value = 100;
            progressBar1.Click += progressBar1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 675);
            Controls.Add(progressBar1);
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            Controls.Add(treeView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(checkedListBox1);
            Controls.Add(Програмчлал);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Label label2;
        private RadioButton radioButton1;
        private CheckedListBox Програмчлал;
        private CheckedListBox checkedListBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private TreeView treeView1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private DataGridViewTextBoxColumn а;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private ProgressBar progressBar1;
    }
}
