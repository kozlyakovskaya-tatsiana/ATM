using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATMWinForm
{
    class WorkingWithCard
    {
        public static List<Card> ReadInfo(string path)
        {
            List<Card> cards = new List<Card>();
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string str = reader.ReadLine();
                char[] separators = new char[] { ' ' };
                string[] cardinfo = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                cards.Add(new Card(cardinfo[0], cardinfo[1], Convert.ToInt32(cardinfo[2])));
            }
            reader.Close();
            return (cards);
        }
       internal static void WriteInfoCards(List<Card> cards, string path)
        {
            FileStream file = new FileStream(path, FileMode.Truncate);
            file.Close();
            StreamWriter writer = new StreamWriter(path,true, System.Text.Encoding.Default);
            foreach(Card card in cards)
            {
                writer.WriteLine(String.Format($"{card.cardNumber} {card.PIN} {card.Sum}"));
            }
            writer.Close();
        }
        

    }
}
