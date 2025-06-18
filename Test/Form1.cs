using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1: Form
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
            // koniec przypisania wartości przycisków
        }
        private void wstep_TextChanged(object sender, EventArgs e)
        {
            

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
        }
        private void WysluchajAkcja()
        {
            //Naprawa problemu z zaznaczeniem tekstu w TextBoxie
            wstep.SelectionStart = 0;
            wstep.SelectionLength = 0;
            // koniec naprawy

            wstep.Text = "Sfinks milczy przez chwilę, a jego oczy zdają się przenikać przez Twoją duszę. W końcu, głos rozbrzmiewa ponownie, głęboki i pełen mocy:" + " " +
                "\r\n\r\n\"Twoja odwaga jest godna podziwu, sprawdźmy czy twój umysł jej dorównuje, czy jesteś gotów odpowiedzieć na moje pytania?\"";
            smierc.Text = "Zadaj pytanie";
            uciekaj.Visible = true;
            wysluchaj.Visible = false;
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
                default:
                    // domyślna akcja
                    break;
            }
        }

        
    }
    
}
