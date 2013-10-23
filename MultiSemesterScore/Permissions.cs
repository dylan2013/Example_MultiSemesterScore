using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiSemesterScore
{
    class Permissions
    {
        //權限代碼
        public static string 多學期成績單_學生 { get { return "Report0060_1"; } }

        public static bool 多學期成績單_學生權限
        {
            get
            {
                return FISCA.Permission.UserAcl.Current[多學期成績單_學生].Executable;
            }
        }

        public static string 多學期成績單_班級 { get { return "Report0170_1"; } }

        public static bool 多學期成績單_班級權限
        {
            get
            {
                return FISCA.Permission.UserAcl.Current[多學期成績單_班級].Executable;
            }
        }
    }
}
