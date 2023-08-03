using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTest.Forms
{
    public class StatusList<T> : IEnumerable<(string, T)>, IEnumerator<(string,T)> 
    {
        public List<int> Id {  get; private set; }
        public List<string> Status { get; private set; }
        public List<int> RowIndex { get; private set; }
        public List<T> ItemsToSave { get; private set; }

        public (string, T) Current => (Status[index], ItemsToSave[index]);

        object IEnumerator.Current => (Status[index], ItemsToSave[index]);

        int index = -1;

        public int Index { get { return index; } }

        public StatusList()
        {
            Id = new List<int>();
            Status = new List<string>();
            RowIndex = new List<int>();
            ItemsToSave = new List<T>();
        }

        public void Clear()
        {
            Id = new List<int>();
            Status = new List<string>();
            RowIndex = new List<int>();
            ItemsToSave = new List<T>();
        }

        public IEnumerator<(string, T)> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index < ItemsToSave.Count - 1) 
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose()
        {
            Reset();
        }
    }
}
