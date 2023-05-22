using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp7
{
    public class ViewMod : ViewModelBase
    {
        public ICommand ItemSelectedCommand { get; }
        public Button Button { get; set; }

        public ViewMod()
        {
            ItemSelectedCommand = new RelayCommand<object>(OnItemSelectedCommand);
        }

        private void OnItemSelectedCommand(object selectedItem)
        {
            Keyboard.Focus(Button);
        }
    }
}
