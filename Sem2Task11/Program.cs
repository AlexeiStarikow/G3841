// Зарандомить трехзначное число и убрать среднюю цифру

// Вариант 1

// System.Random numSintezator = new System.Random();
// int num = numSintezator.Next(100,1000);
// int digitFirst = num/100;
// int digitLast = num%10;
// Console.WriteLine(num);
// Console.WriteLine(digitFirst*10 +digitLast);

// Вариант 2

System.Random random = new System.Random();

int randomNumber = random.Next(100,1000);

Console.WriteLine("число: " + randomNumber);

string value = randomNumber.ToString();

char[] numberArray = value.ToCharArray();

Console.WriteLine(numberArray[0] + "" + numberArray[2]);