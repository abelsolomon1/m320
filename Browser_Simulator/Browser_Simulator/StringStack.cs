using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    public class StringStack
    {
        private string[] values;
        private int index;

        public StringStack(int size)
        {
            values = new string[size];
            index = 0;
        }

        public void Push(string value)
        {
            if (index < values.Length)
            {
                values[index++] = value;
            }
        }

        public string Pop()
        {
            if (index > 0)
            {
                return values[--index];
            }
            return null;
        }

        public string Peak()
        {
            if (index > 0)
            {
                return values[index - 1];
            }
            return null;
        }

        public void Swap()
        {
            if (index >= 2)
            {
                string temp = values[index - 1];
                values[index - 1] = values[index - 2];
                values[index - 2] = temp;
            }
        }

        public void Clear()
        {
            index = 0;
        }

        public bool IsEmpty
        {
            get { return index == 0; }
        }

        public int Count
        {
            get { return index; }
        }

        public bool IsFull
        {
            get { return index == values.Length; }
        }

        public override string ToString()
        {
            return string.Join(", ", values.Take(index));
        }
    }

}
