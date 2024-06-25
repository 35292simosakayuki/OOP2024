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


            var str2 = dateTime.ToString("yyyy”NMMŒŽdd“ú HHŽžmm•ªss•b");
            tbDisp.Text = str2;

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar=new JapaneseCalendar();

            var datestr=dateTime.ToString("ggyy",culture);
            var dayOfWeek=culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);

            var str3=string.Format("{0}”N{1,2}ŒŽ{2,2}“ú({3})",datestr,dateTime.Month,dateTime.Day,dayOfWeek);  
        }

        private void btEx8_2_Click_Click(object sender, EventArgs e) {

        }
    }
}
