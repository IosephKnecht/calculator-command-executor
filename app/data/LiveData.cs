using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{

    interface IMutableLiveData<T>:ILiveData<T>
    {
        /// <summary>
        /// Mehod for set value in wrapper and notify all observers.
        /// </summary>
        /// <param name="value">new value</param>
        void SetValue(T value);
    }

    public interface ILiveData<T>
    {
        /// <summary>
        /// Method for contains logic after notify.  
        /// </summary>
        /// <param name="block">logic's block</param>
        void Observe(Action<T> block);

        /// <summary>
        /// Mehod for get value on wrapper;
        /// </summary>
        /// <returns>wrapper value</returns>
        T GetValue();

        /// <summary>
        /// Method for unsubscribe all observers.
        /// </summary>
        void Unsubscribe();
    }

    /// <summary>
    /// Wrapper for observable data.
    /// </summary>
    /// <typeparam name="T">data type</typeparam>
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
