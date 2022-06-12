// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

string message = "Вы вышли из цикла";
string password = "exit";
string code;
int i = 1;

while (i > 0)
{
    Console.WriteLine("Введите пароль: ");
    code = Console.ReadLine();
    if (code == password)
    {
        Console.WriteLine(message);
        i = 0;
    }
    else
    {
        Console.WriteLine("Пароль неверный, цикл продолжается");
    }
}
