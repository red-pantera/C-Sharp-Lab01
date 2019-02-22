using System;

namespace Lab01.Models
{
    public class BirthdayModel
    {
        private DateTime _birthday;
        public bool IsValid { get; private set; }
        public string Age { get; private set; }
        public string WesternZodiac { get; private set; }
        public string ChineseZodiac { get; private set; }
        
        private static readonly string[] WesternZodiaсs = {"Aries", "Taurus", "Gemini", "Cancer", 
            "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces"};

        private static readonly string[] ChineseZodiaсs = {"Rat", "Ox", "Tiger", "Rabbit", 
            "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig"};

        public BirthdayModel()
        {
            _birthday = DateTime.Today;
        }
        
        public bool IsBirthday
        {
            get
            {
                var today = DateTime.Today;
                return today.Month == _birthday.Month && today.Day == _birthday.Day;
            }
        }

        public DateTime Birthday
        {
            get { return _birthday;} 
            set
            {
                _birthday = value;
                var today = DateTime.Today;
                var years = (today.Year - value.Year) - (today.DayOfYear >= _birthday.DayOfYear? 0 : 1);
                var numDays = today - value;
                
                IsValid = numDays.Days >= 0 && years <= 135;
                if (IsValid)
                {
                    Age = years > 0 ? years + " year(s)":numDays.Days + " day(s)"; 
                    ChineseZodiac = ChineseZodiaсs[(_birthday.Year + 8) % 12];

                    var month = _birthday.Month;
                    var day = _birthday.Day;
                    int westernZodiacNum;
                    switch (month)
                    {
                        case 1:  //January  
                            westernZodiacNum = day <= 20 ? 9 : 10;
                            break;
                        case 2: //February 
                            westernZodiacNum = day <= 19 ? 10 : 11;
                            break;
                        case 3: //March 
                            westernZodiacNum = day <= 20 ? 11 : 0;
                            break;
                        case 4: //April 
                            westernZodiacNum = day <= 20 ? 0 : 1;
                            break;
                        case 5: //May 
                            westernZodiacNum = day <= 20 ? 1 : 2;
                            break;
                        case 6: //June 
                            westernZodiacNum = day <= 20 ? 2 : 3;
                            break;
                        case 7: //Jule
                            westernZodiacNum = day <= 21 ? 3 : 4;
                            break;
                        case 8: //August 
                            westernZodiacNum = day <= 22 ? 4 : 5;
                            break;
                        case 9: //September 
                            westernZodiacNum = day <= 21 ? 5 : 6;
                            break;
                        case 10: //October 
                            westernZodiacNum = day <= 21 ? 6 : 7;
                            break;
                        case 11: //November 
                            westernZodiacNum = day <= 21 ? 7 : 8;
                            break;
                        case 12: //December
                            westernZodiacNum = day <= 21 ? 8 : 9;
                            break;
                        default:
                            westernZodiacNum = 0;
                            break;
                    }
                    WesternZodiac = WesternZodiaсs[westernZodiacNum];
                }
                else
                {
                    Age = WesternZodiac = ChineseZodiac = "";
                }
            }
        }
    }
}