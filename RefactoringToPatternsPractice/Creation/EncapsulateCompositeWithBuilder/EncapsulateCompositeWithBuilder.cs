using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace RefactoringToPatternsPractice.Creation.EncapsulateCompositeWithBuilder
{
    internal class EncapsulateCompositeWithBuilder
    {
        public class TagBuilder
        {
            private TagNode _rootNode;
            private TagNode _currentNode;

            public TagBuilder(string rootTagName)
            {
                _rootNode = new TagNode(rootTagName);
                _currentNode = _rootNode;
            }

            public void AddChild(string childTagName)
            {
                AddTo(_currentNode, childTagName);
            }

            public void AddSibling(string siblingTagName)
            {
                AddTo(_currentNode.GetParent(), siblingTagName);
            }

            public string ToXml()
            {
                return _rootNode.ToString();
            }

            private void AddTo(TagNode parentNode, string tagName)
            {
                _currentNode = new TagNode(tagName);
                parentNode.Add(_currentNode);
            }
        }

        internal class TagNode
        {
            private TagNode _parent;

            public TagNode(string rootTagName)
            {
            }

            public void Add(TagNode childNode)
            {
                childNode.SetParent(this);
                this.Add(childNode);
            }

            public TagNode GetParent()
            {
                return _parent;
            }

            private void SetParent(TagNode parent)
            {
                this._parent = parent;
            }
        }
    }
}