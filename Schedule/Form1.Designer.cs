namespace Schedule
{
    partial class FormSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedule));
            this.grid_week = new System.Windows.Forms.DataGridView();
            this.co_ring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_week)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_week
            // 
            this.grid_week.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_week.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_week.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.co_ring,
            this.co_day1,
            this.co_day2,
            this.co_day3,
            this.co_day4,
            this.co_day5});
            this.grid_week.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_week.Location = new System.Drawing.Point(0, 0);
            this.grid_week.Name = "grid_week";
            this.grid_week.RowTemplate.Height = 24;
            this.grid_week.Size = new System.Drawing.Size(937, 215);
            this.grid_week.TabIndex = 0;
            this.grid_week.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_week_CellEndEdit);
            // 
            // co_ring
            // 
            this.co_ring.FillWeight = 70F;
            this.co_ring.HeaderText = "Звонки";
            this.co_ring.Name = "co_ring";
            this.co_ring.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day1
            // 
            this.co_day1.HeaderText = "Понедельник";
            this.co_day1.Name = "co_day1";
            this.co_day1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day2
            // 
            this.co_day2.HeaderText = "Вторник";
            this.co_day2.Name = "co_day2";
            this.co_day2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day3
            // 
            this.co_day3.HeaderText = "Среда";
            this.co_day3.Name = "co_day3";
            this.co_day3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day4
            // 
            this.co_day4.HeaderText = "Четверг";
            this.co_day4.Name = "co_day4";
            this.co_day4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day5
            // 
            this.co_day5.HeaderText = "Пятница";
            this.co_day5.Name = "co_day5";
            this.co_day5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 215);
            this.Controls.Add(this.grid_week);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание уроков";
            ((System.ComponentModel.ISupportInitialize)(this.grid_week)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_week;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_ring;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day1;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day3;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day4;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day5;
    }
}

