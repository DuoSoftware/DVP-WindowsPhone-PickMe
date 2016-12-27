using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuoSoftware.DuoSoftPhone.Ui
{
    public partial class CallLogItem : UserControl
    {
        public CallLogItem(string phoneNo,DateTime time,double duration)
        {
            InitializeComponent();
        }

      //  http://help.infragistics.com/Doc/WinForms/2012.1/CLR2.0/?page=WinExplorerBar_Create_a_Control_Container_Group.html
    }
}
