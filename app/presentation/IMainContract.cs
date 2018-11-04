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
        LiveData<ICommand> GetCurrentCommandObservable();
        LiveData<List<ICommand>> GetCommandListObservable();
        LiveData<Double> GetResultObservable();
        LiveData<Exception> GetThrowableObservable();

        void Unsubscribe();
    }
}
