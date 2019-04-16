using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_functionsTest
{
    class ModelFunction : INotifyPropertyChanged
    {
        #region private fields
        private double _a = 1; 
        private double _b = 1; 
        private double _c;
        private double _x;
        private double _y;
        private int _power;
        private string _name;

        #endregion

        #region public properties
        public double A
        {
            get
            {
                return _a;
            }

            set
            {
                _a = value;
                OnPropertyChanged();
                OnPropertyChanged("Result");
            }
        }
        public double B
        {
            get
            {
                return _b;
            }

            set
            {
                _b = value;
                OnPropertyChanged();
                OnPropertyChanged("Result");
            }
        }
        public double C
        {
            get
            {
                return _c;
            }

            set
            {
                _c = value;
                OnPropertyChanged();
                OnPropertyChanged("Result");
            }
        }
        public double X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
                OnPropertyChanged();
                OnPropertyChanged("Result");
            }
        }
        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
                OnPropertyChanged();
                OnPropertyChanged("Result");
            }
        }
        public int Power
        {
            get
            {
                return _power;
            }

            set
            {
                _power = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public double Result
        {
            get
            {
                return _a * Math.Pow(_x, _power) + _b * Math.Pow(_y, _power - 1) + _c;
            }
        }

        #endregion

        public ModelFunction(string name, int power)
        {
            _name = name;
            _power = power;
            _c = Math.Pow(10, _power - 1);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string property = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(property));
        }
    }
}
