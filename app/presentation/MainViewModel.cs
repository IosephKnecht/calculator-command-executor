using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.data.exception;

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

        public void ExecuteCommand(params object[] values)
        {
            var command = currentCommandObservable.GetValue();
            if (command != null)
            {
                if (checkParameters(values))
                {
                    resultObservable.SetValue(command.Execute());
                }
            }
            else
            {
                throwableObservable.SetValue(new Exception("Please, select command"));
            }
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

        private bool checkParameters(object[] values)
        {
            var command = currentCommandObservable.GetValue();
            if(command is OneOperandCommand)
            {
                if(values !=null && values.Length >= 1)
                {
                    try
                    {
                        var oneOperandCommand = (OneOperandCommand)command;
                        oneOperandCommand.setOperand(Convert.ToDouble(values[0]));
                        return true;
                    }
                    catch
                    {
                        throwableObservable.SetValue(new ArgumentCastException());
                    }
                }
                else
                {
                    throwableObservable.SetValue(new InputArgumenException());
                }
            }
            else if(command is TwoOperandCommand)
            {
                if (values != null && values.Length >= 2)
                {
                    var twoOperandCommand = (TwoOperandCommand)command;
                    try
                    {
                        twoOperandCommand.setFirstOperand(Convert.ToDouble(values[0]));
                        twoOperandCommand.setSecondOperand(Convert.ToDouble(values[1]));
                        return true;
                    }
                    catch
                    {
                        throwableObservable.SetValue(new ArgumentCastException());
                    }
                }
                else
                {
                    throwableObservable.SetValue(new InputArgumenException());
                }
            }
            else
            {
                throwableObservable.SetValue(new UnknownTypeCommand());
            }

            return false;
        }
    }
}
