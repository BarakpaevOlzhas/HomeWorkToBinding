using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollectionHomeWork
{
    public class Division : INotifyPropertyChanged
    {
        public ObservableCollection<Employee> Employees { set; get; }
        public string Name { set; get; }

        public Division()
        {
            Employees = new ObservableCollection<Employee>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
