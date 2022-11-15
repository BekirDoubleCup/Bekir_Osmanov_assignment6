using Microsoft.VisualBasic.Devices;

namespace Bekir_Osmanov_assignment6
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void user_choice_Click(object sender, EventArgs e)
        {

        }
        int player_choice = 0;
        private void rock_choice_Click(object sender, EventArgs e)
        {
            player_choice = 1;
            {
                int computer_turn = random.Next(1, 4);
                switch (computer_turn)
                {
                    case 1:
                        computer_choice.Image = Properties.Resources.stone_PNG13588;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        computer_choice.Image = Properties.Resources.Paper_Sheet;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        computer_choice.Image = Properties.Resources.Scissor_PNG_Clipart;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    default:
                        computer_choice.Image = Properties.Resources.stone_PNG13588;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;

                }
                switch (player_choice)
                {
                    case 1:
                        user_choice.Image = Properties.Resources.stone_PNG13588;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        user_choice.Image = Properties.Resources.Paper_Sheet;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        user_choice.Image = Properties.Resources.Scissor_PNG_Clipart;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    default:
                        user_choice.Image = Properties.Resources.stone_PNG13588;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
                determineWinner(computer_turn, player_choice);
            }
        }

        private void paper_choice_Click(object sender, EventArgs e)
        {
            player_choice = 2;
            {
                int computer_turn = random.Next(1, 4);
                switch (computer_turn)
                {
                    case 1:
                        computer_choice.Image = Properties.Resources.stone_PNG13588;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        computer_choice.Image = Properties.Resources.Paper_Sheet;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        computer_choice.Image = Properties.Resources.Scissor_PNG_Clipart;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    default:
                        computer_choice.Image = Properties.Resources.stone_PNG13588;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;

                }
                switch (player_choice)
                {
                    case 1:
                        user_choice.Image = Properties.Resources.stone_PNG13588;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        user_choice.Image = Properties.Resources.Paper_Sheet;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        user_choice.Image = Properties.Resources.Scissor_PNG_Clipart;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    default:
                        user_choice.Image = Properties.Resources.stone_PNG13588;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
                determineWinner(computer_turn, player_choice);
            }
        }

        private void scissors_choice_Click(object sender, EventArgs e)
        {
            player_choice = 3;
            {
                int computer_turn = random.Next(1, 4);
                switch (computer_turn)
                {
                    case 1:
                        computer_choice.Image = Properties.Resources.stone_PNG13588;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        computer_choice.Image = Properties.Resources.Paper_Sheet;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        computer_choice.Image = Properties.Resources.Scissor_PNG_Clipart;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    default:
                        computer_choice.Image = Properties.Resources.stone_PNG13588;
                        computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;

                }
                switch (player_choice)
                {
                    case 1:
                        user_choice.Image = Properties.Resources.stone_PNG13588;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        user_choice.Image = Properties.Resources.Paper_Sheet;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        user_choice.Image = Properties.Resources.Scissor_PNG_Clipart;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    default:
                        user_choice.Image = Properties.Resources.stone_PNG13588;
                        user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
                determineWinner(computer_turn, player_choice);
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            int computer_turn = random.Next(1, 4);
            switch (computer_turn)
            {
                case 1:
                    computer_choice.Image = Properties.Resources.stone_PNG13588;
                    computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    computer_choice.Image = Properties.Resources.Paper_Sheet;
                    computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    computer_choice.Image = Properties.Resources.Scissor_PNG_Clipart ;
                    computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                default:
                    computer_choice.Image = Properties.Resources.stone_PNG13588;
                    computer_choice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

            }
            switch (player_choice)
            {
                case 1:
                    user_choice.Image = Properties.Resources.stone_PNG13588;
                    user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    user_choice.Image = Properties.Resources.Paper_Sheet;
                    user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    user_choice.Image = Properties.Resources.Scissor_PNG_Clipart;
                    user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                default:
                    user_choice.Image = Properties.Resources.stone_PNG13588;
                    user_choice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
            determineWinner(computer_turn, player_choice);
        }
        public void determineWinner(int computerScore, int playerScore)
        {
            if(computerScore == 1 && playerScore == 2)
            {
                label5.Text = "You Won!";
            }
            else if (computerScore == 1 && playerScore == 3)
            {
                label5.Text = "Loser!";
            }
            else if (computerScore == 2 && playerScore == 1)
            {
                label5.Text = "Loser!";
            }
            else if (computerScore == 2 && playerScore == 3)
            {
                label5.Text = "You Won!";
            }
            else if (computerScore == 3 && playerScore == 1)
            {
                label5.Text = "You Won!";
            }
            else if (computerScore == 3 && playerScore == 2)
            {
                label5.Text = "Loser!";
            }
            else
            {
                label5.Text = "A Tie!!!";
            }
        }
    }
}