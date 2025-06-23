using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class FormField
    {
        public string FieldName { get; set; }
        public string FieldType { get; set; } // TextBox, ComboBox, etc.
        public bool IsRequired { get; set; }
        public string FieldOptions { get; set; }
    }
}
