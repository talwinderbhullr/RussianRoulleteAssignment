using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulleteAssignment
{
    public class VariableClass
    {
        public int LoadGun { get; set; }//Load variable
        public int SpinGun { get; set; }//Spin Variable 
        public int tryTheGun = 2;//this is for trying gun variable
        public int totalChances = 6;//this variable for chances
        public int LoopShot(int skippingShoot)//This method for shoting time
        {
            if (skippingShoot == 6)
            {
                skippingShoot = 1;
            }
            else
            {
                skippingShoot++;
            }
            return skippingShoot;
        }
    }
}
