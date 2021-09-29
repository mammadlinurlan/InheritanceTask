using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    class Computer
    {
        public string brand; 
        public string videocard;
        public int ram;



        public Computer(string brand , string videocard , int ram )
        {
            this.brand = brand;
            this.videocard = videocard;
            this.ram = ram;
        }


        public override string ToString()
        {
            return $"{brand} {videocard} {ram}";
        }
    }
    


}
