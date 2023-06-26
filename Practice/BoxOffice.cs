using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Practice
{
    public class BoxOffice
    {
        bool check;
        public void SetCheck(bool value)
        {
             check = value;
        }
        void timer()
        {
            Form1 form = new Form1(); 
            // Создаем таймер
            Timer timer = new Timer(10 * 60 * 1000); // Интервал в миллисекундах (10 минут = 10 * 60 * 1000 миллисекунд)
            timer.Elapsed += TimerElapsed; // Подписываемся на событие Elapsed
            timer.AutoReset = true; // Устанавливаем повторение

            // Запускаем таймер
            if (check == true)
            {
                timer.Start();
                form.Message("Симуляция запущена");
            }
            else
            {
                // Останавливаем таймер
                timer.Stop();
                form.Message("Симуляция остановлена");
            }
        }

        static void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Ваш код, который должен выполняться каждые 10 минут
            // Напишите здесь свой код
            Console.WriteLine("Событие выполнилось!");
        }
    }
}
