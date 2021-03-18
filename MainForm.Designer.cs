namespace TolokaManager
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.dt_at = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_unchecked = new System.Windows.Forms.RadioButton();
            this.rb_checked = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pool = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_progress = new System.Windows.Forms.Label();
            this.gv_attachments = new System.Windows.Forms.DataGridView();
            this.tb_result = new System.Windows.Forms.Label();
            this.cb_date_at = new System.Windows.Forms.CheckBox();
            this.cb_date_to = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_attachments)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_date_to);
            this.groupBox1.Controls.Add(this.cb_date_at);
            this.groupBox1.Controls.Add(this.btn_download);
            this.groupBox1.Controls.Add(this.dt_to);
            this.groupBox1.Controls.Add(this.dt_at);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rb_unchecked);
            this.groupBox1.Controls.Add(this.rb_checked);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_pool);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные параметры";
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(10, 260);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(205, 34);
            this.btn_download.TabIndex = 8;
            this.btn_download.Text = "Загрузить";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // dt_to
            // 
            this.dt_to.Enabled = false;
            this.dt_to.Location = new System.Drawing.Point(10, 211);
            this.dt_to.Name = "dt_to";
            this.dt_to.Size = new System.Drawing.Size(205, 20);
            this.dt_to.TabIndex = 7;
            // 
            // dt_at
            // 
            this.dt_at.Enabled = false;
            this.dt_at.Location = new System.Drawing.Point(10, 144);
            this.dt_at.Name = "dt_at";
            this.dt_at.Size = new System.Drawing.Size(205, 20);
            this.dt_at.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата создания (c)";
            // 
            // rb_unchecked
            // 
            this.rb_unchecked.AutoSize = true;
            this.rb_unchecked.Location = new System.Drawing.Point(13, 104);
            this.rb_unchecked.Name = "rb_unchecked";
            this.rb_unchecked.Size = new System.Drawing.Size(96, 17);
            this.rb_unchecked.TabIndex = 4;
            this.rb_unchecked.Text = "Не проверено";
            this.rb_unchecked.UseVisualStyleBackColor = true;
            // 
            // rb_checked
            // 
            this.rb_checked.AutoSize = true;
            this.rb_checked.Checked = true;
            this.rb_checked.Location = new System.Drawing.Point(13, 80);
            this.rb_checked.Name = "rb_checked";
            this.rb_checked.Size = new System.Drawing.Size(81, 17);
            this.rb_checked.TabIndex = 3;
            this.rb_checked.TabStop = true;
            this.rb_checked.Text = "Проверено";
            this.rb_checked.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Статус задания";
            // 
            // tb_pool
            // 
            this.tb_pool.Location = new System.Drawing.Point(10, 36);
            this.tb_pool.Name = "tb_pool";
            this.tb_pool.Size = new System.Drawing.Size(208, 20);
            this.tb_pool.TabIndex = 1;
            this.tb_pool.Text = "9591432";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID пула";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label_progress);
            this.groupBox2.Controls.Add(this.gv_attachments);
            this.groupBox2.Controls.Add(this.tb_result);
            this.groupBox2.Location = new System.Drawing.Point(243, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 294);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            this.groupBox2.Visible = false;
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Location = new System.Drawing.Point(6, 263);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(61, 13);
            this.label_progress.TabIndex = 2;
            this.label_progress.Text = "Скачано: 0";
            // 
            // gv_attachments
            // 
            this.gv_attachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_attachments.Location = new System.Drawing.Point(6, 41);
            this.gv_attachments.Name = "gv_attachments";
            this.gv_attachments.Size = new System.Drawing.Size(532, 190);
            this.gv_attachments.TabIndex = 1;
            // 
            // tb_result
            // 
            this.tb_result.AutoSize = true;
            this.tb_result.Location = new System.Drawing.Point(7, 20);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(35, 13);
            this.tb_result.TabIndex = 0;
            this.tb_result.Text = "label4";
            // 
            // cb_date_at
            // 
            this.cb_date_at.AutoSize = true;
            this.cb_date_at.Location = new System.Drawing.Point(10, 170);
            this.cb_date_at.Name = "cb_date_at";
            this.cb_date_at.Size = new System.Drawing.Size(75, 17);
            this.cb_date_at.TabIndex = 9;
            this.cb_date_at.Text = "Включить";
            this.cb_date_at.UseVisualStyleBackColor = true;
            this.cb_date_at.CheckedChanged += new System.EventHandler(this.cb_date_at_CheckedChanged);
            // 
            // cb_date_to
            // 
            this.cb_date_to.AutoSize = true;
            this.cb_date_to.Location = new System.Drawing.Point(10, 237);
            this.cb_date_to.Name = "cb_date_to";
            this.cb_date_to.Size = new System.Drawing.Size(75, 17);
            this.cb_date_to.TabIndex = 10;
            this.cb_date_to.Text = "Включить";
            this.cb_date_to.UseVisualStyleBackColor = true;
            this.cb_date_to.CheckedChanged += new System.EventHandler(this.cb_date_to_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата создания (до)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 237);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(532, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Toloka Scapper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_attachments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.DateTimePicker dt_to;
        private System.Windows.Forms.DateTimePicker dt_at;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_unchecked;
        private System.Windows.Forms.RadioButton rb_checked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tb_result;
        private System.Windows.Forms.DataGridView gv_attachments;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.CheckBox cb_date_to;
        private System.Windows.Forms.CheckBox cb_date_at;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

