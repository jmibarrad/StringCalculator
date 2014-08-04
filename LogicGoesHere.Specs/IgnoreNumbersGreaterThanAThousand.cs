using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace LogicGoesHere.Specs
{
    class IgnoreNumbersGreaterThanAThousand:Reference
    {
        public class when_IgnoreNumbersGreaterThanAThousand
        {


             Because of = () =>
             {
                 _result = Obj.Add("1\n1000,1");
             };

             It should_should = () =>
             {
                 _result.ShouldEqual(2);
             };


        }

    }
}
