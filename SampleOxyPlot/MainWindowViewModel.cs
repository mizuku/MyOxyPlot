using OxyPlot;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOxyPlot
{
    class MainWindowViewModel
    {
        public ObservableCollection<PlotItem> PlotItems { get; set; }

        public MainWindowViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            PlotItems = new ObservableCollection<PlotItem>(Enumerable.Range(0, 4)
                .Select(i => new PlotItem()
                {
                    // oxyPlot のグラフの値に binding できるのは数値だけっぽい
                    Pos = i,
                    Date = new DateTime(2017, 3, 1 + i * 2),
                    BloodPressure = 100 + i * 4,
                    BodyTemperature = 36.0 + i * .5,
                    Pulse = 80 - i,
                    Breathing = 25 - i,
                }));

            // DataFieldX と DataFieldY を指定しない場合 DataPoint のコレクションにする、みたいだけど動かないような？使い方が間違ってるだけ？
            //BloodPressures = PlotItems.Select((e, i) => new DataPoint(i, e.BloodPressure)).ToList();
            //BodyTemperatures = PlotItems.Select((e, i) => new DataPoint(i, e.BodyTemperature)).ToList();
            //Pulses = PlotItems.Select((e, i) => new DataPoint(i, e.Pulse)).ToList();
            //Breathings = PlotItems.Select((e, i) => new DataPoint(i, e.Breathing)).ToList();
        }
    }
}
