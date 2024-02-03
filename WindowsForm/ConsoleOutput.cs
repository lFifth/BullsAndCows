using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    internal class ConsoleOutput
    {
        public ConsoleOutput()
        {
            console[17] = ">Привет!";
            console[18] = ">Хочешь начать игру? Y\\N";
        }
        public string[] console = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", };//19
        public string Show()
        {
            string temp = console[1];
            foreach (var item in console)
                temp += $"\n{item}";
            return temp;
        }
        public string AddShow(string[] variable)
        {
            for (int i = 0; i < 19 - variable.Length; i++)
                console[i] = console[i + variable.Length];
            for (int i = 19 - variable.Length, j = 0; i < 19; i++, j++)
                console[i] = $">{variable[j]}";
            return Show();
        }
        public void Restart()
        {
            for (int i = 0; i < 19; i++)
                console[i] = "";
        }
    }
}
