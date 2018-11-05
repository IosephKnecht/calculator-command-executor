using app.domain;
using System;
using System.Drawing;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Windows.Forms;

namespace app.presentation
{
    /// <summary>
    /// Is part of the architecture M(V)VM.
    /// </summary>
    public partial class MainForm : Form
    {
        private Interactor interactor;
        private ViewModel viewModel;

        private Subject<String> firsrOperandSubject = new Subject<string>();
        private Subject<String> secondOperandSubject = new Subject<string>();

        private CompositeDisposable compositeDisposable = new CompositeDisposable();

        private Color alertColor = Color.Red;
        private Color defaultColor = Color.White;

        public MainForm()
        {
            InitializeComponent();

            inject();

            viewModel.GetCurrentCommandObservable().Observe(command => {
                if(command is OneOperandCommand)
                {
                    tv_first_operand.Visible = true;
                    tv_second_operand.Visible = false;
                }
                else if(command is TwoOperandCommand)
                {
                    tv_first_operand.Visible = true;
                    tv_second_operand.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error");
                }
                CleanTextView();
                ReloadBackColor();
            });

            viewModel.GetCommandListObservable().Observe(list => {
                command_selector.Items.AddRange(list.ToArray()); 
            });

            viewModel.GetResultObservable().Observe(result =>
            {
                tv_result.Text = result.ToString();
            });

            viewModel.GetThrowableObservable().Observe(error =>
            {
                MessageBox.Show(error.Message);
            });

            compositeDisposable.Add(firsrOperandSubject.Throttle(TimeSpan.FromMilliseconds(500))
                .SubscribeOn(scheduler: Scheduler.Immediate)
                .ObserveOn(this.tv_first_operand)
                .Subscribe(str=> {
                    if (!ArgumentValidator.isDouble(str))
                    {
                        tv_first_operand.BackColor = alertColor;
                    }
                    else
                    {
                        tv_first_operand.BackColor = defaultColor;
                    }
                }));

            compositeDisposable.Add(secondOperandSubject.Throttle(TimeSpan.FromMilliseconds(500))
                .SubscribeOn(Scheduler.Immediate)
                .ObserveOn(this.tv_second_operand)
                .Subscribe(str=> {
                    if (!ArgumentValidator.isDouble(str))
                    {
                        tv_second_operand.BackColor = alertColor;
                    }
                    else
                    {
                        tv_second_operand.BackColor = defaultColor;
                    }
                }));

            interactor.GetCommands();
        }

        private void command_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox view = (ComboBox)sender;
            var command = (ICommand) view.SelectedItem;
            viewModel.GetCurrentCommandObservable().SetValue(command);
        }

        private void inject()
        {
            MainViewModel mainViewModel = new MainViewModel();
            interactor = (Interactor)mainViewModel;
            viewModel = (ViewModel)mainViewModel;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            compositeDisposable.Clear();
            viewModel.Unsubscribe();
        }

        private void execute_button_Click(object sender, EventArgs e)
        {
            interactor.ExecuteCommand(ReceiveData());
        }

        private void CleanTextView()
        {
            tv_first_operand.Text = null;
            tv_second_operand.Text = null;
            tv_result.Text = null;
        }

        private void ReloadBackColor()
        {
            tv_first_operand.BackColor = defaultColor;
            tv_second_operand.BackColor = defaultColor;
        }


        private object[] ReceiveData()
        {
            var firstOperand = tv_first_operand.Text.Trim();
            var secondOperand = tv_second_operand.Text.Trim();
            return new object[] { firstOperand, secondOperand };
        }

        private void OnHintEnterForInput(object sender,EventArgs e)
        {
            var owner = (IWin32Window)sender;
            hint_box.Show("Please, enter operand", owner);
        }

        private void OnClipboardPaste(TextBox textBox)
        {
            var clipboardText = Clipboard.GetText();
            if (textBox.Visible && clipboardText != null) textBox.Text = clipboardText;
        }

        private void copy_first_operand_Click(object sender, EventArgs e)
        {
            OnClipboardPaste(tv_first_operand);
        }

        private void copy_second_operand_Click(object sender, EventArgs e)
        {
            OnClipboardPaste(tv_second_operand);
        }

        private void NotifySubject(object sender, ISubject<String> subject)
        {
            TextBox textBox = (TextBox)sender;
            var emit = textBox.Text;
            if (emit != null && emit != "")
            {
                subject.OnNext(emit);
            }
        }

        private void OnFirstOperandChanged(object sender, EventArgs e)
        {
            NotifySubject(sender, firsrOperandSubject);
        }

        private void OnSecondOperandChanged(object sender, EventArgs e)
        {
            NotifySubject(sender, secondOperandSubject);
        }
    }
}
