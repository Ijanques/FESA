using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letter = "not y or n";
            int count =0;
            List<Game> games= new List<Game>();
            Console.WriteLine("Hi, this is an App to register games (here you can register up to 10 games.\n\nPlease press any key to continue");
            Console.ReadKey();
            do
            {
                Console.Clear();
                bool registerConfirmation = false;
                Game game = new Game();

                do
                {
                    string code;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Type the code of the game: ");
                         code = Console.ReadLine();
                    }while (!int.TryParse(code, out game.SetCode(Convert.ToInt32(code));
                    do
                    {
                        try
                        {
                            Console.WriteLine("Type the name of the game: ");
                            game.SetName(Console.ReadLine());
                            Console.Clear();
                            break;
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error.Message);
                        }
                    } while (true);
                    do
                    {
                        try
                        {
                            Console.WriteLine("Type the category of the game: ");
                            game.SetCategory(Console.ReadLine());
                            Console.Clear();
                            break;
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error.Message);
                        }
                    } while (true);
                    do
                    {
                        try
                        {
                            Console.WriteLine("Type the release date of the game: ");
                            game.SetDate(Convert.ToDateTime(Console.ReadLine()));
                            Console.Clear();
                            break;
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error.Message);
                        }
                    } while (true);
                    Console.WriteLine("Please confirm the data of the game:\n");
                    game.GetInfo();
                    letter = "not y or n";
                    do
                    {
                        try
                        {
                            Console.WriteLine("Type 'y' to confirm and register the game or 'n' to decline and start the registration process again");
                            letter = Console.ReadLine().ToLower();
                            registerConfirmation = true;
                            Console.Clear();
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error.Message);
                        }

                    } while (letter != "y" && letter != "n");
                } while (!registerConfirmation);

                games.Add(game);
                Console.WriteLine("The game was succesfully registered");
                letter = "not y or n";
                do
                {
                    try
                    {
                        Console.WriteLine("Type 'y' to start a new registration process or 'n' to decline and close the app");
                        letter = Console.ReadLine().ToLower();
                        registerConfirmation = true;
                        Console.Clear();
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }

                } while (letter != "y" && letter != "n");
                count++;
            } while (letter == "y" && count <10);
            foreach(Game game in games)
            {
                Console.WriteLine("Informações do jogo " + game.GetName() + ":");
                game.GetInfo();
            }
            Console.ReadKey();
        }
    }
}
    