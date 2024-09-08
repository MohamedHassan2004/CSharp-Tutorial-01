using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct PhoneBook
    {
        int size;
        string[] names;
        long[] numbers;

        public PhoneBook(int size)
        {
            this.size = size;
            names = new string[size];
            numbers = new long[size];
        }

        public void Print()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.size; i++) {
                sb.Append($"{i}::{names[i]}::{numbers[i]}\n");
            }
            Console.WriteLine(sb);
        }

        /// indexer
        public string this[int idx]
        {
            get { return $"{idx}::{names[idx]}"; }
            set { names[idx] = value; }
        }

        public long this[string name]
        {
            get {
                for (int i = 0; i < size; i++)
                {
                    if (name == this.names[i])
                        return numbers[i];
                }
                return 0;
                }
            set
            {
                for (int i = 0; i < size; i++)
                {
                    if (name == this.names[i])
                        numbers[i] = value;
                }
            }
        }
    }
}
