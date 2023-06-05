using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    public class Battle
    {
        public List<Player> players = new List<Player>()
        {
        new("Рыцарь", 125,15,25,50,1,0,0),
        new("Маг", 75,5,5,125,1,0,0),
        new("Вор", 100,10,15,75,1,0,0),
        };

        Slime slimeblue = new Slime(20, 2, 5, 1, 213);
        Slime slimered = new Slime(40, 10, 9, 2, 354);

        public void Battlechek()
        {
            Console.WriteLine("с каким монстром вы хотите драться : 1 - синий слайм, 2 - красный слайм");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                InfiniteBattle(slimeblue.Damage,slimeblue.Def,slimeblue.Health,slimeblue.Gold);
            }
            else if(choise  == 2) 
            {
                InfiniteBattle(slimered.Damage,slimered.Def,slimered.Health,slimered.Gold);
            }
        }

        void InfiniteBattle(double mdmg,double mdef,double Monsterhp,int goldmonster)
        {
            Console.WriteLine("параметры игрока (40 хп -- 16 атак -- 12 защита )");
            Console.WriteLine($"параметры монстра ({Monsterhp} хп -- {mdmg} атакa -- {mdef} защита )");
            Console.WriteLine($"золото которые вы получите после убийства монстра = {goldmonster}");
            double mpp = 30;
            double pdmg = 16;
            double pdef = 12;
            double toPdmg =  mdmg/ pdef;
            double toMdmg = pdmg / mdef;
            double tohilP = 4;
            double Playerhp = 40;
            int goldplayer = 0;


            while (true)
            {
                while (Playerhp > 0 && Monsterhp > 0)
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
                            Playerhp -= toPdmg;
                            Console.WriteLine(Playerhp);


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
                                    Playerhp -= toPdmg;
                                    Console.WriteLine(Playerhp);
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
                                    Playerhp += 2;
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье персонажа вылечено на: 2");
                                    Console.WriteLine("Здоровье персонажа: " + Playerhp);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Монстр вам нанес: " + toPdmg);
                                    Console.WriteLine("______");
                                    Console.WriteLine("Здоровье игрока");
                                    Playerhp -= toPdmg;
                                    Console.WriteLine(Playerhp);
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
                                    Playerhp -= toPdmg;
                                    Console.WriteLine(Playerhp);
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
                                    Console.WriteLine(Playerhp);
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
                                    Console.WriteLine(Playerhp);
                                    Console.WriteLine("Мана персонажа: " + mpp);
                                    Console.WriteLine("__________________");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("__________________");
                            Console.WriteLine("вы использовали лечение");
                            Playerhp += tohilP;
                            Console.WriteLine("______");
                            Console.WriteLine("Здоровье персонажа вылечено на: " + tohilP);
                            Console.WriteLine("______");
                            Console.WriteLine("Здоровье персонажа: " + Playerhp);
                            Console.WriteLine("______");
                            Console.WriteLine("Монстр вам нанес: " + toPdmg);
                            Playerhp -= toPdmg;
                            Console.WriteLine("______");
                            Console.WriteLine("Здоровье персонажа: " + Playerhp);
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
            Console.WriteLine("Здоровье оставшееся у Игрока: " + Playerhp);
            Console.WriteLine("Здоровье оставшееся у Монстра " + Monsterhp);
            Console.WriteLine("Урон нанесеный Игроком: " + "хуета");
            Console.WriteLine("Урон нанесеный Монстром: " + "хуетах2");
            goldplayer += goldmonster;
            Console.WriteLine($"У вас {goldplayer} золота");
            Console.ReadKey();
        }
    }
}
