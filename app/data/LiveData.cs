using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    interface IMutableLiveData<T>:ILiveData<T>
    {
        void SetValue(T value);
    }

    public interface ILiveData<T>
    {
        void Observe(Action<T> block);
        T GetValue();
        void Unsubscribe();
    }


    class LiveData<T>:ILiveData<T>,IMutableLiveData<T>
    {
        private T value = default(T);

        private List<Action<T>> changes = new List<Action<T>>();

        public void Observe(Action<T> block)
        {
            changes.Add(block);
        }

        public void SetValue(T value)
        {
            this.value = value;
            changes.ForEach(element => { element.Invoke(value); });
        }

        public T GetValue()
        {
            return this.value;
        }

        public void Unsubscribe()
        {
            changes.Clear();
        }

    }
}
