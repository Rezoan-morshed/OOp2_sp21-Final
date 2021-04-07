﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bankaccount
{
    class Transaction
    {

        public Account Sender { get; set; }
        public Account Receiver { get; set; }
        public int Ammount { get; set; }
        public String AdditionalInfo { get; set; }

        public Transaction() { }
        public Transaction(Account Sender, Account Receiver, int Ammount, String AdditionalInfo)
        {
            this.Sender = Sender;
            this.Receiver = Receiver;
            this.Ammount = Ammount;
            this.AdditionalInfo = AdditionalInfo;
        }

        public void showInfo()
        {
            Console.WriteLine("Sender Name:{0} Account ID:{1}", Sender.AccName, Sender.Accid);
            Console.WriteLine("Receiver Name:{0} Account ID:{1}", Receiver.AccName, Receiver.Accid);
            Console.WriteLine("Ammount:" + Ammount);
            Console.WriteLine("Additional Information:" + AdditionalInfo);
            Console.WriteLine();
        }
    }
}
