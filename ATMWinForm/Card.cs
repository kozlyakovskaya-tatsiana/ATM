using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATMWinForm
{
    public class Card
    {
        internal string cardNumber;
        internal string PIN;
        private int sum;
        internal int Sum
        {
            get
            {
                return sum;
            }
            set
            {
                if (value >= 0) sum = value;
            }
        }
        
        //private string deleteSpaces(string card)
        //{
        //    StringBuilder s = new StringBuilder();
        //    for (int i = 0; i < card.Length; i++)
        //        if (!(card[i] == ' ')) s.Append(card[i]);
        //    return s.ToString();
        //}
        public bool IsValid()
        {
            int length = cardNumber.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (!(char.IsDigit(cardNumber[i]))) return false;
                int digit = (int)char.GetNumericValue(cardNumber[i]);
                if (i % 2 == 0)
                {
                    sum += (2 * digit > 9) ? (2 * digit - 9) : 2 * digit;
                }
                else sum += digit;
            }
            return (sum % 10 == 0) ? true : false;
        }
        public string DetermineType(TypeOfCard[] types)
        {
            if (!IsValid()) return "Invalid";
            char digit = cardNumber[0];
            foreach (TypeOfCard typecard in types)
            {
                if (digit == typecard.FirstDigit) return typecard.TypeCard;
            }
            return "Another type";
        }
        public Card(string cardNumber, string PIN, int sum)
        {
            this.cardNumber = cardNumber;
            this.PIN = PIN;
            this.sum = sum;
        }
        public Card(Card card)
        {
            this.cardNumber = card.cardNumber;
            this.PIN = card.PIN;
            this.sum = card.sum;

        }
        
        public override string ToString()
        {
            return cardNumber;
        }
    }
    public class TypeOfCard
    {
        public string TypeCard;
        public char FirstDigit;
        public TypeOfCard(string TypeCard, char FirstDigit)
        {
            this.TypeCard = TypeCard;
            this.FirstDigit = FirstDigit;
        }

    }
}
