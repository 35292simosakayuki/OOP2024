using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport>listCarReports=new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReport.DateSource=listCarReports;

        }

        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport carReport = new CarReport {
                Date=dtpDate.Value,
            };
            listCarReports.Add(carReport);
        }
    }
}
