using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int num = 0;
        private int counter = 0;
        private int playerSteps = 0;

        
        
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    counter = default;
                    label1.Text = Convert.ToString("Ошибка");
                    return; 
                }
                counter = value;
                label1.Text = $"Ваше число:{counter}";
                if (tempCounter.Count>0)
                
                
                CheckPlayersAnswer(value);
            }
        }
        public int PlayerSteps
        {
            get {  return playerSteps;  }
            set {
                if (value >= 0)
                    playerSteps = value;
            }
        }

     

        public int ComputerSteps { get; set; }


        Stack<int> tempCounter = new Stack<int>();

        private int helpIndex = 0;
        List<int> help = new List<int>();


        private void Plus1Button(object sender, EventArgs e)
        {
            PlayerSteps++;
            tempCounter.Push(Counter);
            Counter++;
           
        }
        private void MultiplyButton(object sender, EventArgs e)
        {
            PlayerSteps++;
            tempCounter.Push(Counter);
            Counter *= 2;
            
        }

        
        
        private void Reset()
        {
            label2.Text = "Загаданное число:";
            label1.Text = "Ваше число:";
            ComputerSteps = default;
            Counter = default;
            PlayerSteps = default;
            
            tempCounter.Clear();
        }
        private void PlayButton(object sender, EventArgs e)
        {
            
            Reset();
            Random random = new Random();
            Num = random.Next(1,100);
            CountMinStepsToGetNum(Num);
            label2.Text += $" {num}";
            EnableButtons(true);
        }
        private void CheckPlayersAnswer(int value)
        {
            switch (value)
            {
                case int i when i == Num:
                    if (PlayerSteps > ComputerSteps)
                    {
                        MessageBox.Show("Возможно сделать меньше ходов");
                    }
                    else if (PlayerSteps == ComputerSteps)
                    {
                        MessageBox.Show("Вы победили");
                        EnableButtons(false);
                    }
                    break;

                case int i when i > Num:
                    MessageBox.Show("Вы проиграли");
                    EnableButtons(false);
                    break;

                default:
                    
                    counter = value;
                    break;
            }
        }
        private void EnableButtons(bool toogle)
        {
            if(toogle == true) {
                MultiplyX2.Enabled = true;
                Plus1.Enabled = true;
                Back.Enabled = true;
                DropToDeafult.Enabled = true;
            }
            else
            {
                MultiplyX2.Enabled = false;
                Plus1.Enabled = false;
                Back.Enabled = false;
                DropToDeafult.Enabled = false;
            }
        }
        

        private void CountMinStepsToGetNum(int num)
        {
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
                help.Add(num);
                ComputerSteps++;
            }
            helpIndex = help.Count();
        }

        private void DropTOdefault(object sender, EventArgs e)
        {
            Counter = 0;
            PlayerSteps = 0;
            tempCounter.Clear();
        }
        private void BackButton(object sender, EventArgs e)
        {
            
            PlayerSteps--;
            if (tempCounter.Count > 0)
            {
                Counter = tempCounter.Pop();
            }

        }

    }
}

