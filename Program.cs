using System;

public class Program
{
    public static void Main(string[] args)
    {
        //создание объекта класса "Счет в банке"
        BankAccount account = new BankAccount();

        //ввод информации о счете
        Console.WriteLine("Введите номер счета:");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите имя владельца счета:");
        string accountOwner = Console.ReadLine();
        Console.WriteLine("Введите начальный баланс:");
        float initialBalance = float.Parse(Console.ReadLine());

        //открытие счета
        account.OpenAccount(accountNumber, accountOwner, initialBalance);

        //показ информации о счете
        Console.WriteLine("Информация о счете:");
        account.ShowAccountInfo();
        Console.WriteLine();

        //выбор
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Внести деньги");
            Console.WriteLine("2. Снять деньги");
            Console.WriteLine("3. Перевести деньги на другой счет");
            Console.WriteLine("4. Вывести информацию о счете");
            Console.WriteLine("5. Выйти из программы");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //вносим нал
                    Console.WriteLine("Введите сумму для внесения:");
                    float depositAmount = float.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    Console.WriteLine("Внесено {0} рублей", depositAmount);
                    Console.WriteLine();
                    break;
                case 2:
                    //снятие налички
                    Console.WriteLine("Введите сумму для снятия:");
                    float withdrawAmount = float.Parse(Console.ReadLine());
                    account.Withdrawal(withdrawAmount);
                    Console.WriteLine("Снято {0} рублей", withdrawAmount);
                    Console.WriteLine();
                    break;
                case 3:
                    //перевод денег со счета на счет
                    Console.WriteLine("Введите номер счета, на который хотите передать деньги:");
                    int targetAccountNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите сумму для перевода:");
                    float transferAmount = float.Parse(Console.ReadLine());
                    account.Transfer(targetAccountNumber, transferAmount);
                    Console.WriteLine("Переведено {0} рублей на счет {1}", transferAmount, targetAccountNumber);
                    Console.WriteLine();
                    break;
                case 4:
                    //показать информацию о счете
                    Console.WriteLine("Информация о счете:");
                    account.ShowAccountInfo();
                    Console.WriteLine();
                    break;
                case 5:
                    //выход
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Недопустимый выбор.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}