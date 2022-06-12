// В переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы дается 3 попытки ввести пароль и увидеть секретное сообщение.

string message = "Поздравляю, ты угадал пароль";
string password = "753951Qwe";
string code;
int i = 0;

while (i < 3)
{
    Console.WriteLine("Введите пароль: ");
    code = Console.ReadLine();
    if (code == password)
    {
        Console.WriteLine(message);
        i = 3;
    }
    else
    {
        Console.WriteLine("Неверный пароль");
    }
    i++;
}
