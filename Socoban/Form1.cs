using System;
using System.Windows.Forms;
using System.Drawing;

namespace Socoban
{
    public partial class Form1 : Form
    {
        int board_W;
        int board_H;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            board_W = GameRule.Board_W;
            board_H = GameRule.Board_H;

            SetClientSizeCore(board_W, board_H);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image player = Image.FromFile("Character4.png");
            e.Graphics.DrawImage(player, 500, 350);
        }
    }
}
