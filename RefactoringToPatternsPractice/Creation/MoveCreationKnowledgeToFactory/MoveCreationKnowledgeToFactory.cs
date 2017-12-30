using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToPatternsPractice.Creation.MoveCreationKnowledgeToFactory
{
    public class MoveCreationKnowledgeToFactory
    {
        public class StringParser
        {
            public Node Find()
            {
                var parser = new Parser();
                var textBuffer = new Object();
                var textBegin = new Object();
                var textEnd = new object();
                return StringNode.CreateStringNode(textBuffer, textBegin, textEnd, parser.ShouldDecodeNodes());
            }
        }

        public class Parser
        {
            public bool ShouldDecodeNodes()
            {
                return true;
            }
        }

        public class StringNode : Node
        {
            public StringNode(object textBuffer, object textBegin, object textEnd)
            {
            }

            public static Node CreateStringNode(object textBuffer,
                                                object textBegin,
                                                object textEnd,
                                                bool shouldDecodeNodes)
            {
                if (shouldDecodeNodes)
                {
                    return DecodingStringNode(new StringNode(textBuffer, textBegin, textEnd));
                }
                return new StringNode(textBuffer, textBegin, textEnd);
            }

            private static Node DecodingStringNode(StringNode stringNode)
            {
                throw new NotImplementedException();
            }
        }

        public class Node
        {
        }
    }
}