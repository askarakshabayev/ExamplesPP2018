﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class Program
    {
        static Snake snake = new Snake();
        static Wall wall = new Wall(1);
        static int direction = 1; // 1 - left, 2 - right, 3 - up, 4 - down
        static bool gameOver = false;
        static int speed = 1000;

        static void playGame()
        {
            while (!gameOver)
            {
                if (direction == 1)
                    snake.Move(-1, 0);
                if (direction == 2)
                    snake.Move(1, 0);
                if (direction == 3)
                    snake.Move(0, -1);
                if (direction == 4)
                    snake.Move(0, 1);
                if (snake.cnt == 60)
                    wall = new Wall(2);

                Console.Clear();
                snake.Draw();
                wall.Draw();
                if (snake.cnt % 10 == 0)
                {
                    /*
                    speed = speed - 100;
                    if (speed < 0)
                        speed = 1;
                     */ 
                    speed = Math.Max(speed - 100, 1);
                }
                Thread.Sleep(speed);
                
            }
        }

        static void Main(string[] args)
        {

            
            Console.CursorVisible = false;
            Thread thread = new Thread(playGame);
            thread.Start();

            while (!gameOver)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    direction = 3;
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    direction = 4;
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    direction = 1;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    direction = 2;
                if (keyInfo.Key == ConsoleKey.Escape)
                    gameOver = true;
            }
        }
    }
}
