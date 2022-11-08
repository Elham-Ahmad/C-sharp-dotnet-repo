using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Principal;

namespace ConsoleApp1
{

   


    class BankAccount:Question_4
    {
        int account_no;
        string name;
        int balance;
        string type;


        public void createAccount()
        {
            Console.WriteLine("\nEnter the account number \n");
            account_no = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("\nEnter the name of account holder\n");
            name = Console.ReadLine();
            Console.WriteLine("\nEnter the type of account\n");
            type = Console.ReadLine();
            Console.WriteLine("\nEnter the initial amount \n");
            balance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nAcount is created....");




        }

        public void showAccounts()
        {
            Console.WriteLine($"Account number : ${account_no}");
            Console.WriteLine($"Account holder name : ${name}");
            Console.WriteLine($"Type of Account : ${type}");
            Console.WriteLine($"Account balance : ${balance}");

        }

        public void accountModify()
        {

        }

        public void displayMenu()
        {
            int i;


            while (true)
            {

                int ans, choice;

                Console.WriteLine("\n\tMenu");
                Console.WriteLine("\nPress 1 for Create Account");
                Console.WriteLine("\nPress 2 for Deposite amount ");
                Console.WriteLine("\nPress 3 for withdraw amount ");
                Console.WriteLine("\nPress 4 for balance inquiry");
                Console.WriteLine("\nPress 5 for show all account holder list");
                Console.WriteLine("\nPress 6 for close an  account");
                Console.WriteLine("\nPress 7 for modify and account");
                Console.WriteLine("\nPress 8 exit");

                choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter your Choice\n");
                switch (choice)
                {
                    case 1:
                      
                        break;

                }

                Console.WriteLine("\nDo you Want to stop program execution \n" +
                    "Press 1 for yes and 0 for No");

                ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 1) break;
                else continue;
            }
        }




    }
    


    internal class Question_4
    {
       


        public void question4()
        {
            int number_of_accounts=0;
            BankAccount[] accounts = new BankAccount[number_of_accounts];
            

            Console.WriteLine("\nEnter the number of account to be created :");
            number_of_accounts = Convert.ToInt32(Console.ReadLine()); 
            
            for (int i=0; i < number_of_accounts; i++)
            {
                accounts[i].createAccount();
            } 

            BankAccount bankAccount = new BankAccount();
            bankAccount.displayMenu();

           




           
        }
    }
}
