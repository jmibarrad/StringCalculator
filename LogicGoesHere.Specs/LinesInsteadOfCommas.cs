using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace LogicGoesHere.Specs
{
    class LinesInsteadOfCommas:Reference
    {
        public class when_LinesInsteadOfCommas
        {


            Because of = () =>
            {
                 _result = Obj.Add("1\n2,3");
            };

            It should_should = () =>
            {
                _result.ShouldEqual(6);
            };

        }

    }
}
