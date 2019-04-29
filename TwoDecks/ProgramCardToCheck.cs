using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TwoDecks
{
    class ProgramCardToCheck
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.Hearts);
            // or 
            //bool doesItMatch = Card.DoesCardMatch(new Card(Suits.Clubs, Values.Three), Suits.Hearts);
            Debug.WriteLine(doesItMatch);
        }
    }
}
