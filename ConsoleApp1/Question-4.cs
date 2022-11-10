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

    internal class Question_4
    {

      

        public void question4()
        {

            BankAccount bankAccount = new BankAccount();
           
           


            while (true)
                {

                    int ans, choice;

                    Console.WriteLine("\n\tMenu");
                    Console.WriteLine("\nPress 1 for Create Account");
                    Console.WriteLine("\nPress 2 for Deposite amount ");
                    Console.WriteLine("\nPress 3 for withdraw amount ");
                    Console.WriteLine("\nPress 4 for balance inquiry");
                    Console.WriteLine("\nPress 5 for show all account holder list");
                    Console.WriteLine("\nPress 6 for modify and account");
                    Console.WriteLine("\nPress 7 exit");

                    choice = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nEnter your Choice\n");
                    switch (choice)
                    {
                        
                    case 1:
                        bankAccount.createAccount();
                        break;
                        
                    case 2:
                        bankAccount.depositAmount();
                            break;
                    case 3:
                        bankAccount.withdrawAmount();
                        break;

                    case 4:
                        bankAccount.balanceInquiry();
                        break;
                  
                    case 5:
                        bankAccount.showAccounts();
                        break;

                    case 6:
                        bankAccount.modifyAccount();
                        break;
                    case 7:
                        
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
}



class BankAccount
    {

    
        int account_no;
        string name;
        int amount;
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
            amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nAcount is created....");

       
          

        }

        public void showAccounts()
        {
            Console.WriteLine($"Account number : ${account_no}");
            Console.WriteLine($"Account holder name : ${name}");
            Console.WriteLine($"Type of Account : ${type}");
            Console.WriteLine($"Account balance : ${amount}");

        }

        public int modifyAccount()
        {
        int no,modify_field;
        int newAccount_no;
        string newAccount_name,newAccount_type;
        


            Console.WriteLine($"\nenter your account number:");
            no = Convert.ToInt32(Console.ReadLine());  
            if (no == account_no)
            {
            Console.WriteLine($"Account number : {account_no}");
            Console.WriteLine($"Account holder name : {name}");
            Console.WriteLine($"Type of Account : {type}");
            Console.WriteLine($"Account balance : {amount}");

            }
                Console.WriteLine("\n\n What do you modify");
                

                Console.WriteLine($"\nPress 1 for Account number : ");
                Console.WriteLine($"\nPress 2 for Account holder name :");
                Console.WriteLine($"\nPress 3 for Type of Account : ");
             
                modify_field = Convert.ToInt32(Console.ReadLine());

                if (modify_field == 1)
                {
                     Console.WriteLine("\nEnter new Account number");
                     newAccount_no = Convert.ToInt32(Console.ReadLine());
                     account_no = newAccount_no;
                     Console.WriteLine("\nUpdated Successfully....");

        }

                else if (modify_field == 2)
                {
                    Console.WriteLine("\nEnter new Account name");
                    newAccount_name = (Console.ReadLine());
                    name = newAccount_name;
                     Console.WriteLine("\nUpdated Successfully....");
                }

                else if (modify_field == 3)
                {
                    Console.WriteLine("\nEnter new Account type");
                    newAccount_type = (Console.ReadLine());
                    type    = newAccount_type;
                    Console.WriteLine("\nUpdated Successfully....");


                 }

        return account_no;


    }
        
        public void depositAmount()
        {
            int local_account_no;
            int local_amount;
            Console.WriteLine("\nEnter your account number");
            local_account_no = Convert.ToInt32(Console.ReadLine());
        if (local_account_no == account_no)
        {
            Console.WriteLine("\nenter amount to deposit");
            local_amount = Convert.ToInt32(Console.ReadLine());

            amount = amount + local_amount;

        }
        else Console.WriteLine("\nPlease check your account number!!");
            
        }


        public void withdrawAmount()
        {
            int local_account_no;
            int local_amount;

            Console.WriteLine("\nEnter your account number");
            local_account_no = Convert.ToInt32(Console.ReadLine());
            if (local_account_no == account_no)
            {
                Console.WriteLine("\nenter amount to Withdraw");
                local_amount = Convert.ToInt32(Console.ReadLine());

                amount = amount - local_amount;

            }
             else Console.WriteLine("\nPlease check your account number!!");
    }

        public void balanceInquiry()
        {

                int local_account_no;
                int local_amount;

                Console.WriteLine("\nEnter your account number");
                local_account_no = Convert.ToInt32(Console.ReadLine());
                if (local_account_no == account_no)
                {
                    Console.WriteLine($"\n Your balance is {amount}");

                }
                else Console.WriteLine("\nPlease check your account number!!");

    }

       
       



}
    


