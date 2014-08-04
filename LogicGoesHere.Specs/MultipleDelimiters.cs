using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace LogicGoesHere.Specs
{
    class MultipleDelimiters:Reference
    {
        public class when_MultipleDelimiters
        {

            Because of = () =>
            {
                _result = Obj.Add("“//[*][%]\n1*2%3");
            };

            It should_should = () =>
            {
                _result.ShouldEqual(6);
            };


        }

    }
}
