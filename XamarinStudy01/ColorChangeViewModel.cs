using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace XamarinStudy01
{
    public class ColorChangeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        double hue, saturation, luminosity, alphy;
        Color currentColor;

        public double Hue
        {
            set
            {
                if(hue != value)
                {
                    hue = value;
                    OnPropertyChanged("Hue");
                    SetNewColor();
                }
            }

            get
            {
                return this.hue;
            }
        }

        public double Saturation
        {
            set
            {
                if (saturation != value)
                {
                    saturation = value;
                    OnPropertyChanged("Saturation");
                    SetNewColor();
                }
            }

            get
            {
                return this.saturation;
            }
        }

        public double Luminosity
        {
            set
            {
                if (luminosity != value)
                {
                    luminosity = value;
                    OnPropertyChanged("Luminosity");
                    SetNewColor();
                }
            }

            get
            {
                return this.luminosity;
            }
        }

        public double Alphy
        {
            set
            {
                if (alphy != value)
                {
                    alphy = value;
                    OnPropertyChanged("Alphy");
                    SetNewColor();
                }
            }

            get
            {
                return this.alphy;
            }
        }

        public Color CurrentColor
        {
            set
            {
                Debug.WriteLine("CurrentColor");

                if (this.currentColor != value)
                {
                    this.currentColor = value;
                    OnPropertyChanged("CurrentColor");

                    this.Hue = value.Hue;
                    this.Luminosity = value.Luminosity;
                    this.Saturation = value.Saturation;
                    this.alphy = value.A;
                }
            }

            get
            {
                return this.currentColor;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        void SetNewColor()
        {
            this.CurrentColor = Color.FromHsla(this.Hue, this.Saturation, this.Luminosity, this.Alphy);
        }

    }
}
