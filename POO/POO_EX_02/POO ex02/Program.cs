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
            int count =0;
            List<Game> games= new List<Game>();
            Console.WriteLine("Hi, this is an App to register games (here you can register up to 10 games.\n\nPlease press any key to continue");
            Console.ReadKey();
            do
            {
                Console.Clear();
                Game game = new Game();

                do
                {
                    Console.Clear();
                    do
                    {
                        try
                        {
                            Console.WriteLine("Type the code of the game: ");
                            game.SetCode(Convert.ToInt32(Console.ReadLine()));
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

                  
                    Console.WriteLine("Type 'y' to confirm and register the game or 'n' to decline and start the registration process again");
                          
                } while (Console.ReadKey().Key == ConsoleKey.N);
                Console.Clear();

                games.Add(game);
                Console.WriteLine("The game was succesfully registered");
                
                Console.WriteLine("Type 'y' to start a new registration process or 'n' to decline and close the app");
                       
                count++;
            } while (Console.ReadKey().Key == ConsoleKey.Y && count <10);
            Console.Clear();
            foreach(Game game in games)
            {
                Console.WriteLine("Informações do jogo " + game.GetName() + ":");
                game.GetInfo();
            }
            Console.ReadKey();
        }
    }
}
    