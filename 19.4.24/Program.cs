using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._4._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAcc acc = new BankAcc();
            acc.Id = 1;
            acc.Deposit(20);
            acc.Withdraw(30);
            Console.WriteLine(acc.ToString());
           
            var accounts= new Dictionary<int, BankAcc>();
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                var cmdArgs=command.Split();
                var cmdType = cmdArgs[0];
                var ID = int.Parse(cmdArgs[1]);
                if (accounts.ContainsKey(ID))
                {
                    Console.WriteLine("Account alredy exists!");
                }
                else
                {
                    var ACC = new BankAcc();
                    ACC.Id =ID;
                    accounts.Add(ID, acc);
                }
                var Create = int.Parse(cmdArgs[1]);
                if (accounts.ContainsKey(Create))
                {
                    Console.WriteLine("Account alredy exists!");
                }
                else
                {
                    var ACC = new BankAcc();
                    ACC.Create = Create;
                    accounts.Add(Create, acc);
                }
                switch (cmdType)
                {
                    case "Create":Create(cmdArgs,accounts); break;
                    case "Deposit": Deposit(cmdArgs, accounts); break;
                    case "Withdraw": Withdraw(cmdArgs, accounts); break;
                    case "Print": Print(cmdArgs, accounts); break;
                }
            }
           
        }
    }
}
