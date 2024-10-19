using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game_Assignment
{
    public partial class Form1 : Form
    {
        char player = 'O'; // Track the current player
        short turnCounter = 0; // Track the total moves made

        public Form1()
        {
            InitializeComponent();

            // Assigninf shortcut keys F1 to New Game, F2 to About and F3 to exit from the menu items
            optionsToolStripMenuItem.ShortcutKeys = Keys.F1;  // New Game
            aboutToolStripMenuItem.ShortcutKeys = Keys.F2;    // About
            exitToolStripMenuItem.ShortcutKeys = Keys.F3;     // Exit

            // Link menu item clicks to their event handlers
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        }

        // Fucntion to handle the shortcut key presses for F1, F2, and F3
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1: // New Game
                    optionsToolStripMenuItem_Click(this, EventArgs.Empty);
                    return true;

                case Keys.F2: // About
                    aboutToolStripMenuItem_Click(this, EventArgs.Empty);
                    return true;

                case Keys.F3: // Exit
                    exitToolStripMenuItem_Click(this, EventArgs.Empty);
                    return true;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        // Options means the "New Game" is clicked or the button F1 has been pressed
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player = 'O'; // Reset to player O
            turnCounter = 0; // Reset move count
            tableLayoutPanel1.Enabled = true; // Re-enable the game board

            // Clearing all buttons on the form to start a new game
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Button button)
                {
                    button.Text = "";  // Clear text
                    button.Enabled = true; // Enable button
                    button.BackColor = DefaultBackColor; // Reset color
                }
            }
        }

        //Once F2 or About has been clicked this information about the game  will appear.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Tic Tac Toe Game\n" +
                "Click on a square to make a move.\n" +
                "The first player is X, the second player is O.\n" +
                "The winner is the first player to align three symbols horizontally, vertically, or diagonally.\n" +
                "If no winner is found after all moves, the game is a draw.\n\n" +
                "Game made by Leiziane Trevisan Dardin"
            );
        }

        // Handle button clicks for moves
        private void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            btn.BackColor = Color.Gray;

            if (player == 'O')
            {
                btn.Text = "O";

                // Check for winning conditions or draw fucntions called
                if (IsWinningMove() || turnCounter == 8)
                {
                    HandleGameEnd();
                }
                else
                {
                    player = 'X'; // Switch to player X
                    turnCounter++;
                }
            }
            else if (player == 'X')
            {
                btn.Text = "X";

                if (IsWinningMove() || turnCounter == 8)
                {
                    HandleGameEnd();
                }
                else
                {
                    player = 'O'; // Switch to player O
                    turnCounter++;
                }
            }
        }

        //Winner conditions Functions
        private bool IsWinningMove()
        {
            // Checking winner Horizontally
            return (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
                   (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                   (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||
            // Checking winner Vertically
                   (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                   (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                   (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != "") ||
            // Checking winner Diagonally
                   (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                   (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "");
        }

        // Handles the end of the game (win or draw)
        private void HandleGameEnd()
        {
            if (IsWinningMove())
            {
                MessageBox.Show($"The winner is: {player}!");
            }
            else
            {
                MessageBox.Show("No Winner.\nIt's a Draw Match!");
            }
            tableLayoutPanel1.Enabled = false; // The board is disabled here
        }

        // Exit the application when "Exit" is clicked or F3 is pressed
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}


//OpenAI. (2024). Support to add the shortkeys for New Game, About and Exit buttons and improved readbility in private bool IsWinningMove() and
//private void HandleGameEnd(). 
// Winning conditions in one place for clarity ChatGPT.

//Code before improvements:
/* private void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            btn.BackColor = Color.Orange;

            if (player == 'O')
            {
                btn.Text = "O";
                //Checking Horizontal
                if ((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
                   (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                   (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||


                   //Checking Vertical
                   (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                   (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                   (btn3.Text == btn6.Text && btn6.Text == btn3.Text && btn6.Text != "") ||

                //Checking Diagonal
                   (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                   (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != ""))

                {
                    MessageBox.Show(($"The winner is: {player.ToString()}!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (turnCounter == 8)

                {
                    MessageBox.Show("No Winner \t" +
                                       "It is a Draw Match!");
                }

                player = 'X';

            }
            else if (player == 'X')
            {

                btn.Text = "X";
                if ((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
                   (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                   (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||


                   //Checking Vertical
                   (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                   (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                   (btn3.Text == btn6.Text && btn6.Text == btn3.Text && btn6.Text != "") ||

                //Checking Diagonal
                   (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                   (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != ""))

                {
                    MessageBox.Show(($"The winner is: {turnCounter.ToString()}!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (turnCounter == 8)

                {
                    MessageBox.Show("No Winner \t" +
                                    "  \t" +
                                    "It is a Draw Match!");
                }
                player = 'O';
            }
            turnCounter++; //move is incremented by 1 until reaches the 9 tries.

        }

*/