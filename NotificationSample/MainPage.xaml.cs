using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NotificationSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            button.Clicked += (sender, e) =>
            {
                // ネイティブ側から通知を出させるためのメッセージを送信
                // Android の場合、MainActivity で受信する
                MessagingCenter.Send(this, "NOTIFY");
            };
        }
    }
}
