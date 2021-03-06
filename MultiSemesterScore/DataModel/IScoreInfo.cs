using System;
using System.Collections.Generic;
using System.Text;

namespace MultiSemesterScore
{
    public interface IScoreInfo
    {
        int Place { get;set; }
        int Radix { get;set; }
        void AddSemsScore(int grade_year, int semester, decimal score);
        decimal GetAverange();
        decimal GetPercentage();
    }
}
