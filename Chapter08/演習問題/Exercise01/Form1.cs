using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            var str1 = string.Format("{0:yyyy/M/d HH:mm}", dateTime);
            tbDisp.Text = str1+"\r\n";


            var str2 = dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            tbDisp.Text = str2;

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar=new JapaneseCalendar();

            var datestr=dateTime.ToString("ggyy",culture);
            var dayOfWeek=culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);

            var str3=string.Format("{0}年{1,2}月{2,2}日({3})",datestr,dateTime.Month,dateTime.Day,dayOfWeek);  
        }

        private void btEx8_2_Click_Click(object sender, EventArgs e) {

        }
    }
}
