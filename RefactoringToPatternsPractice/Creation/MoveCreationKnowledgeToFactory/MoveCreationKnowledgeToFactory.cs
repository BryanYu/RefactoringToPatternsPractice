using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToPatternsPractice.Creation.MoveCreationKnowledgeToFactory
{
    public class MoveCreationKnowledgeToFactory
    {
        public void Sample()
        {
            NodeFactory factory = new NodeFactory();
            factory.ShouldDecodeStringNodes = true;
            var parser = new Parser();
            parser.NodeFactory = factory;
        }

        public class StringParser
        {
            public Node Find()
            {
                var parser = new Parser();
                var textBuffer = new Object();
                var textBegin = new Object();
                var textEnd = new Object();
                var nodeFactory = new NodeFactory();
                return parser.NodeFactory.CreateStringNode(textBuffer, textBegin, textEnd);
            }
        }

        public class Parser
        {
            private NodeFactory _nodeFactory = new NodeFactory();

            public NodeFactory NodeFactory
            {
                get
                {
                    return this._nodeFactory;
                }
                set
                {
                    this._nodeFactory = value;
                }
            }
        }

        public class NodeFactory
        {
            private bool _shouldDecodeStringNodes;

            public bool ShouldDecodeStringNodes
            {
                get
                {
                    return this._shouldDecodeStringNodes;
                }
                set
                {
                    this._shouldDecodeStringNodes = value;
                }
            }

            public Node CreateStringNode(object textBuffer, object textBegin, object textEnd)
            {
                if (this._shouldDecodeStringNodes)
                {
                    return new DecodingStringNode(new StringNode(textBuffer, textBegin, textEnd));
                }
                return new StringNode(textBuffer, textBegin, textEnd);
            }
        }

        public class StringNode : Node
        {
            public StringNode(object textBuffer, object textBegin, object textEnd)
            {
            }
        }

        public class DecodingStringNode : Node
        {
            public DecodingStringNode(StringNode node)
            {
            }
        }

        public class Node
        {
        }
    }
}