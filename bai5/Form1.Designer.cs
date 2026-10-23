using System.Drawing;
using System.Windows.Forms;

namespace bai5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();

            this.gbRealtime = new System.Windows.Forms.GroupBox();
            this.lblTitleTemp = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();

            this.dgvLogs = new System.Windows.Forms.DataGridView();

            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCycleCount = new System.Windows.Forms.ToolStripStatusLabel();

            this.gbControl.SuspendLayout();
            this.gbRealtime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG GIÁM SÁT CẢNH BÁO IOT REAL-TIME";

            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnStart);
            this.gbControl.Controls.Add(this.btnStop);
            this.gbControl.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbControl.Location = new System.Drawing.Point(12, 12);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(776, 75);
            this.gbControl.TabIndex = 0;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Điều Khiển Giám Sát";

            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(20, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 32);
            this.btnStart.Text = "Bắt Đầu Giám Sát";

            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightCoral;
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(200, 28);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(160, 32);
            this.btnStop.Text = "Dừng Giám Sát";

            // 
            // gbRealtime
            // 
            this.gbRealtime.Controls.Add(this.lblTitleTemp);
            this.gbRealtime.Controls.Add(this.lblTemperature);
            this.gbRealtime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbRealtime.Location = new System.Drawing.Point(12, 95);
            this.gbRealtime.Name = "gbRealtime";
            this.gbRealtime.Size = new System.Drawing.Size(776, 110);
            this.gbRealtime.TabIndex = 1;
            this.gbRealtime.TabStop = false;
            this.gbRealtime.Text = "Hiển Thị Nhiệt Độ Cảm Biến Real-time";

            // 
            // lblTitleTemp
            // 
            this.lblTitleTemp.AutoSize = true;
            this.lblTitleTemp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleTemp.Location = new System.Drawing.Point(20, 45);
            this.lblTitleTemp.Name = "lblTitleTemp";
            this.lblTitleTemp.Size = new System.Drawing.Size(142, 19);
            this.lblTitleTemp.Text = "Nhiệt độ hiện tại:";

            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTemperature.ForeColor = System.Drawing.Color.Green;
            this.lblTemperature.Location = new System.Drawing.Point(180, 28);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(158, 51);
            this.lblTemperature.Text = "--.- °C";

            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvLogs.Location = new System.Drawing.Point(12, 215);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(776, 330);
            this.dgvLogs.TabIndex = 2;

            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnectionStatus,
            this.lblCycleCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 558);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 3;

            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(180, 17);
            this.lblConnectionStatus.Text = "Trạng thái: Chưa kết nối  |  ";

            // 
            // lblCycleCount
            // 
            this.lblCycleCount.Name = "lblCycleCount";
            this.lblCycleCount.Size = new System.Drawing.Size(145, 17);
            this.lblCycleCount.Text = "Số chu kỳ nhận: 0";

            // 
            // Add Controls to Form
            // 
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbRealtime);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.statusStrip);

            this.gbControl.ResumeLayout(false);
            this.gbRealtime.ResumeLayout(false);
            this.gbRealtime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private GroupBox gbControl = null!;
        private Button btnStart = null!;
        private Button btnStop = null!;

        private GroupBox gbRealtime = null!;
        private Label lblTitleTemp = null!;
        private Label lblTemperature = null!;

        private DataGridView dgvLogs = null!;

        private StatusStrip statusStrip = null!;
        private ToolStripStatusLabel lblConnectionStatus = null!;
        private ToolStripStatusLabel lblCycleCount = null!;
    }
}