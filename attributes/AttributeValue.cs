using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniArchive.attributes
{
    public class AttributeValue
    {
        public decimal ID { get; set; }
        public decimal DocumentID { get; set; }
        public decimal? CopyID { get; set; }
        public Attribute Attibute { get; set; }
        public object Value { get; set; }
        
        public override bool Equals(object obj)
        {
            if (obj != null && obj is AttributeValue)
                return this.ID.Equals((obj as AttributeValue).ID);
            else
                return false;
        }
    }
}
