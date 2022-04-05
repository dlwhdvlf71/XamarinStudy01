﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceInfoEx : ContentPage
    {
        public DeviceInfoEx()
        {
            //InitializeComponent();
            this.Padding = 20;

            // Device Model (SMG-950U, iPhone10,6)
            var device = DeviceInfo.Model;

            // Manufacturer (Samsung)
            var manufacturer = DeviceInfo.Manufacturer;

            // Device Name (Motz's iPhone)
            var deviceName = DeviceInfo.Name;

            // Operating System Version Number (7.0)
            var version = DeviceInfo.VersionString;

            // Platform (Android)
            var platform = DeviceInfo.Platform;

            // Idiom (Phone)
            var idiom = DeviceInfo.Idiom;

            // Device Type (Physical)
            var deviceType = DeviceInfo.DeviceType;

            string strInfo = $@"Device Model : {device} \n Manufacturer : {manufacturer} \n deviceName : {deviceName} \n Version : {version}\n Platform : {platform}\n Idiom : {idiom}\n Device Type : {deviceType} ";

            Label label = new Label()
            {
                Text = strInfo,
                FontSize = 12,
                FontAttributes = FontAttributes.Bold,
            };

            Content = new StackLayout
            {
                Children =
                {
                    label
                }
            };
        }
    }
}