using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lab01.Models;

using DynamicData.Annotations;


namespace Zhenchak01.ViewModels
{
    internal class BirthdayViewModel : INotifyPropertyChanged
    {
        private readonly BirthdayModel _birthdayModel = new BirthdayModel();

        public DateTime BirthDate
        {
            get { return _birthdayModel.Birthday; }
            set
            {
                _birthdayModel.Birthday = value;
                if (!_birthdayModel.IsValid)
                {
                    //MessageBox messageError = new MessageBox("You entered invalid date!", MessageBoxStyle.Error);
                    //messageError.Show();
                    Console.WriteLine("You entered invalid date!");
                    
                }
                else
                {
                    if (_birthdayModel.IsBirthday)
                    {
                        //MessageBox message = new MessageBox("Happy Birthday to You!!", MessageBoxStyle.Info);
                        //message.Show();
                        Console.WriteLine("Happy Birthday to You!!");
                    }
                }
                
                OnPropertyChanged();
                OnPropertyChanged(nameof(Age));
                OnPropertyChanged(nameof(ChineseZodiac));
                OnPropertyChanged(nameof(WesternZodiac));
            }
        }

        public string Age
        {
            get { return $"Age:{Environment.NewLine}{_birthdayModel.Age}"; }
        }

        public string WesternZodiac
        {
            get { return $"Western zodiac:{Environment.NewLine}{_birthdayModel.WesternZodiac}"; }
        }

        public string ChineseZodiac
        {
            get { return $"Chinise zodiac:{Environment.NewLine}{_birthdayModel.ChineseZodiac}"; }
        }

        public BirthdayViewModel()
        {
            
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


