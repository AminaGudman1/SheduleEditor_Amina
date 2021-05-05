
namespace SheduleEditor_Amina
{
    partial class SheduleEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridShedule = new System.Windows.Forms.DataGridView();
            this.NumberPars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wendnesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridShedule
            // 
            this.dataGridShedule.AllowUserToAddRows = false;
            this.dataGridShedule.AllowUserToDeleteRows = false;
            this.dataGridShedule.AllowUserToResizeColumns = false;
            this.dataGridShedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridShedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridShedule.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridShedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridShedule.ColumnHeadersHeight = 80;
            this.dataGridShedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberPars,
            this.Monday,
            this.Tuesday,
            this.Wendnesday,
            this.Thursday,
            this.Friday,
            this.Saturday});
            this.dataGridShedule.Location = new System.Drawing.Point(12, 52);
            this.dataGridShedule.Name = "dataGridShedule";
            this.dataGridShedule.RowHeadersVisible = false;
            this.dataGridShedule.RowHeadersWidth = 70;
            this.dataGridShedule.RowTemplate.Height = 24;
            this.dataGridShedule.Size = new System.Drawing.Size(1162, 408);
            this.dataGridShedule.TabIndex = 0;
            this.dataGridShedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridShedule_CellClick);
            // 
            // NumberPars
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NumberPars.DefaultCellStyle = dataGridViewCellStyle3;
            this.NumberPars.Frozen = true;
            this.NumberPars.HeaderText = " Пара";
            this.NumberPars.MinimumWidth = 10;
            this.NumberPars.Name = "NumberPars";
            this.NumberPars.ReadOnly = true;
            this.NumberPars.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NumberPars.Width = 125;
            // 
            // Monday
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Monday.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monday.Frozen = true;
            this.Monday.HeaderText = "Понедельник";
            this.Monday.MinimumWidth = 10;
            this.Monday.Name = "Monday";
            this.Monday.Width = 125;
            // 
            // Tuesday
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tuesday.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tuesday.Frozen = true;
            this.Tuesday.HeaderText = "Вторник";
            this.Tuesday.MinimumWidth = 10;
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Width = 125;
            // 
            // Wendnesday
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Wendnesday.DefaultCellStyle = dataGridViewCellStyle6;
            this.Wendnesday.Frozen = true;
            this.Wendnesday.HeaderText = "Среда";
            this.Wendnesday.MinimumWidth = 6;
            this.Wendnesday.Name = "Wendnesday";
            this.Wendnesday.Width = 125;
            // 
            // Thursday
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Thursday.DefaultCellStyle = dataGridViewCellStyle7;
            this.Thursday.Frozen = true;
            this.Thursday.HeaderText = "Четверг";
            this.Thursday.MinimumWidth = 6;
            this.Thursday.Name = "Thursday";
            this.Thursday.Width = 125;
            // 
            // Friday
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Friday.DefaultCellStyle = dataGridViewCellStyle8;
            this.Friday.Frozen = true;
            this.Friday.HeaderText = "Пятница";
            this.Friday.MinimumWidth = 6;
            this.Friday.Name = "Friday";
            this.Friday.Width = 125;
            // 
            // Saturday
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Saturday.DefaultCellStyle = dataGridViewCellStyle9;
            this.Saturday.Frozen = true;
            this.Saturday.HeaderText = "Суббота";
            this.Saturday.MinimumWidth = 6;
            this.Saturday.Name = "Saturday";
            this.Saturday.Width = 125;
            // 
            // SheduleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 513);
            this.Controls.Add(this.dataGridShedule);
            this.Name = "SheduleEditor";
            this.Text = "Занятость кабинетов";
            this.Load += new System.EventHandler(this.SheduleEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberPars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wendnesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
    }
}

