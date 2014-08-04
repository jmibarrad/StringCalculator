using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace LogicGoesHere.Specs
{
    public class Reference
    {
       

            Establish context = () =>
            {
                Obj = new LogicGoesHereClass();
                 _result= new int();
            };

            public static int _result;
            public static LogicGoesHereClass Obj; 
    }

  

            
}
