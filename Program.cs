using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Slime slimeking = new Slime(500, 25, 20, 10, 2512);
            Random random = new Random();
            ConsoleKeyInfo kodravi;
            Battle battle = new Battle();
            while(true)
            {
                Console.WriteLine("Какое действие вы хотите совершить?\n 1 -- Посмотреть инвентарь \n 2 -- Удалить предмет \n 3 -- Исследовать территорию\n 4 -- Идти дальше \n 5 -- Сразу к Боссу локации\n\n");

                kodravi = Console.ReadKey();
                Console.Write(" --- You pressed ");
                Console.WriteLine(kodravi.Key.ToString());
                if (kodravi.Key == ConsoleKey.D1)
                {
                    battle.Test1();
                    Console.WriteLine("\n Нажмите любую кнопку чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (kodravi.Key == ConsoleKey.D2) 
                {
                battle.Test2();
                    Console.WriteLine("\n Нажмите любую кнопку чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (kodravi.Key == ConsoleKey.D3)
                {
                   battle.Explore();
                    Console.WriteLine("\n Нажмите любую кнопку чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (kodravi.Key == ConsoleKey.D4)
                {
                   int ran = random.Next(0,5);
                    if (ran <= 2) 
                    {
                        Console.Clear() ;
                        Console.WriteLine("Вы продолжили свой путь,с вами ничего не случилось.");
                    }
                    else if (ran >= 3 && ran <= 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Вы наткнулись на монстра");
                        battle.Battlechek();
                    }
                    else if (ran >=5) 
                    { 
                        Console.Clear();
                        Console.WriteLine("Вы продолжили свой путь,с вами ничего не случилось."); 
                    }
                }
                else if (kodravi.Key == ConsoleKey.D5)
                {
                    Console.Clear ();
                    Console.WriteLine("Вы пришли к дверям босса локации, вы чувствуете сильное давление по ту сторону врат, все пространство во круг покрыто липкой слизью");
                    battle.BossBattle(slimeking.Damage,slimeking.Def,slimeking.Health,slimeking.Gold);
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }         






          
        }
    }
}