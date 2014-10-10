using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using System.Windows.Input;

namespace GmScreen.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            AccountName = "testAccount";
            OpenLoginFlyoutCommand = new RelayCommand(() => OpenLoginFlyout());
            CurrentViewModel = helloWorldViewModel;
        }

        protected readonly static HelloWorldViewModel helloWorldViewModel = new HelloWorldViewModel();

        protected string accountName;
        protected bool isLoginFlyoutOpen;
        protected ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                if (currentViewModel == value) return;
                Set("CurrentViewModel", ref currentViewModel, value);
            }
        }

        public string AccountName
        {
            get { return accountName; }
            set
            {
                Set("AccountName", ref accountName, value);
            }
        }
        public bool IsLoginFlyoutOpen
        {
            get { return isLoginFlyoutOpen; }
            set
            {
                Set("IsLoginFlyoutOpen", ref isLoginFlyoutOpen, value);
            }
        }

        public ICommand OpenLoginFlyoutCommand { get; protected set; }

        public void OpenLoginFlyout()
        {
            IsLoginFlyoutOpen = true;
        }
    }
}