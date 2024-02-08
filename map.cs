class Map
{
    public void map()
    {
        Console.WindowWidth = 40; // Ajuster la largeur de la console
        Console.WindowHeight = 20; // Ajuster la hauteur de la console

        char[,] carte =
        {
            {'▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '░', '░', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓'},
            {'▓', '║', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▓'},
            {'▓', '║', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', 'M', '▒', '▒', '▒', '▒', '▒', '▒', '▓'},
            {'▓', '║', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', '▒', '░', '░', '░', '░', '▒', '▒', '▓'},
            {'▓', '║', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', '░', '░', '░', '░', '░', '░', '▒', '▓'},
            {'▓', '║', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', '░', '░', '░', '░', '░', '░', '▒', '▓'},
            {'▓', '║', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', '▒', '░', '░', '░', '░', '▒', '▒', '▓'},
            {'▓', '║', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', '▒', '▒', '░', '░', '░', '▒', '▒', '▓'},
            {'▓', '║', '▒', '▒', '▒', '▒', '▒', '▒', '■', '═', '═', '■', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '►'},
            {'▓', '╚', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '╬', '═', '═', '═', '►'},
            {'▓', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '■', '═', '═', '■', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '►'},
            {'▓', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▓'},
            {'▓', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', '¤', '█', '█', '║', '█', '█', '▒', '▓'},
            {'▓', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', '▒', '█', ' ', '║', ' ', '█', '¤', '▓'},
            {'▓', '▒', '▒', '▒', '▒', '▒', '▒', 'M', '▒', '░', '░', '▒', '▒', '█', ' ', 'M', ' ', '█', '▒', '▓'},
            {'▓', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '¤', '▒', '█', ' ', ' ', ' ', '█', '▒', '▓'},
            {'▓', '¤', '¤', '¤', '¤', '¤', '¤', '¤', '¤', '░', '░', '▒', '▒', '█', '█', '█', '█', '█', '▒', '▓'},
            {'▓', '¤', '¤', '¤', '¤', '¤', '¤', '¤', '¤', '░', '░', '▒', '▒', '▒', '¤', '▒', '▒', '▒', '¤', '▓'},
            {'▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '░', '░', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓'}
        };
    



        int posX = 1;
        int posY = 1;

        AfficherCarte(carte, posX, posY);

        void launchBatlle()
        {
            if (((posX == 15) && (posY == 14)) || ((posX == 12) && (posY == 2)) || ((posX == 7) && (posY == 14)))
            {
                Battle battle = new Battle();
                battle.Duel(new Bandit("Bandit Keith", 2, 8, ElementEnum.NonElement), new ElementHero("LionHeart", 5, 15, 20, ElementEnum.Fire));
            }
        }

        static void AfficherCarte(char[,] carte, int posX, int posY)
        {
            for (int i = 0; i < carte.GetLength(0); i++)
            {
                for (int j = 0; j < carte.GetLength(1); j++)
                {
                    if (i == posY && j == posX)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("P ");
                        Console.ResetColor();
                    }
                    else
                    {
                        char currentChar = carte[i, j];

                        switch (currentChar)
                        {
                            case '▓':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case '▒':
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                break;
                            case '►':
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                            case '░':
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case '■':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case '═':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case '█':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case '¤':
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                break;
                            case '║':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case '╚':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case '╦':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case '╬':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;



                            default:
                                Console.ForegroundColor = ConsoleColor.White; // Par défaut, couleur blanche
                                break;
                        }

                        Console.Write(currentChar + " ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }


        ConsoleKeyInfo keyInfo;

        char caractereOrigine = ' '; // Initialisez à un caractère par défaut

        do
        {
            keyInfo = Console.ReadKey(true);

            // Stocke le caractère d'origine avant de déplacer le personnage
            caractereOrigine = carte[posY, posX];

            switch (keyInfo.Key)
            {
                case ConsoleKey.Z:
                    if ((posY > 1 && (carte[posY - 1, posX] == '║' || carte[posY - 1, posX] == '▒' || carte[posY - 1, posX] == '╬')) || (posY > 0 && carte[posY - 1, posX] == '═') || (posY > 0 && carte[posY - 1, posX] == '▒' || (posY > 0 && carte[posY - 1, posX] == 'M')))
                    {
                        carte[posY, posX] = caractereOrigine; // Rétablit le caractère d'origine
                        posY--;

                    }

                    break;
                case ConsoleKey.S:
                    if (posY < carte.GetLength(0) - 2 && (carte[posY + 1, posX] == '║' || carte[posY + 1, posX] == '▒' || carte[posY + 1, posX] == '╚' || carte[posY + 1, posX] == '═' || carte[posY + 1, posX] == '╬' || (posY > 0 && carte[posY + 1, posX] == 'M')))
                    {
                        carte[posY, posX] = caractereOrigine; // Rétablit le caractère d'origine
                        posY++;
                    }
                    break;
                case ConsoleKey.Q:
                    if (posX > 1 && ((carte[posY, posX - 1] == '═' || carte[posY, posX - 1] == '▒' || carte[posY, posX - 1] == '╬' || carte[posY, posX - 1] == '║' || (posY > 0 && carte[posY - 1, posX - 1] == '║' && carte[posY, posX - 1] == '▒' || (posY > 0 && carte[posY, posX - 1] == 'M')))))
                    {
                        carte[posY, posX] = caractereOrigine; // Rétablit le caractère d'origine
                        posX--;
                    }
                    break;

                case ConsoleKey.D:
                    if (posX < carte.GetLength(1) - 2 && ((carte[posY, posX + 1] == '═' || carte[posY, posX + 1] == '▒' || carte[posY, posX + 1] == '╬' || carte[posY, posX + 1] == '║' || (posY > 0 && carte[posY - 1, posX + 1] == '║' && carte[posY, posX + 1] == '▒' || (posY > 0 && carte[posY, posX + 1] == 'M')))))
                    {
                        carte[posY, posX] = caractereOrigine; // Rétablit le caractère d'origine
                        posX++;
                    }
                    break;
            }


            Console.Clear();
            AfficherCarte(carte, posX, posY);

            launchBatlle();

        } while (keyInfo.Key != ConsoleKey.Escape);

        Console.ReadLine();

    }
}