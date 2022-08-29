using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapLichCPU.Models;

namespace LapLichCPU.Common
{
    public class clscommon
    {
        public void sapxepthutuxuathien(List<Process> list)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
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
                    if (list[i].tthuchien > list[j].tthuchien)
                    {
                        Process processtg = new Process();
                        processtg = list[i];
                        list[i] = list[j];
                        list[j] = processtg;
                    }
                }

            }
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
        
    }
}
