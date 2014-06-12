using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniArchive.attributes
{
    public enum AttributeType
    {
        String,
        Date,
        Boolean,
        Decimal,
        Integer,
        Reference
    }


    public class Attribute
    {
        private decimal referenceType;
        private AttributeType valueType;

        public decimal ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Mandatory { get; set; }

        public decimal ReferenceType
        {
            get { return referenceType; }
            set
            {
                this.referenceType = value;
            }
        }

        public AttributeType ValueType
        {
            get { return this.valueType; }
            set
            {
                this.valueType = value;
            }
        }

        public string ValueTypeName
        {
            get { return this.valueType.ToString(); }
            set
            {
                this.valueType = GetAttributeType(value);
            }
        }

        public static AttributeType GetAttributeType(string valueType)
        {
            return (AttributeType)Enum.Parse(typeof(AttributeType),valueType);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
