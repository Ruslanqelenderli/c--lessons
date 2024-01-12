//for

//for (int i = 5; i <= 50; i += 2)
//{
//    Console.WriteLine(i);
//    if (i == 49)
//    {

//    }
//}


//repeat:

//while(true)
//{
//    if (true)
//    {
//        //goto repeat;
//    }
//}


//for (int i = 1; i <= 100; i++)
//{
//    if (i % 5 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        continue;
//        Console.WriteLine(i);
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }

//    if (i == 77)
//        break;



//}

//int i;
//for (i = 100; i > 1; i--)
//{
//    Console.WriteLine(i);
//}



//while

//bool result = true;
//while (result)
//{
//    result=bool.Parse(Console.ReadLine().ToLower());
//}
//Console.WriteLine("end");

//bool result = false;
//do
//{
//    result = bool.Parse(Console.ReadLine().ToLower());
//}
//while (result);
//Console.WriteLine("end");

//int i = 1;
//bool result = true;
//while (result)
//{
//    Console.WriteLine("Enter number: ");
//    int userResult = int.Parse(Console.ReadLine());

//    if (userResult == i)
//    {
//        Console.WriteLine("It is correct number.");
//        result = false;
//    }
//    else
//    {
//        Console.WriteLine("It is incorrect number.");
//    }



//}

//do while


//int i = 1;
//bool result = false;
//do
//{
//    Console.WriteLine("Enter number: ");
//    int userResult = int.Parse(Console.ReadLine());

//    if (userResult == i)
//    {
//        Console.WriteLine("It is correct number.");
//        result = false;
//    }
//    else
//    {
//        Console.WriteLine("It is incorrect number.");
//        result = true;
//    }

//}
//while (result);


//foreach

//using System.Collections;

//int[] array = { 1, 2, 3, 4, 5, 6, 7 };
//int sum = 0;


//for (int i = 0; i < array.Length; i++)
//{
//    sum += array[i];
//}


//foreach (var arr in array)
//{
//    sum += arr;
//}

//for (int i = 0; i < array.Length; i++)
//{
//    sum += array[i];
//}

//Console.WriteLine(sum);


//int sum2 = 0;
//foreach (var listItem in array)
//{
//    sum2 += listItem;
//}
//Console.WriteLine(sum2);

//using System.Collections;

//var list = new ArrayList();

//list.Add("salam.");
//list.Add("Necesen?");
//list.Add("Yaxshiyam");

//var result="";

//foreach (object item in list)
//{
//    result += item;
//}

//Console.WriteLine(result);


//arraylist

//using System.Collections;

//int[] array = new int[5];

//array[0] =2;
//array[1] = 4;
//array[2] = 5;

//ArrayList array2 = new ArrayList();

//array2.Add(5);
//array2.Add("test");
//array2.Add(DateTime.Now);


//C# Methods

//using Lesson_5;

//Methods.Test1();
//int userResult= int.Parse(Console.ReadLine());

//if (userResult == 0)
//{
//    Console.WriteLine("Rəqəmlər çap olunur");

//    Methods.Test1();
//}
//else if(userResult == 1)    
//{
//    Console.WriteLine("Rəqəmlər çap olunmur");
//}
//else if(userResult == 2)
//{
//    Console.WriteLine("Rəqəmlər çap olunur");

//    Methods.Test1();
//}

//int userResult= int.Parse(Console.ReadLine());




//int result=Methods.Test2(userResult);
//Console.WriteLine(result);
//int value=5;
//Methods.Test1("sdsd",3,ref value);


//Methods.Test2(3,out int val);

Console.ReadLine();


