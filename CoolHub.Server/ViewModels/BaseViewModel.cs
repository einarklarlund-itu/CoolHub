using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace CoolHub.ViewModels
{
    public abstract class BaseViewModel: INotifyPropertyChanged
    {
        private bool isBusy = false; 
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                SetValue(ref isBusy, value);
            }
        }
    
        public event PropertyChangedEventHandler PropertyChanged;
    
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
    
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void SetValue<T>(ref T backingFiled, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingFiled, value)) 
            {
                return; 
            }
            
            backingFiled = value;
            OnPropertyChanged(propertyName);
        }
    }
}