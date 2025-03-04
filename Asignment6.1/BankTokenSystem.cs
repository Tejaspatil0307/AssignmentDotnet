using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment6._1
{
    class BankTokenSystem
    {
        private Queue<int> queue = new Queue<int>();
        private int tokenCounter = 1;// unique token number

        //add new customer to the queue
        public void AddCustomer()
        {
            queue.Enqueue(tokenCounter);
            Console.WriteLine($"Token{tokenCounter}added to the queue.");
            tokenCounter++;//increment for customer
        }
        public void serveCustomer() {
            if (queue.Count > 0) {
                int servedToken = queue.Dequeue();
                Console.WriteLine($"No customers in queue.");
            
            }
        
        }
        //check who is next without removing them
        public void NextCustomer() {
            if (queue.Count > 0)
            {
                Console.WriteLine($"Next customer to be served has token {queue.Peek()}.");
            }
            else {

                Console.WriteLine("no Customers in Queue.");
            }
        
        }

    }
}
