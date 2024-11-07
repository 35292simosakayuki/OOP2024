using SampleWeightConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleWeightConverter {
    public class MainWindowViewModel : ViewModel {
        private double gramValue, imperialValue;

        //▲ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }

        //▼ボタンで呼ばれるコマンド
        public ICommand MetricToImperialUnit { get; private set; }

        // 上のComboBoxで選択されている値
        public GramUnit CurrentMetricUnit { get; set; }

        // 下のComboBoxで選択されている値
        public WeightUnit CurrentImperialUnit { get; set; }

        public double GramValue {
            get { return gramValue; }
            set {
                gramValue = value;
                OnPropertyChanged();
            }
        }

        public double ImperialValue {
            get { return imperialValue; }
            set {
                imperialValue = value;
                OnPropertyChanged();
            }
        }


        public MainWindowViewModel() {
            CurrentMetricUnit = GramUnit.Units.First();
            CurrentImperialUnit = WeightUnit.Units.First();


            MetricToImperialUnit = new DelegateCommand(() =>
                ImperialValue = CurrentImperialUnit.FromMetricUnit(CurrentMetricUnit, GramValue));


            ImperialUnitToMetric = new DelegateCommand(() =>
                GramValue = CurrentMetricUnit.FromImperialUnit(CurrentImperialUnit, ImperialValue));
        }
    }
}