using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA;
using FISCA.Presentation;
using SmartSchool.Customization.Data;
using System.ComponentModel;
using FISCA.Permission;

namespace MultiSemesterScore
{
    public class Program
    {
        [MainMethod()]
        public static void Main()
        {
            RibbonBarItem rbItem_student = FISCA.Presentation.MotherForm.RibbonBarItems["學生", "資料統計"];
            rbItem_student["報表"]["範例相關報表"]["多學期成績單(學生)"].Enable = Permissions.多學期成績單_學生權限;
            rbItem_student["報表"]["範例相關報表"]["多學期成績單(學生)"].Click += delegate
            {
                MultiSemesterScore s = new MultiSemesterScore();
                s._student_button_OnClick(null, null);
            };

            RibbonBarItem rbItem_class = FISCA.Presentation.MotherForm.RibbonBarItems["班級", "資料統計"];
            rbItem_class["報表"]["範例相關報表"]["多學期成績單(班級)"].Enable = Permissions.多學期成績單_班級權限;
            rbItem_class["報表"]["範例相關報表"]["多學期成績單(班級)"].Click += delegate
            {
                MultiSemesterScore s = new MultiSemesterScore();
                s.classButton_OnClick(null, null);
            };

            Catalog ribbon = RoleAclSource.Instance["學生"]["報表"];
            ribbon.Add(new RibbonFeature(Permissions.多學期成績單_學生, "多學期成績單(學生)"));

            ribbon = RoleAclSource.Instance["班級"]["報表"];
            ribbon.Add(new RibbonFeature(Permissions.多學期成績單_班級, "多學期成績單(班級)"));
        }
    }
}
