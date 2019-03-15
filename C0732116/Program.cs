using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Chetan Rahanoo (C0732135)
// Manjot Kaur (C0732136)
// Saksham Saksham (C0732116)

namespace C0732116
{
    class BankAccounts
    {
        private String m_customerName;
        private double m_balance;
        private bool m_frozen = false;
        private BankAccounts()
        {

        }
        public BankAccounts (String customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public String CustomerName
        {
            get
            {
                return m_customerName;
            }
        }
        public double Balance
        {
            get
            {
                return m_balance;
            }
        }

        public void Debit (double amount)
        {

            if (m_frozen)
            {
                throw new Exception("Account Frozen");
            }

            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
        }
            
    }
}
