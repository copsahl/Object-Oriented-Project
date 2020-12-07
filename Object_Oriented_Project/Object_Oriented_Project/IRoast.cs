using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Project
{
    public interface IRoast
    {
        Roast GetRoastByBean(List<Roast> roastList, string beanName);
    }
}
