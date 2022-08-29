using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapLichCPU.Models
{
    public class Process
    {
        public string ID { get; set; }
        public int txuathien { get; set; }
        public int tthuchien { get; set; }
        public int tnapcpu { get; set; }
        public int tendcpu { get; set; }
        public int tconlai { get; set; }
        public int tchodoi { get; set; }
        public Process() { }
    }
}
