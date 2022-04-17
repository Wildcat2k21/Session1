using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool
{
    class timeInSeconds //время и пробразование
    {
        private int hours = 0, minutes = 0, seconds = 0;

        public void AddTime(int[] time)
        {
            hours += time[0];
            minutes += time[1];
            seconds += time[2];
        }

        //прибавить секунды к времени
        public void AddSeconds(int seconds) {
            int[] time = Calc(seconds);
            double lostM, lostS;
            int _min, _sec;

            //Сумма секунд
            lostS = (time[2] + this.seconds) / 60;
            Math.Truncate(lostS);
            _sec = (time[2] + this.seconds) % 60;

            //Сумма минут
            lostM = (time[1] + minutes + Convert.ToInt32(lostS)) / 60;
            Math.Truncate(lostM);
            _min = (time[1] + minutes + Convert.ToInt32(lostS)) % 60;

            //Сумма часов
            hours += (time[0] + Convert.ToInt32(lostM));
            minutes = Convert.ToInt32(_min);
            this.seconds = _sec;
        }

        private int[] Calc(int seconds) {
            //дубликаты для подсчета
            int _hours = 0, _minutes = 0, _seconds = 0;

            //остатки от деления разрядов времени
            double rawHours, rawMinutes;

            //вычисление часов
            rawHours = seconds / 3600;
            Math.Truncate(rawHours);
            _hours = Convert.ToInt32(rawHours);

            //вычисление минут
            rawMinutes = (seconds - _hours * 3600) / 60;
            Math.Truncate(rawMinutes);
            _minutes = Convert.ToInt32(rawMinutes);

            //вычисление секунд
            _seconds = seconds - (_hours * 3600 + _minutes * 60);

            return new int[3] {
                _hours, _minutes, _seconds
            };
        }

        public int[] GetFullTime() {
            return new int[3]{
                hours, minutes, seconds
            };
        }

        public string ToDateTimeString() {
            return hours.ToString() + ':' + minutes.ToString() + ':' + this.seconds.ToString();
        }
    }
}
