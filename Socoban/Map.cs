﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socoban
{
    enum Tile
    {
        ROCK = 1,
        ROAD,
        BALL,
        GOAL
    }

    static class Map
    {
        
        //1 = 벽돌
        //2 = 길
        //3 = 공
        //4 = 타겟
        //5 = 
        static public readonly int[,] map = new int[10, 10]
        {
            //{//1단계
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,1,1,1,0,0,0,0},
                {0,0,0,1,4,1,0,0,0,0},
                {0,0,0,1,0,1,1,1,1,0},
                {0,1,1,1,3,0,3,4,1,0},
                {0,1,4,0,3,0,1,1,1,0},
                {0,1,1,1,1,3,1,0,0,0},
                {0,0,0,0,1,4,1,0,0,0},
                {0,0,0,0,1,1,1,0,0,0},
                {0,0,0,0,0,0,0,0,0,0}
            };
            //{//2단계
            //    {0,0,0,0,0,0,0,0,0,0},
            //    {0,1,1,1,1,1,0,0,0,0},
            //    {0,1,0,0,0,1,0,0,0,0},
            //    {0,1,0,0,0,1,0,1,1,1},
            //    {0,1,0,0,0,1,0,1,0,1},
            //    {0,1,1,1,0,1,1,1,0,1},
            //    {0,0,1,1,0,0,0,0,0,1},
            //    {0,0,1,0,0,0,1,0,0,1},
            //    {0,0,1,0,0,0,1,1,1,1},
            //    {0,0,1,1,1,1,1,0,0,0}
            //},
            //{//3단계
            //    {0,0,0,0,0,0,0,0,0,0},
            //    {0,0,0,1,1,1,1,0,0,0},
            //    {0,0,1,1,0,0,1,0,0,0},
            //    {0,0,1,0,0,0,1,0,0,0},
            //    {0,0,1,1,0,0,1,1,0,0},
            //    {0,0,1,1,0,0,0,1,0,0},
            //    {0,0,1,0,0,0,0,1,0,0},
            //    {0,0,1,0,0,0,0,1,0,0},
            //    {0,0,1,1,1,1,1,1,0,0},
            //    {0,0,0,0,0,0,0,0,0,0}
            //},
            //{//4단계
            //    {0,0,0,0,0,0,0,0,0,0},
            //    {0,0,0,0,0,0,0,0,0,0},
            //    {0,1,1,1,1,1,1,1,0,0},
            //    {0,1,0,0,0,0,0,1,1,1},
            //    {1,1,0,1,1,1,0,0,0,1},
            //    {1,0,0,0,0,0,0,0,0,1},
            //    {1,0,0,0,1,0,0,0,1,1},
            //    {1,1,0,0,1,0,0,0,1,0},
            //    {0,1,1,1,1,1,1,1,1,0},
            //    {0,0,0,0,0,0,0,0,0,0}
            //},
            //{//5단계
            //    {0,0,0,0,0,0,0,0,0,0},
            //    {0,0,1,1,1,1,1,0,0,0},
            //    {0,0,1,0,0,1,1,1,0,0},
            //    {0,0,1,0,0,0,0,1,0,0},
            //    {0,1,1,1,0,1,0,1,1,0},
            //    {0,1,0,1,0,1,0,0,1,0},
            //    {0,1,0,0,0,0,1,0,1,0},
            //    {0,1,0,0,0,0,0,0,1,0},
            //    {0,1,1,1,1,1,1,1,1,0},
            //    {0,0,0,0,0,0,0,0,0,0}
            //}
        //};
    }
}
