// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.


//Считываем данные с консоли
string? imputLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (imputLine != null)
{
// Создаем массив с днями недели
string[] dayofWeek = new string[7];
dayofWeek[0] = "понедельник";
dayofWeek[1] = "вторник";
dayofWeek[2] = "среда";
dayofWeek[3] = "четверг";
dayofWeek[4] = "пятница";
dayofWeek[5] = "суббота";
dayofWeek[6] = "воскресение";
// Парсим введенное число
int imputNumber = int.Parse(imputLine);
// Находим название дня недели по введенному номеру
string outDayofWeek = dayofWeek[imputNumber-1];
// Выводим данные в консоль
Console.WriteLine(outDayofWeek);
}