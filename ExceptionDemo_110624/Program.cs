// See https://aka.ms/new-console-template for more information

#region
//using ExceptionDemo_110624;



//  Phone_book phone_Book = new Phone_book();


//phone_Book[0].number = 1111;
//phone_Book[0].name = "rajesh";

//phone_Book[5].number = 5555;
//phone_Book[5].name = "pavan";

//phone_Book[6].number = 6666;
//phone_Book[6].name = "Dinesh";


//for (int i = 0; i < 7; i++)
//{
//    phone_Book[i].show();
//}

//string search_name = "mahesh";
//bool flag = false;
//for (int i = 0; i < phone_Book.contacts.Length; i++)
//{
//	if (string.Compare( phone_Book[i].name,search_name)==0)
//	{
//        Console.WriteLine("found...");
//        phone_Book[i].show();
//        flag=true;
//        break;
//    }
//}
//if (flag==false)
//{
//    Console.WriteLine(" contact info not found!!!!");
//}

#endregion

using ExceptionDemo_110624;
using System.Runtime.CompilerServices;
#region
//Exception123 obj1 = new Exception123();
//obj1.div(20, 5);
//Console.WriteLine("---------------------------");
//int[]x= new int[5];
//try
//{
//    //3
//    //  obj1.div(20, 0);
//    Environment.FailFast("####");
//   x[8] = 88;
//}
//catch
//{
//    Console.WriteLine("this is catch block...");
//}
//finally
//{
//    Console.WriteLine("finally executed...");
//}

#endregion

try
{
    student s1 = new student(80, "rajesh");
    Console.WriteLine("s1 roll=" + s1.roll + " Name=" + s1.name);
}
catch(myException me)
{
    Console.WriteLine("****message:"+me.Message);
    Console.WriteLine("####stack trace ==="+me.StackTrace);
    Console.WriteLine("=====================================");
    me.

}
Console.WriteLine("last line of prg");