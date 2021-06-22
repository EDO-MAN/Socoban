﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socoban
{
    class Player
    {
        public int X//캐릭터 X좌표
        {
            get;
            private set;
        }
        public int Y//캐릭터 Y좌표
        {
            get;
            private set;
        }
        public void MoveDown()
        {
            Y++;
        }
        public void MoveUp()
        {
            Y--;
        }
        public void MoveLeft()
        {
            X--;
        }
        public void MoveRight()
        {
            X++;
        }
    }
}