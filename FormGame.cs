using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtestatMinesweeper
{
    public partial class FormGame : Form
    {
        public static class globals
        {
            public static int totalBombCount = 10;
            public static int remainingBombCount;
            public static int foundBombCount = 0;
            public static int totalSquares = 100;
            public static int fieldSizeX = 5;
            public static int fieldSizeY = 5;
            public static float timeElapsedInSeconds = 0;
            public static int subSecondTime = 0;
            public static int secondTime = 0;
        }
        public static class globalMatrixes
        {
            public static int[,] matrixBackend= new int [globals.fieldSizeX + 1, globals.fieldSizeY + 1];
            public static spot[,] gameField = new spot[globals.fieldSizeY+1, globals.fieldSizeX+1];
            public static void convertBackToFront()
            {
                for(int i=1;i<=globals.fieldSizeY;i++)
                {
                    for(int j=1;j<=globals.fieldSizeX;j++)
                    {
                        if (matrixBackend[i, j] == 1)
                        {
                            gameField[i, j].hiddenStatus = 1;
                            gameField[i, j].button.ForeColor = Color.Red;
                            gameField[i, j].button.Text = "bomb";
                        }
                        else
                        {
                            gameField[i, j].hiddenStatus = 0;
                            gameField[i, j].button.ForeColor = Color.Black;
                            gameField[i, j].button.Text = "empty";
                        }

                    }
                }
                //miez number modifier
                for (int i = 1; i <= globals.fieldSizeY; i++)
                {
                    for (int j = 1; j <= globals.fieldSizeX; j++)
                    {
                        if(gameField[i, j].hiddenStatus == 0)
                        {
                            int neighbours = 0;
                            for (int ii= i - 1; ii <= i + 1;ii++)
                            {
                                for(int jj=j-1;jj<=j+1;jj++)
                                {
                                    if(ii>=1 && ii<= globals.fieldSizeY && jj>=1 && jj<=globals.fieldSizeX)
                                        if (gameField[ii, jj].hiddenStatus == 1 )
                                        neighbours++;
                                }

                            }
                            gameField[i, j].button.ForeColor = Color.DarkBlue;
                            gameField[i, j].button.Text = neighbours.ToString();
                            gameField[i, j].button.Font = new Font("Georgia", 15, FontStyle.Bold);
                        }
                    }
                }
            }

        }
        public class spot
        {
            public Button button;
            public int hiddenStatus; //0=safe, 1=bomb;
            public int revealStatus; // -1=unrevealed, 0-9 = bombs surounding, 10=bomb;
            public spot(Button buttonToSet, int hiddenStatusToSet, int revealStatusToSet)
            {
                button = buttonToSet;
                hiddenStatus = hiddenStatusToSet;
                revealStatus = revealStatusToSet;
            }
        }
        public FormGame()
        {
            InitializeComponent();
            globals.remainingBombCount = globals.totalBombCount;
            updateCounters(0, 0);
            globals.fieldSizeX = Convert.ToInt32(Math.Sqrt(globals.totalSquares));
            globals.fieldSizeY = globals.fieldSizeX;//changes the vraibles of game size
            generateField(globals.totalSquares);
            timerGame.Enabled = Enabled;
            generateBackendMatrix(globals.fieldSizeX, globals.fieldSizeY);


        }
        public void generateBackendMatrix(int fsizex,int fsizeY)
        {
            for (int i = 1; i <= globals.fieldSizeX; i++)
            {
                for (int j = 1; j <= globals.fieldSizeY; j++)
                {
                    globalMatrixes.matrixBackend[i, j] = 0;
                }
            }
            int bombsLeftToPlace = globals.totalBombCount;
            while(bombsLeftToPlace!=0)
            {
                Random rnd = new Random();
                int randX = rnd.Next(1, fsizex+1 );
                int randY = rnd.Next(1, fsizeY+1 );
                if(globalMatrixes.matrixBackend[randX, randY] == 0)
                {
                    globalMatrixes.matrixBackend[randX, randY] = 1;
                    bombsLeftToPlace--;
                }
            }
        }
        public void updateCounters(int changeRemaining, int changeFound)
        {
            //Updates the amounts of bombs on the left hand side
            globals.remainingBombCount = globals.remainingBombCount + changeRemaining;
            globals.foundBombCount = globals.foundBombCount + changeFound;
            textBoxBombsRemaining.Text = Convert.ToString(globals.remainingBombCount);
            textBoxBombsFound.Text = Convert.ToString(globals.foundBombCount);
        }
        private void generateField(int squareCount)
        {
            int currentCell = 1;
            int spotSizeHeight = panelGame.Height / globals.fieldSizeX;
            int spotSizeWidth = panelGame.Width / globals.fieldSizeY;
            for (int x=1;x<= globals.fieldSizeY;x++)
            {
                for (int y = 1; y <= globals.fieldSizeX; y++)
                {
                    Button buttonToPlace = new Button()
                    {
                        Width = spotSizeWidth,
                        Height = spotSizeHeight,
                        BackColor = Color.Gray,
                        Location = new Point((x-1) * spotSizeWidth, (y-1) * spotSizeHeight),
                        FlatStyle = FlatStyle.Flat,
                        Parent = panelGame,
                        Text = "empty",//initilazing button properties
                    };
                    globalMatrixes.gameField[x, y] = new spot(buttonToPlace, 0, -1);  //intilizes button as safe and unrevealed 
                    currentCell++;
                }
            }

        }
        private void buttontest_Click(object sender, EventArgs e)
        {
            updateCounters(-1, 1);
        }
        private void timerGame_Tick(object sender, EventArgs e)
        {
            //Alfred, adu Bat-Streangul acum!!!
            if(globals.subSecondTime==9)
            {
                globals.subSecondTime = 0;
                globals.secondTime += 1;
            }
            else
                globals.subSecondTime += 1;
            textBoxTimer.Text=globals.secondTime.ToString() + "." +globals.subSecondTime.ToString();
        }

        private void buttonRandomizeTest_Click(object sender, EventArgs e)
        {
            generateBackendMatrix(globals.fieldSizeX, globals.fieldSizeY);
            globalMatrixes.convertBackToFront();

        }
    }
}