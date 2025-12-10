using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    static HashSet<int> discoveredEndings = new HashSet<int>();
    static int totalIterations = 0;
    static int maxIterations = 20;
    static int maxEndings = 10;

    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("=== ХЭЛЛОУИНСКАЯ НОВЕЛЛА С КОЛЛЕКЦИЕЙ КОНЦОВОК ===");
        Console.WriteLine($"Цель: открыть {maxEndings} различных концовок за {maxIterations} попыток!");

        // Главный цикл игры - до 20 итераций или 10 концовок
        while (discoveredEndings.Count < maxEndings && totalIterations < maxIterations)
        {
            totalIterations++;
            Console.WriteLine($"\n=== ПОПЫТКА №{totalIterations} ===");
            Console.WriteLine($"Открыто концовок: {discoveredEndings.Count}/10");
            Console.WriteLine($"Осталось попыток: {maxIterations - totalIterations}");

            StartGame();

            if (discoveredEndings.Count >= maxEndings)
            {
                Console.WriteLine("\n🎉 ПОЗДРАВЛЯЕМ! Вы открыли все 10 концовок!");
                break;
            }

            if (totalIterations < maxIterations)
            {
                Console.WriteLine("\n--- Новая попытка ---");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        ShowFinalStats();
    }

    static void StartGame()
    {
        Console.Clear();
        string go = "";
        string costum = "";
        string eat = "";
        string castom = "";
        string party = "";
        int endingNumber = 0;

        Console.WriteLine("Рано утром проснулась");
        Console.WriteLine("Увидела информацию о праздновании хэллоуина");
        Console.WriteLine("Идти или остаться дома...");
        Console.WriteLine("A - Пойти | D - Не идти | S - Лечь обратно спать | W - Проверить почту");
        string Answer = Console.ReadLine().ToUpper();

        if (Answer == "A")
        {
            go = "da";
            Console.WriteLine("\nВы приняли решение поехать на праздник");
            Console.WriteLine("Начав обдумывать костюм вы прикинули время и возможности.");
            Console.WriteLine("Посчитав время и поняв что у вас осталось 6 часов решили выбрать что-то не сложное.");
            Console.WriteLine("К примеру...");
            Console.WriteLine("A - Призрак | D - Тыква | W - Ведьма/Волшебник | S - Зомби");
            costum = Console.ReadLine().ToUpper();
        }
        else if (Answer == "D")
        {
            go = "net";
            Console.WriteLine("\nВы решили не идти на праздник.");
            Console.WriteLine("Спокойно пошли завтракать.");
            Console.WriteLine("Подойдя к холодильнику начали думать что можно взять.");
            Console.WriteLine("A - Йогурт | D - Бутерброд | W - Приготовить что-то особенное | S - Заказать доставку");
            eat = Console.ReadLine().ToUpper();
        }
        else if (Answer == "S")
        {
            go = "sleep";
            Console.WriteLine("\nВы легли обратно спать.");
            Console.WriteLine("Через несколько часов вас разбудил телефонный звонок...");
            Console.WriteLine("A - Ответить | D - Проигнорировать | W - Проверить, кто звонит");
            string call = Console.ReadLine().ToUpper();

            if (call == "A")
            {
                Console.WriteLine("\nЭто был друг, который напомнил о вечеринке.");
                Console.WriteLine("Он уговорил вас присоединиться.");
                Console.WriteLine("Вы быстро встали и начали готовиться.");
                go = "da";
                costum = "A";
            }
            else if (call == "W")
            {
                Console.WriteLine("\nВы проверили телефон - звонил незнакомый номер.");
                Console.WriteLine("Решили перезвонить и оказалось, что это организаторы вечеринки.");
                Console.WriteLine("Они пригласили вас как специального гостя!");
                Console.WriteLine("Концовка 10: Особое приглашение!");
                endingNumber = 10;
                RecordEnding(endingNumber);
                return;
            }
            else
            {
                Console.WriteLine("\nВы проигнорировали звонок и проспали до вечера.");
                Console.WriteLine("Проснувшись, поняли что пропустили все мероприятия.");
                Console.WriteLine("Концовка 1: Сон лучше праздника.");
                endingNumber = 1;
                RecordEnding(endingNumber);
                return;
            }
        }
        else if (Answer == "W")
        {
            Console.WriteLine("\nВы проверили почту и обнаружили загадочное письмо...");
            Console.WriteLine("В нём была карта с указанием места тайной вечеринки.");
            Console.WriteLine("A - Последовать указаниям | D - Проигнорировать | S - Позвать друзей");
            string mystery = Console.ReadLine().ToUpper();

            if (mystery == "A")
            {
                Console.WriteLine("\nВы отправились по указанному адресу.");
                Console.WriteLine("Там оказалось самое эпическое хэллоуинское мероприятие!");
                Console.WriteLine("Концовка 11: Тайная вечеринка!");
                endingNumber = 11;
                RecordEnding(endingNumber);
                return;
            }
            else
            {
                Console.WriteLine("\nВы решили не рисковать и остались дома.");
                Console.WriteLine("Концовка 12: Осторожность не бывает лишней.");
                endingNumber = 12;
                RecordEnding(endingNumber);
                return;
            }
        }
        else
        {
            Console.WriteLine("Неверный выбор. Попробуйте другую ветку в следующий раз!");
            return;
        }

        if (go == "da")
        {
            if (costum == "A")
            {
                Console.WriteLine("\nНачали думать что вам нужно для костюма призрака.");
                Console.WriteLine("Взяв белую простынь вы начали думать, что с ней можно сделать.");
                Console.WriteLine("Подошли к столу и взяли ножницы.");
                Console.WriteLine("Аккуратно вырезали отверстия под глаза.");
                Console.WriteLine("Взяли красную краску и оставили пятна.");
                Console.WriteLine("Выглядит страшно... ТО ЧТО НАДО.");

                Console.WriteLine("\nКогда вы оделись, подъехал друг на машине.");
                Console.WriteLine("Он был в костюме вампира и выглядел эффектно.");
                Console.WriteLine("По дороге на вечеринку вы обсуждали планы на вечер.");

                Console.WriteLine("\nПриехав на место, вы увидели украшенный дом.");
                Console.WriteLine("На вечеринке уже было много людей в разных костюмах.");
                Console.WriteLine("A - Пойти танцевать | D - Пойти к столу с угощениями | W - Искать знакомых | S - Участвовать в конкурсе");
                party = Console.ReadLine().ToUpper();

                if (party == "A")
                {
                    Console.WriteLine("\nВы пошли на танцпол.");
                    Console.WriteLine("Ваш костюм привлекал много внимания.");
                    Console.WriteLine("Вы отлично провели время, танцуя всю ночь.");
                    Console.WriteLine("Концовка 2: Ночь страшных танцев!");
                    endingNumber = 2;
                }
                else if (party == "D")
                {
                    Console.WriteLine("\nВы направились к столу с угощениями.");
                    Console.WriteLine("Там были тыквенные пироги, коктейли и сладости.");
                    Console.WriteLine("Попробовав всё, вы почувствовали себя плохо...");
                    Console.WriteLine("Оказалось, в еду добавили слишком много красителей.");
                    Console.WriteLine("Концовка 3: Праздник испорчен животиком.");
                    endingNumber = 3;
                }
                else if (party == "W")
                {
                    Console.WriteLine("\nВы начали искать знакомых в толпе.");
                    Console.WriteLine("Внезапно кто-то схватил вас за руку...");
                    Console.WriteLine("Это был ваш старый друг в костюме скелета!");
                    Console.WriteLine("Вы провели всю ночь, вспоминая старые времена.");
                    Console.WriteLine("Концовка 13: Неожиданная встреча!");
                    endingNumber = 13;
                }
                else if (party == "S")
                {
                    Console.WriteLine("\nВы решили участвовать в конкурсе костюмов.");
                    Console.WriteLine("Жюри оценило вашу креативность и простоту.");
                    Console.WriteLine("Вы заняли 2 место и выиграли приз!");
                    Console.WriteLine("Концовка 14: Призовой призрак!");
                    endingNumber = 14;
                }
            }
            else if (costum == "D")
            {
                Console.WriteLine("\nОсмотрели комнату в поисках материалов для тыквы.");
                Console.WriteLine("Нашли ткань оранжевого цвета и проволоку.");
                Console.WriteLine("Потратили 3 часа на создание каркаса тыквы.");
                Console.WriteLine("Обтянули его тканью и закрепили.");
                Console.WriteLine("Взяли краску и нарисовали текстуры и лицо.");
                Console.WriteLine("Выглядит не плохо, но можно лучше.");
                Console.WriteLine("A - Усложнить костюм | D - И так нормально | W - Добавить звуковые эффекты");
                castom = Console.ReadLine().ToUpper();

                if (castom == "A")
                {
                    Console.WriteLine("\nВы решили добавить светодиоды внутрь костюма.");
                    Console.WriteLine("Нашли старую гирлянду и встроили её.");
                    Console.WriteLine("Теперь тыква светится в темноте!");
                    Console.WriteLine("Также добавили зелёный шарф как хвостик.");

                    Console.WriteLine("\nПриехав на вечеринку, все восхищались вашим костюмом.");
                    Console.WriteLine("Даже хозяин вечеринки отметил вашу креативность.");
                    Console.WriteLine("Вы выиграли конкурс на лучший костюм!");
                    Console.WriteLine("Концовка 4: Король/Королева Хэллоуина!");
                    endingNumber = 4;
                }
                else if (castom == "D")
                {
                    Console.WriteLine("\nВы решили не заморачиваться с доработками.");
                    Console.WriteLine("Вместо этого посмотрели фильм ужасов, чтобы настроиться.");
                    Console.WriteLine("Затем собрались и поехали на вечеринку.");

                    Console.WriteLine("\nНа вечеринке ваш костюм выглядел просто, но мило.");
                    Console.WriteLine("Вы познакомились с интересными людьми.");
                    Console.WriteLine("Всю ночь играли в хэллоуинские игры и веселились.");
                    Console.WriteLine("Концовка 5: Простая, но счастливая ночь.");
                    endingNumber = 5;
                }
                else if (castom == "W")
                {
                    Console.WriteLine("\nВы добавили динамик с записью страшного смеха.");
                    Console.WriteLine("Костюм получился очень эффектным!");
                    Console.WriteLine("На вечеринке вы всех пугали своим смехом.");
                    Console.WriteLine("Концовка 15: Смеющаяся тыква!");
                    endingNumber = 15;
                }
            }
            else if (costum == "W")
            {
                Console.WriteLine("\nВы решили нарядиться ведьмой/волшебником.");
                Console.WriteLine("Нашли старую мантию, шляпу и сделали волшебную палочку.");
                Console.WriteLine("На вечеринке вы показывали 'магические' фокусы.");
                Console.WriteLine("Концовка 16: Ночь магии!");
                endingNumber = 16;
            }
            else if (costum == "S")
            {
                Console.WriteLine("\nВы создали потрясающий костюм зомби.");
                Console.WriteLine("Специальным гримом сделали раны и швы.");
                Console.WriteLine("Ваша походка и движения были очень реалистичны!");
                Console.WriteLine("Концовка 17: Лучший зомби вечеринки!");
                endingNumber = 17;
            }
        }
        else if (go == "net")
        {
            if (eat == "A")
            {
                Console.WriteLine("\nВы решили покушать йогурт.");
                Console.WriteLine("Подошли к холодильнику, достали йогурт.");
                Console.WriteLine("Пока ели, заметили в окне детей в костюмах.");
                Console.WriteLine("Они ходили по домам и собирали конфеты.");

                Console.WriteLine("\nA - Дать им конфет | D - Сделать вид, что вас нет дома | W - Пригласить их внутрь");
                string kids = Console.ReadLine().ToUpper();

                if (kids == "A")
                {
                    Console.WriteLine("\nВы нашли немного конфет и вышли к детям.");
                    Console.WriteLine("Они обрадовались и поблагодарили вас.");
                    Console.WriteLine("Один ребёнок даже подарил вам маленькую тыковку.");
                    Console.WriteLine("Вы почувствовали дух праздника, даже оставаясь дома.");
                    Console.WriteLine("Концовка 6: Тихое, но душевное Хэллоуин.");
                    endingNumber = 6;
                }
                else if (kids == "W")
                {
                    Console.WriteLine("\nВы пригласили детей внутрь и устроили мини-вечеринку.");
                    Console.WriteLine("Рассказывали страшные истории и играли в игры.");
                    Console.WriteLine("Концовка 18: Домашний детский Хэллоуин!");
                    endingNumber = 18;
                }
                else
                {
                    Console.WriteLine("\nВы выключили свет и притаились.");
                    Console.WriteLine("Смотрели как дети ходят по улице.");
                    Console.WriteLine("Внезапно в дверь постучали...");
                    Console.WriteLine("Оказалось, это друзья пришли проведать вас с угощениями!");
                    Console.WriteLine("Концовка 7: Сюрприз от друзей.");
                    endingNumber = 7;
                }
            }
            else if (eat == "D")
            {
                Console.WriteLine("\nВы решили сделать бутерброды.");
                Console.WriteLine("Взяли хлеб, колбасу, сыр и овощи.");
                Console.WriteLine("Начали нарезать ингредиенты...");
                Console.WriteLine("На запах сбежалась вся семья.");
                Console.WriteLine("Пришлось делать бутерброды для всех.");

                Console.WriteLine("\nПосле ужина семья решила посмотреть фильмы.");
                Console.WriteLine("A - Фильм ужасов | D - Комедию про Хэллоуин | W - Создать свой фильм");
                string movie = Console.ReadLine().ToUpper();

                if (movie == "A")
                {
                    Console.WriteLine("\nВы выбрали классический хоррор.");
                    Console.WriteLine("Всей семьёй прыгали от страха в ключевые моменты.");
                    Console.WriteLine("Было весело и страшно одновременно!");
                    Console.WriteLine("Концовка 8: Семейный ужастик.");
                    endingNumber = 8;
                }
                else if (movie == "W")
                {
                    Console.WriteLine("\nВы решили снять свой хэллоуинский фильм на телефон.");
                    Console.WriteLine("Получилось смешно и страшно одновременно!");
                    Console.WriteLine("Концовка 19: Семейный режиссёр!");
                    endingNumber = 19;
                }
                else
                {
                    Console.WriteLine("\nВы посмотрели лёгкую комедию.");
                    Console.WriteLine("Смеялись до слёз всей семьёй.");
                    Console.WriteLine("Заказали пиццу и продолжили веселье.");
                    Console.WriteLine("Концовка 9: Уютный семейный вечер.");
                    endingNumber = 9;
                }
            }
            else if (eat == "W")
            {
                Console.WriteLine("\nВы приготовили особое хэллоуинское блюдо.");
                Console.WriteLine("Тыквенный суп и печенье в форме привидений!");
                Console.WriteLine("Ужин получился волшебным.");
                Console.WriteLine("Концовка 20: Кулинарный Хэллоуин!");
                endingNumber = 20;
            }
            else if (eat == "S")
            {
                Console.WriteLine("\nВы заказали специальную хэллоуинскую пиццу.");
                Console.WriteLine("Курьер был в костюме монстра!");
                Console.WriteLine("Вы хорошо провели время в одиночестве.");
                Console.WriteLine("Концовка 21: Уютное одиночество.");
                endingNumber = 21;
            }
        }

        if (endingNumber > 0)
        {
            RecordEnding(endingNumber);
        }
    }

    static void RecordEnding(int endingNumber)
    {
        Console.WriteLine($"\n=== КОНЦОВКА №{endingNumber} ДОСТИГНУТА ===");

        if (discoveredEndings.Contains(endingNumber))
        {
            Console.WriteLine("(Эта концовка уже была открыта ранее)");
        }
        else
        {
            discoveredEndings.Add(endingNumber);
            Console.WriteLine("✨ НОВАЯ КОНЦОВКА! ✨");
        }

        Console.WriteLine($"Всего открыто: {discoveredEndings.Count}/10 концовок");
    }

    static void ShowFinalStats()
    {
        Console.WriteLine("\n=== ИГРА ЗАВЕРШЕНА ===");
        Console.WriteLine($"Общее количество попыток: {totalIterations}");
        Console.WriteLine($"Открыто концовок: {discoveredEndings.Count}/10");

        if (discoveredEndings.Count > 0)
        {
            Console.WriteLine("\nОткрытые концовки:");
            List<int> sortedEndings = new List<int>(discoveredEndings);
            sortedEndings.Sort();

            foreach (var ending in sortedEndings)
            {
                Console.WriteLine($"- Концовка №{ending}");
            }
        }

        if (discoveredEndings.Count >= 10)
        {
            Console.WriteLine("\n🎉 ВЫ ПОБЕДИЛИ! Открыты все концовки!");
        }
        else if (totalIterations >= maxIterations)
        {
            Console.WriteLine($"\n⏰ Время вышло! Вы достигли лимита в {maxIterations} попыток.");
        }

        Console.WriteLine("\nСпасибо за игру! Счастливого Хэллоуина! 🎃👻");
    }
}
