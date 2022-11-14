namespace WinFormsApp1
   
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer cp;
        public Form1()
        {
            InitializeComponent();
            cp = CurrentPlayer.Cross;
            changelabel();
        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton =  (Button)sender;
            if (cp == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                cp = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
                cp = CurrentPlayer.Cross;
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label2.Text = "Wygra³ gracz X";
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label2.Text = "Wygra³ gracz X";
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label2.Text = "Wygra³ gracz X";
            }
            if (button7.Text == "X" && button4.Text == "X" && button1.Text == "X")
            {
                label2.Text = "Wygra³ gracz X";
            }
            if (button8.Text == "X" && button5.Text == "X" && button2.Text == "X")
            {
                label2.Text = "Wygra³ gracz X";
            }
            if (button9.Text == "X" && button6.Text == "X" && button3.Text == "X")
            {
                label2.Text = "Wygra³ gracz X";
            }
            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                label2.Text = "Wygra³ gracz X";
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label2.Text = "Wygra³ gracz X";
            }

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label2.Text = "Wygra³ gracz O";
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label2.Text = "Wygra³ gracz O";
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label2.Text = "Wygra³ gracz O";
            }
            if (button7.Text == "O" && button4.Text == "O" && button1.Text == "O")
            {
                label2.Text = "Wygra³ gracz O";
            }
            if (button8.Text == "O" && button5.Text == "O" && button2.Text == "O")
            {
                label2.Text = "Wygra³ gracz O";
            }
            if (button9.Text == "O" && button6.Text == "O" && button3.Text == "O")
            {
                label2.Text = "Wygra³ gracz O";
            }
            if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                label2.Text = "Wygra³ gracz O";
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label2.Text = "Wygra³ gracz O";
            }
            changelabel();
        }
        public void changelabel()
        {
            if (cp == CurrentPlayer.Cross)
            {
                CurrentPlayerLabel.Text = "Krzy¿yk";
            }
            else
            {
                CurrentPlayerLabel.Text = "kó³ko";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}