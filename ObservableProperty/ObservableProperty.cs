using System.ComponentModel;

namespace Xamarin.MVVM
{
    public class ObservableProperty:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
            
        }
    }

}
