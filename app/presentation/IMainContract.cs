using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.presentation
{
    interface Interactor
    {
        void GetCommands();
        void ExecuteCommand(params object[] values);
    }

    interface ViewModel
    {
        IMutableLiveData<ICommand> GetCurrentCommandObservable();
        ILiveData<List<ICommand>> GetCommandListObservable();
        ILiveData<Double> GetResultObservable();
        ILiveData<Exception> GetThrowableObservable();

        void Unsubscribe();
    }
}
