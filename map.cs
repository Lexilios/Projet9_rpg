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
            {'▓', '║', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '▒', 'O', '▒', '▒', '▒', '▒', '▒', '▒', '▓'},
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
            {'▓', '▒', '▒', '▒', '▒', '▒', '▒', 'O', '▒', '░', '░', '▒', '▒', '█', ' ', 'O', ' ', '█', '▒', '▓'},
            {'▓', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '░', '░', '¤', '▒', '█', ' ', ' ', ' ', '█', '▒', '▓'},
            {'▓', '¤', '¤', '¤', '¤', '¤', '¤', '¤', '¤', '░', '░', '▒', '▒', '█', '█', '█', '█', '█', '▒', '▓'},
            {'▓', '¤', '¤', '¤', '¤', '¤', '¤', '¤', '¤', '░', '░', '▒', '▒', '▒', '¤', '▒', '▒', '▒', '¤', '▓'},
            {'▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '░', '░', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓', '▓'}
        };
    



        int posX = 1;
        int posY = 1;

        AfficherCarte(carte, posX, posY);

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
                    if ((posY > 1 && (carte[posY - 1, posX] == '║' || carte[posY - 1, posX] == '▒' || carte[posY - 1, posX] == '╬')) || (posY > 0 && carte[posY - 1, posX] == '═') || (posY > 0 && carte[posY - 1, posX] == '▒'))
                    {
                        carte[posY, posX] = caractereOrigine; // Rétablit le caractère d'origine
                        posY--;
                    }
                    break;
                case ConsoleKey.S:
                    if (posY < carte.GetLength(0) - 2 && (carte[posY + 1, posX] == '║' || carte[posY + 1, posX] == '▒' || carte[posY + 1, posX] == '╚' || carte[posY + 1, posX] == '═' || carte[posY + 1, posX] == '╬'))
                    {
                        carte[posY, posX] = caractereOrigine; // Rétablit le caractère d'origine
                        posY++;
                    }
                    break;
                case ConsoleKey.Q:
                    if (posX > 1 && ((carte[posY, posX - 1] == '═' || carte[posY, posX - 1] == '▒' || carte[posY, posX - 1] == '╬' || carte[posY, posX - 1] == '║' || (posY > 0 && carte[posY - 1, posX - 1] == '║' && carte[posY, posX - 1] == '▒'))))
                    {
                        carte[posY, posX] = caractereOrigine; // Rétablit le caractère d'origine
                        posX--;
                    }
                    break;

                case ConsoleKey.D:
                    if (posX < carte.GetLength(1) - 2 && ((carte[posY, posX + 1] == '═' || carte[posY, posX + 1] == '▒' || carte[posY, posX + 1] == '╬' || carte[posY, posX + 1] == '║' || (posY > 0 && carte[posY - 1, posX + 1] == '║' && carte[posY, posX + 1] == '▒'))))
                    {
                        carte[posY, posX] = caractereOrigine; // Rétablit le caractère d'origine
                        posX++;
                    }
                    break;
            }

            Console.Clear();
            AfficherCarte(carte, posX, posY);

        } while (keyInfo.Key != ConsoleKey.Escape);

        Console.ReadLine();

    }
}