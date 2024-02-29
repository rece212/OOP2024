using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2024
{
    public abstract class Burger
    {
        private String patty = "Beef";
        private String bun = "Plain Wheat";

        public virtual String getPatty()
        {
            return patty;
        }
        public String getBun() 
        { 
        return bun;
        }

        public String getBun(String optionone)
        {
            return optionone;
        }
        public String getBun(String optionone, String optiontwo)
        {
            return optionone+optiontwo;
        }


    }
}
