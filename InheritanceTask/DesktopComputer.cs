using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    class DesktopComputer:Computer
    {
        public DesktopComputer(string brand, string videocard, int ram ) : base(brand, videocard, ram)
        {

        }

        public string Mouse()
        {
            return "Desktop Computer Is Using With Mouse";
        }

        public override string ToString()
        {
            return $"{base.ToString()}  {Mouse()}";
        }

    }
}
