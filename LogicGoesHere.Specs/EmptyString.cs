using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace LogicGoesHere.Specs
{
    class EmptyString:Reference
    {
        public class when_EmptyString
        {

             Because of = () =>
             {
                 _result = Obj.Add("");
             };

             It should_should = () =>
             {
                 _result.ShouldEqual(0);
             };


        }

    }
}
