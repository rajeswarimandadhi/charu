using System;
using System.Collections.Generic;
using System.Text;

namespace module
{
    public class Account
    {

        private string name;
        private double balance;
        private string v;

        public Account(string v)
            {
            this.v = v;
            }
    
    
        public Account(string name, double balance)
        {
            this.name = name;
            if (balance > 0.0)
                this.balance = balance;
            
                
            
        }
        public void deposit(double depositAmount)
        {
            if (depositAmount > 0.0)
                balance = balance + depositAmount;
        }
        public double getbalance()
        {
            return balance;
        }
      
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
}

class class6
{
    public static void Main6()
    {
        module.Account account1 = new module.Account("Jasten Austen ,250.00");
    
        account1.getbalance();

        Console.WriteLine("250.00");
       
        
    }

}