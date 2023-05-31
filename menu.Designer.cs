namespace decanat.obj
{
    partial class menu
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
            tabControl_menu = new TabControl();
            tabControl_student = new TabPage();
            dataGridView_student = new DataGridView();
            button_update_student = new Button();
            groupBox_student = new GroupBox();
            button_delete_student = new Button();
            button_edit_student = new Button();
            button_add_student = new Button();
            tabControl_disciplines = new TabPage();
            dataGridView_disciplines = new DataGridView();
            groupBox_disciplines = new GroupBox();
            button_delete_disciplines = new Button();
            button_edit_disciplines = new Button();
            button_add_disciplines = new Button();
            button_update_disciplines = new Button();
            tabControl_evaluations = new TabPage();
            dataGridView_evaluations = new DataGridView();
            button_update_evaluations = new Button();
            groupBox_evaluations = new GroupBox();
            button_delete_evaluations = new Button();
            button_edit_evaluations = new Button();
            button_add_evaluations = new Button();
            tabPage1 = new TabPage();
            label_student = new Label();
            comboBox_student = new ComboBox();
            button_student = new Button();
            dataGridView1 = new DataGridView();
            tabControl_menu.SuspendLayout();
            tabControl_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).BeginInit();
            groupBox_student.SuspendLayout();
            tabControl_disciplines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_disciplines).BeginInit();
            groupBox_disciplines.SuspendLayout();
            tabControl_evaluations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_evaluations).BeginInit();
            groupBox_evaluations.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl_menu
            // 
            tabControl_menu.Controls.Add(tabControl_student);
            tabControl_menu.Controls.Add(tabControl_disciplines);
            tabControl_menu.Controls.Add(tabControl_evaluations);
            tabControl_menu.Controls.Add(tabPage1);
            tabControl_menu.Dock = DockStyle.Fill;
            tabControl_menu.Location = new Point(0, 0);
            tabControl_menu.Name = "tabControl_menu";
            tabControl_menu.SelectedIndex = 0;
            tabControl_menu.Size = new Size(601, 450);
            tabControl_menu.TabIndex = 0;
            tabControl_menu.SelectedIndexChanged += tabControl_menu_SelectedIndexChanged;
            // 
            // tabControl_student
            // 
            tabControl_student.Controls.Add(dataGridView_student);
            tabControl_student.Controls.Add(button_update_student);
            tabControl_student.Controls.Add(groupBox_student);
            tabControl_student.Location = new Point(4, 24);
            tabControl_student.Name = "tabControl_student";
            tabControl_student.Padding = new Padding(3);
            tabControl_student.Size = new Size(593, 422);
            tabControl_student.TabIndex = 0;
            tabControl_student.Text = "Студенты";
            tabControl_student.UseVisualStyleBackColor = true;
            // 
            // dataGridView_student
            // 
            dataGridView_student.AllowUserToAddRows = false;
            dataGridView_student.AllowUserToDeleteRows = false;
            dataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_student.Location = new Point(12, 65);
            dataGridView_student.Name = "dataGridView_student";
            dataGridView_student.ReadOnly = true;
            dataGridView_student.RowTemplate.Height = 25;
            dataGridView_student.Size = new Size(550, 327);
            dataGridView_student.TabIndex = 0;
            // 
            // button_update_student
            // 
            button_update_student.Location = new Point(263, 27);
            button_update_student.Name = "button_update_student";
            button_update_student.Size = new Size(75, 23);
            button_update_student.TabIndex = 0;
            button_update_student.Text = "Обновить";
            button_update_student.UseVisualStyleBackColor = true;
            button_update_student.Click += button_update_student_Click;
            // 
            // groupBox_student
            // 
            groupBox_student.Controls.Add(button_delete_student);
            groupBox_student.Controls.Add(button_edit_student);
            groupBox_student.Controls.Add(button_add_student);
            groupBox_student.Location = new Point(6, 6);
            groupBox_student.Name = "groupBox_student";
            groupBox_student.Size = new Size(251, 53);
            groupBox_student.TabIndex = 0;
            groupBox_student.TabStop = false;
            groupBox_student.Text = "Управление";
            // 
            // button_delete_student
            // 
            button_delete_student.Location = new Point(168, 21);
            button_delete_student.Name = "button_delete_student";
            button_delete_student.Size = new Size(75, 23);
            button_delete_student.TabIndex = 0;
            button_delete_student.Text = "Удалить";
            button_delete_student.UseVisualStyleBackColor = true;
            button_delete_student.Click += button_delete_student_Click;
            // 
            // button_edit_student
            // 
            button_edit_student.Location = new Point(87, 22);
            button_edit_student.Name = "button_edit_student";
            button_edit_student.Size = new Size(75, 23);
            button_edit_student.TabIndex = 0;
            button_edit_student.Text = "Изменить";
            button_edit_student.UseVisualStyleBackColor = true;
            button_edit_student.Click += button_edit_student_Click;
            // 
            // button_add_student
            // 
            button_add_student.Location = new Point(6, 22);
            button_add_student.Name = "button_add_student";
            button_add_student.Size = new Size(75, 23);
            button_add_student.TabIndex = 0;
            button_add_student.Text = "Добавить";
            button_add_student.UseVisualStyleBackColor = true;
            button_add_student.Click += button_add_student_Click;
            // 
            // tabControl_disciplines
            // 
            tabControl_disciplines.Controls.Add(dataGridView_disciplines);
            tabControl_disciplines.Controls.Add(groupBox_disciplines);
            tabControl_disciplines.Controls.Add(button_update_disciplines);
            tabControl_disciplines.Location = new Point(4, 24);
            tabControl_disciplines.Name = "tabControl_disciplines";
            tabControl_disciplines.Padding = new Padding(3);
            tabControl_disciplines.Size = new Size(593, 422);
            tabControl_disciplines.TabIndex = 1;
            tabControl_disciplines.Text = "Дисциплины";
            tabControl_disciplines.UseVisualStyleBackColor = true;
            // 
            // dataGridView_disciplines
            // 
            dataGridView_disciplines.AllowUserToAddRows = false;
            dataGridView_disciplines.AllowUserToDeleteRows = false;
            dataGridView_disciplines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_disciplines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_disciplines.Location = new Point(12, 66);
            dataGridView_disciplines.Name = "dataGridView_disciplines";
            dataGridView_disciplines.ReadOnly = true;
            dataGridView_disciplines.RowTemplate.Height = 25;
            dataGridView_disciplines.Size = new Size(550, 326);
            dataGridView_disciplines.TabIndex = 1;
            // 
            // groupBox_disciplines
            // 
            groupBox_disciplines.Controls.Add(button_delete_disciplines);
            groupBox_disciplines.Controls.Add(button_edit_disciplines);
            groupBox_disciplines.Controls.Add(button_add_disciplines);
            groupBox_disciplines.Location = new Point(6, 6);
            groupBox_disciplines.Name = "groupBox_disciplines";
            groupBox_disciplines.Size = new Size(251, 54);
            groupBox_disciplines.TabIndex = 1;
            groupBox_disciplines.TabStop = false;
            groupBox_disciplines.Text = "Дисциплины";
            // 
            // button_delete_disciplines
            // 
            button_delete_disciplines.Location = new Point(168, 22);
            button_delete_disciplines.Name = "button_delete_disciplines";
            button_delete_disciplines.Size = new Size(75, 23);
            button_delete_disciplines.TabIndex = 1;
            button_delete_disciplines.Text = "Удалить";
            button_delete_disciplines.UseVisualStyleBackColor = true;
            button_delete_disciplines.Click += button_delete_disciplines_Click;
            // 
            // button_edit_disciplines
            // 
            button_edit_disciplines.Location = new Point(87, 22);
            button_edit_disciplines.Name = "button_edit_disciplines";
            button_edit_disciplines.Size = new Size(75, 23);
            button_edit_disciplines.TabIndex = 1;
            button_edit_disciplines.Text = "Изменить";
            button_edit_disciplines.UseVisualStyleBackColor = true;
            button_edit_disciplines.Click += button_edit_disciplines_Click;
            // 
            // button_add_disciplines
            // 
            button_add_disciplines.Location = new Point(6, 22);
            button_add_disciplines.Name = "button_add_disciplines";
            button_add_disciplines.Size = new Size(75, 23);
            button_add_disciplines.TabIndex = 1;
            button_add_disciplines.Text = "Добавить";
            button_add_disciplines.UseVisualStyleBackColor = true;
            button_add_disciplines.Click += button_add_disciplines_Click;
            // 
            // button_update_disciplines
            // 
            button_update_disciplines.Location = new Point(263, 28);
            button_update_disciplines.Name = "button_update_disciplines";
            button_update_disciplines.Size = new Size(75, 23);
            button_update_disciplines.TabIndex = 1;
            button_update_disciplines.Text = "Обновить";
            button_update_disciplines.UseVisualStyleBackColor = true;
            button_update_disciplines.Click += button_update_disciplines_Click;
            // 
            // tabControl_evaluations
            // 
            tabControl_evaluations.Controls.Add(dataGridView_evaluations);
            tabControl_evaluations.Controls.Add(button_update_evaluations);
            tabControl_evaluations.Controls.Add(groupBox_evaluations);
            tabControl_evaluations.Location = new Point(4, 24);
            tabControl_evaluations.Name = "tabControl_evaluations";
            tabControl_evaluations.Padding = new Padding(3);
            tabControl_evaluations.Size = new Size(593, 422);
            tabControl_evaluations.TabIndex = 2;
            tabControl_evaluations.Text = "Оценки";
            tabControl_evaluations.UseVisualStyleBackColor = true;
            // 
            // dataGridView_evaluations
            // 
            dataGridView_evaluations.AllowUserToAddRows = false;
            dataGridView_evaluations.AllowUserToDeleteRows = false;
            dataGridView_evaluations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_evaluations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_evaluations.Location = new Point(12, 64);
            dataGridView_evaluations.Name = "dataGridView_evaluations";
            dataGridView_evaluations.ReadOnly = true;
            dataGridView_evaluations.RowTemplate.Height = 25;
            dataGridView_evaluations.Size = new Size(550, 328);
            dataGridView_evaluations.TabIndex = 2;
            // 
            // button_update_evaluations
            // 
            button_update_evaluations.Location = new Point(262, 28);
            button_update_evaluations.Name = "button_update_evaluations";
            button_update_evaluations.Size = new Size(75, 23);
            button_update_evaluations.TabIndex = 2;
            button_update_evaluations.Text = "Обновить";
            button_update_evaluations.UseVisualStyleBackColor = true;
            button_update_evaluations.Click += button_update_evaluations_Click;
            // 
            // groupBox_evaluations
            // 
            groupBox_evaluations.Controls.Add(button_delete_evaluations);
            groupBox_evaluations.Controls.Add(button_edit_evaluations);
            groupBox_evaluations.Controls.Add(button_add_evaluations);
            groupBox_evaluations.Location = new Point(6, 6);
            groupBox_evaluations.Name = "groupBox_evaluations";
            groupBox_evaluations.Size = new Size(250, 52);
            groupBox_evaluations.TabIndex = 2;
            groupBox_evaluations.TabStop = false;
            groupBox_evaluations.Text = "Оценки";
            // 
            // button_delete_evaluations
            // 
            button_delete_evaluations.Location = new Point(168, 22);
            button_delete_evaluations.Name = "button_delete_evaluations";
            button_delete_evaluations.Size = new Size(75, 23);
            button_delete_evaluations.TabIndex = 2;
            button_delete_evaluations.Text = "Удалить";
            button_delete_evaluations.UseVisualStyleBackColor = true;
            button_delete_evaluations.Click += button_delete_evaluations_Click;
            // 
            // button_edit_evaluations
            // 
            button_edit_evaluations.Location = new Point(87, 22);
            button_edit_evaluations.Name = "button_edit_evaluations";
            button_edit_evaluations.Size = new Size(75, 23);
            button_edit_evaluations.TabIndex = 2;
            button_edit_evaluations.Text = "Изменить";
            button_edit_evaluations.UseVisualStyleBackColor = true;
            button_edit_evaluations.Click += button_edit_evaluations_Click;
            // 
            // button_add_evaluations
            // 
            button_add_evaluations.Location = new Point(6, 22);
            button_add_evaluations.Name = "button_add_evaluations";
            button_add_evaluations.Size = new Size(75, 23);
            button_add_evaluations.TabIndex = 2;
            button_add_evaluations.Text = "Добавить";
            button_add_evaluations.UseVisualStyleBackColor = true;
            button_add_evaluations.Click += button_add_evaluations_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label_student);
            tabPage1.Controls.Add(comboBox_student);
            tabPage1.Controls.Add(button_student);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(593, 422);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Отчет по студенту";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_student
            // 
            label_student.AutoSize = true;
            label_student.Location = new Point(33, 37);
            label_student.Name = "label_student";
            label_student.Size = new Size(111, 15);
            label_student.TabIndex = 3;
            label_student.Text = "Выберите студента";
            // 
            // comboBox_student
            // 
            comboBox_student.FormattingEnabled = true;
            comboBox_student.Location = new Point(170, 34);
            comboBox_student.Name = "comboBox_student";
            comboBox_student.Size = new Size(415, 23);
            comboBox_student.TabIndex = 2;
            // 
            // button_student
            // 
            button_student.Location = new Point(330, 63);
            button_student.Name = "button_student";
            button_student.Size = new Size(255, 23);
            button_student.TabIndex = 1;
            button_student.Text = "Сформировать отчет";
            button_student.UseVisualStyleBackColor = true;
            button_student.Click += button_student_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(577, 304);
            dataGridView1.TabIndex = 0;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(tabControl_menu);
            Name = "menu";
            Text = "Меню";
            Load += button_update_student_Click;
            tabControl_menu.ResumeLayout(false);
            tabControl_student.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).EndInit();
            groupBox_student.ResumeLayout(false);
            tabControl_disciplines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_disciplines).EndInit();
            groupBox_disciplines.ResumeLayout(false);
            tabControl_evaluations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_evaluations).EndInit();
            groupBox_evaluations.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_menu;
        private TabPage tabControl_student;
        private GroupBox groupBox_student;
        private TabPage tabControl_disciplines;
        private TabPage tabControl_evaluations;
        private Button button_add_student;
        private Button button_edit_student;
        private Button button_delete_student;
        private Button button_update_student;
        private Button button_update_disciplines;
        private GroupBox groupBox_disciplines;
        private GroupBox groupBox_evaluations;
        private Button button_add_disciplines;
        private Button button_edit_disciplines;
        private Button button_delete_disciplines;
        private Button button_edit_evaluations;
        private Button button_add_evaluations;
        private Button button_delete_evaluations;
        private Button button_update_evaluations;
        private DataGridView dataGridView_student;
        private DataGridView dataGridView_disciplines;
        private DataGridView dataGridView_evaluations;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Label label_student;
        private ComboBox comboBox_student;
        private Button button_student;
    }
}