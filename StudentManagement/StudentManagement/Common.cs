﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public static class Common
    {
        public static void ErrorMessage(string message)
        {
            MessageBox.Show(message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
