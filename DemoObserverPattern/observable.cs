﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern
{
    class Observable:INotifyPropertyChanged
    {
        private int number;
        private String name;
        private String item;

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged();   
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public string Item
        {
            get { return item; }
            set { item = value; }
        }

        public Observable()
        {
        }


        public override string ToString()
        {
            return $"Number: {number}, Name: {name}, Item: {item}";
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
