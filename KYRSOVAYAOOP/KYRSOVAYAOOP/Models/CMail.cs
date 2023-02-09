using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYRSOVAYAOOP.Models
{
    class CMail// начало области действия класса
    {
        //статические поля и методы классы
        static public int count;
        static public void countCMail() { count++; }
        static public int getCount() { return count; }
        //Закрытые члены класса
        private int postindex; //Почтовый индекс
        public int Postindex
        {
            get 
            { 
                return postindex; 
            }
            set 
            {
                if (value > 0)
                {
                    postindex = value;
                }
                else
                {
                    throw new Exception("Postindex cannot be less than zero");
                }
            }
        }
        private int apartment; // Номер квартиры
        public int Apartment { get { return apartment; } set { apartment = value; } }
        private int numbhouse; // Номер дома
        public int Numbhouse { get { return numbhouse; } set { numbhouse = value; } }
        private string country; // Страна
        public string Country { get { return country; } set { country = value; } }
        private string rayon; // Район
        public string Rayon { get { return rayon; } set { rayon = value; } }
        private string oblast; // Область
        public string Oblast { get { return oblast; } set { oblast = value; } }
        private string gorod; // Город
        public string Gorod { get { return gorod; } set { gorod = value; } }
        private string street; // Улица
        public string Street { get { return street; } set { street = value; } }

	// Конструктор по умолчанию
        public CMail()
        {
            country = "Россия";
            postindex = 625000;
            oblast = "Тюменская область";
            rayon = "Тюменский район";
            gorod = "Тюмень";
            street = "50 лет Октября";
            numbhouse = 102;
            apartment = 13;
            countCMail();
        }
        // Конструктор с параметрами
        public CMail(int Vpostindex, int Vapartment, int Vnumbhouse, string Vcountry, string Vrayon, string Voblast, string Vgorod, string Vstreet)
        {
            postindex = Vpostindex;
            apartment = Vapartment;
            numbhouse = Vnumbhouse;
            country = Vcountry;
            oblast = Voblast;
            rayon = Vrayon;
            gorod = Vgorod;
            street = Vstreet;
            countCMail();
        }

        //Метод для вычисления признака проживания адресата (Деревня - Город)
        public bool getPrisnakGor()
        {
            if (apartment > 2)
                return true;
            else
                return false;
        }

        //Общий метод для оповещения об отсутствие необходиомй информации адресата
        public string lostInfo()
        {
            string info = "";
            if (postindex == 0)
                info += "Отсутствует информация о почтовом индексе\n";
            if (numbhouse == 0)
                info += "Отсутствует информация о номере дома\n";
            if (country == " ")
                info += "Отсутствует информация о стране\n";
            if (rayon == " ")
                info += "Отсутствует информация о районе\n";
            if (oblast == " ")
                info += "Отсутствует информация о области\n";
            if (gorod == " ")
                info += "Отсутствует информация о городе\n";
            if (street == " ")
                info += "Отсутствует информация о улице\n";
            return info;
        }

        public string info()
        {
            return "Страна: " + country + ", Область: " + oblast + ", Район: " + rayon +
                ", Город: " + gorod + ", Улица: " + street + ", Номер дома: " + numbhouse +
                ", Квартира: " + apartment + ", Почтовый индекс: " + postindex;
        }

        public static bool operator == (CMail A,CMail B) { return A.postindex == B.postindex && A.apartment == B.apartment && A.numbhouse == B.numbhouse && A.country == B.country && A.oblast == B.oblast && A.rayon == B.rayon && A.gorod == B.gorod && A.street == B.street; }
        public static bool operator != (CMail A, CMail B) { return A.postindex != B.postindex || A.apartment != B.apartment || A.numbhouse != B.numbhouse || A.country != B.country || A.oblast != B.oblast || A.rayon != B.rayon || A.gorod != B.gorod || A.street != B.street; }

        public static bool operator > (CMail A, CMail C) { return A.apartment > C.apartment; }
        public static bool operator < (CMail A, CMail C) { return A.apartment < C.apartment; }

        ~CMail() { count--; }
    }
}
