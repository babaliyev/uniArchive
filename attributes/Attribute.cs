using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniArchive.attributes
{
    public enum AttributeType
    {
        String,
        DateTime,
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
            if (valueType.Equals(AttributeType.String.ToString().ToLower()))
                return AttributeType.String;
            else
                if (valueType.Equals(AttributeType.DateTime.ToString().ToLower()))
                    return AttributeType.DateTime;
                else
                    if (valueType.Equals(AttributeType.Decimal.ToString().ToLower()))
                        return AttributeType.Decimal;
                    else
                        if (valueType.Equals(AttributeType.Integer.ToString().ToLower()))
                            return AttributeType.Integer;
                        else
                            if (valueType.Equals(AttributeType.Boolean.ToString().ToLower()))
                                return AttributeType.Boolean;
                            else
                                return AttributeType.Reference;

        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
