using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class LiveData<T>
    {
        public delegate void Change(T value);

        private T pep = default(T);

        private List<Change> changes = new List<Change>();

        public void Observe(Change block)
        {
            changes.Add(block);
        }

        public void SetValue(T value)
        {
            this.pep = value;
            changes.ForEach(element => { element.Invoke(value); });
        }

        public T GetValue()
        {
            return this.pep;
        }

        public void Unsubscribe()
        {
            changes.Clear();
        }

    }
}
