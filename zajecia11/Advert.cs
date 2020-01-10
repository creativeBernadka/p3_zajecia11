using System;

namespace zajecia11
{
    class Advert
    {
        public string Content;
        private PersonType _personType;
        private Interests _interests;

        public void Test()
        {
            if (_personType.HasFlag(PersonType.Child))
            {
                Console.WriteLine("Ta reklama jest dla dzieci");
            }

            if (_personType < PersonType.Adult)
            {
                Console.WriteLine("Ta reklama jest tylko dla niepełnoletnich");
            }

            for (int i = 0; i <= PersonType.None.PersonTypeSum(); i++)
            {
                Console.WriteLine((PersonType)i);
            }
        }
        
        public Advert(string content, PersonType personType, Interests interests)
        {
            Content = content;
            _personType = personType;
            _interests = interests;
        }
    }
}