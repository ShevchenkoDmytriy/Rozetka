using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rozetka._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Phone> Phones { get; set; }
        public ObservableCollection<Phone> Phones1 { get; set; }
        public ObservableCollection<Phone> Phones2 { get; set; }
        public ObservableCollection<Phone> Phones3 { get; set; }
        public ObservableCollection<Phone> Phones4 { get; set; }
        public ObservableCollection<Phone> Phones5 { get; set; }
        public ObservableCollection<Phone> Phones6 { get; set; }
        public ObservableCollection<Phone> Phones7 { get; set; }
        public ObservableCollection<Phone> Phones8 { get; set; }
        public ObservableCollection<Phone> Phones9 { get; set; }
        public MainWindow()
        {
            
        InitializeComponent();
            Phones = new ObservableCollection<Phone>()
            {
                new Phone{ Money = "37 999 UAH", ImagePath="Resource/1.jpg", Title="Acer Aspire 7", Company="Acer"},
                new Phone{ Money = "36 999 UAH", ImagePath="Resource/2.jpg", Title="ASUS TUF Gaming F15", Company="ASUS"},
                new Phone{ Money = "27 999 UAH", ImagePath="Resource/3.jpg", Title="Lenovo IdeaPad 3", Company="Lenovo"},
                new Phone{ Money = "42 999 UAH", ImagePath="Resource/4.jpg", Title="Apple MacBook Air 13", Company="Apple"},
                new Phone{ Money = "21 999 UAH", ImagePath="Resource/5.jpg", Title="Acer Aspire 5", Company="Acer"},
                 new Phone{ Money = "21 999 UAH", ImagePath="Resource/6.jpg", Title="Samsung Odyssey G7", Company="Samsung"},
                new Phone{ Money = "9 399 UAH", ImagePath="Resource/7.jpg", Title="Asus TUF Gaming", Company="Asus"},
                new Phone{ Money = "6 799 UAH", ImagePath="Resource/8.jpg", Title="Iiyama G-Master", Company="Iiyama"},
                new Phone{ Money = "7 199 UAH", ImagePath="Resource/9.jpg", Title="AOC 24G2SAE/BK", Company="AOC"},
                new Phone{ Money = "14 499 UAH", ImagePath="Resource/10.jpg", Title="Dell S2722DC", Company="Dell"},
                 new Phone{ Money = "16 719 UAH", ImagePath="Resource/11.jpg", Title="GeForce RTX 3060", Company="Asus"},
                new Phone{ Money = "8 499 UAH", ImagePath="Resource/12.jpg", Title="GeForce GTX 1650", Company="Asus"},
               
                
            };
            Phones1 = new ObservableCollection<Phone>()
            {
                new Phone{ Money = "8 555 UAH", ImagePath="Resource/1.1.jpg", Title="Samsung Galaxy M32", Company="Samsung"},
                new Phone{ Money = "41 499 UAH", ImagePath="Resource/2.1.jpg", Title="Aplle iPhone 14", Company="Aplle"},
                new Phone{ Money = "19 599 UAH", ImagePath="Resource/3.1.jpg", Title="Samsung Galaxy A53", Company="Samsung"},
                new Phone{ Money = "7 699 UAH", ImagePath="Resource/4.1.jpg", Title="   Motorola G32", Company="Motorola"},
                new Phone{ Money = "5 499 UAH", ImagePath="Resource/5.1.jpg", Title="   ZTE Blade V30", Company="ZTE"},
                 new Phone{ Money = "18 999 UAH", ImagePath="Resource/6.1.jpg", Title="Samsung UE50AU7100", Company="Samsung"},
                new Phone{ Money = "15 999 UAH", ImagePath="Resource/7.1.jpg", Title="Hisense 50A7100F", Company="Hisense"},
                new Phone{ Money = "21 999 UAH", ImagePath="Resource/8.1.jpg", Title="Samsung UE55AU", Company="Samsung"},
                new Phone{ Money = "8 999 UAH", ImagePath="Resource/9.1.jpg", Title="Nokia Smart TV", Company="Nokia"},
                new Phone{ Money = "16 999 UAH", ImagePath="Resource/10.1.jpg", Title="Hisense 55A7100F", Company="Hisense"},
                 new Phone{ Money = "10 499 UAH", ImagePath="Resource/11.1.jpg", Title="Lenovo Tab M10", Company="Lenovo"},
                new Phone{ Money = "9 099 UAH", ImagePath="Resource/12.1.jpg", Title="Galaxy Tab A8", Company="Samsung"},
               

            };
            Phones2 = new ObservableCollection<Phone>()
            {
                  new Phone{ Money = "8 555 UAH", ImagePath="Resource/1.1.jpg", Title="Samsung Galaxy M32", Company="Samsung"},
               new Phone{ Money = "8 499 UAH", ImagePath="Resource/12.jpg", Title="GeForce GTX 1650", Company="Asus"},
               new Phone{ Money = "42 999 UAH", ImagePath="Resource/4.jpg", Title="Apple MacBook Air 13", Company="Apple"},
                   new Phone{ Money = "15 999 UAH", ImagePath="Resource/7.1.jpg", Title="Hisense 50A7100F", Company="Hisense"},
               new Phone{ Money = "21 999 UAH", ImagePath="Resource/6.jpg", Title="Samsung Odyssey G7", Company="Samsung"},
            };
            phoneList.ItemsSource = Phones2;
            Phones3 = new ObservableCollection<Phone>()
            {
                new Phone{ Money = "27 999 UAH", ImagePath="Resource/16.jpg", Title="Xbox Series X", Company="Microsoft"},
                new Phone{ Money = "14 999 UAH", ImagePath="Resource/17.jpg", Title="Nintendo Switch", Company="Nintendo"},
                new Phone{ Money = "36 097 UAH", ImagePath="Resource/18.png", Title="Sony Playstation 5", Company="Sony"},
                new Phone{ Money = "49 788 UAH", ImagePath="Resource/19.jpg", Title="Steam Deck 512", Company="Valve"},
                new Phone{ Money = "37 999 UAH", ImagePath="Resource/20.jpg", Title="Acer Aspire 7", Company="Acer"},
                 new Phone{ Money = "36 999 UAH", ImagePath="Resource/21.jpg", Title="ASUS TUF Gaming", Company="ASUS"},
                new Phone{ Money = "43 999 UAH", ImagePath="Resource/22.jpg", Title="ASUS TUF Gaming", Company="ASUS"},
                new Phone{ Money = "57 999 UAH", ImagePath="Resource/23.jpg", Title="Asus ROG Strix", Company="Asus"},
                new Phone{ Money = "12 999 UAH", ImagePath="Resource/24.jpg", Title="Anda Seat Kaiser", Company="Anda"},
                new Phone{ Money = "7 299 UAH", ImagePath="Resource/25.jpg", Title="2E Gaming Chair", Company="2E"},
                 new Phone{ Money = "17 999 UAH", ImagePath="Resource/26.jpg", Title="Razer Iskur", Company="Razer"},
                new Phone{ Money = "10 999 UAH", ImagePath="Resource/27.jpg", Title="Anda Seat Phantom", Company="Anda"},
            };
            Phones4 = new ObservableCollection<Phone>()
            {
                new Phone{ Money = "13 999 UAH", ImagePath="Resource/28.jpg", Title="HOTPOINT ARISTON", Company="HOTPOINT"},
                new Phone{ Money = "20 499 UAH", ImagePath="Resource/29.jpg", Title="SAMSUNG RB34T60", Company="Samsung"},
                new Phone{ Money = "17 499 UAH", ImagePath="Resource/30.jpg", Title="SAMSUNG WW62J42E0", Company="Samsung"},
                new Phone{ Money = "14 799 UAH", ImagePath="Resource/31.jpg", Title="GORENJE GK5C40WF", Company="GORENJE"},
                new Phone{ Money = "10 999 UAH", ImagePath="Resource/32.jpg", Title="Philips EP0820", Company="Philips"},
                 new Phone{ Money = "12 999 UAH", ImagePath="Resource/33.jpg", Title="KRUPS Essential", Company="KRUPS"},
                new Phone{ Money = "29 999 UAH", ImagePath="Resource/34.jpg", Title="Delonghi ECAM", Company="Delonghi"},
                new Phone{ Money = "57 999 UAH", ImagePath="Resource/36.jpg", Title="Candy CMW20TNMB", Company="Candy"},
                new Phone{ Money = "9 399 UAH", ImagePath="Resource/35.jpg", Title="TEFAL Bread", Company="TEFAL"},
                new Phone{ Money = "3 799 UAH", ImagePath="Resource/37.jpg", Title="PANASONIC NN-ST", Company="PANASONIC"},
                 new Phone{ Money = "5 999 UAH", ImagePath="Resource/38.png", Title="TEFAL OptiGrill+", Company="TEFAL"},
                new Phone{ Money = "14 999 UAH", ImagePath="Resource/39.jpg", Title="BOSCH MUM58M59", Company="BOSCH"},
            };
            Phones5 = new ObservableCollection<Phone>()
            {
                new Phone{ Money = "1 799 UAH", ImagePath="Resource/40.jpg", Title="DC Lina", Company="DC"},
                new Phone{ Money = "7 975 UAH", ImagePath="Resource/41.jpg", Title="ТВ Meblion", Company="Meblion"},
                new Phone{ Money = "2 165 UAH", ImagePath="Resource/42.jpg", Title="DC Emma", Company="DC"},
                new Phone{ Money = "9 039 UAH", ImagePath="Resource/43.jpg", Title="Ліжко двоспальне", Company="GORENJE"},
                new Phone{ Money = "14 959 UAH", ImagePath="Resource/44.jpg", Title="Eagle Irma Lift", Company="Eagle"},
                 new Phone{ Money = "10 930 UAH", ImagePath="Resource/45.jpg", Title="Estella Рената", Company="Estella"},
                new Phone{ Money = "4 499 UAH", ImagePath="Resource/46.jpg", Title="GMT Sunset", Company="GMT"},
                new Phone{ Money = "5 999 UAH", ImagePath="Resource/47.jpg", Title="Біокамін GMT", Company="GMT"},
                new Phone{ Money = "12 095 UAH", ImagePath="Resource/48.jpg", Title="Electrolux EFP", Company="EFP"},
                new Phone{ Money = "16 000 UAH", ImagePath="Resource/49.jpg", Title="ArtiFlame Colorado", Company="ArtiFlame"},
                 new Phone{ Money = "21 600 UAH", ImagePath="Resource/50.jpg", Title="Royal 3D Etna", Company="Royal"},
                new Phone{ Money = "7 500 UAH", ImagePath="Resource/51.jpg", Title="ArtiFlame AF18", Company="ArtiFlame"},
            };
            Phones6 = new ObservableCollection<Phone>()
            {
                new Phone{ Money = "1 444 UAH", ImagePath="Resource/52.jpg", Title="Aspiring GT21", Company="Aspiring"},
                new Phone{ Money = "2 399 UAH", ImagePath="Resource/53.jpg", Title="Blaupunkt BP", Company="Blaupunkt"},
                new Phone{ Money = "15 580 UAH", ImagePath="Resource/54.jpg", Title="Blackvue DR590X", Company="Blackvue"},
                new Phone{ Money = "3 469 UAH", ImagePath="Resource/55.jpg", Title="COYOTE 780", Company="COYOTE"},
                new Phone{ Money = "5 499 UAH", ImagePath="Resource/56.jpg", Title="COYOTE 820", Company="COYOTE"},
                 new Phone{ Money = "8 990 UAH", ImagePath="Resource/57.jpg", Title="GARMIN DriveSmart", Company="GARMIN"},
                new Phone{ Money = "6 329 UAH", ImagePath="Resource/58.jpg", Title="Gazer HR100", Company="Gazer"},
                new Phone{ Money = "9 789 UAH", ImagePath="Resource/59.jpg", Title="Gazer HR250", Company="Gazer"},
                new Phone{ Money = "1 673 UAH", ImagePath="Resource/60.jpg", Title="Mobil 1 ESP", Company="Mobil"},
                new Phone{ Money = "877 UAH", ImagePath="Resource/61.jpg", Title="Mobil Super", Company="Mobil"},
                 new Phone{ Money = "198 UAH", ImagePath="Resource/62.jpg", Title="WIX Filters", Company="WIX"},
                new Phone{ Money = "1 089 UAH", ImagePath="Resource/63.jpg", Title="PartsFix ВАЗ", Company="PartsFix"},
            };
            Phones7 = new ObservableCollection<Phone>()
            {
                new Phone{ Money = "3 190 UAH", ImagePath="Resource/64.jpg", Title="МОЙДОДИР Руна", Company="Aspiring"},
                new Phone{ Money = "6 489 UAH", ImagePath="Resource/65.jpg", Title="RJ First 60", Company="RJ"},
                new Phone{ Money = "3 020 UAH", ImagePath="Resource/66.jpg", Title="Дзеркальна шафка", Company="Blackvue"},
                new Phone{ Money = "999 UAH", ImagePath="Resource/67.jpg", Title="Maxus Smart ZigBee", Company="Maxus"},
                new Phone{ Money = "849 UAH", ImagePath="Resource/68.jpg", Title="Vibration Detector", Company="Aqara"},
                 new Phone{ Money = "3 499 UAH", ImagePath="Resource/69.jpg", Title="Aqara JT-BZ-03", Company="Aqara"},
                new Phone{ Money = "1 699 UAH", ImagePath="Resource/70.jpg", Title="RZTK RD 1220Li", Company="RZTK"},
                new Phone{ Money = "699 UAH", ImagePath="Resource/71.jpg", Title="RZTK AG", Company="RZTK"},
                new Phone{ Money = "1 799 UAH", ImagePath="Resource/72.jpg", Title="RZTK H 1200", Company="RZTK"},
                new Phone{ Money = "599 UAH", ImagePath="Resource/73.jpg", Title="RZTK AJ 650", Company="RZTK"},
                 new Phone{ Money = "1 399 UAH", ImagePath="Resource/74.jpg", Title="RZTK RMT 3109", Company="RZTK"},
                new Phone{ Money = "5 999 UAH", ImagePath="Resource/75.jpg", Title="Metabo KS 216", Company="PartsFix"},
            };
            Phones8 = new ObservableCollection<Phone>()
            {
                new Phone{ Money = "3 999 UAH", ImagePath="Resource/76.jpg", Title="Forte FES 24-40", Company="Forte"},
                new Phone{ Money = "4 599 UAH", ImagePath="Resource/77.jpg", Title="Makita ELM3320", Company="Makita"},
                new Phone{ Money = "1 186 UAH", ImagePath="Resource/78.jpg", Title="Bosch EasyGrassCut", Company="Bosch"},
                new Phone{ Money = "5 499 UAH", ImagePath="Resource/79.jpg", Title="Greenworks GTL9526", Company="Greenworks"},
                new Phone{ Money = "5 699 UAH", ImagePath="Resource/80.jpg", Title="AL-KO Comfort", Company="AL-KO"},
                 new Phone{ Money = "2 570 UAH", ImagePath="Resource/81.jpg", Title="Bosch EasyHedge", Company="Bosch"},
                new Phone{ Money = "2 935 UAH", ImagePath="Resource/82.jpg", Title="Budmonster", Company="Budmonster"},
                new Phone{ Money = "7 399 UAH", ImagePath="Resource/83.jpg", Title="Каркасний басейн", Company="Intex"},
                new Phone{ Money = "25 950 UAH", ImagePath="Resource/84.jpg", Title="Keter Bahamas", Company="Keter"},
                new Phone{ Money = "686 681 UAH", ImagePath="Resource/85.jpg", Title="Диван-альтанка", Company="Spartan"},
                 new Phone{ Money = "12 058 UAH", ImagePath="Resource/86.jpg", Title="Гойдалка садова", Company="Vitan"},
                new Phone{ Money = "5 810 UAH", ImagePath="Resource/87.jpg", Title="Гойдалка садова", Company="Vitan"},
            };
            Phones9 = new ObservableCollection<Phone>()
            {
                new Phone{ Money = "14 693 UAH", ImagePath="Resource/88.jpg", Title="CORRADO Piemont", Company="CORRADO"},
                new Phone{ Money = "12 349 UAH", ImagePath="Resource/89.jpg", Title="Ardis Titan 27.5", Company="Ardis"},
                new Phone{ Money = "22 999 UAH", ImagePath="Resource/90.jpg", Title="Segway Ninebot", Company="Segway"},
                new Phone{ Money = "6 659 UAH", ImagePath="Resource/91.jpg", Title="Segway Ninebot A6", Company="Segway"},
                new Phone{ Money = "2 999 UAH", ImagePath="Resource/92.jpg", Title="Універсальні гантелі", Company="Supretto"},
                 new Phone{ Money = "1 159 UAH", ImagePath="Resource/93.jpg", Title="Комплект гантелей", Company="Neo Sport"},
                new Phone{ Money = "5 432 UAH", ImagePath="Resource/94.jpg", Title="Набір RN-Sport", Company="RN-Sport"},
                new Phone{ Money = "13 599 UAH", ImagePath="Resource/95.jpg", Title="Бігова доріжка", Company="Spokey EVEN"},
                new Phone{ Money = "11 925 UAH", ImagePath="Resource/96.jpg", Title="Лава для жиму", Company=" RN-Sport"},
                new Phone{ Money = "2 374 UAH", ImagePath="Resource/97.jpg", Title="Турнік-бруси", Company="Newt Iron"},
                 new Phone{ Money = "6 195 UAH", ImagePath="Resource/98.jpg", Title="Батут", Company="HouseFit"},
                new Phone{ Money = "23 692 UAH", ImagePath="Resource/99.jpg", Title="Стіл для тенісу", Company="Donic Outdoor"},
            };
        }
        private void text1_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            text1.Clear();
        }

        private void label1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            phoneList.ItemsSource = Phones;
        }

        private void label2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            phoneList.ItemsSource = Phones1;
        }

        private void label3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            phoneList.ItemsSource = Phones3;
        }

        private void roz_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            phoneList.ItemsSource = Phones2;
        }

        private void label4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            phoneList.ItemsSource = Phones4;
        }

        private void label5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            phoneList.ItemsSource = Phones5;
        }

        private void label6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            phoneList.ItemsSource = Phones6;
        }

        private void label7_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            phoneList.ItemsSource = Phones7;
        }

        private void label8_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            phoneList.ItemsSource = Phones8;
        }

        private void label9_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            phoneList.ItemsSource = Phones9;
        }
    }
    public class Phone
    {

        public string Money { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string ImagePath { get; set; }
    }
}
