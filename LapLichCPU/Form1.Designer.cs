namespace LapLichCPU
{
    partial class CPUProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPUProcess));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.ExecType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.p1exec = new System.Windows.Forms.TextBox();
            this.p2exec = new System.Windows.Forms.TextBox();
            this.p3exec = new System.Windows.Forms.TextBox();
            this.p4exec = new System.Windows.Forms.TextBox();
            this.p5exec = new System.Windows.Forms.TextBox();
            this.p1appear = new System.Windows.Forms.TextBox();
            this.p2appear = new System.Windows.Forms.TextBox();
            this.p3appear = new System.Windows.Forms.TextBox();
            this.p4appear = new System.Windows.Forms.TextBox();
            this.p5appear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.GrantPannel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblScale = new System.Windows.Forms.Label();
            this.btnScaleDown = new System.Windows.Forms.Button();
            this.btnScaleUp = new System.Windows.Forms.Button();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txuathien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tthuchien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TnapCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TendCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tconlai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(99, 208);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Tính toán";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ExecType
            // 
            this.ExecType.FormattingEnabled = true;
            this.ExecType.Items.AddRange(new object[] {
            "FCFS",
            "SJF",
            "SRT",
            "RR"});
            this.ExecType.Location = new System.Drawing.Point(122, 12);
            this.ExecType.Name = "ExecType";
            this.ExecType.Size = new System.Drawing.Size(121, 21);
            this.ExecType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "P1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "P2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "P3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "P4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "P5";
            // 
            // p1exec
            // 
            this.p1exec.Location = new System.Drawing.Point(183, 80);
            this.p1exec.Name = "p1exec";
            this.p1exec.Size = new System.Drawing.Size(100, 20);
            this.p1exec.TabIndex = 9;
            // 
            // p2exec
            // 
            this.p2exec.Location = new System.Drawing.Point(183, 107);
            this.p2exec.Name = "p2exec";
            this.p2exec.Size = new System.Drawing.Size(100, 20);
            this.p2exec.TabIndex = 10;
            // 
            // p3exec
            // 
            this.p3exec.Location = new System.Drawing.Point(183, 134);
            this.p3exec.Name = "p3exec";
            this.p3exec.Size = new System.Drawing.Size(100, 20);
            this.p3exec.TabIndex = 11;
            // 
            // p4exec
            // 
            this.p4exec.Location = new System.Drawing.Point(183, 156);
            this.p4exec.Name = "p4exec";
            this.p4exec.Size = new System.Drawing.Size(100, 20);
            this.p4exec.TabIndex = 12;
            // 
            // p5exec
            // 
            this.p5exec.Location = new System.Drawing.Point(183, 182);
            this.p5exec.Name = "p5exec";
            this.p5exec.Size = new System.Drawing.Size(100, 20);
            this.p5exec.TabIndex = 13;
            // 
            // p1appear
            // 
            this.p1appear.Location = new System.Drawing.Point(74, 80);
            this.p1appear.Name = "p1appear";
            this.p1appear.Size = new System.Drawing.Size(100, 20);
            this.p1appear.TabIndex = 14;
            // 
            // p2appear
            // 
            this.p2appear.Location = new System.Drawing.Point(74, 108);
            this.p2appear.Name = "p2appear";
            this.p2appear.Size = new System.Drawing.Size(100, 20);
            this.p2appear.TabIndex = 15;
            // 
            // p3appear
            // 
            this.p3appear.Location = new System.Drawing.Point(74, 134);
            this.p3appear.Name = "p3appear";
            this.p3appear.Size = new System.Drawing.Size(100, 20);
            this.p3appear.TabIndex = 16;
            // 
            // p4appear
            // 
            this.p4appear.Location = new System.Drawing.Point(74, 156);
            this.p4appear.Name = "p4appear";
            this.p4appear.Size = new System.Drawing.Size(100, 20);
            this.p4appear.TabIndex = 17;
            // 
            // p5appear
            // 
            this.p5appear.Location = new System.Drawing.Point(74, 182);
            this.p5appear.Name = "p5appear";
            this.p5appear.Size = new System.Drawing.Size(100, 20);
            this.p5appear.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Loại thuật toán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Thời gian thực hiện";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Thời gian xuất hiện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sơ đồ Grant";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(183, 208);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process,
            this.Txuathien,
            this.Tthuchien,
            this.TnapCPU,
            this.TendCPU,
            this.Tconlai});
            this.GridView.Location = new System.Drawing.Point(289, 80);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(520, 205);
            this.GridView.TabIndex = 35;
            // 
            // GrantPannel
            // 
            this.GrantPannel.Location = new System.Drawing.Point(11, 291);
            this.GrantPannel.Name = "GrantPannel";
            this.GrantPannel.Size = new System.Drawing.Size(797, 99);
            this.GrantPannel.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Bảng thứ tự thực hiện";
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(12, 272);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(34, 13);
            this.lblScale.TabIndex = 38;
            this.lblScale.Text = "Scale";
            // 
            // btnScaleDown
            // 
            this.btnScaleDown.Location = new System.Drawing.Point(52, 267);
            this.btnScaleDown.Name = "btnScaleDown";
            this.btnScaleDown.Size = new System.Drawing.Size(25, 23);
            this.btnScaleDown.TabIndex = 39;
            this.btnScaleDown.Text = "-";
            this.btnScaleDown.UseVisualStyleBackColor = true;
            this.btnScaleDown.Click += new System.EventHandler(this.btnScaleDown_Click);
            // 
            // btnScaleUp
            // 
            this.btnScaleUp.Location = new System.Drawing.Point(83, 267);
            this.btnScaleUp.Name = "btnScaleUp";
            this.btnScaleUp.Size = new System.Drawing.Size(25, 23);
            this.btnScaleUp.TabIndex = 40;
            this.btnScaleUp.Text = "+";
            this.btnScaleUp.UseVisualStyleBackColor = true;
            this.btnScaleUp.Click += new System.EventHandler(this.btnScaleUp_Click);
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(734, 15);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(33, 20);
            this.txtScale.TabIndex = 41;
            this.txtScale.Visible = false;
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(327, 12);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(33, 20);
            this.txtQ.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Time Quantum";
            // 
            // Process
            // 
            this.Process.DataPropertyName = "ID";
            this.Process.FillWeight = 80F;
            this.Process.HeaderText = "Process";
            this.Process.Name = "Process";
            this.Process.Width = 80;
            // 
            // Txuathien
            // 
            this.Txuathien.DataPropertyName = "txuathien";
            this.Txuathien.FillWeight = 80F;
            this.Txuathien.HeaderText = "Txuathien";
            this.Txuathien.Name = "Txuathien";
            this.Txuathien.Width = 80;
            // 
            // Tthuchien
            // 
            this.Tthuchien.DataPropertyName = "tthuchien";
            this.Tthuchien.FillWeight = 80F;
            this.Tthuchien.HeaderText = "Tthuchien";
            this.Tthuchien.Name = "Tthuchien";
            this.Tthuchien.Width = 80;
            // 
            // TnapCPU
            // 
            this.TnapCPU.DataPropertyName = "tnapcpu";
            this.TnapCPU.FillWeight = 80F;
            this.TnapCPU.HeaderText = "TnapCPU";
            this.TnapCPU.Name = "TnapCPU";
            this.TnapCPU.Width = 80;
            // 
            // TendCPU
            // 
            this.TendCPU.DataPropertyName = "tendcpu";
            this.TendCPU.FillWeight = 80F;
            this.TendCPU.HeaderText = "TendCPU";
            this.TendCPU.Name = "TendCPU";
            this.TendCPU.Width = 80;
            // 
            // Tconlai
            // 
            this.Tconlai.DataPropertyName = "tconlai";
            this.Tconlai.FillWeight = 80F;
            this.Tconlai.HeaderText = "Tconlai";
            this.Tconlai.Name = "Tconlai";
            this.Tconlai.Width = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(534, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 31);
            this.label11.TabIndex = 44;
            this.label11.Text = "Created by QuangDD";
            // 
            // CPUProcess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(823, 438);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.btnScaleUp);
            this.Controls.Add(this.btnScaleDown);
            this.Controls.Add(this.lblScale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GrantPannel);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.p5appear);
            this.Controls.Add(this.p4appear);
            this.Controls.Add(this.p3appear);
            this.Controls.Add(this.p2appear);
            this.Controls.Add(this.p1appear);
            this.Controls.Add(this.p5exec);
            this.Controls.Add(this.p4exec);
            this.Controls.Add(this.p3exec);
            this.Controls.Add(this.p2exec);
            this.Controls.Add(this.p1exec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExecType);
            this.Controls.Add(this.btnCalculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CPUProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô phỏng lập lịch CPU";
            this.Load += new System.EventHandler(this.CPUProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox ExecType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p1exec;
        private System.Windows.Forms.TextBox p2exec;
        private System.Windows.Forms.TextBox p3exec;
        private System.Windows.Forms.TextBox p4exec;
        private System.Windows.Forms.TextBox p5exec;
        private System.Windows.Forms.TextBox p1appear;
        private System.Windows.Forms.TextBox p2appear;
        private System.Windows.Forms.TextBox p3appear;
        private System.Windows.Forms.TextBox p4appear;
        private System.Windows.Forms.TextBox p5appear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Panel GrantPannel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnScaleUp;
        private System.Windows.Forms.Button btnScaleDown;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txuathien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tthuchien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TnapCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TendCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tconlai;
        private System.Windows.Forms.Label label11;
    }
}

