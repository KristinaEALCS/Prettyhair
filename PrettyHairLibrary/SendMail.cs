using System;

namespace PrettyHairLibrary
{
    public class MailServer
    {

        public int EmailsSent {
            get; private set;
        }
        public MailServer() {
            EmailsSent = 0;
        }

        public void Subscribe(OrderRepository ort)
        {
            ort.Tick += new OrderRepository.TickHandler(Send);
        }

        public void Send(OrderRepository m, EventArgs e)
        {
            // Email STMP not implemented
            this.EmailsSent++; 
        }
    }
}
