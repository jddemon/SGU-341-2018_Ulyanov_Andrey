using System;
using Game_SGU.Field;
using Game_SGU.Hero;
using Game_SGU.Barrier;
using Game_SGU.Hunter;
using Game_SGU.Bonus;


namespace Game_SGU.Logic_GM
{
   public class Game
        {
            private Area PlayerField { get; set; }
            private Player PlayerHero { get; set; }
            private Hunt MyHunter { get; set; }
            private Remuneration MyBonus { get; set; }
            private Hurdle MyBarrier { get; set; }

            public void StartGame()
            {
                SelectField();

                SelectHero();

                PlacementObject();

                Console.WriteLine("The creation of the game is over");
            }

            private void SelectField()
            {
                Console.WriteLine($"Select the field{Environment.NewLine}1 - Small field (10x15){Environment.NewLine}2 - Big field (50x55)");
                try
                {
                    ConsoleKeyInfo entry = Console.ReadKey(intercept: true);
                    switch (entry.Key)
                    {
                        case ConsoleKey.D1:
                            {
                                PlayerField = new Small(10, 15, 2, 2, 3);

                                break;
                            }
                        case ConsoleKey.D2:
                            {
                                PlayerField = new Big(50, 55, 9, 15, 11);

                                break;
                            }
                        default:
                            {
                                Console.WriteLine($"Invalid number");
                                SelectField();
                                break;
                            }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Invalid number");
                    SelectField();
                }
            }

            private void SelectHero()
            {
                Console.WriteLine($"Select the hero{Environment.NewLine}1 - Rabbit{Environment.NewLine}2 - Duck{Environment.NewLine}3 - Goat");
                try
                {
                    ConsoleKeyInfo entry = Console.ReadKey(intercept: true);
                    switch (entry.Key)
                    {
                        case ConsoleKey.D1:
                            {
                                PlayerHero = new Rabbit(100, new Point { X = 1, Y = 1 });
                                break;
                            }
                        case ConsoleKey.D2:
                            {
                                PlayerHero = new Duck(150, new Point { X = 1, Y = 1 });
                                break;
                            }
                        case ConsoleKey.D3:
                            {
                                PlayerHero = new Goat(125, new Point { X = 1, Y = 1 });
                                break;
                            }
                        default:
                            {
                                Console.WriteLine($"Invalid number");
                                SelectHero();
                                break;
                            }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Invalid number");
                    SelectHero();
                }
            }

            private void PlacementObject()
            {
                Random random = new Random();

                MyHunter = new Bear(300, new Point
                {
                    X = random.Next(PlayerHero.Position.X + 2, PlayerField.Width),
                    Y = random.Next(PlayerHero.Position.Y + 2, PlayerField.Height)
                },
                20);

                MyHunter = new Wolf(200, new Point
                {
                    X = random.Next(PlayerHero.Position.X + 2, PlayerField.Width),
                    Y = random.Next(PlayerHero.Position.Y + 2, PlayerField.Height)
                },
                15);

                MyBarrier = new Tree(new Point
                {
                    X = random.Next(PlayerHero.Position.X + 1, PlayerField.Width),
                    Y = random.Next(PlayerHero.Position.Y + 3, PlayerField.Height)
                },
                100);

                MyBarrier = new Hole(new Point
                {
                    X = random.Next(PlayerHero.Position.X + 1, PlayerField.Width),
                    Y = random.Next(PlayerHero.Position.Y + 3, PlayerField.Height)
                },
                100);

                MyBonus = new Apple(new Point
                {
                    X = random.Next(PlayerHero.Position.X + 1, PlayerField.Width),
                    Y = random.Next(PlayerHero.Position.Y + 3, PlayerField.Height)
                },
                30);

                MyBonus = new Cherry(new Point
                {
                    X = random.Next(PlayerHero.Position.X + 1, PlayerField.Width),
                    Y = random.Next(PlayerHero.Position.Y + 3, PlayerField.Height)
                },
                20);

                MyBonus = new Carrot(new Point
                {
                    X = random.Next(PlayerHero.Position.X + 1, PlayerField.Width),
                    Y = random.Next(PlayerHero.Position.Y + 3, PlayerField.Height)
                },
                50);
            }

            public void Gameplay()
            {
                if (PlayerHero.Power >= 100)
                {
                    Console.WriteLine("YOU WIN!");
                }
            }
        }
    }
