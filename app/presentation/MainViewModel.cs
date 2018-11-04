using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.presentation
{
    class MainViewModel: ViewModel, Interactor
    {
        private LiveData<ICommand> currentCommandObservable = new LiveData<ICommand>();
        private LiveData<List<ICommand>> commandsObservable = new LiveData<List<ICommand>>();
        private LiveData<Double> resultObservable = new LiveData<double>();
        private LiveData<Exception> throwableObservable = new LiveData<Exception>();

        public MainViewModel()
        {

        }

        #region Interactor Scope
        public void GetCommands()
        {
            commandsObservable.SetValue(CommandInjector.Instance.GetCommandList());
        }

        public void ExecuteCommand()
        {
            var command = currentCommandObservable.GetValue();
            if (command != null) resultObservable.SetValue(command.Execute());
            else throwableObservable.SetValue(new Exception("Please, select command"));
        }
        #endregion

        #region ViewModel Scope
        public LiveData<ICommand> GetCurrentCommandObservable()
        {
            return currentCommandObservable;
        }

        public LiveData<List<ICommand>> GetCommandListObservable()
        {
            return commandsObservable;
        }

        public void Unsubscribe()
        {
            currentCommandObservable.Unsubscribe();
            commandsObservable.Unsubscribe();
        }

        public LiveData<double> GetResultObservable()
        {
            return resultObservable;
        }

        public LiveData<Exception> GetThrowableObservable()
        {
            return throwableObservable;
        }
        #endregion
    }
}
