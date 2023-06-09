﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;   
namespace ConsoleApp2
{


    public class Battle
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
        List<Shop> shops = new List<Shop>()
        {
            new("палочка гавнодава",24),
            new("сапоги людоеды", 600),
            new("Носки пчеловода",2500),
        
        };
        Random explorerand = new Random();
        Random amountrand = new Random();
        Knight knight = new(PlayerChoiseName(), "Рыцарь", 125, 15, 25, 50, 1, 0, 0);

        Slime slimeblue = new Slime(20, 2, 5, 1, 213);
        Slime slimered = new Slime(40, 10, 9, 2, 354);

        public void Battlechek()
        {
            ConsoleKeyInfo selectfight;
            
            while (true)
            {
                Console.WriteLine("с каким монстром вы хотите драться : 1 - синий слайм, 2 - красный слайм");
                selectfight = Console.ReadKey();
                Console.Write(" --- You pressed ");
                Console.WriteLine(selectfight.Key.ToString());
                if (selectfight.Key == ConsoleKey.D1 || selectfight.Key == ConsoleKey.D2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("дурачек тебя просили выбрать с кем ты будешь драться ");
                }

            }


           Console.Clear();
            
          
            if (selectfight.Key == ConsoleKey.D1)
            {
                Console.WriteLine("вы начали бой с синим слаймом");
                InfiniteBattle(slimeblue.Damage, slimeblue.Def, slimeblue.Health, slimeblue.Gold);
            }
            else if (selectfight.Key == ConsoleKey.D2)
            {
                Console.WriteLine("вы начали бой с красным слаймом");
                InfiniteBattle(slimered.Damage, slimered.Def, slimered.Health, slimered.Gold);
            }
        }

        static string PlayerChoiseName()
        {
            ConsoleKeyInfo choisehero;
            Console.WriteLine("Введите имя вашего героя");

            string? heroname = Console.ReadLine();

            if (heroname == "" || heroname == " ")
            {
                return "try again";
            }
            return heroname;


        }

        void ChoiseHero()
        {
            ConsoleKeyInfo choisehero;
            Console.WriteLine("Введите имя вашего героя");
            
            string heroname = Console.ReadLine();
            if (heroname == "" || heroname == " ")
            {
                Console.WriteLine("Введите имя вашего героя ( нельзя чтобы было пустым)");
            heroname = Console.ReadLine();
            if (heroname == "" || heroname == " ")
                {
                    Console.WriteLine("Отныне имя вашего героя Player");
                    heroname = "Player";
                }
            }

            InfoAboutHero();
            while (true)
            {
                choisehero = Console.ReadKey();
                Console.Write(" --- You pressed ");
                Console.WriteLine(choisehero.Key.ToString());
                if (choisehero.Key == ConsoleKey.D1 )
                {
                   
                    double playerhp = knight.Health;
                    double mpp = knight.Mana;
                    double pdmg = knight.Damage;
                    double pdef = knight.Defense;
                    double goldplayer = knight.Gold;
                    break;
                }
                else if (choisehero.Key == ConsoleKey.D2)
                {
                    Wizard wizard = new Wizard(heroname, "Маг", 75, 5, 5, 125, 1, 0, 0);
                    double playerhp = wizard.Health;
                    double mpp = wizard.Mana;
                    double pdmg = wizard.Damage;
                    double pdef = wizard.Defense;
                    double goldplayer = wizard.Gold;
                    break;
                }
                else if (choisehero.Key == ConsoleKey.D3) 
                {
                    Thief thief = new Thief(heroname, "Вор", 100, 10, 15, 75, 1, 0, 0);
                    double playerhp = thief.Health;
                    double mpp = thief.Mana;
                    double pdmg = thief.Damage;
                    double pdef = thief.Defense;
                    double goldplayer = thief.Gold;
                    break;
                }
                else
                {
                    Console.WriteLine(" Выберите Класс Героя ");
                }
            }
    
       
            
        }
        void InfoAboutHero()
        {
            Console.WriteLine("1.Рыцарь \n   Здоровье -- 125  |  Атака -- 15  |  Защита -- 25  |  Мана -- 25\n\n");
            Console.WriteLine("2.Маг \n  Здоровье -- 125  |  Атака -- 15  |  Защита -- 25  |  Мана -- 125\n\n");
            Console.WriteLine("3.Вор \n Здоровье -- 100  |  Атака -- 10  |  Защита -- 15  |  Мана -- 75\n\n");
        }

        void InfiniteBattle(double mdmg, double mdef, double Monsterhp, int goldmonster)
        {
            Console.WriteLine($"параметры игрока (40 хп -- 18 атак -- 12 защита )");
            Console.WriteLine($"параметры монстра ({Monsterhp} хп -- {mdmg} атакa -- {mdef} защита )");
            Console.WriteLine($"золото которые вы получите после убийства монстра = {goldmonster}");
            double playerhp = 40;
            double mpp = 30;
            double pdmg = 18;
            double pdef = 12;
            int goldplayer = 0;
            double toPdmg = mdmg / pdef;
            double toMdmg = pdmg / mdef;
            double tohilP = 4;
            int s = 1; 

            while (true)
            {
                while (playerhp > 0 && Monsterhp > 0)
                {
           
                    Console.WriteLine("==================================");
                    Console.WriteLine("новый ход");
                    Console.WriteLine("__________________");
                    Console.WriteLine("ваша мана восстановлена на 3 ед.");
                    mpp += 3;
                    Console.WriteLine("Мана персонажа: " + mpp);
                    Console.WriteLine("__________________");
                    Console.WriteLine("Выберите действие которое хотите использовать:1 - атака, 2 - магия, 3 - лечение");
                    Console.WriteLine("__________________");
                    Console.WriteLine(Monsterhp);

                    int modescroll = int.Parse(Console.ReadLine());
                    switch (modescroll)
                    {

                        case 1:
                            Console.WriteLine("__________________");
                            Console.WriteLine("Вы использовали атаку");
                            Console.WriteLine("__________________");
                            Console.WriteLine("Вы нанесли монстру: " + toMdmg);
                            Console.WriteLine("__________________");
                            Console.WriteLine("Здоровье Монстров");
                            Monsterhp -= toMdmg;
                            Console.WriteLine(Monsterhp);

                            Console.WriteLine("__________________");
                            Console.WriteLine("Монстр вам нанес: " + toPdmg);
                            Console.WriteLine("__________________");
                            Console.WriteLine("Здоровье игрока");
                            playerhp -= toPdmg;
                            Console.WriteLine(playerhp);


                            break;
                        case 2:
                            Console.WriteLine("__________________");
                            Console.WriteLine("Выберите навык который хотие использовать:1 - Fireball; 2 - Shadow Dance; 3 - First Strike;" +
               " 4 - Reverse Polarity; 5 - Charge of Darkness");
                            int modeskill = int.Parse(Console.ReadLine());
                            switch (modeskill)
                            {
                                case 1:
                                    Console.WriteLine("__________________");
                                    Console.WriteLine("вы выбрали fireball");
                                    mpp -= 5;
                                    Console.WriteLine("вы потратили 5 маны");
                                    Console.WriteLine("Вы нанесли монстру: 5 ед. урона");
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье Монстров");
                                    Monsterhp -= 5;
                                    Console.WriteLine(Monsterhp);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Монстр вам нанес: " + toPdmg);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье игрока");
                                    playerhp -= toPdmg;
                                    Console.WriteLine(playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                                case 2:
                                    Console.WriteLine("__________________");
                                    Console.WriteLine("вы выбрали shadow dance");
                                    mpp -= 7;
                                    Console.WriteLine("вы потратили 7 маны");
                                    Console.WriteLine("Вы нанесли монстру: 2 ед. урона");
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье Монстров");
                                    Monsterhp -= 2;
                                    Console.WriteLine(Monsterhp);
                                    playerhp += 2;
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье персонажа вылечено на: 2");
                                    Console.WriteLine("Здоровье персонажа: " + playerhp);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Монстр вам нанес: " + toPdmg);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье игрока");
                                    playerhp -= toPdmg;
                                    Console.WriteLine(playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                                case 3:
                                    Console.WriteLine("__________________");
                                    Console.WriteLine("вы выбрали first strike");
                                    mpp -= 8;
                                    Console.WriteLine("вы потратили 8 маны");
                                    Console.WriteLine("Вы нанесли монстру: 6");
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье Монстров");
                                    Monsterhp -= 6;
                                    Console.WriteLine(Monsterhp);

                                    Console.WriteLine("______");
                                    Console.WriteLine("Монстр вам нанес: " + toPdmg);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье игрока");
                                    playerhp -= toPdmg;
                                    Console.WriteLine(playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                                case 4:
                                    Console.WriteLine("__________________");
                                    Console.WriteLine("вы выбрали reverse polarity");
                                    mpp -= 13;
                                    Console.WriteLine("вы потратили 13 маны");
                                    Console.WriteLine("вы оглушили врага и нанесли ему 3 ед.урона");
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье Монстров");
                                    Monsterhp -= 3;
                                    Console.WriteLine(Monsterhp);
                                    Console.WriteLine("Здоровье игрока");
                                    Console.WriteLine(playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                                case 5:
                                    Console.WriteLine("__________________");
                                    Console.WriteLine("вы выбрали charge of darkness");
                                    mpp -= 1;
                                    Console.WriteLine("вы потратили 1 маны");
                                    Console.WriteLine("вы оглушили врага и нанесли ему 30 ед.урона");
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье Монстров");
                                    Monsterhp -= 30;
                                    Console.WriteLine(Monsterhp);
                                    Console.WriteLine("Здоровье игрока");
                                    Console.WriteLine(playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("__________________");
                            Console.WriteLine("вы использовали лечение");
                            playerhp += tohilP;
                            Console.WriteLine("______");
                            Console.WriteLine("Здоровье персонажа вылечено на: " + tohilP);
                            Console.WriteLine("______");
                            Console.WriteLine("Здоровье персонажа: " + playerhp);
                            Console.WriteLine("______");
                            Console.WriteLine("Монстр вам нанес: " + toPdmg);
                            playerhp -= toPdmg;
                            Console.WriteLine("______");
                            Console.WriteLine("Здоровье персонажа: " + playerhp);
                            Console.WriteLine("__________________");
                            break;
                    }


                    Console.WriteLine("==================================");
                }


                Console.WriteLine("вы хотите начать бой заного? (Y/N)");
                string userInput = Console.ReadLine();

                if (userInput == "y")
                {
                    Console.WriteLine("Бой был перезапущен");
                    continue;
                }
                else if (userInput == "n")
                {
                    Console.WriteLine("бой окончен");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                    Console.WriteLine("вы хотите вернуться к выбору? (y/n)");
                    string c = (Console.ReadLine());
                    if (c == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

            }

            Console.WriteLine("Итоги битвы:");
            Console.WriteLine("Здоровье оставшееся у Игрока: " + playerhp);
            Console.WriteLine("Здоровье оставшееся у Монстра " + Monsterhp);
            Console.WriteLine("Урон нанесеный Игроком: " + "хуета");
            Console.WriteLine("Урон нанесеный Монстром: " + "хуетах2");
            goldplayer += goldmonster;
            Console.WriteLine($"У вас {goldplayer} золота");
            Console.ReadKey();
        }
       public void BossBattle(double mdmg, double mdef, double Monsterhp, int goldmonster)
        {
            Console.WriteLine($"параметры игрока (40 хп -- 18 атак -- 12 защита )");
            Console.WriteLine($"параметры монстра ({Monsterhp} хп -- {mdmg} атакa -- {mdef} защита )");
            Console.WriteLine($"золото которые вы получите после убийства монстра = {goldmonster}");
            double playerhp = 40;
            double mpp = 30;
            double pdmg = 18;
            double pdef = 12;
            int goldplayer = 0;
            double toPdmg = mdmg / pdef;
            double toMdmg = pdmg / mdef;
            double tohilP = 4;
            int s = 1;

            while (true)
            {
                while (playerhp > 0 && Monsterhp > 0)
                {

                    Console.WriteLine("==================================");
                    Console.WriteLine("новый ход");
                    Console.WriteLine("__________________");
                    Console.WriteLine("ваша мана восстановлена на 3 ед.");
                    mpp += 3;
                    Console.WriteLine("Мана персонажа: " + mpp);
                    Console.WriteLine("__________________");
                    Console.WriteLine("Выберите действие которое хотите использовать:1 - атака, 2 - магия, 3 - лечение");
                    Console.WriteLine("__________________");
                    Console.WriteLine(Monsterhp);

                    
                    int modescroll = int.Parse(Console.ReadLine());
                    switch (modescroll)
                    {

                        case 1:
                            Console.WriteLine("__________________");
                            Console.WriteLine("Вы использовали атаку");
                            Console.WriteLine("__________________");
                            Console.WriteLine("Вы нанесли монстру: " + toMdmg);
                            Console.WriteLine("__________________");
                            Console.WriteLine("Здоровье Монстров");
                            Monsterhp -= toMdmg;
                            Console.WriteLine(Monsterhp);

                            Console.WriteLine("__________________");
                            Console.WriteLine("Монстр вам нанес: " + toPdmg);
                            Console.WriteLine("__________________");
                            Console.WriteLine("Здоровье игрока");
                            playerhp -= toPdmg;
                            Console.WriteLine(playerhp);


                            break;
                        case 2:
                            Console.WriteLine("__________________");
                            Console.WriteLine("Выберите навык который хотие использовать:1 - Fireball; 2 - Shadow Dance; 3 - First Strike;" +
               " 4 - Reverse Polarity; 5 - Charge of Darkness");
                            int modeskill = int.Parse(Console.ReadLine());
                            switch (modeskill)
                            {
                                case 1:
                                    Console.WriteLine("__________________");
                                    Console.WriteLine("вы выбрали fireball");
                                    mpp -= 5;
                                    Console.WriteLine("вы потратили 5 маны");
                                    Console.WriteLine("Вы нанесли монстру: 5 ед. урона");
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье Монстров");
                                    Monsterhp -= 5;
                                    Console.WriteLine(Monsterhp);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Монстр вам нанес: " + toPdmg);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье игрока");
                                    playerhp -= toPdmg;
                                    Console.WriteLine(playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                                case 2:
                                    Console.WriteLine("__________________");
                                    Console.WriteLine("вы выбрали shadow dance");
                                    mpp -= 7;
                                    Console.WriteLine("вы потратили 7 маны");
                                    Console.WriteLine("Вы нанесли монстру: 2 ед. урона");
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье Монстров");
                                    Monsterhp -= 2;
                                    Console.WriteLine(Monsterhp);
                                    playerhp += 2;
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье персонажа вылечено на: 2");
                                    Console.WriteLine("Здоровье персонажа: " + playerhp);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Монстр вам нанес: " + toPdmg);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье игрока");
                                    playerhp -= toPdmg;
                                    Console.WriteLine(playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                                case 3:
                                    Console.WriteLine("__________________");
                                    Console.WriteLine("вы выбрали first strike");
                                    mpp -= 8;
                                    Console.WriteLine("вы потратили 8 маны");
                                    Console.WriteLine("Вы нанесли монстру: 6");
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье Монстров");
                                    Monsterhp -= 6;
                                    Console.WriteLine(Monsterhp);

                                    Console.WriteLine("______");
                                    Console.WriteLine("Монстр вам нанес: " + toPdmg);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье игрока");
                                    playerhp -= toPdmg;
                                    Console.WriteLine(playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                                case 4:
                                    Console.WriteLine("__________________");
                                    Console.WriteLine("вы выбрали reverse polarity");
                                    mpp -= 13;
                                    Console.WriteLine("вы потратили 13 маны");
                                    Console.WriteLine("вы оглушили врага и нанесли ему 3 ед.урона");
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье Монстров");
                                    Monsterhp -= 3;
                                    Console.WriteLine(Monsterhp);
                                    Console.WriteLine("Здоровье игрока");
                                    Console.WriteLine(playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                                case 5:
                                    Console.WriteLine("__________________");
                                    Console.WriteLine("вы выбрали charge of darkness");
                                    mpp -= 1;
                                    Console.WriteLine("вы потратили 1 маны");
                                    Console.WriteLine("вы оглушили врага и нанесли ему 30 ед.урона");
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье Монстров");
                                    Monsterhp -= 500;
                                    Console.WriteLine(Monsterhp);
                                    Console.WriteLine("Здоровье игрока");
                                    Console.WriteLine(playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("__________________");
                            Console.WriteLine("вы использовали лечение");
                            playerhp += tohilP;
                            Console.WriteLine("______");
                            Console.WriteLine("Здоровье персонажа вылечено на: " + tohilP);
                            Console.WriteLine("______");
                            Console.WriteLine("Здоровье персонажа: " + playerhp);
                            Console.WriteLine("______");
                            Console.WriteLine("Монстр вам нанес: " + toPdmg);
                            playerhp -= toPdmg;
                            Console.WriteLine("______");
                            Console.WriteLine("Здоровье персонажа: " + playerhp);
                            Console.WriteLine("__________________");
                            break;
                    }


                    Console.WriteLine("==================================");
                }



                if (playerhp <= 0)
                {
                    Console.WriteLine("Вы проиграли, хотите перезапустить бой?");

                    string userInput = Console.ReadLine();

                    if (userInput == "y")
                    {
                        Console.WriteLine("Бой был перезапущен");

                        continue;
                    }
                    else if (userInput == "n")
                    {
                        Console.WriteLine("бой окончен");

                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное значение");
                        Console.WriteLine("вы хотите вернуться к выбору? (y/n)");
                        string c = (Console.ReadLine());
                        if (c == "y")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Environment.Exit(0);

                        }
                    }
                }
                else if (Monsterhp <= 0)
                {
                    Console.WriteLine("Итоги битвы:");
                    Console.WriteLine("Здоровье оставшееся у Игрока: " + playerhp);
                    Console.WriteLine("Здоровье оставшееся у Монстра " + Monsterhp);
                    Console.WriteLine("Урон нанесеный Игроком: " + "хуета");
                    Console.WriteLine("Урон нанесеный Монстром: " + "хуетах2");

                    goldplayer += goldmonster;
                    Console.WriteLine($"У вас {goldplayer} золота");
                    Console.WriteLine("чтобы продолжить нажмите любую кнопку");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }

            
        }

      public void Test1()
        {
            Console.WriteLine("список ваших предметов");
            foreach (var invent in inventory)
            {
                Console.WriteLine($"{invent._id}, {invent.Name}, {invent.Count}");
            }
            Console.WriteLine("\n\n");
        }

      public  void TestAddItem(string item, int amount)
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

       public void Test2()
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

       public void Explore()
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

        public void Shop()
        {

        }
    }

}
