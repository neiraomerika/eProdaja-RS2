using System;

namespace eProdaja.Model.Request
{
    internal class RequiredAttribute : Attribute
    {
        public bool AllowEmptyStrings { get; set; }
    }
}