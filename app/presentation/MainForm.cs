using System;
using System.Windows.Forms;

namespace app.presentation
{
    public partial class MainForm : Form
    {
        private Interactor interactor;
        private ViewModel viewModel;

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
            });

            viewModel.GetCommandListObservable().Observe(list => {
                command_selector.Items.AddRange(list.ToArray()); 
            });

            viewModel.GetResultObservable().Observe(result =>
            {
                MessageBox.Show(result.ToString());
            });

            viewModel.GetThrowableObservable().Observe(error =>
            {
                MessageBox.Show(error.Message);
            });

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
    }
}
