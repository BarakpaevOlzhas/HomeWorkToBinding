using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ObservableCollectionHomeWork
{
    public class Employee : INotifyPropertyChanged
    {
        private string fullName;
        private int age;        

        public string FullName
        {
            set
            {
                fullName = value;
                OnPropertyChanged("FullName");
            }
            get
            {
                return fullName;
            }
        }

        public int Age
        {
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
            get
            {
                return age;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
