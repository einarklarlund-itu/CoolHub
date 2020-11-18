using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CoolHub.ViewModels
{
    public class ToDoBasicViewModel : INotifyPropertyChanged
    {
        private bool isBusy =  false;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsBusy
        {
            get => isBusy; 
            set
            {
                isBusy = value; 
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}