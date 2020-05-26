using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;  //true znamena X je na tahu, false znamena ze Y je na tahu
        int turnCount = 0;  //pocitac tahu
        static String player1, player2;

        public Form1()
        {
            InitializeComponent();
        }

        public static void setPlayerNames (string n1, string n2)    
        {
            player1 = n1;
            player2 = n2;
        }
       
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Eda", "Tic Tac Toe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClick(object sender, EventArgs e) //spolecna metoda pro vsechny btn - proste neco vykona po kliknuti na btn
        {
            Button b = (Button)sender;  //udelej ze sender objektu btn nazvany b
            if (turn)
            {                    //pokud je turn true, zobraz na btn X nebo Y (else vetev)                
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;                  //prehod hrace, aby se stridali
            b.Enabled = false;              //zrus funkcnost btn pote se na nej klikne
            turnCount++;
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool weHaveWinner = false;
            //horizontalni zkouska toho zda mame viteze - proste porovna text na btn a pta se jestli je prvni z tlacitek nekliknutelne
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            {
                weHaveWinner = true;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                weHaveWinner = true;
            }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
            {
                weHaveWinner = true;
            }

            //vertikalni zkouska toho zda mame viteze - proste porovna text na btn a pta se jestli je prvni z tlacitek nekliknutelne
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
            {
                weHaveWinner = true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
            {
                weHaveWinner = true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
            {
                weHaveWinner = true;
            }

            //diagonalni zkouska toho zda mame viteze - proste porovna text na btn a pta se jestli je prvni z tlacitek nekliknutelne
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
            {
                weHaveWinner = true;
            }
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!a3.Enabled))
            {
                weHaveWinner = true;
            }


            if (weHaveWinner)
            {
                disableButtons();           //disabluje btn
                string winner = "";
                if (turn)
                {
                    winner = player2;
                    oWinCount.Text = (Int32.Parse(oWinCount.Text) + 1).ToString();      //updatuj udaj o poctu vitezstvi jednotlivych hracu
                }
                else
                {
                    winner = player1;
                    xWinCount.Text = (Int32.Parse(xWinCount.Text) + 1).ToString();  //updatuj udaj o poctu vitezstvi jednotlivych hracu
                }
                MessageBox.Show(winner + " wins!", "Victory!");
            }
            else if (turnCount == 9)    //remiza
            {                        
                drawCount.Text = (Int32.Parse(drawCount.Text) + 1).ToString();
                MessageBox.Show("This is a draw", ":-)");
            }
        }

        private void disableButtons()
        {
            try         //musim pouzit try block protoze konvertuji vse v okne (tedy nejen buttony) na buttony coz neni bezne
            {
                foreach (Control c in Controls) //vse co okno aplikace obsahuje
                {   
                    Button b = (Button)c;           //konvertuje vse v okne na btn
                    b.Enabled = false;              //vsechny btn disabluj
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            
            foreach (Control c in Controls) //vse co okno aplikace obsahuje
            {
                try
                {
                    Button b = (Button)c;           //konvertuje vse v okne na btn
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { };
            }
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            }
        }


        private void buttonLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetWinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oWinCount.Text = "0";
            xWinCount.Text = "0";
            drawCount.Text = "0";
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
        }
    }
}
