﻿using Xamarin.Forms;
using Com.OneSignal;

namespace XamarinLatinoPushNotifications
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinLatinoPushNotificationsPage();

            //Setting OneSignal
            OneSignal.Current.StartInit("37064466-c9ad-4b6e-9e3c-6df406f13777").HandleNotificationOpened(OnHandleNotificationOpened).EndInit();
        }

        private void OnHandleNotificationOpened(Com.OneSignal.Abstractions.OSNotificationOpenedResult result)
        {
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
