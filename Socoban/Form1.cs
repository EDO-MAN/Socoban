using System;
using System.Windows.Forms;
using System.Drawing;

namespace Socoban
{
    public partial class Form1 : Form
    {
        Image p = Image.FromFile("Character4.png");
        Image wall = Image.FromFile("Wall_Brown.png");
        Player play = new Player();

        int board_W;
        int board_H;
        int bh;
        int bw;
        int X;
        int Y;
        int before_X;
        int before_Y;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            board_W = GameRule.Board_W;//게임보드 가로
            board_H = GameRule.Board_H;//게임보드 세로
            bw = GameRule.Size_W;//벽돌사이즈
            bh = GameRule.Size_H;//벽돌사이즈
          
            SetClientSizeCore(board_W, board_H);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawMap(e.Graphics);
            DrawPlayer(e.Graphics);
            DoubleBuffered = true;
        }

        private void DrawPlayer(Graphics graphics)//캐릭터 그리기
        {
            Bitmap player = new Bitmap(p);
            //if(Map.map[X,Y] != 1)
            //{
            //    graphics.DrawImage(player, X * bw + 15, Y * bh);
            //}
            X = play.X;
            Y = play.Y;
            if (Map.map[X, Y] == 1)
            {
                play.X = before_X;
                play.Y = before_Y;
                X = play.X;
                Y = play.Y;
            }
            graphics.DrawImage(player, X * bw + 15, Y * bh);
        }

        private void DrawMap(Graphics graphics)
        {
            Bitmap wall_brown = new Bitmap(wall, bw, bh);
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (Map.map[x, y] == 1)
                    {
                        graphics.DrawImage(wall_brown,  x * bw, y * bh);
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            before_X = X;
            before_Y = Y;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    play.MoveLeft();
                    break;
                case Keys.Right:
                    play.MoveRight();
                    break;
                case Keys.Up:
                    play.MoveUp();
                    break;
                case Keys.Down:
                    play.MoveDown();
                    break;
            }
            Invalidate();
        }
    }
}
