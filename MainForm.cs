using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TolokaManager.Models;

namespace TolokaManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private API m_API; 
        private Thread m_Job;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            m_API = new API();
        }


        private void btn_download_Click(object sender, EventArgs e)
        {
            if (tb_pool.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле 'ID пула'");
                return;
            }
            saveFD.FileName = "Save Here";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                btn_download.Enabled = false;
                var path = Path.GetDirectoryName(saveFD.FileName);

                var result = m_API.GetAttachments(int.Parse(tb_pool.Text), rb_checked.Checked, cb_date_at.Checked ? dt_at.Value : DateTime.MinValue, cb_date_to.Checked ? dt_to.Value : DateTime.MinValue);
                var result_download = result.FindAll(x => x.right.Count > 0);
                tb_result.Text = $"Ответы в пуле: {result.Count}";

                gv_attachments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                gv_attachments.AllowUserToAddRows = false;
                gv_attachments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                gv_attachments.AllowUserToAddRows = false;
                gv_attachments.ColumnCount = 4;
                gv_attachments.Columns[0].HeaderText = "Ответ";
                gv_attachments.Columns[1].HeaderText = "Статус";
                gv_attachments.Columns[2].HeaderText = "Исполнитель";
                gv_attachments.Columns[3].HeaderText = "Количество ресурсов";

                foreach(var row_data in result_download) {
                    gv_attachments.Rows.Add(row_data.id,  row_data.status, row_data.user_id, row_data.right.Count+row_data.left.Count);
                    gv_attachments.Rows[gv_attachments.RowCount - 1].DefaultCellStyle.BackColor = Color.White;
                }
                groupBox2.Visible = true;
                m_Job = new Thread(() =>
                {
                    int k = 0;
                    int count = result_download.Select(x => x.right.Count + x.left.Count).Sum();
                    var action = new Action(() =>
                    {
                        label_progress.Text = $"Скачано файлов: {++k} из {count}";
                        progressBar1.Value = k * 100 / count;
                    });
                    Invoke(action);
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    for (int i = 0; i < result_download.Count; i++)
                    {
                        gv_attachments.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        var data = result_download[i];
                        var curPath = Path.Combine(path, data.user_id);
                        Directory.CreateDirectory(curPath);
                        foreach (var item in data.left)
                        {
                            m_API.DownloadFile(item, Path.Combine(curPath, $"left{m_API.GetFileExtension(item)}"));

                            Invoke(action);
                        }
                        foreach (var item in data.right)
                        {
                            m_API.DownloadFile(item, Path.Combine(curPath, $"right{m_API.GetFileExtension(item)}"));
                            Invoke(action);
                        }
                        gv_attachments.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                });
                m_Job.Start();
            }
        }


        private void cb_date_at_CheckedChanged(object sender, EventArgs e)
        {
            dt_at.Enabled = cb_date_at.Checked;
        }

        private void cb_date_to_CheckedChanged(object sender, EventArgs e)
        {
            dt_to.Enabled = cb_date_to.Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_Job != null)
                m_Job.Abort();
        }
    }
}
