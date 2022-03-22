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
        Color device01Color, device02Color;

        public ICommand IncreaseCommandForDevice01Temp { get; private set; }
        public ICommand DecreaseCommandForDevice01Temp { get; private set; }
        public ICommand IncreaseCommandForDevice02Temp { get; private set; }
        public ICommand DecreaseCommandForDevice02Temp { get; private set; }

        public TemperatureViewModel()
        {
            IncreaseCommandForDevice01Temp = new Command(
                execute: () =>
                {
                    Device01Temp++;
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
                    Device01Temp--;
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
                    Device02Temp++;
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
                    Device02Temp--;
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

                    if (value >= 40)
                    {
                        this.Device01Color = Color.Red;
                    }
                    else if (value >= 31 && value < 40)
                    {
                        this.Device01Color = Color.Green;
                    }
                    else
                    {
                        this.Device01Color = Color.Blue;
                    }

                    ((Command)IncreaseCommandForDevice01Temp).ChangeCanExecute();
                    ((Command)DecreaseCommandForDevice01Temp).ChangeCanExecute();
                }
            }
        }

        public Color Device01Color
        {
            get
            {
                return this.device01Color;
            }

            set
            {
                if(this.device01Color != value)
                {
                    this.device01Color = value;
                    OnPropertyChanged("Device01Color");
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

                    if (value >= 40)
                    {
                        this.Device02Color = Color.Red;
                    }
                    else if (value >= 31 && value < 40)
                    {
                        this.Device02Color = Color.Green;
                    }
                    else
                    {
                        this.Device02Color = Color.Blue;
                    }

                    ((Command)IncreaseCommandForDevice02Temp).ChangeCanExecute();
                    ((Command)DecreaseCommandForDevice02Temp).ChangeCanExecute();
                }
            }
        }

        public Color Device02Color
        {
            get
            {
                return this.Device02Color;
            }

            set
            {
                if(this.Device02Color != value)
                {
                    this.Device02Color = value;
                    OnPropertyChanged("Device02Color");
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
