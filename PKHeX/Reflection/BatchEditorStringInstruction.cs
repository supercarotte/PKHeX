using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKHeX.Reflection
{
    public class BatchEditorStringInstruction
    {
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public bool Evaluator { get; set; }
        public void setScreenedValue(string[] arr)
        {
            int index = Array.IndexOf(arr, PropertyValue);
            PropertyValue = index > -1 ? index.ToString() : PropertyValue;
        }

        // Extra Functionality
        public bool Random;
        public int Min, Max;
        public int RandomValue => Util.rand.Next(Min, Max + 1);
    }
}
