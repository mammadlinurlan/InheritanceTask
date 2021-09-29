using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    class NoteBook:Computer
    {
        public NoteBook(string brand, string videocard, int ram) : base(brand, videocard, ram)
        {

        }

        public string TouchPad()
        {
            return "NoteBook Has TouchPad For Using";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {TouchPad()}";
        }


    }
}
