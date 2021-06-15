using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    public class Savings_Checking
    {
        public long Account_Number { get; set; }
        public string Acc_opening_date { get; set; }
        public double Balance_Ammount { get; set; }
        public long listof_transaction { get; set; }

        public virtual double Debit(double Withdraw_Amt)
        {

            return Withdraw_Amt;

        }
        public string Acc_holder_name;
        public void Set_Acc_holder_name(string name)
        {

            if (name == "Mahesh" || name == "Maahi")
            {
                Acc_holder_name = name;
            }
        }

        public string get_Acc_holder_name()
        {
            return Acc_holder_name;
        }


    }

    public class Savings_Acc : Savings_Checking
    {
        public override double Debit(double Withdraw_Amt)
        {
            double debit_amt;
            return debit_amt = Withdraw_Amt + (Withdraw_Amt * 0.1);

        }
    }

    public class Checking_Acc : Savings_Checking
    {
        public override double Debit(Double Withdraw_Amt)
        {
            double debit_amt;
            return debit_amt = Withdraw_Amt + (Withdraw_Amt * 0.25);


        }

    }

}

