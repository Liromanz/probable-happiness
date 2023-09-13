/*Console.WriteLine("Сколько ложек вы хотите?");
string txt = Console.ReadLine(); //5
int num = Convert.ToInt32(txt);

for (int lojki = 1; lojki <= num; lojki++)
{
    Console.WriteLine("Добавила " + lojki + " ложек сахара");
}
*/
/*
for (int i = 1000; i >= 6; i -=7)
{
    Console.WriteLine(i);
}*/

/*
bool isListening;

do
{
    Console.WriteLine("Говорю");
    Console.WriteLine("Меня слушают?");
    bool.TryParse(Console.ReadLine(), out isListening);
} while (isListening);*/


string colour;
do
{
    Console.WriteLine("Выберите цвет");
    Console.WriteLine("1. Синий");
    Console.WriteLine("2. Зеленый");
    Console.WriteLine("3. Красный");
    Console.WriteLine("4. Выход");
    colour = Console.ReadLine();

    switch (colour)
    {
        case "1":
            break;
        case "2":
            Console.WriteLine("зеленая листва шуршит");
            break;
        case "3":
            Console.WriteLine("красный как корова");
            break;
    }
} while (colour != "4");