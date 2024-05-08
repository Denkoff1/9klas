using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._4._24
{
    internal class BankAcc
    {
        int id;
        double balance;
        int create;
        int print;
        public int Id 
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public double Balance 
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public int Create{ get;set; }
        public int Print { get; set; }
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }
       
        public override string ToString()
        {
            return $"Account:{this.id},balance:{this.balance}";
        }
    }
}
