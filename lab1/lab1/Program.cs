//prg 1
//Console.WriteLine("Name : Dhara");
//Console.WriteLine("Address : Raval Street, \n Mahendra Para \n Morbi-36341");
//Console.WriteLine("Mo : 12345 67890");
//Console.WriteLine("City : Morbi");
//====================================================================================


//prg 2
//Console.WriteLine("ENter number 1 : ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter number 2 : ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(n1);
//Console.WriteLine(n2);
//=======================================================================================


//prg 3
//Console.WriteLine("Enter Name : ");
//String name = Console.ReadLine();
//Console.WriteLine("Enter country : ");
//String cont = Console.ReadLine();
//Console.WriteLine("Hello "+name + " from" +  cont);

//========================================================================================
//prg 4

////Console.WriteLine("ENter length : ");
//int l = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Enter width : ");
//int w = Convert.ToInt32(Console.ReadLine());
//float area = l * w;
//Console.WriteLine("Area is " + area);

//==========================================================================================
//prg 5
//Console.writeLine("Enter radius : ");
//float r = Convert.ToInt32(Console.ReadLine());
//float areaofcircle = (float)((2 * 3.14) * r);


////Console.WriteLine("ENter length : ");
//int l = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Enter width : ");
//int w = Convert.ToInt32(Console.ReadLine());
//float area = l * w;
//Console.WriteLine("Area of rectangle is " + area);

//Console.WriteLine("Enter dimension : ");
//int l = Convert.ToInt32(Console.ReadLine());
//int areasq = l * l;
//Console.WriteLine("Area of square is " + areasq);

//============================================================================================

//prg 6
////Console.WriteLine("ENter celcius : ");
//double c = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter fahrenhit : ");
//double f = Convert.ToDouble(Console.ReadLine());

//double tofah = (c * 9 / 5) + 32;
//double tocel = (f - 32) * 5 / 9;
//Console.WriteLine("Celcius to fahrenhit is " + tofah);
//Console.WriteLine("fahrenhit to celcius is " + tocel);

//============================================================================================

//prg 7
////Console.WriteLine("ENter P : ");
//double p = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter R : ");
//double r = Convert.ToDouble(Console.ReadLine());
////Console.WriteLine("ENter N : ");
//double n = Convert.ToDouble(Console.ReadLine());

//double si = (p * r * n) / 100;
//Console.WriteLine(si);

//============================================================================================

//prg 8
//Console.WriteLine("Enter number 1 : ");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("ENter number 2 : ");
//double b = Convert.ToDouble(Console.ReadLine());
//double ans;
//Console.WriteLine("ENter operator : ");
//String ch = Console.ReadLine();
//if(ch == "+")
//{
//    ans = a + b;

//}else if(ch == "-")
//{
//    ans = a - b;
//}else if (ch == "*")
//{
//    ans = a * b;
//}else if (ch == "/")
//{
//    ans = a / b;
//}
//else
//{
//    Console.WriteLine("Enter valid operator");
//}

//switch (ch) {
//    case "+":
//        ans = a + b;
//        break;
//    case "-":
//        ans = a - b;
//        break;
//    case "*":
//        ans = a * b;
//        break;
//    case "/":
//        ans = a / b;
//        break;
//    default:
//        Console.WriteLine("Enter valid operator");
//        break;
//}

//Console.WriteLine("Answer is : " + ans);
//====================================================================================

//prg 9
//Console.WriteLine("Enter number 1 : ");
//int a = Convert.ToInt32(Console.ReadLine()); //10
//Console.WriteLine("Enter number 2 : ");
//int b = Convert.ToInt32(Console.ReadLine());    //20

//a = a + b;
//b = a - b;
//a = a - b;
//Console.WriteLine("A = " + a + " and B = " + b);

//int temp = a;
//a = b;
//b = temp;
//Console.WriteLine("A = " + a + " and B = " + b);

//============================================================================

//prg 10
//Console.WriteLine("Enter number 1 : ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("ENter number 2 : ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter number 3 : ");
//int c = Convert.ToInt32(Console.ReadLine());

//int largest = (a > b) ? ((b > a) ? b : a) : ((b > c) ? b : c);
//Console.WriteLine("Largest is : "+largest);





//=======================================================================================


Console.WriteLine("Enter program number : ");
int prg = Convert.ToInt32(Console.ReadLine());
switch (prg)
{
    case 1:
        Console.WriteLine("Name : Dhara");
        Console.WriteLine("Address : Raval Street, \n Mahendra Para \n Morbi-36341");
        Console.WriteLine("Mo : 12345 67890");
        Console.WriteLine("City : Morbi");
        break;
    case 2:
        Console.WriteLine("ENter number 1 : ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number 2 : ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        break;
    case 3:
        Console.WriteLine("Enter Name : ");
        String name = Console.ReadLine();
        Console.WriteLine("Enter country : ");
        String cont = Console.ReadLine();
        Console.WriteLine("Hello " + name + " from" + cont);
        break;
    case 4:
        Console.WriteLine("ENter length : ");
        int l = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter width : ");
        int w = Convert.ToInt32(Console.ReadLine());
        float area = l * w;
        Console.WriteLine("Area is " + area);
        break;
    case 5:
        Console.WriteLine("Enter radius : ");
        float r = Convert.ToInt32(Console.ReadLine());
        float areaofcircle = (float)((2 * 3.14) * r);


        Console.WriteLine("ENter length : ");
        int l2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter width : ");
        int w2 = Convert.ToInt32(Console.ReadLine());
        float area2 = l2 * w2;
        Console.WriteLine("Area of rectangle is " + area2);

        Console.WriteLine("Enter dimension : ");
        int l3 = Convert.ToInt32(Console.ReadLine());
        int areasq = l3 * l3;
        Console.WriteLine("Area of square is " + areasq);
        break;
    case 6:
        Console.WriteLine("ENter celcius : ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter fahrenhit : ");
        double f = Convert.ToDouble(Console.ReadLine());

        double tofah = (c * 9 / 5) + 32;
        double tocel = (f - 32) * 5 / 9;
        Console.WriteLine("Celcius to fahrenhit is " + tofah);
        Console.WriteLine("fahrenhit to celcius is " + tocel);
        break;
    case 7:
        Console.WriteLine("ENter P : ");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter R : ");
        double r2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ENter N : ");
        double n = Convert.ToDouble(Console.ReadLine());

        double si = (p * r2 * n) / 100;
        Console.WriteLine(si);
        break;
    case 8:
        Console.WriteLine("Enter number 1 : ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ENter number 2 : ");
        double b = Convert.ToDouble(Console.ReadLine());
        double ans;
        Console.WriteLine("ENter operator : ");
        String ch = Console.ReadLine();
        if (ch == "+")
        {
            ans = a + b;
            Console.WriteLine("Ans : " + ans);
        }
        else if (ch == "-")
        {
            ans = a - b;
            Console.WriteLine("Ans : " + ans);
        }
        else if (ch == "*")
        {
            ans = a * b;
            Console.WriteLine("Ans : " + ans);
        }
        else if (ch == "/")
        {
            ans = a / b;
            Console.WriteLine("Ans : " + ans);
        }
        else
        {
            Console.WriteLine("Enter valid operator");
        }
        //switch (ch)
        //{
        //    case "+":
        //        ans = a + b;
        //        break;
        //    case "-":
        //        ans = a - b;
        //        break;
        //    case "*":
        //        ans = a * b;
        //        break;
        //    case "/":
        //        ans = a / b;
        //        break;
        //    default:
        //        Console.WriteLine("Enter valid operator");
        //        break;
        //}
        break;
    case 9:
        Console.WriteLine("Enter number 1 : ");
        int a3 = Convert.ToInt32(Console.ReadLine()); //10
        Console.WriteLine("Enter number 2 : ");
        int b3 = Convert.ToInt32(Console.ReadLine());    //20

        a3 = a3 + b3;
        b3 = a3 - b3;
        a3 = a3 - b3;
        Console.WriteLine("A = " + a3 + " and B = " + b3);

        int temp = a3;
        a3 = b3;
        b3 = temp;
        Console.WriteLine("A = " + a3 + " and B = " + b3);
        break;
    case 10:
        Console.WriteLine("Enter number 1 : ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number 2 : ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number 3 : ");
        int z = Convert.ToInt32(Console.ReadLine());

        int largest = (x > y) ? ((y > x) ? y : x) : ((y > z) ? y : z);
        Console.WriteLine("Largest is : " + largest);
        break;
    default:
        Console.WriteLine("Enter valid program number!!!");
        break;

}