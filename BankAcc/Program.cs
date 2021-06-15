using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    class Program
    {
        //it is comment
        static void Main(string[] args)
        {

            //dosto forever
            Savings_Checking ob1 = new Savings_Checking();
            ob1.Account_Number = 74062832277435;
            ob1.Set_Acc_holder_name("Mahesh");
            Console.WriteLine(ob1.get_Acc_holder_name());
            ob1.Acc_opening_date = "03/02/1996";
            //ob1.Balance_Ammount = 7000;
            //ob1.listof_transaction = 5;


            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Select the transaction: Savings=1 Or Checking Acc=2 ");
                int Transaction = Convert.ToInt32(Console.ReadLine());
                if (Transaction == 1)
                {
                    Console.WriteLine("Enter the amount to withdraw : ");
                    Savings_Acc ob2 = new Savings_Acc();
                    int Amt = Convert.ToInt32(Console.ReadLine());
                    if ( i == 1 || i == 2 || i == 3 || i == 4 || i == 5)
                    {
                        Console.WriteLine(i +". transaction Debited Amount : " + ob2.Debit(Amt));
                    }
                }

                else if (Transaction == 2)
                {
                    Checking_Acc ob3 = new Checking_Acc();
                    int Amt = Convert.ToInt32(Console.ReadLine());
                    if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5)
                    {
                        Console.WriteLine(i +".  transaction Debited Amount : " + ob3.Debit(Amt));
                    }
                }
            }
        }

    }
}
