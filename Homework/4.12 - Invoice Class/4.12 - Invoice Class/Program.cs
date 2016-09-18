using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12___Invoice_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice myInvoice;
            Console.WriteLine("Testing Invalid Arguments for the constructor first ...");
            try
            {
                myInvoice = new Invoice("45a2675", "A Plumbus", -1, 23.52m);//Should throw an Invalid Argument Exception
                Console.WriteLine(" - Ah crap ... the exception didn't go off ... (Negative Quantity)");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(" + Invalid argument Caught! Negative Quantites don't work here");
            }
            try
            {
                myInvoice = new Invoice("45a2675", "A Plumbus", 23, -2.0m);
                Console.WriteLine(" - Awh shucks ... We shouldn't have reached this ... (Negative Price Per)");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(" + Invalid Argument Caught! Negative values don't make sense anyway");
            }
            Console.WriteLine("\nAlright! Now onto actual valid stuff!");
            try
            {
                myInvoice = new Invoice("45a2675", "A Plumbus", 23, 23.52m);
                Console.WriteLine(" + Alright! we have a valid Invoice");
                myInvoice.partNumber = "C317";
                if (myInvoice.partNumber.Equals("C317"))
                {
                    Console.WriteLine(" + Invoice Part Number Successfuly changed to C317");
                }
                else
                {
                    Console.WriteLine(" - Invoice Part Number did not change ...");
                }
                myInvoice.partDescription = "Plumbus";
                if (myInvoice.partDescription.Equals("Plumbus"))
                {
                    Console.WriteLine(" + Part Description is now \"Plumbus\"");
                }
                else
                {
                    Console.WriteLine(" - Part Description is the same ...");
                }
                myInvoice.pricePer = -5m;
                if (myInvoice.pricePer == -5m)
                {
                    Console.WriteLine(" - Price changed to a negative value ... crap");
                }
                else
                {
                    Console.WriteLine(" + Price Has not changed");
                }
                myInvoice.pricePer = 1.6180m;
                if(myInvoice.pricePer == 1.6180m)
                {
                    Console.WriteLine(" + The Price per Plumbus is now the golden ratio, neat");
                }
                else
                {
                    Console.WriteLine(" - The Price per Plumbus has remained unchanged ...");
                }
                myInvoice.quantity = -2;
                if (myInvoice.quantity == -2)
                {
                    Console.WriteLine(" - The Quantity changed to a negative Value");
                }
                else
                {
                    Console.WriteLine(" + The Quantaty didn't change to a negative Value");
                }
                myInvoice.quantity = 42;
                if (myInvoice.quantity == 42)
                {
                    Console.WriteLine(" + The Quantity changed to the Meaning of Life the Universe and everything");
                }
                else
                {
                    Console.WriteLine(" - The Quantity has not changed");
                }
                Console.WriteLine("Final Test: Check to see if the GetInvoiceAmmount Method works ...");
                if (myInvoice.GetInvoiceAmount() == myInvoice.quantity * myInvoice.pricePer)
                {
                    Console.WriteLine(" + Lovely! The Total cost of "+myInvoice.quantity+ " "+myInvoice.partDescription+" Is: "+myInvoice.GetInvoiceAmount());
                }
                else
                {
                    Console.WriteLine(" - ... How did this screw up ...");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(" - Well ... shit we literally can't go on ... ");
            }

        }
    }
}
