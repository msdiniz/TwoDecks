using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TwoDecks
{
    class ProgramFiveCards
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Debug.WriteLine("Five random cards:");
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Suits)random.Next(4),
                (Values)random.Next(1, 14)));
                Debug.WriteLine(cards[i].Name);
            }
            Debug.WriteLine("");
            Debug.WriteLine("Those same cards, sorted:");
            cards.Sort(new CardComparer_byValue());
            foreach (Card card in cards)
            {
                Debug.WriteLine(card.Name);
            }
            Debug.WriteLine("");
        }
    }
}
