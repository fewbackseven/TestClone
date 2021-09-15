using System;
using System.Collections.Generic;
using System.Text;
using TestClone.ViewModel;

namespace TestClone.Model
{
    public class khata
    {
        public  string book { get; set; }
    }
    public  class DataToWork
    {
        public List<string> KhataBook()
        {
            List<string> kh = new List<string>();
            kh.Add( "Office1" );
            kh.Add("Office2" );
            return kh;
        }
                      
        public List<khata> listofKhatas()
        {
            List<khata> khatas = new List<khata>();
            khatas.Add(new khata { book = "Khata1" });
            khatas.Add(new khata { book = "Khata2" });
            return khatas;
        }
    }
    


}
