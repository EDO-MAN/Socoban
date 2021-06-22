using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

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
            Bitmap bitmap = new Bitmap("Character4.png");
            e.Graphics.DrawImage(bitmap, 500, 350);
        }
    }
}
