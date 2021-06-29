using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Socoban
{
    class Game
    {
        Player player;
        public Point NowPosition//현재 플레이어 좌표
        {
            get
            {
                if(player == null)
                {
                    return new Point(0, 0);
                }
                return new Point(player.X, player.Y);
            }
        }
        
        #region 단일체
        public static Game Singleton 
        {
            get;
            private set;
        }
        static Game()
        {
            Singleton = new Game();
        }
        #endregion
        public int MapLevel
        {
            get
            {
                return player.MapLevel;
            }
        }
    }
}
