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

        int totalBombCount = 6;
        int remainingBombCount;
        int foundBombCount = 0;
        int totalSquares = 9;
        int fieldSizeX=0;
        int fieldSizeY=0;
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
            remainingBombCount = totalBombCount;
            updateCounters(0, 0);
            fieldSizeX = Convert.ToInt32(Math.Sqrt(totalSquares));
            fieldSizeY = fieldSizeX;
            generateField(totalSquares);
        }
        public void updateCounters(int changeRemaining, int changeFound)
        {
            remainingBombCount = remainingBombCount + changeRemaining;
            foundBombCount = foundBombCount + changeFound;
            textBoxBombsRemaining.Text = Convert.ToString(remainingBombCount);
            textBoxBombsFound.Text = Convert.ToString(foundBombCount);
        }
        private void generateField(int squareCount)
        {
            spot[,] gameField = new spot[fieldSizeY,fieldSizeX];
            int currentCell = 1;
            int spotSizeHeight = panelGame.Height / fieldSizeX;
            int spotSizeWidth = panelGame.Width / fieldSizeY;
            for (int y=0;y<fieldSizeY;y++)
            {
                for (int x = 0; x < fieldSizeX; x++)
                {
                    Button buttonToPlace = new Button()
                    {
                        Width = spotSizeWidth,
                        Height = spotSizeHeight,
                        BackColor = Color.Gray,
                        Location = new Point(y * spotSizeHeight, x * spotSizeWidth),
                        FlatStyle = FlatStyle.Flat,
                        Parent = panelGame,
                        Text = currentCell.ToString(),
                    };
                    gameField[x, y] = new spot(buttonToPlace, 0, -1);   
                    currentCell++;
                }
            }
            gameField[1, 2].hiddenStatus = 1;


        }
        private void buttontest_Click(object sender, EventArgs e)
        {
            updateCounters(-1, 1);
        }
    }
}
