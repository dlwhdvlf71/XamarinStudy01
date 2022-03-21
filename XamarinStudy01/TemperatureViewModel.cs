using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Diagnostics;

namespace XamarinStudy01
{
    public class TemperatureViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        double device01Temp, device02Temp;

        public ICommand IncreaseCommandForDevice01Temp {private get; set; }
        public ICommand DecreaseCommandForDevice01Temp { private get; set; }
        public ICommand IncreaseCommandForDevice02Temp { private get; set; }
        public ICommand DecreaseCommandForDevice02Temp { private get; set; }

        public TemperatureViewModel()
        {
            IncreaseCommandForDevice01Temp = new Command(
                execute: () =>
                {
                    Debug.WriteLine("Increase Device 01");
                    Device01Temp += 1;
                },
                canExecute: () =>
                {
                    if (Device01Temp >= 45)
                        return false;
                    else
                        return true;
                });

            DecreaseCommandForDevice01Temp = new Command(
                execute: () =>
                {
                    Device01Temp -= 1;
                },
                canExecute: () =>
                {
                    if (Device01Temp <= 25)
                        return false;
                    else
                        return true;
                });

            IncreaseCommandForDevice02Temp = new Command(
                execute: () =>
                {
                    Device02Temp += 1;
                },
                canExecute: () =>
                {
                    if (Device02Temp >= 45)
                        return false;
                    else
                        return true;
                });

            DecreaseCommandForDevice02Temp = new Command(
                execute: () =>
                {
                    Device02Temp -= 1;
                },
                canExecute: () =>
                {
                    if (Device02Temp <= 25)
                        return false;
                    else
                        return true;
                });

            Device01Temp = 30;
            Device02Temp = 28;
        }

        public double Device01Temp 
        {
            get
            {
                return this.device01Temp;
            }

            set
            {
                if(this.device01Temp != value)
                {
                    this.device01Temp = value;
                    OnPropertyChanged("Device01Temp");
                }
            }
        }

        public double Device02Temp
        {
            get
            {
                return this.device02Temp;
            }

            set
            {
                if (this.device02Temp != value)
                {
                    this.device02Temp = value;
                    OnPropertyChanged("Device02Temp");
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
