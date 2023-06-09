﻿using System;

namespace game_practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Text text = new Text();
            text.Welcome();
            Player player = new Player("Люсьен", 100, 1500, 0);
            Skelet skelet = new Skelet("Костантин", 20, 500);
            Ork ork = new Ork("Ляррррва", 40, 700);
            Wizard wizard = new Wizard("Якубович", 55, 900);







            while (true)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Вы находитесь в убежище, количесво монет в сумке {player.Coins} выберите действие: \n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("1 - купить увелечение хп(800) стоимость: 6 монет");
                Console.WriteLine("2 - купить увеличение урона(15) стоимость: 8 монет ");
                Console.WriteLine("3 - начать битву со скелетом");
                Console.WriteLine("4 - начать битву с орком");
                Console.WriteLine("5 - начать битву с магом");
                Console.WriteLine("6 - закончить игру, стоимость: 100 монет");
                Console.ForegroundColor = ConsoleColor.White;



                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Poison_hp();
                        break;
                    case 2:
                        Poison_damage();
                        break;
                    case 3:
                        Battle_Skelet();
                        break;
                    case 4:
                        Battle_Ork();
                        break;
                    case 5:
                        Battle_Wizard();
                        break;
                    case 6:
                        final();
                        break;
                }

                void Poison_hp()
                {

                    if (player.Coins < 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("у вас не хватает монет");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        player.Health = player.Health += 800;

                        Console.WriteLine($"вы выбрали бафф хп, количество ваших хп {player.Health}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Монет осталось: {player.Coins -= 6}");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }

                void Poison_damage()
                {
                    if (player.Coins < 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("у вас не хватает монет");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        player.Damage = player.Damage += 15;
                        Console.WriteLine($"вы выбрали бафф урона, количество вашего урона {player.Damage}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Монет осталось: {player.Coins -= 8}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }


                void Battle_Skelet()
                {
                    if (player.Health > 0)
                    {
                        Console.WriteLine($"Вы начали битву со скелетом по имени Константин");
                        while (player.Health > 0 && skelet.Health > 0)
                        {

                            Console.WriteLine($"Люсьен бьет оставляя Константину {skelet.Health -= player.Damage} здоровья");
                            Console.WriteLine($"Константин бьет оставляя Люсьену {player.Health -= skelet.Damage} здоровья");
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\nВы победили и получили 1 монетку.  Монет в сумке {player.Coins += 1}");
                        Console.ForegroundColor = ConsoleColor.White;
                        skelet.Health += 500;
                    }
                    else if (player.Health <= 0)
                    {
                        Console.WriteLine("Ты сдох");
                    } 

                    
                }


                void Battle_Ork()
                {
                    if (player.Health > 0)
                    {
                        Console.WriteLine($"Вы начали битву со орком по имени Ляррррва");
                        while (player.Health > 0 && ork.Health > 0)
                        {
                            Console.WriteLine($"Люсьен бьет оставляя Ляррррве {ork.Health -= player.Damage} здоровья");
                            Console.WriteLine($"Ляррррва бьет оставляя Люсьену{player.Health -= ork.Damage} здоровья");
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\nВы победили и получили 3 монетки.  Монет в сумке {player.Coins += 3}");
                        Console.ForegroundColor = ConsoleColor.White;
                        ork.Health += 700;
                    }
                    else if (player.Health <= 0)
                    {
                        Console.WriteLine("Ты сдох");
                    }
                }

                void Battle_Wizard()
                {
                    if (player.Health > 0)
                    {
                        Console.WriteLine($"Вы начали битву с магом по имени Якубович");
                        while (player.Health > 0 && wizard.Health > 0)
                        {
                            Console.WriteLine($"Люсьен бьет оставляя Якубовичу {wizard.Health -= player.Damage} здоровья");
                            Console.WriteLine($"Якубович бьет оставляя Люсьену {player.Health -= wizard.Damage} здоровья");
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($" \n Вы победили и получили 7 монеток.  Монет в сумке {player.Coins += 7}");
                        Console.ForegroundColor = ConsoleColor.White;
                        wizard.Health += 900;
                    }
                    else if (player.Health <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ты сдох");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                void final ()
                {
                    if (player.Coins < 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n Рано, иди бейся ссыкло \n");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else
                    {
                        while (false) ;
                        Text text = new Text();
                        text.Game_over();
                    }
                }

            }

        }
    }
}