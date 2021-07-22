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
        Player player;//플레이어 객체 참조 선언
        //public Point NowPosition//현재 플레이어 좌표
        //{
        //    get
        //    {
        //        if(player == null)
        //        {
        //            return new Point(0, 0);
        //        }
        //        return new Point(X, Y);
        //    }
        //}

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
        Game()
        {
            player = new Player();
        }
        #endregion
        //public int MapLevel
        //{
        //    get
        //    {
        //        return player.MapLevel;
        //    }
        //}
        //public bool MoveLeft()
        //{
        //    player.MoveLeft();
        //    return true;
        //}
        //public bool MoveRight()
        //{
        //    player.MoveRight();
        //    return true;
        //}
        //public bool MoveUp()
        //{
        //    player.MoveUp();
        //    return true;
        //}
        //public bool MoveDown()
        //{
        //    player.MoveDown();
        //    return true;
        //}

    }
}
