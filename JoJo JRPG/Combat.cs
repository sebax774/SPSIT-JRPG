﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JoJo_JRPG
{
    class Combat
    {
        public void CombatGUI()
        {
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
                |                                                                                  |                                                                        |
                |             _   _             _      ___        ___                              |                              _    _            _   ___ _    _ ___      |
                |        /\  | | | |           | |    |  _|  /\  |_  |                             |                             | |  | |          | | |  _| |  | |_  |     |
                |       /  \ | |_| |_ __ _  ___| | __ | |   /  \   | |                             |                             | |__| | ___  __ _| | | | | |__| | | |     |
                |      / /\ \| __| __/ _` |/ __| |/ / | |  / /\ \  | |                             |                             |  __  |/ _ \/ _` | | | | |  __  | | |     |
                |     / ____ \ |_| || (_| | (__|   <  | | / ____ \ | |                             |                             | |  | |  __/ (_| | | | | | |  | | | |     |
                |    /_/    \_\__|\__\__,_|\___|_|\_\ | |/_/    \_\| |                             |                             |_|  |_|\___|\__,_|_| | |_|_|  |_|_| |     |
                |                                     |___|      |___|                             |                                                   |___|      |___|     |
                |                                                                                  |                                                                        |
                |__________________________________________________________________________________|________________________________________________________________________|





";
            Console.WriteLine(bojovaObrazovka);
            Console.ReadKey();
        }
    }
  }
