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
        bool againstComputer = false;       //defaultne je hra pro dva hrace

        public Form1()
        {
            InitializeComponent();
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
            if (p1.Text == "Player 1" || p2.Text == "Player 2")
            {
                MessageBox.Show("You must specify the players name before you can start. Type Computer (for player 2) to play against PC.");
            }
            else
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
            //jestli hrajes proti PC a zaroven je na tahu O (O je vzdy PC)
            if ((!turn) && (againstComputer))
            {
                computerMakeMove();
            }
        }
              
        private void computerMakeMove()
        {
            {
                //1:  ziskej piskvorky - tedy tri pole vertikalne, horizontalne, ci diagonalne
                //2:  kdyz to nejde, blokuj tahy Xka
                //3:  kdyz ani to nejde, zaber rohovy policka
                //4:  kdyz ani to ne, zaber cokoli

                Button move = null;

                //hledej moznosti
                move = lookForWinOrBlock("O"); //zkus vyhrat - bod 1
                if (move == null)
                {
                    move = lookForWinOrBlock("X"); //bod 2
                    if (move == null)
                    {
                        move = lookForCorner();   //bod 3
                        if (move == null)
                        {
                            move = lookForOpenSpace(); //bod 4
                        }
                    }
                }
                if (turnCount != 9)     //klikne se jen tehdy, kdyz je mene nez 9 obsazenych policek
                { 
                    move.PerformClick();        //klikni na policko
                }
            }
        }

        private Button lookForWinOrBlock(string mark) //metoda vraci button na ktery kliknu

        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((a1.Text == mark) && (a2.Text == mark) && (a3.Text == ""))  //kdyz je A1 a A2 X nebo O (win or block) a take je volny A3, vrat to volne pole (zde A3)
                return a3;
            if ((a2.Text == mark) && (a3.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (a3.Text == mark) && (a2.Text == ""))
                return a2;

            if ((b1.Text == mark) && (b2.Text == mark) && (b3.Text == ""))
                return b3;
            if ((b2.Text == mark) && (b3.Text == mark) && (b1.Text == ""))
                return b1;
            if ((b1.Text == mark) && (b3.Text == mark) && (b2.Text == ""))
                return b2;

            if ((c1.Text == mark) && (c2.Text == mark) && (c3.Text == ""))
                return c3;
            if ((c2.Text == mark) && (c3.Text == mark) && (c1.Text == ""))
                return c1;
            if ((c1.Text == mark) && (c3.Text == mark) && (c2.Text == ""))
                return c2;

            //VERTICAL TESTS
            if ((a1.Text == mark) && (b1.Text == mark) && (c1.Text == ""))
                return c1;
            if ((b1.Text == mark) && (c1.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (c1.Text == mark) && (b1.Text == ""))
                return b1;

            if ((a2.Text == mark) && (b2.Text == mark) && (c2.Text == ""))
                return c2;
            if ((b2.Text == mark) && (c2.Text == mark) && (a2.Text == ""))
                return a2;
            if ((a2.Text == mark) && (c2.Text == mark) && (b2.Text == ""))
                return b2;

            if ((a3.Text == mark) && (b3.Text == mark) && (c3.Text == ""))
                return c3;
            if ((b3.Text == mark) && (c3.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a3.Text == mark) && (c3.Text == mark) && (b3.Text == ""))
                return b3;

            //DIAGONAL TESTS
            if ((a1.Text == mark) && (b2.Text == mark) && (c3.Text == ""))
                return c3;
            if ((b2.Text == mark) && (c3.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (c3.Text == mark) && (b2.Text == ""))
                return b2;

            if ((a3.Text == mark) && (b2.Text == mark) && (c1.Text == ""))
                return c1;
            if ((b2.Text == mark) && (c1.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a3.Text == mark) && (c1.Text == mark) && (b2.Text == ""))
                return b2;

            return null;  //zadny pouzitelny tah jsem nenasel
        }

        private Button lookForCorner() 

        {
            Console.WriteLine("Looking for corner");
            if (a1.Text == "O")
            {
                if (a3.Text == "")
                    return a3;
                if (c3.Text == "")
                    return c3;
                if (c1.Text == "")
                    return c1;
            }

            if (a3.Text == "O")
            {
                if (a1.Text == "")
                    return a1;
                if (c3.Text == "")
                    return c3;
                if (c1.Text == "")
                    return c1;
            }

            if (c3.Text == "O")
            {
                if (a1.Text == "")
                    return a3;
                if (a3.Text == "")
                    return a3;
                if (c1.Text == "")
                    return c1;
            }

            if (c1.Text == "O")
            {
                if (a1.Text == "")
                    return a3;
                if (a3.Text == "")
                    return a3;
                if (c3.Text == "")
                    return c3;
            }

            if (a1.Text == "")
                return a1;
            if (a3.Text == "")
                return a3;
            if (c1.Text == "")
                return c1;
            if (c3.Text == "")
                return c3;

            return null;        //pokud nenajdu volne rohove pole
        }

        private Button lookForOpenSpace() 
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)     //projdi vsechny pole v aplikaci (buttony, textboxy atd.)
            {
                b = c as Button;        //zkus vse prevest na button - to samozrejme nejde - kod vrati null
                if (b != null)          //pokud to neni null, je to button
                {
                    if (b.Text == "")           //pole je prazdne, neoznacene X ci O
                        return b;               //vrat button
                }
            }

            return null;
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
                    winner = p2.Text;
                    oWinCount.Text = (Int32.Parse(oWinCount.Text) + 1).ToString();      //updatuj udaj o poctu vitezstvi jednotlivych hracu
                }
                else
                {
                    winner = p1.Text;
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

        private void p2_TextChanged(object sender, EventArgs e)
        {
            if (p2.Text.ToUpper() == "COMPUTER")
            {
                againstComputer = true;
            }
            else
            {
                againstComputer = false;
            }
        }

        private void setPlayerDefaultsToolStripMenuItem_Click(object sender, EventArgs e)       //automaticky nastavi jmena hracu - viz i metoda nize
        {
            p1.Text = "Eda";
            p2.Text = "Computer";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setPlayerDefaultsToolStripMenuItem.PerformClick();
        }


    }
}
