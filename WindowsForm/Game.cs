using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsForm
{
    public partial class Game : Form
    {
        private bool launch = false;
        private int attempts;
        private Game1 game1;
        private ConsoleOutput consoleOutput = new ConsoleOutput();
        private Words words = new Words();
        public void Show()
        { Console.Text = consoleOutput.Show(); }
        public void AddShow(params string[] variable)
        { Console.Text = consoleOutput.AddShow(variable); }
        public void Start()
        {
            attempts = 5;
            game1 = new Game1();
            Field1.Text = game1.Field1;
            Field2.Text = game1.Field2;
            Attempts.Text = $"Попыток осталось: {attempts}";
            AddShow("Игра началась!");
        }
        public Game() { InitializeComponent(); }
        private void button1_Click(object sender, EventArgs e) { Info info = new Info(); info.Show(); }
        private void CloseButton_Click(object sender, EventArgs e) { this.Close(); }
        private void Game_Load(object sender, EventArgs e) { Show(); Attempts.Text = ""; }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !launch)
            {
                AddShow($"{textBox1.Text}");
                string text = (string)(textBox1.Text).ToLower();
                textBox1.Clear();
                switch (text)
                {
                    case "y":
                        {
                            Start();
                            launch = true;
                            break;
                        }
                    case "n":
                        {
                            this.Close();
                            break;
                        }
                    default:
                        {
                            AddShow("Я не знаю такой команды", "Хочешь начать игру? Y\\N");
                            break;
                        }
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {

                AddShow($"{textBox1.Text}");
                string text = textBox1.Text.ToUpper();
                textBox1.Clear();
                if (consoleOutput.console[17] == ">Хотите сыграть ещё раз? Y\\N")
                {
                    if (text == "Y")
                    {
                        consoleOutput.Restart();
                        Start();
                        return;
                    }
                    else if (text == "N")
                    {
                        Field1.Text = "";
                        Field2.Text = "";
                        Attempts.Text = "";
                        consoleOutput = new ConsoleOutput();
                        Show();
                        launch = false;
                        return;
                    }
                    else
                    {
                        AddShow("Я не знаю такой команды", "Хотите сыграть ещё раз? Y\\N");
                        return;
                    }
                }

                if (text == (string)game1.rightWord)
                {
                    AddShow("Вы победили", "Хотите сыграть ещё раз? Y\\N");
                }
                else if (Array.IndexOf(game1.wordList, text) != -1)
                {
                    Attempts.Text = $"Попыток осталось: {--attempts}";
                    if (attempts == 0)
                    {
                        AddShow("Вы проиграли", $"Правильное слово: {game1.rightWord}", "Хотите сыграть ещё раз? Y\\N");
                        return;
                    }
                    AddShow($"{game1.BullsAndCows(text)}");
                    
                }
                else if (text == "ПЕРЕЗАПУСК")
                {
                    consoleOutput.Restart();
                    Start();
                }
                else if (text == "YYNY")
                    MessageBox.Show($"{game1.rightWord}");
                else
                {
                    AddShow("Слово не найдено");
                }
            }
        }
    }
}
