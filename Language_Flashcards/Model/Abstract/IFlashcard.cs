using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;

namespace Model.Abstract
{
    public interface IFlashcard
    {
        IEnumerable<Flashcard> GetAll();
        Flashcard GetById(int id);
    }
}
