using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JoJo_JRPG
{
    class Combat
    {
        public void CombatGUI()
        {
            int DudoveHP = 100;
            int VirdzoveHP = 100;
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "SPSIT JRPG";
            string bojovaObrazovka = @"
                 _____                                                                                                                                            __      __
                |  __ \                                                                                                                                           \ \    / /
                | |  | |                                                                                                                                           \ \  / / 
                | |  | |                                                                                                                                            \ \/ /  
                | |__| |                                                                                                                                             \  /   
                |_____/                                                                                                                                            ___\/    
                | |  | |                                                                                                                                          |_   _|   
                | |  | |                                                                                                                                            | |     
                | |  | |                                                                                                                                            | |     
                | |__| |                                                                                                                                           _| |_    
                 \____/                                                                                                                                           |_____|   
                |  __ \                                                                                                                                           |  __ \   
                | |  | |                                                                                                                                          | |__) |  
                | |  | |                                                                                                                                          |  _  /   
                | |__| |                                                                                                                                          | | \ \   
                |_____/                                                                                                                                           |_|__\_\  
                |_   _|                                                                                                                                           |  __ \    
                  | |                                                                                                                                             | |  | |   
                  | |                                                                                                                                             | |  | |   
                 _| |_                                                                                                                                            | |__| |   
                |_____|                                                                                                                                           |_____/    
                | \ | |                                                                                                                                           |___  /    
                |  \| |                                                                                                                                              / /     
                | . ` |                                                                                                                                             / /      
                | |\  |                                                                                                                                            / /__     
                |_| \_|__                                                                                                                                         /_____|   
                \ \   / /                                                                                                                                          / __ \  
                 \ \_/ /                                                                                                                                          | |  | | 
                  \   /                                                                                                                                           | |  | | 
                   | |                                                                                                                                            | |__| | 
                   |_|                                                                                                                                             \____/  



                ____________________________________________________________________________________________________________________________________________________________
                |                                                                              |                                                                            |
                |             _   _             _      ___        ___                          |                                  _    _            _   ___ _    _ ___      |
                |        /\  | | | |           | |    |  _|  /\  |_  |                         |                                 | |  | |          | | |  _| |  | |_  |     |
                |       /  \ | |_| |_ __ _  ___| | __ | |   /  \   | |                         |                                 | |__| | ___  __ _| | | | | |__| | | |     |
                |      / /\ \| __| __/ _` |/ __| |/ / | |  / /\ \  | |                         |                                 |  __  |/ _ \/ _` | | | | |  __  | | |     |
                |     / ____ \ |_| || (_| | (__|   <  | | / ____ \ | |                         |                                 | |  | |  __/ (_| | | | | | |  | | | |     |
                |    /_/    \_\__|\__\__,_|\___|_|\_\ | |/_/    \_\| |                         |                                 |_|  |_|\___|\__,_|_| | |_|_|  |_|_| |     |
                |                                     |___|      |___|                         |                                                       |___|      |___|     |
                |                                                                              |                                                                            |
                |______________________________________________________________________________|____________________________________________________________________________|





";
            pindik:
            Console.WriteLine("                " + DudoveHP + "/100" + "                                                                                                                                            " + VirdzoveHP + "/100");
            Console.WriteLine(bojovaObrazovka);


            if (1 > DudoveHP)
            {
                Console.Clear();
                GameOver GameOverPage = new GameOver();
                GameOverPage.GameOverGUI();
            }
            if (1 > VirdzoveHP)
            {
                Console.Clear();
                Win WinPage = new Win();
                WinPage.WinGUI();
            }


        pisurka:
            char dudoS = Convert.ToChar(Console.Read());
            string dudoStringS = dudoS.ToString();
            switch (dudoStringS)
            {
                case "a":
                case "A":
                    {
                        int attackP = rnd.Next(20);
                        VirdzoveHP = VirdzoveHP - attackP;
                        goto cicina;
                    }
                case "h":
                case "H":
                    {
                        int healP = rnd.Next(20, 40);
                        DudoveHP = DudoveHP + healP;
                        goto cicina;
                    }
                case "\r":
                case "\n":
                case "\0":
                    {
                        goto pisurka;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("You picked a invalid option! Please wait until this message is gone to pick another one.");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        goto pindik;
                    }
            }

        cicina:

            int dudovaRit = rnd.Next(10, 12);

            if (1 > DudoveHP)
            {
                Console.Clear();
                GameOver GameOverPage = new GameOver();
                GameOverPage.GameOverGUI();
            }

            if (VirdzoveHP >= 50)
            {
                int attackAI = rnd.Next(20);
                DudoveHP = DudoveHP - attackAI;
                Console.Clear();
                goto pindik;
            }
            else if (49 >= VirdzoveHP && VirdzoveHP >= 1)
            {
                if (dudovaRit <= 10)
                {
                    Console.Clear();
                    goto pindik;
                }
                int healAI = rnd.Next(40);
                VirdzoveHP = VirdzoveHP + healAI;
                Console.Clear();
                goto pindik;
            }
            else if (1 > VirdzoveHP)
            {
                Console.Clear();
                Win WinPage = new Win();
                WinPage.WinGUI();
            }
        }
    }
  }
