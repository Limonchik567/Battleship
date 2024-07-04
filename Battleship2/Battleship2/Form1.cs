using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship2
{
    public partial class Form1 : Form
    {
        private PictureBox[,] emptyCell;
        private Bitmap emptyCellImg;
        private PictureBox[,] emptyCellEnemy;
        private Bitmap emptyCellEnemyImg;

        public Form1()
        {
            InitializeComponent();
            Invalidate();
            Field();
            FieldEnemy();
        }

        public void Field()
        {
            emptyCellImg = new Bitmap("G:\\p\\empty.png");            

            int rows = 10;
            int cols = 10;
            int width = 50;
            int height = 50;

            emptyCell = new PictureBox[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    PictureBox ec = new PictureBox();
                    ec.Size = new Size(width, height);
                    ec.Location = new Point(i * 48 + 50, j * 48 + 50);
                    ec.Image = emptyCellImg;
                    this.Controls.Add(ec);
                    emptyCell[i, j] = ec;
                }
            }
        }

        public void FieldEnemy()
        {
            emptyCellEnemyImg = new Bitmap("G:\\p\\empty.png");

            int rows = 10;
            int cols = 10;
            int width = 50;
            int height = 50;

            emptyCellEnemy = new PictureBox[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    PictureBox ece = new PictureBox();
                    ece.Size = new Size(width, height);
                    ece.Location = new Point(i * 48 + 760, j * 48 + 50);
                    ece.Image = emptyCellEnemyImg;
                    this.Controls.Add(ece);
                    emptyCellEnemy[i, j] = ece;
                }
            }
        }
    }
}
