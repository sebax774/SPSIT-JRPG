using System;
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
            Console.Title = "JoJo's JRPG";
            string title = @"
                  _______________________________________________________________________________________________________________________________________________________________________________________________________
                  |                                                                                                                                                                                                     |
                  |                                                                                                                                                                                                     |
                  |                                                                                  ''''''                                                                                                             |
                  |               JJJJJJJJJJJ                           JJJJJJJJJJJ                  '::::'                                JJJJJJJJJJJRRRRRRRRRRRRRRRRR   PPPPPPPPPPPPPPPPP           GGGGGGGGGGGGG     |
                  |               J:::::::::J                           J:::::::::J                  '::::'                                J:::::::::JR::::::::::::::::R  P::::::::::::::::P       GGG::::::::::::G     |
                  |               J:::::::::J                           J:::::::::J                  ':::''                                J:::::::::JR::::::RRRRRR:::::R P::::::PPPPPP:::::P    GG:::::::::::::::G     |
                  |               JJ:::::::JJ                           JJ:::::::JJ                 ':::'                                  JJ:::::::JJRR:::::R     R:::::RPP:::::P     P:::::P  G:::::GGGGGGGG::::G     |
                  |                 J:::::J     ooooooooooo               J:::::J     ooooooooooo   ''''       ssssssssss                    J:::::J    R::::R     R:::::R  P::::P     P:::::P G:::::G       GGGGGG     |
                  |                 J:::::J   oo:::::::::::oo             J:::::J   oo:::::::::::oo          ss::::::::::s                   J:::::J    R::::R     R:::::R  P::::P     P:::::PG:::::G                   |
                  |                 J:::::J  o:::::::::::::::o            J:::::J  o:::::::::::::::o       ss:::::::::::::s                  J:::::J    R::::RRRRRR:::::R   P::::PPPPPP:::::P G:::::G                   |
                  |                 J:::::j  o:::::ooooo:::::o            J:::::j  o:::::ooooo:::::o       s::::::ssss:::::s                 J:::::j    R:::::::::::::RR    P:::::::::::::PP  G:::::G    GGGGGGGGGG     |
                  |                 J:::::J  o::::o     o::::o            J:::::J  o::::o     o::::o        s:::::s  ssssss                  J:::::J    R::::RRRRRR:::::R   P::::PPPPPPPPP    G:::::G    G::::::::G     |
                  |     JJJJJJJ     J:::::J  o::::o     o::::oJJJJJJJ     J:::::J  o::::o     o::::o          s::::::s           JJJJJJJ     J:::::J    R::::R     R:::::R  P::::P            G:::::G    GGGGG::::G     |
                  |     J:::::J     J:::::J  o::::o     o::::oJ:::::J     J:::::J  o::::o     o::::o             s::::::s        J:::::J     J:::::J    R::::R     R:::::R  P::::P            G:::::G        G::::G     |
                  |     J::::::J   J::::::J  o::::o     o::::oJ::::::J   J::::::J  o::::o     o::::o       ssssss   s:::::s      J::::::J   J::::::J    R::::R     R:::::R  P::::P             G:::::G       G::::G     |
                  |     J:::::::JJJ:::::::J  o:::::ooooo:::::oJ:::::::JJJ:::::::J  o:::::ooooo:::::o       s:::::ssss::::::s     J:::::::JJJ:::::::J  RR:::::R     R:::::RPP::::::PP            G:::::GGGGGGGG::::G     |
                  |      JJ:::::::::::::JJ   o:::::::::::::::o JJ:::::::::::::JJ   o:::::::::::::::o       s::::::::::::::s       JJ:::::::::::::JJ   R::::::R     R:::::RP::::::::P             GG:::::::::::::::G     |
                  |        JJ:::::::::JJ      oo:::::::::::oo    JJ:::::::::JJ      oo:::::::::::oo         s:::::::::::ss          JJ:::::::::JJ     R::::::R     R:::::RP::::::::P               GGG::::::GGG:::G     |
                  |          JJJJJJJJJ          ooooooooooo        JJJJJJJJJ          ooooooooooo            sssssssssss              JJJJJJJJJ       RRRRRRRR     RRRRRRRPPPPPPPPPP                  GGGGGG   GGGG     |
                  |                                                                                                                                                                                                     |
                  |                                                                                                                                                                                                     |
                  |_____________________________________________________________________________________________________________________________________________________________________________________________________|

            ";
            Console.WriteLine(title);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string buttons = @"








                  ___________________________________________________________________                                                                 ___________________________________________________________________
                  |      _  __             _____                 ___  _  __  ___    |                                                                 |           _____           ___ __        ___  _____  ___         |
                  |     / |/ /__ _    __  / ___/__ ___ _  ___   / _/ / |/ / /  /    |                                                                 |          / ___/______ ___/ (_) /____   / _/ / ___/ /  /         |
                  |    /    / -_) |/|/ / / (_ / _ `/  ' \/ -_) / /  /    /  / /     |                                                                 |         / /__/ __/ -_) _  / / __(_-<  / /  / /__   / /          |
                  |   /_/|_/\__/|__,__/  \___/\_,_/_/_/_/\__/ / /  /_/|_/ _/ /      |                                                                 |         \___/_/  \__/\_,_/_/\__/___/ / /   \___/ _/ /           |
                  |                                          /__/        /__/       |                                                                 |                                     /__/        /__/            |
                  |_________________________________________________________________|                                                                 |_________________________________________________________________|


                  ___________________________________________________________________                                                                 ___________________________________________________________________
                  |     __                __  _____                 ___  __     ___ |                                                                 |         ____                                  ___  ____  ___    |
                  |    / /  ___  ___ ____/ / / ___/__ ___ _  ___   / _/ / /    /  / |                                                                 |        / __/__  ___  ___  ___ ___  _______   / _/ / __/ /  /    |
                  |   / /__/ _ \/ _ `/ _  / / (_ / _ `/  ' \/ -_) / /  / /__   / /  |                                                                 |       _\ \/ _ \/ _ \/ _ \(_-</ _ \/ __(_-<  / /  _\ \   / /     |
                  |  /____/\___/\_,_/\_,_/  \___/\_,_/_/_/_/\__/ / /  /____/ _/ /   |                                                                 |      /___/ .__/\___/_//_/___/\___/_/ /___/ / /  /___/ _/ /      |
                  |                                             /__/        /__/    |                                                                 |         /_/                               /__/       /__/       |
                  |_________________________________________________________________|                                                                 |_________________________________________________________________|

                  ___________________________________________________________________                                                                 ____________________________________________________________________
                  |         ____       __  _                 ___  ____    ___       |                                                                 |        ____      _ __    _____                 ___  ____  ___    |
                  |        / __ \___  / /_(_)__  ___  ___   / _/ / __ \  /  /       |                                                                 |       / __/_ __ (_) /_  / ___/__ ___ _  ___   / _/ / __/ /  /    |
                  |       / /_/ / _ \/ __/ / _ \/ _ \(_-<  / /  / /_/ /  / /        |                                                                 |      / _/ \ \ // / __/ / (_ / _ `/  ' \/ -_) / /  / _/   / /     |
                  |       \____/ .__/\__/_/\___/_//_/___/ / /   \____/ _/ /         |                                                                 |     /___//_\_\/_/\__/  \___/\_,_/_/_/_/\__/ / /  /___/ _/ /      |
                  |           /_/                        /__/         /__/          |                                                                 |                                            /__/       /__/       |
                  |_________________________________________________________________|                                                                 |__________________________________________________________________|
            ";

            Console.WriteLine(buttons);




            char dudo = Convert.ToChar(Console.Read());
            string dudoString = dudo.ToString();
            switch (dudoString)
            {
                case "N":
                case "n":
                    {
                        Console.WriteLine("Vybral si si písmeno N");
                        break;
                    }
                case "L":
                case "l":
                    {
                        Console.WriteLine("Vybral si si písmeno L");
                        break;
                    }
                case "O":
                case "o":
                    {
                        Console.WriteLine("Vybral si si písmeno O");
                        break;
                    }
                case "C":
                case "c":
                    {
                        Console.WriteLine("This game was made by Ján Krajči and Sebastián Bugáň as a school project.");
                        System.Threading.Thread.Sleep(5000);
                        Console.Clear();
                        Menu mainPage = new Menu();
                        mainPage.MenuGUI();
                        break;
                    }
                case "S":
                case "s":
                    {
                        Console.Clear();
                        Console.WriteLine("This game was paid for by the starving african children and their souls. God bless America.");
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
                default:
                    {

                        Console.WriteLine("You picked a invalid option! Please wait until this message is gone to pick another one.");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        Menu mainPage = new Menu();
                        mainPage.MenuGUI();
                        break;
                    }
            }
            
        }
    }
}
