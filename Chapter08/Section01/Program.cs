using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("年:");
            int year = int.Parse(Console.ReadLine());

            Console.Write("月:");
            int mounth = int.Parse(Console.ReadLine());

            Console.Write("日:");
            int day = int.Parse(Console.ReadLine());



            var birthday = new DateTime(year, mounth, day);
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar=new JapaneseCalendar();
            
            var day1 = culture.DateTimeFormat.GetDayName(birthday.DayOfWeek);

            
            var totalDays = DateTime.Today.Subtract(birthday).TotalDays;


            Console.WriteLine("あなたは"+birthday.ToString("ggyy年M月d日",culture)+day1+"に生まれました");

            Console.WriteLine("あなたは生まれてから今日で"+totalDays+"日目です");

        }


    }
}

