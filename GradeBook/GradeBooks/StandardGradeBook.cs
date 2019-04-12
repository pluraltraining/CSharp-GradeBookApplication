using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : GradeBook
    {
        public StandardGradeBook(string name)
        {
            base(name);
            Type = GradeBookType.Standard;
        }
    }
}