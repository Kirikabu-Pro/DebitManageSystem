﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitManageSystem
{
    class DebitInfo
    {
        int _ID;
        String _Subject;

        public int ID
        {
            get { return this._ID; }
            set { this._ID = value; }
        }
        public string SubjectName
        {
            get { return this._Subject; }
            set { this._Subject = value; }
        }


    }
}
