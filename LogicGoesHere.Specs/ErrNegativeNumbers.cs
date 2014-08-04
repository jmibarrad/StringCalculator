using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace LogicGoesHere.Specs
{
    class ErrNegativeNumbers:Reference
    {
        public class when_ErrNegativeNumbers
        {
            private static int _var=-1;
            Because of = () =>
            {
                try
                {
                    _result = Obj.Add("//;\n1;2\n3");
                }
                catch (Exception ex)
                {

                    if (!ex.Message.StartsWith("Negatives not allowed"))
                        throw new ArgumentException(ex.Message);
                    else
                        _var = 0;

                }
            };

            It should_should = () =>
            {
                _var.ShouldEqual(-1);
            };


        }

    }
}
