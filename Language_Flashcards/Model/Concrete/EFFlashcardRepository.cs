using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Abstract;
using Model.Entities;

namespace Model.Concrete
{
    public class EFFlashcardRepository : IFlashcard
    {
        FlashcardDbEntities _dataContext;

        public EFFlashcardRepository()
        {
            _dataContext = new FlashcardDbEntities();
        }

        public IEnumerable<Entities.Flashcard> GetAll()
        {
            return _dataContext.Flashcards
                               .Select(f => f);
        }

        public Entities.Flashcard GetById(int id)
        {
            return _dataContext.Flashcards
                               .Where(f => f.FlashcardId == id)
                               .Select(f => f)
                               .FirstOrDefault();
        }
    }
}
