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
            List<Inventory> inventory = new List<Inventory>()
            {
                new("что-то",2),
            };

            
            List<ExploreItems> explitem = new List<ExploreItems>()
            {
                 new("зелька здоровья"),
                 new("хавчик +2к к ЧСВ"),
                 new("зелька ''быстрые ноги люлей не получат''"),
                 new("хавчик +2 к шансу упасть"),
                 new("зелька прыгучисти"),
                 new("хавчик3"),
                 new("зелька4"),
                 new("хавчик4"),
                 new("зелька5"),
                 new("хавчик5"),


            };
            Slime slimeking = new Slime(500, 25, 20, 10, 2512);

            Random explorerand = new Random();
            Random amountrand = new Random();
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
                    Test1();
                    Console.WriteLine("\n Нажмите любую кнопку чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (kodravi.Key == ConsoleKey.D2) 
                {
                Test2();
                    Console.WriteLine("\n Нажмите любую кнопку чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (kodravi.Key == ConsoleKey.D3)
                {
                    Explore();
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






            void Test1()
            {
                Console.WriteLine("список ваших предметов");
                foreach (var invent in inventory)
                {
                    Console.WriteLine($"{invent._id}, {invent.Name}, {invent.Count}");
                }
                Console.WriteLine("\n\n");
            }

            void TestAddItem(string item, int amount)
            {
                Console.WriteLine($"вам выпал {item} в количестве {amount}. вы хотите его добавить в свой инвентарь? (Y)es/(N)o");
                string choiseadditem = Console.ReadLine();
                if (choiseadditem == "Y" || choiseadditem == "y" || choiseadditem == "У" || choiseadditem == "у")
                {
                    if (inventory.Count < inventory.Capacity)
                    {
                        inventory.Add(new(item, amount));
                    }
                    else
                    {
                        Console.WriteLine("у вас нет места в инвентаре");
                    }
                }
                else if (choiseadditem == "N" || choiseadditem == "n")
                {
                    Console.WriteLine("Правильно, нахер этот предмет нужен :3");
                }
            }

            void Test2()
            {
                Console.WriteLine("напишите номер предмета(id) который вы хотите выкинуть:");
                int x = int.Parse(Console.ReadLine());
                foreach (var invent in inventory)
                {
                    if (invent._id == x)
                    {
                        Console.WriteLine("вы хотите выкинуть все предметы(dropall) или только один(drop)");
                        string choisedrop = Console.ReadLine();
                        if (choisedrop == "dropall")
                        {
                            inventory.Remove(invent);
                            break;
                        }
                        else if (choisedrop == "drop")
                        {
                            invent.Count -= 1;
                            break;
                        }
                    }
                }
            }

            void Explore()
            {
                int kkk = 0;
                int amount = amountrand.Next(1, 6);
                Console.WriteLine("Вы пробуете поискать в округе что-нибудь полезное");
                int explrand = explorerand.Next(0, 15);
                foreach (var exitem in explitem)
                {
                    if (explrand == exitem._id)
                    {
                        TestAddItem(exitem.Name, amount);
                        kkk++;
                    }
                }
                if (kkk == 0)
                {
                    Console.WriteLine("Ничего полезного");
                }
            }
        }
    }
}