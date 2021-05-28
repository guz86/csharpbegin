using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJuniorApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Привет, мир!");
            // Console.ReadKey();
            // Основные типы: int и uint, остальные можно не исопльзовать, попытка экономить на мощностях. | float | char | string | bool
            // Целочисленные
            byte b; // 0 до 255
            sbyte sb; // -128 до 127
            short sh; // -32768 до 32767
            ushort us; // 0 до 65535 (отказ от знаковой части в пользу беззнаковой)
            int i; // -2147483648 до 2147483647
            uint ui; // 0 до 4294967295
            long ln; // как посмотреть значение добавить = long.MaxValue всплывет  (редко пригождается)
            ulong ul;
            // Числа с плавающей точкой
            float fl = 5.6f; // точность 7 знаков после запятой
            double db = 5.2; // точность 15 знаков после запятой
            // Символьный тип
            char ch = ' '; // 1 символ
            // Строковые
            string str = "Hello";
            // Логические
            bool bl; // true false

            int age = 5;

            // Арифметические операторы + - * / %

            int x, y;
            x = 5;
            y = 2;
            float result = Convert.ToSingle(x) / y;
            Console.WriteLine(result);

            //  % остаток от деления часы минуты
            int time = 65;
            int hour = time / 60;
            int min = time % 60;

            Console.WriteLine("Часы, минуты 65 минут:");
            Console.WriteLine(hour);
            Console.WriteLine(min);

            // age = age + 1
            int testage = 18;
            // testage = testage + 1;
            testage += 1;
             // += -+ *= /= %=
            Console.WriteLine(testage);

            // Логические операторы == != <= >= > < 

            int myAge = 17;
            bool isBuyAlcohol = myAge >= 18;
            Console.WriteLine(isBuyAlcohol);

            // Интерполяция

            int intAge = 21;
            string intName = "Вася";
            Console.WriteLine($"Ваше имя {intName} и количество ваших лет равняется - {intAge}.");

            // Конвертация

            int conAge;
            string conStr = "15";
            // conStr = conAge;
            conAge = Convert.ToInt32(conStr);
            Console.WriteLine(conAge);

            float itog;
            int g = 2, h = 7;
            // itog = g / h;
            itog = Convert.ToSingle(x) / h;
            Console.WriteLine(itog);

            // Консоль

            string consName;
            int consAge;

            Console.Write("Введите ваше имя: ");
           // consName = Console.ReadLine();
            
            Console.Write("Введите ваш возраст: ");
            // consAge = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Вас зовут " + consName + " и Ваш возраст " + consAge + " лет.");

            // Инкремент и декремент
            int l = 0;
            // l++;
            Console.WriteLine("Переменная l++ + ++l = " + l++ + ++l);
            Console.WriteLine("Переменная l = " + l);
            Console.WriteLine("Переменная l = " + l++);
            Console.WriteLine("Переменная l = " + ++l);

            int ll = 0;
            ll--;
            Console.WriteLine("Переменная ll = " + ll);
            Console.WriteLine("Переменная ll = " + ll--);
            Console.WriteLine("Переменная ll = " + --ll);


            // инкремент имеет преоритет перед умножением
            //                1   + 2 + 1 + 1 + "1" + 3 * 2
            int A = 0;   
            Console.WriteLine(++A + 2 + 1 + A++ + "1" + ++A * 2);
            // 516


            // Практика
            // расчет урона персонажу health armor damage
            float health;
            int armor; // сколько процентов дойдет до здоровья
            int damage;

            //Console.Write("Введите количество жизней: ");
            //health = Convert.ToInt32( Console.ReadLine());
            //Console.Write("Введите количество брони: ");
            //armor = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите количество урона: ");
            //damage = Convert.ToInt32(Console.ReadLine());

            // Считаем сколько составляет 1 процент от нанесенного
            // урона и умножаем это количество на процент Армор,
            // получаем здоровье минус процент от задержанного армором урона

            //health -= Convert.ToSingle(damage) / 100 * armor;

            //Console.WriteLine("Здоровье после урона в " + damage 
            //+" составляет "  + health);

            // практика магазин товаров
            int eatPrice = 99;
            int money;
            int eatCount;
            bool enoughMoney;

            Console.WriteLine("Добро пожаловать, сегодня у нас все по " + eatPrice + " монет!");

            //Console.Write("Сколько у вас монет: ");
            //money = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Сколько товаров вы хотите приобрести: ");
            //eatCount = Convert.ToInt32(Console.ReadLine());

            //enoughMoney = money >= eatCount * eatPrice;
            // Если true то домножаем количество еды на 1,
            // если false, то домножаем количество еды на 0
            // и покупка не произойдет и денег останется как было

            //eatCount *= Convert.ToInt32(enoughMoney);

            //money -= eatCount * eatPrice;

            //Console.WriteLine("У вас в сумке " + eatCount + " товаров и осталось в кармане " + money + " монет!");

            // ДЗ  начало

            // объявить 10 переменных разных типов
            int buttonNotebook =  - 5;
            uint giftButton = 123;
            byte fingers = 10;
            sbyte debtMoney = -5;
            short thingsRoom =  - 2;
            ushort stillThings = 50;
            float scoreLife = 22.5f;
            char sign = 'M';
            string namePlayer = "Frank";
            bool answer = true;


            // Что выведется в консоль и почему
            int aa = 10;
            int bb = 38 * 17;
            //  31 - 50 = -19/646 = -0.02
            int cx = (31 - 5 * aa) / bb;
            // cx? 
            Console.WriteLine(cx);
            int cxr = -19 / 6;
            Console.WriteLine(cxr);
            float cxsr = -19f /46;
            Console.WriteLine(cxsr);
            double cxsdr = -19.43 / 46;
            Console.WriteLine(cxsdr);

            // На экране в специальной зоне выводятся картинки по 3 в ряд.
            // Всего у пользователя в альбоме 52 картинки.
            // Код должен вывести, сколько полностью заполненных рядов можно будет вывести
            // и сколько картинок будет сверх меры.
            // В качестве решения ожидаются объявленные переменные с необходимыми значениями
            // и, основываясь на значениях переменных, вывод необходимых данных.

            int countPictures = 52;
            int countScreen = 3;
            int viewPictures;
            int noviewPictures;

            viewPictures = countPictures / countScreen;
            noviewPictures = countPictures % countScreen;

            Console.WriteLine("На экране из 52х по 3 в ряд выведется " + viewPictures + " картинок.");
            Console.WriteLine("На экране из 52х по 3 в ряд не выведется " + noviewPictures + "картинок.");

            // Легенда: Вы приходите в магазин и хотите купить за свое золото кристаллы.
            // В вашем кошельке есть какое - то количество золота, продавец справшивает у вас,
            // сколько кристаллов вы хотите купить?
            // После сделки у вас остается какое - то количество золота и появляется какое - то количество кристаллов.
            // Формально: При старте программы пользователь вводит начальное количество золота.
            // Потом ему предлагается купить какое - то количество кристаллов по цене Н(задать в программе самому).
            // Пользователь вводит число и его золото конвертируется в кристаллы.
            // Остаток золота и кристаллов выводится на экран.Проверять на то, что у игрока достаточно денег Не нужно.

            int goldCount;
            int crystalPrice = 2;
            int crystalWantToBuy;

            Console.Write("Сколько у вас золота? ");
            //goldCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Добрый, кристаллы по цене: "+crystalPrice+" монеты. Сколько кристаллов вы хотите купить? ");
            //crystalWantToBuy = Convert.ToInt32(Console.ReadLine());

            //goldCount -= crystalPrice * crystalWantToBuy;

            //Console.WriteLine("У вас осталось золота: " + goldCount + " и кристаллов вы купили " + crystalWantToBuy);


            // Поликлиника
            // Легенда: Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать время ожидания в очереди.
            // Формально Пользователь вводит количество людей в очереди.
            // Фиксированное время прием одного человека всегда равно 10 минутам.
            // Пример ввода: введите количество старушек: 14
            // Пример вывода: Вы должны стоять в очереди 2 часа и 20 минут.

            int peopleCount;
            int timeCount = 10;
            int timeWait;
            Console.WriteLine("");
            Console.WriteLine("------------Поликлиника----------- ");
            Console.Write("Введите количество посетителей: ");
            peopleCount = Convert.ToInt32(Console.ReadLine());

            timeWait = timeCount * peopleCount;
            //Console.WriteLine("Вы должны стоять в очереди " + timeWait+ " минут");
            // timeWait /= 60;
            Console.WriteLine("Вы должны стоять в очереди " + timeWait/60 + " часов и " + timeWait%60 +" минут" );

            // Работа со строками
            // Вы задаете вопросы пользователю, как вас зовут, какой ваш знак зодиака и т.д. после ввода формируете текст о пользователе
            // "Вас зовут алексей, вам 21 год, вы водолей и работаете на заводе."

            string namePerson;
            string zodiacPerson;
            int oldPerson;
            string workPerson;

            Console.Write("Как вас зовут? ");
            namePerson = Console.ReadLine();

            Console.Write("Сколько вам лет? ");
            oldPerson = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какой ваш знак зодиака ");
            zodiacPerson = Console.ReadLine();

            Console.Write("Где вы работаете? ");
            workPerson = Console.ReadLine();

            Console.WriteLine("Вас зовут "+namePerson+", вам "+oldPerson+ " год, вы " + zodiacPerson +" и работаете на " + workPerson);






            // ДЗ конец

        }
    }
}
