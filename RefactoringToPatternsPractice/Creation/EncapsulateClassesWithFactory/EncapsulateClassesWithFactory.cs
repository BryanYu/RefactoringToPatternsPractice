using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToPatternsPractice.Creation.EncapsulateClassesWithFactory
{
    public class EncapsulateClassesWithFactory
    {
        public abstract class AttributeDescriptor
        {
            protected string name;

            protected AttributeDescriptor attributeDescriptor;

            protected Type type;

            protected AttributeDescriptor(string name, AttributeDescriptor attributeDescriptor, Type type)
            {
                this.name = name;
                this.attributeDescriptor = attributeDescriptor;
                this.type = type;
            }

            public static AttributeDescriptor ForInteger(string name, AttributeDescriptor attributeDescriptor)
            {
                return new DefaultDescriptor(name, attributeDescriptor, typeof(int));
            }

            public static AttributeDescriptor ForDate(string name,
                AttributeDescriptor attributeDescriptor)
            {
                return new DefaultDescriptor(name, attributeDescriptor, typeof(DateTime));
            }

            public static AttributeDescriptor ForDate(string name, AttributeDescriptor attributeDescriptor, Type referenceType)
            {
                return new ReferenceDescriptor(name, attributeDescriptor, referenceType, typeof(DateTime));
            }

            protected List<AttributeDescriptor> CreateAttributeDescriptors()
            {
                var result = new List<AttributeDescriptor>();
                result.Add(AttributeDescriptor.ForInteger("remoteId", this));
                result.Add(AttributeDescriptor.ForDate("createdDate", this));
                result.Add(AttributeDescriptor.ForDate("lastChangedDate", this));
                result.Add(AttributeDescriptor.ForDate("createdBy", this, typeof(ApplicationIdentity)));
                result.Add(AttributeDescriptor.ForDate("lastChangBy", this, typeof(ApplicationIdentity)));
                result.Add(AttributeDescriptor.ForInteger("optimisticLockVersion", this));
                return result;
            }
        }

        public class BooleanDescriptor : AttributeDescriptor
        {
            public BooleanDescriptor(string name, AttributeDescriptor attributeDescriptor, Type type) : base(name, attributeDescriptor, type)
            {
            }
        }

        public class DefaultDescriptor : AttributeDescriptor
        {
            public DefaultDescriptor(string name, AttributeDescriptor attributeDescriptor, Type type) : base(name, attributeDescriptor, type)
            {
            }
        }

        public class ReferenceDescriptor : AttributeDescriptor
        {
            protected Type referenceType;

            public ReferenceDescriptor(string name, AttributeDescriptor attributeDescriptor, Type referenceType, Type type) : base(name, attributeDescriptor, type)
            {
                this.referenceType = referenceType;
            }
        }
    }
}