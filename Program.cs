using System;

namespace YEARMOUTHDAY
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入年份");
            //int year = Console.ReadLine();
            //Console.WriteLine("请输出月份");
            //string month = Console.ReadLine();
            //Console.WriteLine("请输入日期");
            //string day = Console.ReadLine();
            int year = 2019, month = 4,day = 16;
            PrintCalende(year, month, day);
  
        }
   
        private static  void PrintCalende(int year,int month,int day)
        {
            Console.WriteLine("{0}年 {1} 月 {2}", year, month, day);
            Console.WriteLine("日\t一\t二\t三\t四\t五\t六\t");
            int Week = GetWeekByDay(year, month,1);
            for (int i = 0; i < Week; i++)
            { 
                Console.WriteLine(" "+"\t");
             };
            int days = GetDaysByMonth(year, month);

            for (int i = 1; i <= days; i++)
            {
                Console.Write(i+"\t");
              
                if (GetWeekByDay(year, month, i) == 6)
                {
                    Console.WriteLine();
                }
             
                }
        }
        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        }
        private static int GetDaysByMonth(int year, int month)
        {
            if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 2:
                        return IsLeapYear(year) ? 29 : 28;
                    case 4:
                    case 6:
                    case 8:
                    case 11:
                        return 30;
                    default:
                        return 31;
                }
            }
            else
                return 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns>星期几</returns>
        private static  int GetWeekByDay(int year,int month,int day)
        {
            DateTime weekByday = new DateTime(year,month,day);
            return (int) weekByday.DayOfWeek;
        }



///啊啊啊啊啊

    }
}
