using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using System.Data.Entity;
using Model.Concrete;




namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EFFlashcardRepository test = new EFFlashcardRepository();

            //foreach (Flashcard item in test.GetById(1))
            //{
            //    Console.WriteLine(item.Question);
            //}

            Console.WriteLine(test.GetById(1).Question);
        }
    }
}
