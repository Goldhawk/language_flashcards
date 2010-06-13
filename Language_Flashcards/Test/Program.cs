using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using System.Data.Entity;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            FlashcardDbEntities test = new FlashcardDbEntities();

            foreach (Flashcard item in test.Flashcards)
            {
                Console.WriteLine(item.Question);
            }
        }
    }
}
