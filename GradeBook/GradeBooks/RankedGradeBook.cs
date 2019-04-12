using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : GradeBook    
    {
        public RankedGradeBook(string name)
        {
            base(name);
            Type = GradeBookType.Ranked;
        }
    }
}