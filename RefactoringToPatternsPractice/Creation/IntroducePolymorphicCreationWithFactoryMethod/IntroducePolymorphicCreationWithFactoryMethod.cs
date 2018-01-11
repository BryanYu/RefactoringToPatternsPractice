using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToPatternsPractice.Creation.IntroducePolymorphicCreationWithFactoryMethod
{
    internal class IntroducePolymorphicCreationWithFactoryMethod
    {
        public class DOMBuilder : OutputBuilder
        {
            private OutputBuilder _builder;

            public DOMBuilder(string name)
            {
            }

            public void AddAboveRoot()
            {
                var invalidResult = "<orders>" +
                                    "<order>" +
                                    "</order>" +
                                    "<customer>" +
                                    "<customer>";
                this._builder = new DOMBuilder("orders");
                _builder.AddBelow("order");
                try
                {
                    _builder.AddAbove("customer");
                    throw new Exception("RuntimeException");
                }
                catch (Exception e)
                {
                }
            }
        }

        public class OutputBuilder
        {
            public void AddBelow(string order)
            {
                throw new NotImplementedException();
            }

            public void AddAbove(string customer)
            {
                throw new NotImplementedException();
            }
        }
    }
}