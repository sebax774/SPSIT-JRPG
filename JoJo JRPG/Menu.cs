﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JoJo_JRPG
{
    class Menu
    {
        public void MenuGUI()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "SPSIT JRPG";
            erika:
            string title = @"
                  
                                                                                                                                                                                  
                                                                                                                                                                                  
                           SSSSSSSSSSSSSSS PPPPPPPPPPPPPPPPP      SSSSSSSSSSSSSSS IIIIIIIIIITTTTTTTTTTTTTTTTTTTTTTT               JJJJJJJJJJJRRRRRRRRRRRRRRRRR   PPPPPPPPPPPPPPPPP           GGGGGGGGGGGGG
                         SS:::::::::::::::SP::::::::::::::::P   SS:::::::::::::::SI::::::::IT:::::::::::::::::::::T               J:::::::::JR::::::::::::::::R  P::::::::::::::::P       GGG::::::::::::G
                        S:::::SSSSSS::::::SP::::::PPPPPP:::::P S:::::SSSSSS::::::SI::::::::IT:::::::::::::::::::::T               J:::::::::JR::::::RRRRRR:::::R P::::::PPPPPP:::::P    GG:::::::::::::::G
                        S:::::S     SSSSSSSPP:::::P     P:::::PS:::::S     SSSSSSSII::::::IIT:::::TT:::::::TT:::::T               JJ:::::::JJRR:::::R     R:::::RPP:::::P     P:::::P  G:::::GGGGGGGG::::G
                        S:::::S              P::::P     P:::::PS:::::S              I::::I  TTTTTT  T:::::T  TTTTTT                 J:::::J    R::::R     R:::::R  P::::P     P:::::P G:::::G       GGGGGG
                        S:::::S              P::::P     P:::::PS:::::S              I::::I          T:::::T                         J:::::J    R::::R     R:::::R  P::::P     P:::::PG:::::G              
                         S::::SSSS           P::::PPPPPP:::::P  S::::SSSS           I::::I          T:::::T                         J:::::J    R::::RRRRRR:::::R   P::::PPPPPP:::::P G:::::G              
                          SS::::::SSSSS      P:::::::::::::PP    SS::::::SSSSS      I::::I          T:::::T                         J:::::j    R:::::::::::::RR    P:::::::::::::PP  G:::::G    GGGGGGGGGG
                            SSS::::::::SS    P::::PPPPPPPPP        SSS::::::::SS    I::::I          T:::::T                         J:::::J    R::::RRRRRR:::::R   P::::PPPPPPPPP    G:::::G    G::::::::G
                               SSSSSS::::S   P::::P                   SSSSSS::::S   I::::I          T:::::T             JJJJJJJ     J:::::J    R::::R     R:::::R  P::::P            G:::::G    GGGGG::::G
                                    S:::::S  P::::P                        S:::::S  I::::I          T:::::T             J:::::J     J:::::J    R::::R     R:::::R  P::::P            G:::::G        G::::G
                                    S:::::S  P::::P                        S:::::S  I::::I          T:::::T             J::::::J   J::::::J    R::::R     R:::::R  P::::P             G:::::G       G::::G
                        SSSSSSS     S:::::SPP::::::PP          SSSSSSS     S:::::SII::::::II      TT:::::::TT           J:::::::JJJ:::::::J  RR:::::R     R:::::RPP::::::PP            G:::::GGGGGGGG::::G
                        S::::::SSSSSS:::::SP::::::::P          S::::::SSSSSS:::::SI::::::::I      T:::::::::T            JJ:::::::::::::JJ   R::::::R     R:::::RP::::::::P             GG:::::::::::::::G
                        S:::::::::::::::SS P::::::::P          S:::::::::::::::SS I::::::::I      T:::::::::T              JJ:::::::::JJ     R::::::R     R:::::RP::::::::P               GGG::::::GGG:::G
                         SSSSSSSSSSSSSSS   PPPPPPPPPP           SSSSSSSSSSSSSSS   IIIIIIIIII      TTTTTTTTTTT                JJJJJJJJJ       RRRRRRRR     RRRRRRRPPPPPPPPPP                  GGGGGG   GGGG
                                                                                                                                                                                  
                                                                                                                                                                                  

            ";
            Console.WriteLine(title);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string buttons = @"








             ___________________________________________________________________          ___________________________________________________________________          ____________________________________________________________________
             |      _  __             _____                 ___  _  __  ___    |          |           _____           ___ __        ___  _____  ___         |          |        ____      _ __    _____                 ___  ____  ___    |
             |     / |/ /__ _    __  / ___/__ ___ _  ___   / _/ / |/ / /  /    |          |          / ___/______ ___/ (_) /____   / _/ / ___/ /  /         |          |       / __/_ __ (_) /_  / ___/__ ___ _  ___   / _/ / __/ /  /    |
             |    /    / -_) |/|/ / / (_ / _ `/  ' \/ -_) / /  /    /  / /     |          |         / /__/ __/ -_) _  / / __(_-<  / /  / /__   / /          |          |      / _/ \ \ // / __/ / (_ / _ `/  ' \/ -_) / /  / _/   / /     |
             |   /_/|_/\__/|__,__/  \___/\_,_/_/_/_/\__/ / /  /_/|_/ _/ /      |          |         \___/_/  \__/\_,_/_/\__/___/ / /   \___/ _/ /           |          |     /___//_\_\/_/\__/  \___/\_,_/_/_/_/\__/ / /  /___/ _/ /      |
             |                                          /__/        /__/       |          |                                     /__/        /__/            |          |                                            /__/       /__/       |
             |_________________________________________________________________|          |_________________________________________________________________|          |__________________________________________________________________|









            ";

            Console.WriteLine(buttons);

            string creditsASCIIart = @"


                 ________  __        __                                                                                                                                          __                  __                 
                |        \|  \      |  \                                                                                                                                        |  \                |  \                
                 \$$$$$$$$| $$____   \$$  _______         ______    ______   ______ ____    ______         __   __   __   ______    _______        ______ ____    ______    ____| $$  ______        | $$____   __    __ 
                   | $$   | $$    \ |  \ /       \       /      \  |      \ |      \    \  /      \       |  \ |  \ |  \ |      \  /       \      |      \    \  |      \  /      $$ /      \       | $$    \ |  \  |  \
                   | $$   | $$$$$$$\| $$|  $$$$$$$      |  $$$$$$\  \$$$$$$\| $$$$$$\$$$$\|  $$$$$$\      | $$ | $$ | $$  \$$$$$$\|  $$$$$$$      | $$$$$$\$$$$\  \$$$$$$\|  $$$$$$$|  $$$$$$\      | $$$$$$$\| $$  | $$
                   | $$   | $$  | $$| $$ \$$    \       | $$  | $$ /      $$| $$ | $$ | $$| $$    $$      | $$ | $$ | $$ /      $$ \$$    \       | $$ | $$ | $$ /      $$| $$  | $$| $$    $$      | $$  | $$| $$  | $$
                   | $$   | $$  | $$| $$ _\$$$$$$\      | $$__| $$|  $$$$$$$| $$ | $$ | $$| $$$$$$$$      | $$_/ $$_/ $$|  $$$$$$$ _\$$$$$$\      | $$ | $$ | $$|  $$$$$$$| $$__| $$| $$$$$$$$      | $$__/ $$| $$__/ $$
                   | $$   | $$  | $$| $$|       $$       \$$    $$ \$$    $$| $$ | $$ | $$ \$$     \       \$$   $$   $$ \$$    $$|       $$      | $$ | $$ | $$ \$$    $$ \$$    $$ \$$     \      | $$    $$ \$$    $$
                    \$$    \$$   \$$ \$$ \$$$$$$$        _\$$$$$$$  \$$$$$$$ \$$  \$$  \$$  \$$$$$$$        \$$$$$\$$$$   \$$$$$$$ \$$$$$$$        \$$  \$$  \$$  \$$$$$$$  \$$$$$$$  \$$$$$$$       \$$$$$$$  _\$$$$$$$
                                                        |  \__| $$                                                                                                                                            |  \__| $$
                                                         \$$    $$                                                                                                                                             \$$    $$
                                                          \$$$$$$                                                                                                                                               \$$$$$$ 
                    _____                            __    __                                        __                                  __                                                                             
                   |     \                          |  \  /  \                                      |  \                                |  \                                                                            
                    \$$$$$  ______   _______        | $$ /  $$  ______   ______        __   _______  \$$        ______   _______    ____| $$                                                                            
                      | $$ |      \ |       \       | $$/  $$  /      \ |      \      |  \ /       \|  \       |      \ |       \  /      $$                                                                            
                 __   | $$  \$$$$$$\| $$$$$$$\      | $$  $$  |  $$$$$$\ \$$$$$$\      \$$|  $$$$$$$| $$        \$$$$$$\| $$$$$$$\|  $$$$$$$                                                                            
                |  \  | $$ /      $$| $$  | $$      | $$$$$\  | $$   \$$/      $$     |  \| $$      | $$       /      $$| $$  | $$| $$  | $$                                                                            
                | $$__| $$|  $$$$$$$| $$  | $$      | $$ \$$\ | $$     |  $$$$$$$     | $$| $$_____ | $$      |  $$$$$$$| $$  | $$| $$__| $$                                                                            
                 \$$    $$ \$$    $$| $$  | $$      | $$  \$$\| $$      \$$    $$     | $$ \$$     \| $$       \$$    $$| $$  | $$ \$$    $$                                                                            
                  \$$$$$$   \$$$$$$$ \$$   \$$       \$$   \$$ \$$       \$$$$$$$__   | $$  \$$$$$$$ \$$        \$$$$$$$ \$$   \$$  \$$$$$$$                                                                            
                                                                                |  \__/ $$                                                                                                                              
                                                                                 \$$    $$                                                                                                                              
                                                                                  \$$$$$$                                                                                                                               
                  ______             __                              __      __                            _______                                                                                                      
                 /      \           |  \                            |  \    |  \                          |       \                                                                                                     
                |  $$$$$$\  ______  | $$____    ______    _______  _| $$_    \$$  ______   _______        | $$$$$$$\ __    __   ______    ______   _______                                                              
                | $$___\$$ /      \ | $$    \  |      \  /       \|   $$ \  |  \ |      \ |       \       | $$__/ $$|  \  |  \ /      \  |      \ |       \                                                             
                 \$$    \ |  $$$$$$\| $$$$$$$\  \$$$$$$\|  $$$$$$$ \$$$$$$  | $$  \$$$$$$\| $$$$$$$\      | $$    $$| $$  | $$|  $$$$$$\  \$$$$$$\| $$$$$$$\                                                            
                 _\$$$$$$\| $$    $$| $$  | $$ /      $$ \$$    \   | $$ __ | $$ /      $$| $$  | $$      | $$$$$$$\| $$  | $$| $$  | $$ /      $$| $$  | $$                                                            
                |  \__| $$| $$$$$$$$| $$__/ $$|  $$$$$$$ _\$$$$$$\  | $$|  \| $$|  $$$$$$$| $$  | $$      | $$__/ $$| $$__/ $$| $$__| $$|  $$$$$$$| $$  | $$                                                            
                 \$$    $$ \$$     \| $$    $$ \$$    $$|       $$   \$$  $$| $$ \$$    $$| $$  | $$      | $$    $$ \$$    $$ \$$    $$ \$$    $$| $$  | $$                                                            
                  \$$$$$$   \$$$$$$$ \$$$$$$$   \$$$$$$$ \$$$$$$$     \$$$$  \$$  \$$$$$$$ \$$   \$$       \$$$$$$$   \$$$$$$  _\$$$$$$$  \$$$$$$$ \$$   \$$                                                            
                                                                                                                              |  \__| $$                                                                                
                                                                                                                               \$$    $$                                                                                
                                                                                                                                \$$$$$$                                                                                 
                                                                               __                            __                                                                    __                                   
                                                                              |  \                          |  \                                                                  |  \                                  
                  ______    _______         ______          _______   _______ | $$____    ______    ______  | $$        ______    ______    ______       __   ______    _______  _| $$_                                 
                 |      \  /       \       |      \        /       \ /       \| $$    \  /      \  /      \ | $$       /      \  /      \  /      \     |  \ /      \  /       \|   $$ \                                
                  \$$$$$$\|  $$$$$$$        \$$$$$$\      |  $$$$$$$|  $$$$$$$| $$$$$$$\|  $$$$$$\|  $$$$$$\| $$      |  $$$$$$\|  $$$$$$\|  $$$$$$\     \$$|  $$$$$$\|  $$$$$$$ \$$$$$$                                
                 /      $$ \$$    \        /      $$       \$$    \ | $$      | $$  | $$| $$  | $$| $$  | $$| $$      | $$  | $$| $$   \$$| $$  | $$    |  \| $$    $$| $$        | $$ __                               
                |  $$$$$$$ _\$$$$$$\      |  $$$$$$$       _\$$$$$$\| $$_____ | $$  | $$| $$__/ $$| $$__/ $$| $$      | $$__/ $$| $$      | $$__/ $$    | $$| $$$$$$$$| $$_____   | $$|  \ __                           
                 \$$    $$|       $$       \$$    $$      |       $$ \$$     \| $$  | $$ \$$    $$ \$$    $$| $$      | $$    $$| $$       \$$    $$    | $$ \$$     \ \$$     \   \$$  $$|  \                          
                  \$$$$$$$ \$$$$$$$         \$$$$$$$       \$$$$$$$   \$$$$$$$ \$$   \$$  \$$$$$$   \$$$$$$  \$$      | $$$$$$$  \$$        \$$$$$$__   | $$  \$$$$$$$  \$$$$$$$    \$$$$  \$$                          
                                                                                                                      | $$                        |  \__/ $$                                                            
                                                                                                                      | $$                         \$$    $$                                                            
                                                                                                                       \$$                          \$$$$$$                                                             


";
            pipik:
            char dudo = Convert.ToChar(Console.Read());
            string dudoString = dudo.ToString();
            switch (dudoString)
            {
                case "N":
                case "n":
                    {
                        Console.Clear();
                        Story introPage = new Story();
                        introPage.IntroStory();
                        break;
                    }
                case "C":
                case "c":
                    {
                        Console.Clear();
                        Console.WriteLine(creditsASCIIart);
                        System.Threading.Thread.Sleep(5000);
                        Console.Clear();
                        Menu mainPage = new Menu();
                        mainPage.MenuGUI();
                        break;
                    }
                case "E":
                case "e":
                    {
                        return;
                    }
                case "\r":
                case "\n":
                    {
                        goto pipik;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("You picked a invalid option! Please wait until this message is gone to pick another one.");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        goto erika;
                    }
            }
            
        }
    }
}
