using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LapLichCPU.Models;
namespace LapLichCPU
{
    public partial class LapLichCPU : Form
    {
        Graphics graphics;
        public LapLichCPU()
        {
            InitializeComponent();
            graphics = this.GrantPannel.CreateGraphics();
            txtScale.Text = "35";
        }
        public void Swap(List<Process> list, int i, int j)
        {
            Process proctg = new Process();
            proctg = list[i];
            list[i] = list[j];
            list[j] = proctg;
        }

        public int ValidateValue()
        {
            if (p1appear.Text.Trim() == "")
            {
                Error.SetError(p1appear, "Vui lòng nhập giá trị"); return -1;
            }
            if (p2appear.Text.Trim() == "")
            {
                Error.SetError(p2appear, "Vui lòng nhập giá trị"); return -1;
            }
            if (p3appear.Text.Trim() == "")
            {
                Error.SetError(p3appear, "Vui lòng nhập giá trị"); return -1;
            }
            if (p4appear.Text.Trim() == "")
            {
                Error.SetError(p4appear, "Vui lòng nhập giá trị"); return -1;
            }
            if (p5appear.Text.Trim() == "")
            {
                Error.SetError(p5appear, "Vui lòng nhập giá trị"); return -1;
            }
            if (p1exec.Text.Trim() == "")
            {
                Error.SetError(p1exec, "Vui lòng nhập giá trị"); return -1;
            }
            if (p2exec.Text.Trim() == "")
            {
                Error.SetError(p2exec, "Vui lòng nhập giá trị"); return -1;
            }
            if (p3exec.Text.Trim() == "")
            {
                Error.SetError(p3exec, "Vui lòng nhập giá trị"); return -1;
            }
            if (p4exec.Text.Trim() == "")
            {
                Error.SetError(p4exec, "Vui lòng nhập giá trị"); return -1;
            }
            if (p5exec.Text.Trim() == "")
            {
                Error.SetError(p5exec, "Vui lòng nhập giá trị"); return -1;
            }
            return 1;
        }
        public void FCFS()
        {

            try
            {
                List<Process> listprocess = new List<Process>();
                List<Process> listsource = new List<Process>();
                Process P1 = new Process();
                Process P2 = new Process();
                Process P3 = new Process();
                Process P4 = new Process();
                Process P5 = new Process();
                gangiatri(P1, P2, P3, P4, P5);
                listprocess.Add(P1);
                listprocess.Add(P2);
                listprocess.Add(P3);
                listprocess.Add(P4);
                listprocess.Add(P5);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (listprocess[i].txuathien > listprocess[j].txuathien)
                        {
                            Swap(listprocess, i, j);
                        }
                    }
                    listprocess[i].tnapcpu = i == 0 ? listprocess[i].txuathien : (listprocess[i - 1].tendcpu > listprocess[i].txuathien ? listprocess[i - 1].tendcpu : listprocess[i].txuathien);
                    listprocess[i].tendcpu = listprocess[i].tnapcpu + listprocess[i].tthuchien;
                    listprocess[i].tchodoi = listprocess[i].tnapcpu - listprocess[i].txuathien;

                }
                GridView.DataSource = listprocess;
                label1.Text = "Sơ đồ Grant: Thuật toán " + ExecType.Text;
                label1.ForeColor = Color.Green;
                DrawGranttChart(listprocess);
                AVGWaitTime(listprocess);
            }
            catch (Exception ex)
            {
                label1.Text = ex.ToString();
                label1.ForeColor = Color.Red;
            }
        }
        public void SJF()
        {
            List<Process> listprocess = new List<Process>();
            List<Process> listsource = new List<Process>();
            Process P1 = new Process();
            Process P2 = new Process();
            Process P3 = new Process();
            Process P4 = new Process();
            Process P5 = new Process();
            gangiatri(P1, P2, P3, P4, P5);
            listprocess.Add(P1);
            listprocess.Add(P2);
            listprocess.Add(P3);
            listprocess.Add(P4);
            listprocess.Add(P5);
            //vong
            sapxepthutuxuathien(listprocess);
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    listprocess[i].tnapcpu = listprocess[i].txuathien;
                }
                else
                {
                    listprocess[i].tnapcpu = listprocess[i - 1].tendcpu;
                    if (listprocess[i].tnapcpu < listprocess[i].txuathien)
                    {
                        listprocess[i].tnapcpu = listprocess[i].txuathien;
                    }
                }
                listprocess[i].tendcpu = listprocess[i].tnapcpu + listprocess[i].tthuchien;
                listprocess[i].tchodoi = listprocess[i].tnapcpu - listprocess[i].txuathien;
                for (int j = i+1; j < 5; j++)
                {
                    if (listprocess[i].tendcpu>listprocess[j].txuathien)
                    {
                        Sapxepthututhuchien(listprocess,i+1, j);
                    }
                }
            }

            GridView.DataSource = listprocess;
            label1.Text = "Sơ đồ Grant: Thuật toán " + ExecType.Text;
            label1.ForeColor = Color.Green;
            DrawGranttChart(listprocess);
            AVGWaitTime(listprocess);
        }
        //public void SJF_preemtive()
        //{
        //    List<Process> listprocess = new List<Process>();
        //    List<Process> listsource = new List<Process>();
        //    Process P1 = new Process();
        //    Process P2 = new Process();
        //    Process P3 = new Process();
        //    Process P4 = new Process();
        //    Process P5 = new Process();
        //    gangiatri(P1, P2, P3, P4, P5);
        //    listprocess.Add(P1);
        //    listprocess.Add(P2);
        //    listprocess.Add(P3);
        //    listprocess.Add(P4);
        //    listprocess.Add(P5);
        //    //vong
        //    sapxepthutuxuathien(listprocess);
        //    for (int i = 0; i < listprocess.Count - 1; i++)
        //    {
        //        if (i == 0)
        //        {
        //            listprocess[i].tnapcpu = listprocess[i].txuathien;
        //        }
        //        else
        //        {
        //            listprocess[i].tnapcpu = listprocess[i - 1].tendcpu;
        //            if (listprocess[i].tnapcpu < listprocess[i].txuathien)
        //            {
        //                listprocess[i].tnapcpu = listprocess[i].txuathien;
        //            }
        //        }
        //        listprocess[i].tendcpu = listprocess[i].tnapcpu + listprocess[i].tthuchien;
        //        listprocess[i].tchodoi = listprocess[i].tnapcpu - listprocess[i].txuathien;
        //        for (int j = i+1; j < listprocess.Count; j++)
        //        {
        //            if (listprocess[i].tendcpu > listprocess[j].txuathien)
        //            {
        //                int conlai = 0;
        //                if (listprocess[i].tnapcpu < listprocess[j].txuathien)
        //                {
        //                    conlai = listprocess[i].tendcpu - listprocess[i].tnapcpu - listprocess[j].txuathien + listprocess[i].txuathien + (listprocess[i].tnapcpu - listprocess[i].txuathien);
        //                }
        //                else
        //                {
        //                    if (listprocess[i].tthuchien < listprocess[j].tthuchien)
        //                    {
        //                        conlai = 0;
        //                    }
        //                    else
        //                    {
        //                        conlai = listprocess[i].tendcpu - listprocess[i].tnapcpu - listprocess[j].txuathien + listprocess[i].txuathien - (listprocess[i].tnapcpu - listprocess[i].txuathien);

        //                    }
        //                }
        //                if (conlai > listprocess[j].tthuchien)
        //                {
        //                    Process newprocess = new Process();
        //                    gan(newprocess, listprocess[i]);
        //                    listprocess[i].tconlai = conlai;
        //                    listprocess[i].tendcpu = listprocess[j].txuathien;
        //                    listprocess[i].tthuchien = listprocess[j].txuathien - listprocess[i].tnapcpu;
        //                    newprocess.txuathien = listprocess[j].txuathien;
        //                    newprocess.tthuchien = listprocess[i].tconlai;
        //                    newprocess.tconlai = 0;
        //                    listprocess.Add(newprocess);
        //                    for (int k = listprocess.Count - 1; k > i; k--)
        //                    {
        //                        listprocess[k] = listprocess[k - 1];
        //                    }
        //                    listprocess[i + 1] = newprocess;
        //                    Sapxepthututhuchien(listprocess, i + 1, j + 1);

        //                }
        //            }
        //        }
        //    }

        //}
            public void SRT()
        {
            List<Process> listprocess = new List<Process>();
            List<Process> listsource = new List<Process>();
            Process P1 = new Process();
            Process P2 = new Process();
            Process P3 = new Process();
            Process P4 = new Process();
            Process P5 = new Process();
            gangiatri(P1, P2, P3, P4, P5);
            listprocess.Add(P1);
            listprocess.Add(P2);
            listprocess.Add(P3);
            listprocess.Add(P4);
            listprocess.Add(P5);

            sapxepthutuxuathien(listprocess);
            for (int i = 0; i < listprocess.Count - 1 ; i++)
            {
                if (i == 0)
                {
                    listprocess[i].tnapcpu = listprocess[i].txuathien;
                }
                else
                {
                    listprocess[i].tnapcpu = listprocess[i - 1].tendcpu;
                    if (listprocess[i].tnapcpu < listprocess[i].txuathien)
                    {
                        listprocess[i].tnapcpu = listprocess[i].txuathien;
                    }
                }
                listprocess[i].tendcpu = listprocess[i].tnapcpu + listprocess[i].tthuchien;
                listprocess[i].tchodoi = listprocess[i].tnapcpu - listprocess[i].txuathien;

                for (int j = i + 1; j < listprocess.Count; j++)
                {
                    if (listprocess[i].tendcpu > listprocess[j].txuathien)
                    {
                        int conlai = 0;
                        if (listprocess[i].tnapcpu < listprocess[j].txuathien)
                        {
                            conlai = listprocess[i].tendcpu - listprocess[i].tnapcpu - listprocess[j].txuathien + listprocess[i].txuathien + (listprocess[i].tnapcpu - listprocess[i].txuathien);
                        }
                        else
                        {
                            if (listprocess[i].tthuchien < listprocess[j].tthuchien)
                            {
                                conlai = 0;
                            }
                            else
                            {
                                conlai = listprocess[i].tendcpu - listprocess[i].tnapcpu - listprocess[j].txuathien + listprocess[i].txuathien - (listprocess[i].tnapcpu - listprocess[i].txuathien);

                            }


                        }
                        if (conlai > listprocess[j].tthuchien)
                        {
                            Process newprocess = new Process();
                            gan(newprocess, listprocess[i]);
                            listprocess[i].tconlai = conlai;
                            listprocess[i].tendcpu = listprocess[j].txuathien;
                            //Lỗi ở phần tính time xuất hiện
                            listprocess[i].tthuchien = listprocess[j].txuathien - listprocess[i].tnapcpu;
                            newprocess.txuathien = listprocess[j].txuathien;
                            newprocess.tthuchien = listprocess[i].tconlai;
                            newprocess.tconlai = 0;
                            listprocess.Add(newprocess);
                            for (int k = listprocess.Count - 1; k > i; k--)
                            {
                                listprocess[k] = listprocess[k - 1];
                            }
                            listprocess[i + 1] = newprocess;
                            Sapxepthututhuchien(listprocess, i + 1, j + 1);

                        }

                    }
                }
                for (int l = 0; l < listprocess.Count; l++)
                {
                    listsource.Add(listprocess[l]);

                }
                Sapxepthututhuchien(listprocess, i + 1, listprocess.Count - 1);

                listsource.Add(new Process());
            }

            listprocess[listprocess.Count - 1].tnapcpu = listprocess[listprocess.Count - 2].tendcpu;

            if (listprocess[listprocess.Count - 1].tnapcpu < listprocess[listprocess.Count - 1].txuathien)
            {
                listprocess[listprocess.Count - 1].tnapcpu = listprocess[listprocess.Count - 1].txuathien;
            }
            listprocess[listprocess.Count - 1].tendcpu = listprocess[listprocess.Count - 1].tnapcpu + listprocess[listprocess.Count - 1].tthuchien;
            listprocess[listprocess.Count - 1].tchodoi = listprocess[listprocess.Count - 1].tnapcpu - listprocess[listprocess.Count - 1].txuathien;
            AVGWaitTime(listprocess);

            GridView.DataSource = listprocess;
            DrawGranttChart(listprocess);
            label1.Text = "Sơ đồ Grant: Thuật toán " + ExecType.Text;
            label1.ForeColor = Color.Green;
        }
        public void RR()
        {
            if (txtQ.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập giá trị Time Quantum", "ERROR");
                return;
            }
            int q = int.Parse(txtQ.Text);
            int now = 0;
            List<Process> listprocess = new List<Process>();
            List<Process> listsource = new List<Process>();
            Process P1 = new Process();
            Process P2 = new Process();
            Process P3 = new Process();
            Process P4 = new Process();
            Process P5 = new Process();
            gangiatri(P1, P2, P3, P4, P5);
            listprocess.Add(P1);
            listprocess.Add(P2);
            listprocess.Add(P3);
            listprocess.Add(P4);
            listprocess.Add(P5);
            sapxepthutuxuathien(listprocess);
            //chạy vòng for

            for (int i = 0; i < listprocess.Count; i++)
            {
                if (i == 0)
                {
                    listprocess[i].tnapcpu = listprocess[i].txuathien;
                    now = listprocess[i].tnapcpu + q;
                }
                else
                {
                    listprocess[i].tnapcpu = listprocess[i - 1].tendcpu;
                    if (listprocess[i].tnapcpu < listprocess[i].txuathien)
                    {
                        listprocess[i].tnapcpu = listprocess[i].txuathien;
                    }
                    now = listprocess[i].tnapcpu + q;

                }
                listprocess[i].tchodoi = listprocess[i].tnapcpu - listprocess[i].txuathien;

                listprocess[i].tendcpu = listprocess[i].tnapcpu + listprocess[i].tthuchien;

                int conlai = listprocess[i].tendcpu - now;


                if (listprocess[i].tendcpu > now)
                {
                    int location = i;
                    Process newprocess = new Process();
                    gan(newprocess, listprocess[i]);
                    listprocess[i].tconlai = conlai;
                    listprocess[i].tendcpu = now;
                    listprocess[i].tthuchien = q;
                    newprocess.txuathien = now;
                    newprocess.tthuchien = conlai;
                    newprocess.tconlai = 0;
                    for (int l = i + 1; l < listprocess.Count; l++)
                    {
                        if (now >= listprocess[l].txuathien)
                        {
                            location = location + 1;
                        }
                    }
                    listprocess.Add(newprocess);
                    for (int k = listprocess.Count - 1; k > location; k--)
                    {
                        listprocess[k] = listprocess[k - 1];
                    }
                    listprocess[location] = newprocess;
                    sapxepthutuxuathien(listprocess);

                }
                for (int l = 0; l < listprocess.Count; l++)
                {
                    listsource.Add(listprocess[l]);

                }

                listsource.Add(new Process());

                now = now + 3;
            }

            GridView.DataSource = listprocess;
            DrawGranttChart(listprocess);
            AVGWaitTime(listprocess);
            label1.Text = "Sơ đồ Grant: Thuật toán " + ExecType.Text;
            label1.ForeColor = Color.Green;
        }
        public void gangiatri(Process P1, Process P2, Process P3, Process P4, Process P5)
        {
            P1.ID = "P1";
            P1.txuathien = int.Parse(p1appear.Text);
            P1.tthuchien = int.Parse(p1exec.Text);
            P2.ID = "P2";
            P2.txuathien = int.Parse(p2appear.Text);
            P2.tthuchien = int.Parse(p2exec.Text);
            P3.ID = "P3";
            P3.txuathien = int.Parse(p3appear.Text);
            P3.tthuchien = int.Parse(p3exec.Text);
            P4.ID = "P4";
            P4.txuathien = int.Parse(p4appear.Text);
            P4.tthuchien = int.Parse(p4exec.Text);
            P5.ID = "P5";
            P5.txuathien = int.Parse(p5appear.Text);
            P5.tthuchien = int.Parse(p5exec.Text);
        }
        public void sapxepthutuxuathien(List<Process> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].txuathien > list[j].txuathien)
                    {
                        Process processtg = new Process();
                        processtg = list[i];
                        list[i] = list[j];
                        list[j] = processtg;
                    }
                }
            }
        }
        public void Sapxepthututhuchien(List<Process> list, int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                for (int j = i + 1; j <= to; j++)
                {
                    int tnap = list[i - 1].tnapcpu + list[i - 1].tthuchien;
                    if (list[i].tthuchien > list[j].tthuchien)
                    {
                        //cần check time xuất hiện 
                        if (tnap > list[i].txuathien && tnap >= list[j].txuathien)
                        {
                            Process processtg = new Process();
                            processtg = list[i];
                            list[i] = list[j];
                            list[j] = processtg;
                        }
                        else
                        {
                            if (tnap <= list[j].txuathien && list[j].txuathien <= list[i].txuathien && tnap >= list[i].txuathien)
                            {
                                list[i].tnapcpu = tnap;
                                int i_tthuchien = list[i].tthuchien - (list[j].txuathien - tnap);
                                if (i_tthuchien > list[j].tthuchien)
                                {
                                    Process processtg = new Process();
                                    processtg = list[i];
                                    list[i] = list[j];
                                    list[j] = processtg;
                                }
                            }
                        }
                    }

                }

            }
            
        }

        public int Greatest(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
        public void gan(Process p1, Process p2)
        {
            p1.ID = p2.ID; //khai báo item mới, gán giá trị bằng list 0
            p1.txuathien = p2.txuathien; //khai báo item mới, gán giá trị bằng list 0
            p1.tthuchien = p2.tthuchien; //khai báo item mới, gán giá trị bằng list 0
            p1.tnapcpu = p2.tnapcpu; //khai báo item mới, gán giá trị bằng list 0
            p1.tendcpu = p2.tendcpu; //khai báo item mới, gán giá trị bằng list 0
            p1.tconlai = p2.tconlai;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int validate = ValidateValue();
            if (validate == -1)
            {
                return;
            }
            if (ExecType.SelectedIndex == 0)
            {
                FCFS();
            }
            else if (ExecType.SelectedIndex == 1)
            {
                SJF();
            }
            else if (ExecType.SelectedIndex == 2)
            {
                SRT();
            }
            else
            {
                RR();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearGranttChart();
            ExecType.SelectedIndex = 0;
            GridView.DataSource = null;
            p1appear.Text = "";
            p2appear.Text = "";
            p3appear.Text = "";
            p4appear.Text = "";
            p5appear.Text = "";
            p1exec.Text = "";
            p2exec.Text = "";
            p3exec.Text = "";
            p4exec.Text = "";
            p5exec.Text = "";
        }
        public void ClearGranttChart()
        {
            Rectangle rect;
            rect = new Rectangle(0, 0, 912, 160);
            graphics.FillRectangle(Brushes.White, rect);
        }
        public void DrawGranttChart(List<Process> GranttSource)
        {

            int margin = 20;
            int Scalewidth = int.Parse(txtScale.Text);
            Point point;
            Brush Rbrush = Brushes.Red;
            Brush Bbrush = Brushes.Red;
            Brush Ybrush = Brushes.Red;
            Rectangle rect;
            Pen BPen = new Pen(Color.Blue);
            Pen defaultpen = new Pen(Brushes.White);
            Size size = new Size(912, 160);
            rect = new Rectangle(0, 0, 912, 160);
            graphics.FillRectangle(Brushes.White, rect);

            for (int i = 0; i < GranttSource.Count; i++)
            {
                point = new Point(GranttSource[i].tnapcpu * Scalewidth, 20);
                rect = new Rectangle(GranttSource[i].tnapcpu * Scalewidth, 20, GranttSource[i].tthuchien * Scalewidth, 50);
                graphics.DrawRectangle(BPen, rect);

                point = new Point(GranttSource[i].tnapcpu * Scalewidth, 20 + margin);
                graphics.DrawString(GranttSource[i].ID, this.Font, Rbrush, point);

                point = new Point(GranttSource[i].tnapcpu * Scalewidth, 55 + margin);
                graphics.DrawString(GranttSource[i].tnapcpu.ToString(), this.Font, Bbrush, point);

                if (i < GranttSource.Count - 2)
                {
                    if (GranttSource[i].tendcpu < GranttSource[i + 1].tnapcpu)
                    {
                        point = new Point(GranttSource[i].tendcpu * Scalewidth, 55 + margin);
                        graphics.DrawString(GranttSource[i].tendcpu.ToString(), this.Font, Ybrush, point);
                    }

                }
            }
            point = new Point(GranttSource[GranttSource.Count - 1].tendcpu * Scalewidth, 55 + margin);
            graphics.DrawString(GranttSource[GranttSource.Count - 1].tendcpu.ToString(), this.Font, Ybrush, point);
        }

        private void btnScaleDown_Click(object sender, EventArgs e)
        {
            txtScale.Text = (int.Parse(txtScale.Text) - 5).ToString();
            int validate = ValidateValue();
            if (validate == -1)
            {
                return;
            }
            if (ExecType.SelectedIndex == 0)
            {
                FCFS();
            }
            else if (ExecType.SelectedIndex == 1)
            {
                SJF();
            }
            else if (ExecType.SelectedIndex == 2)
            {
                SRT();
            }
            else
            {
                RR();
            }
            if (txtScale.Text == "5" || txtScale.Text == "35")
            {
                btnScaleDown.Enabled = false;
                btnScaleUp.Enabled = true;
            }
            else
            {
                btnScaleUp.Enabled = true;
                btnScaleDown.Enabled = true;
            }
        }

        private void btnScaleUp_Click(object sender, EventArgs e)
        {
            txtScale.Text = (int.Parse(txtScale.Text) + 5).ToString();
            int validate = ValidateValue();
            if (validate == -1)
            {
                return;
            }
            if (ExecType.SelectedIndex == 0)
            {
                FCFS();
            }
            else if (ExecType.SelectedIndex == 1)
            {
                SJF();
            }
            else if (ExecType.SelectedIndex == 2)
            {
                SRT();
            }
            else
            {
                RR();
            }
            if (txtScale.Text == "5" || txtScale.Text == "35")
            {
                btnScaleUp.Enabled = false;
                btnScaleDown.Enabled = true;
            }
            else
            {
                btnScaleUp.Enabled = true;
                btnScaleDown.Enabled = true;
            }
        }

        private void LapLichCPU_Load(object sender, EventArgs e)
        {
            ExecType.SelectedIndex = 0;
            p1appear.Text = "0";
            p2appear.Text = "21";
            p3appear.Text = "12";
            p4appear.Text = "9";
            p5appear.Text = "6";
            p1exec.Text = "16";
            p2exec.Text = "6";
            p3exec.Text = "4";
            p4exec.Text = "14";
            p5exec.Text = "8";
        }

        private void ExecType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExecType.SelectedIndex != 3)
            {
                txtQ.Visible = false;
                lblTimequantum.Visible = false;
            }
            else
            {
                txtQ.Visible = true;
                lblTimequantum.Visible = true;
            }
        }
        public void AVGWaitTime(List<Process> list)
        {
            double sumwaittime = 0;
            foreach(var item in list)
            {
                sumwaittime += item.tchodoi;
            }
            lblAvgWaitTime.Text = sumwaittime+"/"+5+"="+(sumwaittime / 5).ToString();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}