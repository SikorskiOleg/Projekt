using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wstep.Text = "Drzwi grobowca z wolna ustępują pod Twoim naciskiem, skrzypiąc jak kości starożytnego strażnika. Powietrze jest gęste od pyłu i woni zbutwiałych tkanin – to miejsce nie widziało żywego oddechu od stuleci. Pochodnia w Twojej dłoni rzuca niespokojne blaski, a cienie na ścianach zdają się drżeć wbrew prawom fizyki. Nagle, kilka kroków przed Tobą, mrok się rozstępuje..." + " " +
                "\r\n\r\n► Przed Tobą stoi Sfinks.\r\n\r\nJego kamienne ciało, pokryte pęknięciami czasu, zdaje się żyć w migotliwym świetle płomienia. Oczy – głębokie jak studnie prowadzące do podziemi – wpatrują się w Ciebie z nieludzką cierpliwością. Kiedy otwierasz usta, by przemówić, wargi Sfinksa poruszają się pierwsze, a głos rozlega się nie w uszach, lecz głęboko we wnętrzu Twojej czaszki:" + " " +
                "\r\n\r\n\"Witaj, śmiertelniku. Czy jesteś gotów stanąć przed Sędzią Zagubionych Dusz?\"";
            //Naprawa problemu z zaznaczeniem tekstu w TextBoxie
            wstep.SelectionStart = 0;
            wstep.SelectionLength = 0;
            // koniec naprawy
            //Przypisanie wartości przycisków
            smierc.Click += Click_Button;
            uciekaj.Click += Click_Button;
            wysluchaj.Click += Click_Button;
            pytanie.Click += Click_Button;
            que1.Click += Click_Button;
            que2.Click += Click_Button;
            que3.Click += Click_Button;
            que4.Click += Click_Button;
            // koniec przypisania wartości przycisków
        }
        private string tabelapytania()
        {
            que1.Visible = true;
            que2.Visible = true;
            que3.Visible = true;
            que4.Visible = true;
            pytanie.Visible = false;
            wstep.Visible = false;
            tytul.Visible = false;
            blokpytanie.Visible = true;
            string[] tab = new string[4];
            tab[0] = "Co jest zawsze przed tobą, ale nigdy nie możesz tego zobaczyć?";
            tab[1] = "Co ma wiele kluczy, ale nie otwiera żadnych drzwi?";
            tab[2] = "Co jest tak delikatne, że nawet słowo może to złamać?";
            tab[3] = "Co jest większe niż Bóg, gorsze niż diabeł, bogaci to mają, biedni tego potrzebują, a jeśli to zjesz, umrzesz?";

            Random losuj = new Random();
            int i = losuj.Next(tab.Length); // losowy indeks 0-3

            if (i == 0)
            {
                blokpytanie.Text = tab[0];
                que1.Text = "Powietrze";
                que2.Text = "Cień";
                que3.Text = "Przyszłość";
                que4.Text = "Horyzont";
                que1.Click += (s, e) => { SmiercAkcja(); };
                que2.Click += (s, e) => { SmiercAkcja(); };
                que3.Click += (s, e) => { Odpowiedz(); }; 
                que4.Click += (s, e) => { SmiercAkcja(); };
            }
            else if (i == 1)
            {
                blokpytanie.Text = tab[1];
                que1.Text = "Fortepian";
                que2.Text = "Taran";
                que3.Text = "Wytrych";
                que4.Text = "Woźny";
                que1.Click += (s, e) => { Odpowiedz(); };
                que2.Click += (s, e) => { SmiercAkcja(); };
                que3.Click += (s, e) => { SmiercAkcja(); };
                que4.Click += (s, e) => { SmiercAkcja(); };
            }
            else if (i == 2)
            {
                blokpytanie.Text = tab[2];
                que1.Text = "Serce";
                que2.Text = "Lód";
                que3.Text = "Szkło";
                que4.Text = "Cisza";
                que1.Click += (s, e) => { SmiercAkcja(); };
                que2.Click += (s, e) => { SmiercAkcja(); };
                que3.Click += (s, e) => { SmiercAkcja(); };
                que4.Click += (s, e) => { Odpowiedz(); };
            }
            else if (i == 3)
            {
                blokpytanie.Text = tab[3];
                que1.Text = "Śmierć";
                que2.Text = "Czas";
                que3.Text = "Nic";
                que4.Text = "Nieskończoność";
                que1.Click += (s, e) => { SmiercAkcja(); };
                que2.Click += (s, e) => { SmiercAkcja(); };
                que3.Click += (s, e) => { Odpowiedz(); };
                que4.Click += (s, e) => { SmiercAkcja(); };
            }
            return tab[i];
        }
        private void UciekajAkcja()
        {
            //Naprawa problemu z zaznaczeniem tekstu w TextBoxie
            wstep.SelectionStart = 0;
            wstep.SelectionLength = 0;
            // koniec naprawy

            wstep.Text = "Uciekasz w popłochu, serce bije jak młot. Cienie za Tobą zdają się gonić, a echo Twoich kroków odbija się od kamiennych ścian. W końcu, po długim biegu, znajdujesz się na zewnątrz grobowca, oddychając ciężko i czując ulgę. Ale wiesz, że Sfinks nadal czeka w mroku, gotów na kolejną próbę." + " " +
                "\r\n\r\n► Uciekłeś przed Sfinksem.";
            smierc.Visible = false;
            uciekaj.Visible = false;
            wysluchaj.Visible = false;
            ponownie.Visible = true;
            poddaj.Visible = true;

            poddaj.Click += (s, e) =>
             {
                 Application.Exit();
             };
            ponownie.Click += (s, e) =>
            {
                Application.Restart();
            };
        }
        private void SmiercAkcja()
        {
            //Naprawa problemu z zaznaczeniem tekstu w TextBoxie
            wstep.SelectionStart = 0;
            wstep.SelectionLength = 0;
            // koniec naprawy

            // Naprawa problemu z wychodzeniem za okno
            wstep.Font = new Font(wstep.Font.FontFamily, 9);
            // koniec naprawy

            wstep.Text = "Kamienne oczy posągu śledzą twój każdy ruch, a powietrze wokół gęstnieje, jakby samo miejsce sprzeciwiało się twojej zuchwałości. " +
                "Nagle - ostry ból rozdziera Twoją czaszkę, jakby ktoś wbił ci w skronie rozżarzone sztylety. Kolana uginają się pod tobą, a z ust wydobywa się chrapliwy jęk." +
                "\r\n\r\nWidzenie przesłania ci krwawą mgłą." +
                "\r\n\r\nW ostatnim przebłysku świadomości dostrzegasz, jak kamienne powieki Sfinksa drgają, a jego źrenice – głębokie jak przepaść – zwracają się ku tobie z nieludzką, zimną ciekawością. Czujesz, jak coś wysysa z ciebie życie, powoli, metodycznie, jak gdybyś był tylko kolejną świecą, którą można zdmuchnąć." +
                "\r\n\r\nPróbujesz pełznąć dalej, ale twoje ciało nie słucha rozkazów. Palce drgawkowo zaciskają się na kamiennej posadzce, zostawiając krwawe ślady. Ostatnie, co widzisz, to uśmiech Sfinksa – ledwie dostrzegalny, a jednak niewyobrażalnie pełen głodu." + " " +
                "\r\n\r\nŚwiat gaśnie.";
            smierc.Visible = false;
            uciekaj.Visible = false;
            wysluchaj.Visible = false;
            ponownie.Visible = true;
            poddaj.Visible = true;

            poddaj.Click += (s, e) =>
            {
                Application.Exit();
            };
            ponownie.Click += (s, e) =>
            {
                Application.Restart();
            };
        }
        private void WysluchajAkcja()
        {
            //Naprawa problemu z zaznaczeniem tekstu w TextBoxie
            wstep.SelectionStart = 0;
            wstep.SelectionLength = 0;
            // koniec naprawy

            wstep.Text = "Sfinks milczy przez chwilę, a jego oczy zdają się przenikać przez Twoją duszę. W końcu, głos rozbrzmiewa ponownie, głęboki i pełen mocy:" + " " +
                "\r\n\r\n\"Twoja odwaga jest godna podziwu, sprawdźmy czy twój umysł jej dorównuje, czy jesteś gotów odpowiedzieć na moje pytania?\"";
            smierc.Visible = false;
            uciekaj.Visible = true;
            wysluchaj.Visible = false;
            pytanie.Visible = true;
            pytanie.Text = "Zadaj pytanie";



        }
        private void Odpowiedz()
        {
            tabelapytania();
            uciekaj.Visible = false;
            wysluchaj.Visible = false;
            poddaj.Visible = true;
            
            for (int i = 0; i <= 3; i++)
            {
                blokpytanie.Visible = true;
                if (i == 3)
                {
                    //Jeśli odpowiedź jest poprawna
                    Koniec();
                    return;
                }
            }
        }
        private void Koniec()
        {
            //Naprawa problemu z zaznaczeniem tekstu w TextBoxie
            wstep.SelectionStart = 0;
            wstep.SelectionLength = 0;
            // koniec naprawy
            wstep.Visible = true;
            wstep.Text = "Twoje odpowiedzi były poprawne, Sfinks skinął głową, a jego kamienne usta rozciągnęły się w uśmiechu" +
                "" +
                "Kamienne łąpy Sfinxa rozsuwają się i ujawniają przed tobą niewielką obsydianową skrzynkę ze złotymi zdobieniami, zdobyłeś to po co przyszedłeś";
            blokpytanie.Visible = false;
            que1.Visible = false;
            que2.Visible = false;
            que3.Visible = false;
            que4.Visible = false;
            smierc.Visible = false;
            uciekaj.Visible = false;
            wysluchaj.Visible = false;
            ponownie.Visible = true;
            ponownie.Text = "Zagraj ponownie";  
            poddaj.Visible = false;
            poddaj.Text = "Zakończ grę";
            poddaj.Click += (s, e) =>
            {
                Application.Exit();
            };
            ponownie.Click += (s, e) =>
            {
                Application.Restart();
            };
        }
        private void Click_Button(object sender, EventArgs e)
        {
            Button klikniety = sender as Button;
            switch (klikniety.Name)
            {
                case "smierc":
                    SmiercAkcja();
                    break;
                case "uciekaj":
                    UciekajAkcja();
                    break;
                case "wysluchaj":
                    WysluchajAkcja();
                    break;
                case "pytanie":
                    Odpowiedz();
                    break;
                default:
                    // domyślna akcja
                    break;
            }
        }
        


    }
    
}
