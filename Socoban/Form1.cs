using System;
using System.Windows.Forms;
using System.Drawing;

namespace Socoban
{
    public partial class Form1 : Form
    {
        Image p = Image.FromFile("Character4.png");
        Image wall = Image.FromFile("Wall_Brown.png");
        Game game;
        int board_W;
        int board_H;
        int bh;
        int bw;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            board_W = GameRule.Board_W;
            board_H = GameRule.Board_H;
            bw = GameRule.Size_W;
            bh = GameRule.Size_H;

            SetClientSizeCore(board_W, board_H);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Size resize = new Size(bw, bh);
            //Bitmap player = new Bitmap(p, resize);
            //e.Graphics.DrawImage(player, 250, 250);
            DrawMap(e.Graphics);
            DoubleBuffered = true;
        }

        private void DrawMap(Graphics graphics)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
