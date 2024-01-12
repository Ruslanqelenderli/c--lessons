var password = "123";
int amount = 500;
var wrongCount = 3;
bool programRunning = true;
Console.WriteLine("Salam.Xoş gəlmisiniz");
while (programRunning)
{
    bool commandRunning = true;
    Console.Write("Şifrəni daxil edin:");
    

    string passwordUser = Console.ReadLine();

    if (passwordUser != password)
    {
        Console.Write("Şifrə sehvdir!");
        wrongCount--;
        if (wrongCount == 0) break;
        continue;
    }
    else
    {
        while (commandRunning)
        {
            Console.WriteLine("Pulun miqdarı  1");
            Console.WriteLine("Pul əlavə et   2");
            Console.WriteLine("Pul çək        3");
            Console.WriteLine("Hesabdan çıx   4");
            Console.WriteLine();
            Console.WriteLine("Bir emr daxil et");
            var command = Console.ReadLine();
            bool addRunning = true;
            bool removeRunning = true;

            switch (command)
            {
                case "1":
                    Console.WriteLine($"Balansınızdakı miqdar:{amount}");
                    Console.WriteLine($"Siyahiya qayitmaq uchun 0 daxil,proqramı sonlandırmaq üchün 9 daxil edin");
                    var result1=Console.ReadLine();
                    if(result1 == "0")
                    {
                        break;
                    }
                    else if (result1 == "9")
                    {
                        programRunning = false;
                        commandRunning = false;
                    }

                    break;
                case "2":
                    while (addRunning)
                    {
                        Console.Write("Miqdar daxil edin:");
                        try
                        {
                            int addAmount = int.Parse(Console.ReadLine());
                            amount += addAmount;
                            Console.WriteLine("Elave edildi");
                            Console.WriteLine($"Siyahiya qayitmaq uchun 0 daxil,proqramı sonlandırmaq üchün 9 daxil edin");
                            var result2 = Console.ReadLine();
                            if (result2 == "0")
                            {
                                addRunning = false;
                                break;
                            }
                            else if (result2 == "9")
                            {
                                programRunning = false;
                                commandRunning = false;
                                addRunning = false;
                                break;
                            }
                            
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Miqdari duzgun daxil edin");
                        }
                    }
                    
                  
                    break;
                case "3":
                    while (removeRunning)
                    {
                        Console.Write("Miqdar daxil edin:");
                        try
                        {
                            int removeAmount = int.Parse(Console.ReadLine());

                            if(amount< removeAmount)
                            {
                                Console.WriteLine("Balansınızda kifayet qeder məbləğ yoxdur");
                                continue;
                            }
                            amount -= removeAmount;
                            Console.WriteLine("Pul çəkildi");
                            Console.WriteLine($"Siyahiya qayitmaq uchun 0 daxil,proqramı sonlandırmaq üchün 9 daxil edin");
                            var result2 = Console.ReadLine();
                            if (result2 == "0")
                            {
                                removeRunning = false;
                                break;
                            }
                            else if (result2 == "9")
                            {
                                programRunning = false;
                                commandRunning = false;
                                removeRunning = false;
                                break;
                            }

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Miqdari duzgun daxil edin");
                        }
                    }
                    break;
                case "4":
                    commandRunning = false;
                    break;
                default:
                    Console.WriteLine("Sehv emr");
                    break;
            }
        }
        

    }
}

Console.ReadLine();
