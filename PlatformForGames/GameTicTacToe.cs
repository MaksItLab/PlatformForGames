using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformForGames
{
    public partial class GameTicTacToe : Form
    {
        public bool Step = false;

        int[,] array = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        
        public GameTicTacToe()
        {
            InitializeComponent();
        }

        public void Win()
        {
            if(array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2] && array[0, 0] != 0 && array[0, 1] != 0 && array[0, 2] != 0 ||
               array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2] && array[1, 0] != 0 && array[1, 1] != 0 && array[1, 2] != 0 ||
               array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2] && array[2, 0] != 0 && array[2, 1] != 0 && array[2, 2] != 0 ||

               array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0] && array[0, 0] != 0 && array[1, 0] != 0 && array[2, 0] != 0 ||
               array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1] && array[0, 1] != 0 && array[1, 1] != 0 && array[2, 1] != 0 ||
               array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2] && array[0, 2] != 0 && array[1, 2] != 0 && array[2, 2] != 0 ||

               array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[0, 0] != 0 && array[1, 1] != 0 && array[2, 2] != 0 ||
               array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[0, 2] != 0 && array[1, 1] != 0 && array[2, 0] != 0 )
            {

                MessageBox.Show("VICTORY!");
                if (Step)
                {
                    label1.Text = (int.Parse(label1.Text) + 1).ToString();
                }
                else
                {
                    label2.Text = (int.Parse(label2.Text) + 1).ToString();
                }

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                Step = false;
                array = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button1.Text))
            {
                if (Step)
                {
                    button1.Text = "X";
                    Step = !Step;
                    array[0, 0] = -1; // поставили X
                }
                else
                {
                    button1.Text = "O";
                    Step = !Step;
                    array[0, 0] = 1; // Поставили O
                }
            }
            Win();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button2.Text))
            {
                if (Step)
                {
                    button2.Text = "X";
                    Step = !Step;
                    array[0, 1] = -1; // поставили X
                }
                else
                {
                    button2.Text = "O";
                    Step = !Step;
                    array[0, 1] = 1; // Поставили O
                }
            }
            Win();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button3.Text))
            {
                if (Step)
                {
                    button3.Text = "X";
                    Step = !Step;
                    array[0, 2] = -1; // поставили X
                }
                else
                {
                    button3.Text = "O";
                    Step = !Step;
                    array[0, 2] = 1; // Поставили O
                }
            }
            Win();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button6.Text))
            {
                if (Step)
                {
                    button6.Text = "X";
                    Step = !Step;
                    array[1, 0] = -1; // поставили X
                }
                else
                {
                    button6.Text = "O";
                    Step = !Step;
                    array[1, 0] = 1; // Поставили O
                }
            }
            Win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button5.Text))
            {
                if (Step)
                {
                    button5.Text = "X";
                    Step = !Step;
                    array[1, 1] = -1; // поставили X
                }
                else
                {
                    button5.Text = "O";
                    Step = !Step;
                    array[1, 1] = 1; // Поставили O
                }
            }
            Win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button4.Text))
            {
                if (Step)
                {
                    button4.Text = "X";
                    Step = !Step;
                    array[1, 2] = -1; // поставили X
                }
                else
                {
                    button4.Text = "O";
                    Step = !Step;
                    array[1, 2] = 1; // Поставили O
                }

            }
            Win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button9.Text))
            {
                if (Step)
                {
                    button9.Text = "X";
                    Step = !Step;
                    array[2, 0] = -1; // поставили X
                }
                else
                {
                    button9.Text = "O";
                    Step = !Step;
                    array[2, 0] = 1; // Поставили O
                }
            }
            Win();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button8.Text))
            {
                if (Step)
                {
                    button8.Text = "X";
                    Step = !Step;
                    array[2, 1] = -1; // поставили X
                }
                else
                {
                    button8.Text = "O";
                    Step = !Step;
                    array[2, 1] = 1; // Поставили O
                }
            }
            Win();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button7.Text))
            {
                if (Step)
                {
                    button7.Text = "X";
                    Step = !Step;
                    array[2, 2] = -1; // поставили X
                }
                else
                {
                    button7.Text = "O";
                    Step = !Step;
                    array[2, 2] = 1; // Поставили O
                }
            }
            Win();
        }
    }
}
