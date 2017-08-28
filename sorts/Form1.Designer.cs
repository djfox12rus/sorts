namespace sorts
{
    partial class Sorting_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sorting_tab = new System.Windows.Forms.TabControl();
            this.Sorting_test = new System.Windows.Forms.TabPage();
            this.Arr_output = new System.Windows.Forms.RichTextBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Start_button = new System.Windows.Forms.Button();
            this.Arr_input = new System.Windows.Forms.RichTextBox();
            this.Arr_input_check = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Arr_size = new System.Windows.Forms.TextBox();
            this.Arr_range_max = new System.Windows.Forms.TextBox();
            this.Arr_range_min = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Arr_rand_check = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sort_choose = new System.Windows.Forms.CheckedListBox();
            this.Speed_test = new System.Windows.Forms.TabPage();
            this.Sorting_tab.SuspendLayout();
            this.Sorting_test.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sorting_tab
            // 
            this.Sorting_tab.Controls.Add(this.Sorting_test);
            this.Sorting_tab.Controls.Add(this.Speed_test);
            this.Sorting_tab.Location = new System.Drawing.Point(3, 4);
            this.Sorting_tab.Name = "Sorting_tab";
            this.Sorting_tab.SelectedIndex = 0;
            this.Sorting_tab.Size = new System.Drawing.Size(877, 594);
            this.Sorting_tab.TabIndex = 0;
            // 
            // Sorting_test
            // 
            this.Sorting_test.BackColor = System.Drawing.Color.Silver;
            this.Sorting_test.Controls.Add(this.Arr_output);
            this.Sorting_test.Controls.Add(this.Clear_button);
            this.Sorting_test.Controls.Add(this.Start_button);
            this.Sorting_test.Controls.Add(this.Arr_input);
            this.Sorting_test.Controls.Add(this.Arr_input_check);
            this.Sorting_test.Controls.Add(this.label4);
            this.Sorting_test.Controls.Add(this.Arr_size);
            this.Sorting_test.Controls.Add(this.Arr_range_max);
            this.Sorting_test.Controls.Add(this.Arr_range_min);
            this.Sorting_test.Controls.Add(this.label3);
            this.Sorting_test.Controls.Add(this.label2);
            this.Sorting_test.Controls.Add(this.Arr_rand_check);
            this.Sorting_test.Controls.Add(this.label1);
            this.Sorting_test.Controls.Add(this.Sort_choose);
            this.Sorting_test.Location = new System.Drawing.Point(4, 26);
            this.Sorting_test.Name = "Sorting_test";
            this.Sorting_test.Padding = new System.Windows.Forms.Padding(3);
            this.Sorting_test.Size = new System.Drawing.Size(869, 564);
            this.Sorting_test.TabIndex = 0;
            this.Sorting_test.Text = "Тест сортировок";
            // 
            // Arr_output
            // 
            this.Arr_output.Location = new System.Drawing.Point(3, 326);
            this.Arr_output.Name = "Arr_output";
            this.Arr_output.ReadOnly = true;
            this.Arr_output.Size = new System.Drawing.Size(863, 235);
            this.Arr_output.TabIndex = 13;
            this.Arr_output.Text = "";
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(490, 284);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(197, 35);
            this.Clear_button.TabIndex = 12;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(287, 284);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(197, 35);
            this.Start_button.TabIndex = 11;
            this.Start_button.Text = "Старт";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Arr_input
            // 
            this.Arr_input.Location = new System.Drawing.Point(288, 129);
            this.Arr_input.Name = "Arr_input";
            this.Arr_input.ReadOnly = true;
            this.Arr_input.Size = new System.Drawing.Size(578, 149);
            this.Arr_input.TabIndex = 10;
            this.Arr_input.Text = "54,32,41,12,2,8,7,3,1,4,6,9,15,78,3,9,16,65,41,2,3,64,1";
            // 
            // Arr_input_check
            // 
            this.Arr_input_check.AutoSize = true;
            this.Arr_input_check.Location = new System.Drawing.Point(289, 101);
            this.Arr_input_check.Name = "Arr_input_check";
            this.Arr_input_check.Size = new System.Drawing.Size(379, 21);
            this.Arr_input_check.TabIndex = 9;
            this.Arr_input_check.Text = "Введите элементы массива, разделённые пробелом:";
            this.Arr_input_check.UseVisualStyleBackColor = true;
            this.Arr_input_check.CheckedChanged += new System.EventHandler(this.Arr_input_check_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "или";
            // 
            // Arr_size
            // 
            this.Arr_size.Location = new System.Drawing.Point(529, 25);
            this.Arr_size.Name = "Arr_size";
            this.Arr_size.ReadOnly = true;
            this.Arr_size.Size = new System.Drawing.Size(128, 23);
            this.Arr_size.TabIndex = 7;
            // 
            // Arr_range_max
            // 
            this.Arr_range_max.Location = new System.Drawing.Point(596, 53);
            this.Arr_range_max.Name = "Arr_range_max";
            this.Arr_range_max.ReadOnly = true;
            this.Arr_range_max.Size = new System.Drawing.Size(61, 23);
            this.Arr_range_max.TabIndex = 6;
            // 
            // Arr_range_min
            // 
            this.Arr_range_min.Location = new System.Drawing.Point(529, 53);
            this.Arr_range_min.Name = "Arr_range_min";
            this.Arr_range_min.ReadOnly = true;
            this.Arr_range_min.Size = new System.Drawing.Size(61, 23);
            this.Arr_range_min.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Задайте интервал для элементов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите размер массива:";
            // 
            // Arr_rand_check
            // 
            this.Arr_rand_check.AutoSize = true;
            this.Arr_rand_check.Location = new System.Drawing.Point(290, 6);
            this.Arr_rand_check.Name = "Arr_rand_check";
            this.Arr_rand_check.Size = new System.Drawing.Size(248, 21);
            this.Arr_rand_check.TabIndex = 2;
            this.Arr_rand_check.Text = "Сформируйте случайный массив:";
            this.Arr_rand_check.UseVisualStyleBackColor = true;
            this.Arr_rand_check.CheckedChanged += new System.EventHandler(this.Arr_rand_check_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите сортировку:";
            // 
            // Sort_choose
            // 
            this.Sort_choose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Sort_choose.CheckOnClick = true;
            this.Sort_choose.FormattingEnabled = true;
            this.Sort_choose.Items.AddRange(new object[] {
            "Сортировка пузырьком",
            "Сортировка вставками ",
            "Сортировка слиянием (списком)",
            "Сортировка деревом",
            "Корзинная сортировка",
            "Поразрядная сортировка (radix MSD)",
            "Поразрядная сортировка (radix LSD)",
            "Сортировка выбором ",
            "Сортировка расчёской ",
            "Сортировка Шелла",
            "Пирамидальная сортировка",
            "Плавная сортировка ",
            "Быстрая сортировка",
            "Интроспективная сортировка",
            "Терпеливая сортировка ",
            "Бусики!"});
            this.Sort_choose.Location = new System.Drawing.Point(3, 27);
            this.Sort_choose.Name = "Sort_choose";
            this.Sort_choose.Size = new System.Drawing.Size(278, 292);
            this.Sort_choose.TabIndex = 0;
            this.Sort_choose.SelectedIndexChanged += new System.EventHandler(this.Sort_choose_SelectedIndexChanged);
            // 
            // Speed_test
            // 
            this.Speed_test.BackColor = System.Drawing.Color.Silver;
            this.Speed_test.Location = new System.Drawing.Point(4, 26);
            this.Speed_test.Name = "Speed_test";
            this.Speed_test.Padding = new System.Windows.Forms.Padding(3);
            this.Speed_test.Size = new System.Drawing.Size(869, 564);
            this.Speed_test.TabIndex = 1;
            this.Speed_test.Text = "Тест скорости";
            // 
            // Sorting_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 598);
            this.Controls.Add(this.Sorting_tab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sorting_form";
            this.Text = "Sorting";
            this.Sorting_tab.ResumeLayout(false);
            this.Sorting_test.ResumeLayout(false);
            this.Sorting_test.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Sorting_tab;
        private System.Windows.Forms.TabPage Sorting_test;
        private System.Windows.Forms.RichTextBox Arr_output;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.RichTextBox Arr_input;
        private System.Windows.Forms.CheckBox Arr_input_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Arr_size;
        private System.Windows.Forms.TextBox Arr_range_max;
        private System.Windows.Forms.TextBox Arr_range_min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Arr_rand_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Sort_choose;
        private System.Windows.Forms.TabPage Speed_test;
    }
}

