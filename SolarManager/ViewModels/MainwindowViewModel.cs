using GalaSoft.MvvmLight;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarManager.ViewModels
{
    class eventTest: PubSubEvent<string>
    {

    }
   public class MainwindowViewModel : ViewModelBase

    {

        private string tab_1 = "Plant Map";
        private string tab_2 = "Camera Show";
        private string tab_3 = "Select Mode";
        private string tab_4 = "Set Parameter";
        private string tab_5 = "Initialize";
        private string tab_6 = "Notification";

        public String Tab1
        {
            set
            {
                tab_1 = value; 
            }
            get
            {
                return tab_1;
            }
        }

        public String Tab2
        {
            set
            {
                tab_2 = value;
            }
            get
            {
                return tab_2;
            }
        }

        public String Tab3
        {
            set
            {
                tab_3 = value;
            }
            get
            {
                return tab_3;
            }
        }

        public String Tab4
        {
            set
            {
                tab_4 = value;
            }
            get
            {
                return tab_4;
            }
        }
        public void Test()
        {
            EventAggregator evtA = new EventAggregator();

            evtA.GetEvent<eventTest>().Subscribe(sub, true);

            evtA.GetEvent<eventTest>().Publish("hsdhsgds");

        }
        public void sub(string a)
        {

        }
    }
}
