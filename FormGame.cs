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
        int totalSquares = 25;
        int fieldSizeX=0;
        int fieldSizeY=0;
        public FormGame()
        {
            InitializeComponent();
            remainingBombCount = totalBombCount;
            updateCounters(0, 0);
            fieldSizeX = Convert.ToInt32(Math.Sqrt(totalSquares));
            fieldSizeY = fieldSizeX;
            generateField(25);
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
            Button[,] gameField = new Button[fieldSizeY,fieldSizeX];
            int currentCell = 1;
            for(int y=0;y<fieldSizeY;y++)
            {
                for (int x = 0; x < fieldSizeX; x++)
                {
                    gameField[y, x] = new Button()
                    {
                        Width = 40,
                        Height = 40,
                        BackColor = Color.DarkCyan,
                        Location = new Point(y * 40, x * 40),
                        FlatStyle = FlatStyle.Flat,
                        Parent = panelGame,
                    };
                }
            }
        }
        private void buttontest_Click(object sender, EventArgs e)
        {
            updateCounters(-1, 1);
        }
    }
}
