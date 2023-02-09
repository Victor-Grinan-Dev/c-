SwitchStatement

using System;
namespace Giraffe
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1);
            Console.ReadLine();
        }

        static string WeekDay(int day)
        {
            string dayName;
            switch(day)
            {
                case 0:
                    dayName = 'Monday';
                    break;
                case 1:
                    dayName = 'Tuesday';
                    break;
                case 2:
                    dayName = 'Wednesday';
                    break;
                case 3:
                    dayName = 'Thursday';
                    break;
                case 4:
                    dayName = 'Friday';
                    break;
                case 5:
                    dayName = 'Saturday';
                    break;
                case 6:
                    dayName = 'Sunday';
                    break;
                default:   
                    dayName = 'INVALID NUMBER';
                    break;
            }
            return dayName;
        }
    }
}