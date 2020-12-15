using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JoJo_JRPG
{
    class Story
    {
        public void IntroStory()
        {
            Console.Title = "SPSIT JRPG";
            string pribeh = @"

                 __     __                                 _           _       _____            _ _       _                                                           
                 \ \   / /                                | |         | |     |  __ \          | (_)     (_)                                                          
                  \ \_/ /__  _   _    __ _ _ __ ___       | | ___  ___| |__   | |  | |_   _  __| |_ _ __  _                                                           
                   \   / _ \| | | |  / _` | '__/ _ \  _   | |/ _ \/ __| '_ \  | |  | | | | |/ _` | | '_ \| |                                                          
                    | | (_) | |_| | | (_| | | |  __/ | |__| | (_) \__ \ | | | | |__| | |_| | (_| | | | | | |_                                                         
                 __ |_|\___/ \__,_|  \__,_|_|  \___|  \____/ \___/|___/_| |_| |_____/_\__,_|\__,_|_|_| |_|_(_)          _  __      ___         _                      
                 \ \   / /                              | | | |            | |     / _|         | |   |  __ \          | | \ \    / (_)       | |                     
                  \ \_/ /__  _   _   _ __   ___  ___  __| | | |_ ___     __| | ___| |_ ___  __ _| |_  | |__) |_ _ _   _| |  \ \  / / _ _ __ __| |_______ _ __   ___   
                   \   / _ \| | | | | '_ \ / _ \/ _ \/ _` | | __/ _ \   / _` |/ _ \  _/ _ \/ _` | __| |  ___/ _` | | | | |   \ \/ / | | '__/ _` |_  / _ \ '_ \ / _ \  
                    | | (_) | |_| | | | | |  __/  __/ (_| | | || (_) | | (_| |  __/ ||  __/ (_| | |_  | |  | (_| | |_| | |    \  /  | | | | (_| |/ /  __/ | | |  __/_ 
                   _|_|\___/ \__,_| |_| |_|\___|\___|\__,_| _\__\___/ _ \__,_|\___|_| \___|\__,_|\__| |_|   \__,_|\__,_|_|     \/   |_|_|  \__,_/___\___|_| |_|\___(_)
                  / ____|                       | | | |  (_) | | | | | |         | |       | |         | |                                                            
                 | |  __  ___     __ _ _ __   __| | | | ___| | | | |_| |__   __ _| |_    __| |_   _  __| | ___                                                        
                 | | |_ |/ _ \   / _` | '_ \ / _` | | |/ / | | | | __| '_ \ / _` | __|  / _` | | | |/ _` |/ _ \                                                       
                 | |__| | (_) | | (_| | | | | (_| | |   <| | | | | |_| | | | (_| | |_  | (_| | |_| | (_| |  __/_                                                      
                  \_____|\___/   \__,_|_| |_|\__,_| |_|\_\_|_|_|  \__|_| |_|\__,_|\__|  \__,_|\__,_|\__,_|\___(_)                                                     
                                                                                                                                                      










                        PRESS ANYTHING TO CONTINUE
";
            if (File.Exists(@"C:/Temp/DudoHP.txt") || File.Exists(@"C:/Temp/Virdzo.HP.txt") || File.Exists(@"C:/Temp/Turn.txt"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please clear C:/Temp of DudoHP.txt VirdzoHP.txt and Turn.txt");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                return;
            }
            else
            {
                TextWriter tx = new StreamWriter("C:/Temp/DudoHP.txt", true);
                tx.Write("100");
                tx.Close();

                TextWriter ty = new StreamWriter("C:/Temp/VirdzoHP.txt", true);
                ty.Write("100");
                ty.Close();

                TextWriter tz = new StreamWriter("C:/Temp/Turn.txt", true);
                tz.Write("1");
                tz.Close();
            }
            



            Console.WriteLine(pribeh);
            Console.ReadKey();
            Console.Clear();
            Combat CombatPage = new Combat();
            CombatPage.CombatGUI();
        }
    }
}
