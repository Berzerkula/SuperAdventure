using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest : INotifyPropertyChanged
    {
        private Quest _details;
        public bool IsCompleted { get; set; }

        public Quest Details
        {
            get { return _details; }
            set
            {
                _details = value;
                OnPropertyChanged("Details");
            }
        }

        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string name)
    {
        if(PropertyChanged != null)
        {
            PropertyChangedEventHandler(this, new PropertyChangedEventArgs(name));
        }
    }
}
