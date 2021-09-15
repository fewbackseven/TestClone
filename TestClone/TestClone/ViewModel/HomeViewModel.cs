using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using TestClone.Model;
using Xamarin.Forms;

namespace TestClone.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public bool _settingsTapped;

        public bool _SettingsTapped
        {
            get
            {                               
               return  _settingsTapped;                
            }
        }

        Command tapSettings;
        public HomeViewModel()
        {
            tapSettings = new Command(OnTapped);
        }

        public Command TapSettings
        {
            get { return tapSettings; }
        }

        void OnTapped(object s)
        {
            _settingsTapped = !_settingsTapped;
            NotifyPropertyChanged("_SettingsTapped");
            //RefreshSettingsTapped();
        }

       

        string  name;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        DataToWork ln = new DataToWork();
        List<string> books = new List<string>();
        
        
        

        public List<string> SearchResults
        {
            get
            {
                books = ln.KhataBook();
                return books;
            }
            set
            {
                books = value;
                NotifyPropertyChanged();
            }
        }
        public string Name 
        {
            get { return name="Enter Shop Name"; } 
            set { name = Name; } 
        }

        /*public List<string> Khatabook
        {
            private set
            {
                itm = khatabook[khatabook.Count+1];                                
                DataToWork.KhataBook().Add(itm);
                
                PropertyChangedEventHandler handler = PropertyChanged;

                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("Khatabook"));
                }

            }

            get
            {
                if (khatabook == null||khatabook!=DataToWork.KhataBook())
                {
                    khatabook = DataToWork.KhataBook();
                    return khatabook;
                }

                else
                    return khatabook;
            }
        }*/

        /*protected void OnPropertyChanged(propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }*/
    }
}
