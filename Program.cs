Console.WriteLine("Вторая задача на поиск большего числа из трёх");

bool valid = false;
int num1 = 0;
int num2 = 0;
int num3 = 0;

while (valid == false) {
Console.WriteLine("Введите первое число: ");
string? str = Console.ReadLine();
if(int.TryParse(str, out int number1)) {
    num1 = number1;
    valid = true;
}
else Console.WriteLine("Некорректно введено первое число!");
}
valid = false;

while (valid == false) {
Console.WriteLine("Введите второе число: ");
string? str = Console.ReadLine();
if(int.TryParse(str, out int number2)) {
    num2 = number2;
    valid = true;
}
else Console.WriteLine("Некорректно введено второе число!");
}
valid = false;

while (valid == false) {
Console.WriteLine("Введите третье число: ");
string? str = Console.ReadLine();
if(int.TryParse(str, out int number3)) {
    num3 = number3;
    valid = true;
}
else Console.WriteLine("Некорректно введено третье число!");
}

if(num1 > num2) {
    if (num1 > num3) {
    Console.WriteLine("Большее число из введённых Вами: " + num1);
    }
    else Console.WriteLine("Большее число из введённых Вами: " + num3);
}
else if(num2 > num3) {
    Console.WriteLine("Большее число из введённых Вами: " + num2);
} else Console.WriteLine("Большее число из введённых Вами: " + num3); 