using System;
using Tools.Model;
using Tools.Core;

namespace Tools.ViewModel
{
    public class ToolsViewModel : ObservableObject
    {
        private ToolsModel number = new ToolsModel();

        public string Number
        {
            get
            {   if(number == null)
                    number = new ToolsModel();

                return number.Number.ToString();
            }
            set
            {
                int result = 0;

                if (Int32.TryParse(value, out result))
                    number.Number = result;
                else
                    number.Number = 0;

                OnPropertyChanged(nameof(Number));
                OnPropertyChanged(nameof(Number1));
                OnPropertyChanged(nameof(Number2));
                OnPropertyChanged(nameof(Number3));
                OnPropertyChanged(nameof(Number4));
                OnPropertyChanged(nameof(Number5));
            }
        }

        public string Number1
        {
            get
            {
                return number.Number1.ToString();
            }
        }
        public string Number2
        {
            get
            {
                return number.Number2.ToString();
            }
        }

        public string Number3
        {
            get
            {
                return number.Number3.ToString();
            }
        }

        public string Number4
        {
            get
            {
                return number.Number4.ToString();
            }
        }

        public string Number5
        {
            get
            {
                return number.Number5.ToString();
            }
        }


    }

}
