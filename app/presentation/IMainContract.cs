using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.presentation
{
    /// <summary>
    /// Interface for business logic of ViewModel.
    /// </summary>
    interface Interactor
    {
        void GetCommands();
        void ExecuteCommand(params object[] values);
    }

    /// <summary>
    /// Interface for presentation logic of ViewModel.
    /// </summary>
    interface ViewModel
    {
        IMutableLiveData<ICommand> GetCurrentCommandObservable();
        ILiveData<List<ICommand>> GetCommandListObservable();
        ILiveData<Double> GetResultObservable();
        ILiveData<Exception> GetThrowableObservable();

        void Unsubscribe();
    }
}
