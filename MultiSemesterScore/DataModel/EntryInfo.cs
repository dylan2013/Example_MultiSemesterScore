using System;
using System.Collections.Generic;
using System.Text;

namespace MultiSemesterScore
{
    public class EntryInfo : ScoreInfo
    {
        public EntryInfo(string name)
            : base(name)
        {
        }
    }

    public class EntryCollection : Dictionary<string, EntryInfo>
    {
    }
}
