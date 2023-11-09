using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cauciones
{
    public class AgrupComboboxItem
    {
        public AgrupComboboxItem(string text, int value)
        {
            this.Text = text;
            this.Value = value;
        }
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return  Text;
        }
    }
}
