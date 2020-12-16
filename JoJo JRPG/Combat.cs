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
            
            string DudoveHP = File.ReadAllText(@"C:/Temp/DudoHP.txt");
            int DudoveHPint = Int32.Parse(DudoveHP);
            string VirdzoveHP = File.ReadAllText(@"C:/Temp/VirdzoHP.txt");
            int VirdzoveHPint = Int32.Parse(VirdzoveHP);

            Console.WriteLine("                " + DudoveHP + "/100" + "                                                                                                                                            " + VirdzoveHP + "/100");
            Console.WriteLine(bojovaObrazovka);


            if (1 > DudoveHPint)
            {
                Console.Clear();
                GameOver GameOverPage = new GameOver();
                GameOverPage.GameOverGUI();
            }
            if (1 > VirdzoveHPint)
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
                        int attackPoutputInt = VirdzoveHPint - attackP;
                        string attackPoutput = attackPoutputInt.ToString();
                        File.WriteAllText(@"C:/Temp/VirdzoHP.txt", attackPoutput);
                        goto cicina;
                    }
                case "h":
                case "H":
                    {
                        int healP = rnd.Next(20, 40);
                        int healPoutputInt = DudoveHPint + healP;
                        if (DudoveHPint >= 100)
                            healPoutputInt = 100;
                        else
                            DudoveHPint = healPoutputInt;
                        string healPoutput = healPoutputInt.ToString();
                        File.WriteAllText(@"C:/Temp/DudoHP.txt", healPoutput);
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

            if (1 > DudoveHPint)
            {
                Console.Clear();
                GameOver GameOverPage = new GameOver();
                GameOverPage.GameOverGUI();
            }

            if (VirdzoveHPint >= 50)
            {
                int attackAI = rnd.Next(20);
                int attackAIoutputInt = DudoveHPint - attackAI;
                string attackAIoutput = attackAIoutputInt.ToString();
                File.WriteAllText(@"C:/Temp/DudoHP.txt", attackAIoutput);
                Console.Clear();
                goto pindik;
            }
            else if (49 >= VirdzoveHPint && VirdzoveHPint >= 1)
            {
                if (dudovaRit <= 10)
                {
                    Console.Clear();
                    goto pindik;
                }
                int healAI = rnd.Next(40);
                int healAIoutputInt = VirdzoveHPint + healAI;
                if (VirdzoveHPint >= 100)
                    healAIoutputInt = 100;
                else
                    VirdzoveHPint = healAIoutputInt;
                string healAIoutput = healAIoutputInt.ToString();
                File.WriteAllText(@"C:/Temp/VirdzoHP.txt", healAIoutput);
                Console.Clear();
                goto pindik;
            }
            else if (1 > VirdzoveHPint)
            {
                Console.Clear();
                Win WinPage = new Win();
                WinPage.WinGUI();
            }
        }
    }
  }
