using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace LogicGoesHere.Specs
{
    class UnknownAmountOfNumbers: Reference
    {
        public class when_UnknownAmountOfNumbers
        {


            Because of = () =>
            {
                 _result = Obj.Add("1,3,2,4,5,7,6,8");
            };

            It should_should = () =>
            {
                _result.ShouldEqual(36);
            };

        }


    }
}
