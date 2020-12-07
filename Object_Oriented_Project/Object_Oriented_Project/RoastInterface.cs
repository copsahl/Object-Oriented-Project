using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Project
{
    public class RoastInterface : IRoast
    {
        public Roast GetRoastByBean(List<Roast> roastList, string beanName)
        {
            foreach(Roast r in roastList)
            {
                if(r.Bean == beanName)
                {
                    return r;
                }
            }
            return null;
        }
    }
}
