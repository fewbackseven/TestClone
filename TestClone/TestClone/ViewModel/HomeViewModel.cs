using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TestClone.Model;

namespace TestClone.ViewModel
{
    public class HomeViewModel //: INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        public List<string> Khatabook 
        {
            get; set;         //return KhataBook;
        }

        string  name;
        
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
