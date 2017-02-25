using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOxyPlot
{
    class PlotItem
    {
        [DisplayName("日付")]
        public DateTime Date { get; set; }

        public int Pos { get; set; }

        [DisplayName("血圧")]
        public double BloodPressure { get; set; }

        [DisplayName("体温")]
        public double BodyTemperature { get; set; }

        [DisplayName("脈拍")]
        public double Pulse { get; set; }

        [DisplayName("呼吸数")]
        public double Breathing { get; set; }

    }
}
