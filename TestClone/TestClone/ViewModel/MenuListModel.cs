using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
//using MvvmHelpers;
//using MvvmHelpers.Commands;

namespace TestClone.ViewModel
{
     
    public class MenuListModel: INotifyPropertyChanged
    {
        Command tapSettings,tapHelp, tapAbout;
        
        public bool _settingsTapped,_tapHelp, _tapAbout, scroller;
        public event PropertyChangedEventHandler PropertyChanged;
        public MenuListModel()
        {
            tapSettings = new Command(OnTapped);
            tapHelp = new Command(OnHelpTapped);
            tapAbout = new Command(OnAboutTapped);
        }

        
        public bool _AboutTapped
        {
            get { return _tapAbout; }
        }

        public Command TapAbout
        {
            get { return tapAbout; }
        }

        void OnAboutTapped()
        {
            _tapAbout = !_tapAbout;
            NotifyPropertyChanged("_AboutTapped");
        }

        public bool _HelpTapped
        {
            get { return _tapHelp; }
        }

        void OnHelpTapped()
        {
            _tapHelp = !_tapHelp;
            NotifyPropertyChanged("_HelpTapped");
        }

        public Command TapHelp
        {
            get { return tapHelp; }
        }
        public bool _SettingsTapped
        {
            get
            {
                return _settingsTapped;
            }
            set
            {
                _settingsTapped = value;
            }
        }

        public Command TapSettings
        {
            get { return tapSettings; }
        }

        void OnTapped(object s)
        {
            _settingsTapped = !_settingsTapped;
            scroller = _settingsTapped;            
            NotifyPropertyChanged("_SettingsTapped");            
        }

        
        public List<string> SettingsList1()
        {
            List<string> kh1 = new List<string>()
            {
                "Recycle Bin",
                "App Lock",
                "Language",
                "Backup Information",
                "Delete Khata",
                "App Update"               
            };

            return kh1;
        }

        public List<string> MoreList1()
        {
           List<string> items1 = new List<string>()
            {
               "Business Card",
               "Cash Book",
               "Play Quiz",
               "Earn Money",
               "Manage Staff"
            };
            return items1;
        }

        List<string> items = new List<string>();
        public List<string> SettingsList
        {            
            get
            {
                items = SettingsList1();                
                return items;
            }           
        }

        public List<string> MoreList
        {
            get
            {
                items = MoreList1();
                return items;
            }
        }

        public List<string> HelpSupport
        {
            get
            {
                items = new List<string>()
                { 
                    "FAQs",
                    "Help on WhatsApp",
                    "Call Us"
                };
                return items;
            }
        }

        public List<string> AboutList
        {
            get
            {
                items = new List<string>()
                {
                    "About Khatabook",
                    "Privacy Policy",
                    "Terms & Conditions"
                };
                return items;
            }
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
